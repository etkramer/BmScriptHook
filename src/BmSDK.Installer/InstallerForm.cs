using System.Diagnostics;
using System.Reflection;

namespace BmSDK.Installer;

internal sealed class InstallerForm : Form
{
    private const string IconResourceName = "BmSDK.Installer.icon.ico";

    private readonly ListView _installList = new();
    private readonly Button _browseButton = new();
    private readonly Label _statusLabel = new();
    private readonly ProgressBar _progressBar = new();
    private readonly Button _actionButton = new();
    private readonly Button _closeButton = new();

    private readonly string? _presetTarget;
    private readonly bool _autoInstall;
    private readonly float _scale;
    private bool _isInstalled;

    public InstallerForm(string? presetTarget, bool autoInstall)
    {
        _presetTarget = presetTarget;
        _autoInstall = autoInstall;
        _scale = DeviceDpi / 96f;

        InitializeLayout();
    }

    // The layout below is written in 96 DPI pixels, so every coordinate goes through these
    private int Px(int value) => (int)(value * _scale);

    private Point Pt(int x, int y) => new(Px(x), Px(y));

    private Size Sz(int width, int height) => new(Px(width), Px(height));

    private string? SelectedPath =>
        _installList.SelectedItems.Count > 0 ? _installList.SelectedItems[0].SubItems[0].Text : null;

    private void InitializeLayout()
    {
        Text = "BmSDK Installer";
        Icon = LoadIcon();

        // Scaling is applied by hand below, so keep WinForms from doing it a second time
        AutoScaleMode = AutoScaleMode.None;

        ClientSize = Sz(564, 396);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Font = SystemFonts.MessageBoxFont ?? Font;

        var heading = new Label
        {
            Text = $"Install BmSDK v{Program.Version}",
            Font = new Font(Font.FontFamily, 13f, FontStyle.Bold),
            Location = Pt(16, 16),
            Size = Sz(532, 26),
        };

        var subheading = new Label
        {
            Text = "Choose the Batman: Arkham City folder to install into.",
            Location = Pt(16, 44),
            Size = Sz(532, 20),
        };

        _installList.Location = Pt(16, 72);
        _installList.Size = Sz(532, 152);
        _installList.View = View.Details;
        _installList.FullRowSelect = true;
        _installList.MultiSelect = false;
        _installList.HideSelection = false;
        _installList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
        _installList.Columns.Add("Game folder", Px(386));
        _installList.Columns.Add("Found via", Px(122));
        _installList.SelectedIndexChanged += (_, _) => UpdateStatus();

        _browseButton.Text = "Choose another folder...";
        _browseButton.Location = Pt(16, 232);
        _browseButton.Size = Sz(170, 30);
        _browseButton.Click += OnBrowseClicked;

        _statusLabel.Location = Pt(16, 274);
        _statusLabel.Size = Sz(532, 40);

        _progressBar.Location = Pt(16, 322);
        _progressBar.Size = Sz(532, 16);
        _progressBar.Visible = false;

        _actionButton.Text = "Install";
        _actionButton.Location = Pt(364, 352);
        _actionButton.Size = Sz(88, 30);
        _actionButton.Enabled = false;
        _actionButton.Click += OnActionClicked;

        _closeButton.Text = "Close";
        _closeButton.Location = Pt(460, 352);
        _closeButton.Size = Sz(88, 30);
        _closeButton.Click += (_, _) => Close();

        Controls.AddRange(heading, subheading, _installList, _browseButton, _statusLabel, _progressBar,
            _actionButton, _closeButton);

        AcceptButton = _actionButton;
        CancelButton = _closeButton;
    }

    // Takes the 256px layer so the taskbar still looks sharp when Windows scales it down
    private static Icon LoadIcon()
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(IconResourceName)!;

        return new Icon(stream, 256, 256);
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);

        LoadInstalls();

        if (_autoInstall && SelectedPath is not null)
        {
            BeginInstall();
        }
    }

    private void LoadInstalls()
    {
        foreach (var install in GameDetector.DetectAll())
        {
            AddRow(install);
        }

        // An explicitly requested folder always wins, even if detection missed it
        if (GameDetector.IsValidGameDir(_presetTarget))
        {
            SelectPath(_presetTarget!);
        }
        else if (_installList.Items.Count == 1)
        {
            _installList.Items[0].Selected = true;
        }

        UpdateStatus();
    }

    private ListViewItem AddRow(GameInstall install)
    {
        var item = new ListViewItem(install.Path);
        item.SubItems.Add(install.Source);

        return _installList.Items.Add(item);
    }

    private void SelectPath(string path)
    {
        foreach (ListViewItem item in _installList.Items)
        {
            if (GameDetector.PathsEqual(item.SubItems[0].Text, path))
            {
                item.Selected = true;
                return;
            }
        }

        AddRow(new GameInstall(GameDetector.Normalize(path), "Chosen manually")).Selected = true;
    }

    private void UpdateStatus()
    {
        _actionButton.Enabled = SelectedPath is not null;

        if (SelectedPath is { } path)
        {
            var installed = GameDetector.GetInstalledVersion(path);
            SetStatus(installed is null
                ? "Ready to install. Any existing BmSDK files in this folder will be replaced."
                : $"BmSDK v{installed} is already installed here and will be updated to v{Program.Version}.");
        }
        else if (_installList.Items.Count == 0)
        {
            SetStatus("No Arkham City installation was found. Use \"Choose another folder...\" to pick one yourself.");
        }
        else
        {
            SetStatus("Select the installation you want to use.");
        }
    }

    private void SetStatus(string text, bool isError = false)
    {
        _statusLabel.Text = text;
        _statusLabel.ForeColor = isError ? Color.Firebrick : SystemColors.ControlText;
    }

    private void OnBrowseClicked(object? sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog
        {
            Description = "Select your Batman: Arkham City folder",
            UseDescriptionForTitle = true,
            ShowNewFolderButton = false,
            InitialDirectory = SelectedPath ?? string.Empty,
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        if (!GameDetector.IsValidGameDir(dialog.SelectedPath))
        {
            MessageBox.Show(this,
                $"That folder doesn't look like a Batman: Arkham City installation:\n\n{dialog.SelectedPath}\n\n"
                    + "Pick the folder containing the Binaries and BmGame folders.",
                "BmSDK Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        SelectPath(dialog.SelectedPath);
        UpdateStatus();
    }

    private void OnActionClicked(object? sender, EventArgs e)
    {
        if (_isInstalled)
        {
            Process.Start(new ProcessStartInfo(SelectedPath!) { UseShellExecute = true });
            return;
        }

        BeginInstall();
    }

    private async void BeginInstall()
    {
        var targetPath = SelectedPath!;

        // Epic installs often live under Program Files, where writing needs elevation
        if (!PayloadInstaller.IsWritable(targetPath))
        {
            if (PayloadInstaller.RelaunchElevated(targetPath))
            {
                Close();
            }
            else
            {
                SetStatus("Administrator access is needed to write to this folder. Please try again and accept the prompt.", true);
            }

            return;
        }

        SetUiBusy(true);
        SetStatus($"Installing to {targetPath}...");

        var progress = new Progress<int>(percent => _progressBar.Value = percent);

        try
        {
            await Task.Run(() => PayloadInstaller.Install(targetPath, progress));
        }
        catch (Exception ex)
        {
            SetUiBusy(false);
            SetStatus($"Installation failed: {ex.Message}", true);
            return;
        }

        _isInstalled = true;
        SetUiBusy(false);

        _installList.Enabled = false;
        _browseButton.Enabled = false;
        _actionButton.Text = "Open Folder";
        _actionButton.Enabled = true;
        _closeButton.Text = "Done";

        SetStatus($"BmSDK v{Program.Version} was installed successfully. "
            + "Drop script mods into BmGame\\Scripts and start the game.");
    }

    private void SetUiBusy(bool isBusy)
    {
        _progressBar.Visible = isBusy;
        _progressBar.Value = 0;
        _installList.Enabled = !isBusy;
        _browseButton.Enabled = !isBusy;
        _actionButton.Enabled = !isBusy;
        _closeButton.Enabled = !isBusy;
        UseWaitCursor = isBusy;
    }
}
