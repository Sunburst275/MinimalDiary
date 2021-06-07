using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MinimalDiary
{
    public partial class MainForm : Form
    {
        const string ProgramName = "Minimal Diary";
        const string KEY_LOCATION = "SOFTWARE\\MinimalDiary\\DefaultSaveLocation";

        #region MainForm
        public MainForm()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainMenuSave.Click += MainMenuSave_Click;
            this.MainMenuSetDefaultSaveLocation.Click += MainMenuSetDefaultSaveLocation_Click;
            this.MainMenuGotoDefaultSaveLocation.Click += MainMenuGotoDefaultSaveLocation_Click;
            this.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveEntry();
                if (e.Shift)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResizeMainMenuTextBox();
            LoadDefaultLocation();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeMainMenuTextBox();
        }
        #endregion

        private void ResizeMainMenuTextBox()
        {
            // Resize TextBoxDefaultSaveLocation to fit entire MainMenuBar
            var newsize = MainMenu.Size.Width - (MainMenuSetDefaultSaveLocation.Size.Width + MainMenuGotoDefaultSaveLocation.Size.Width + MainMenuSave.Size.Width + 20);
            MainMenuDefaultSaveLocation.Size = new Size(newsize, MainMenuDefaultSaveLocation.Size.Height);
        }

        private void SetDefaultLocation()
        {
            Microsoft.Win32.RegistryKey key;
            string DefaultSaveLocation = MainMenuDefaultSaveLocation.Text;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(KEY_LOCATION, true);
                if (key == null)
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(KEY_LOCATION, true);
                }

                key.SetValue("DefaultSaveLocation", DefaultSaveLocation, Microsoft.Win32.RegistryValueKind.String);
                key.Close();

                MessageBox.Show($"Set default save path to\n{DefaultSaveLocation}!",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                var x = "Something went wrong while trying to set the default save location!\nMessage:\n";
                MessageBox.Show($"{x}{ex.Message}",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadDefaultLocation()
        {
            Microsoft.Win32.RegistryKey key;
            string DefaultSaveLocation = String.Empty;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(KEY_LOCATION, true);
                if (key == null)
                {
                    // Create key
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(KEY_LOCATION, true);
                    key.SetValue("DefaultSaveLocation", (String.Empty));
                    key.Close();
                    return;
                }

                if (key.GetValueNames().Contains("DefaultSaveLocation"))
                {
                    DefaultSaveLocation = (string)(key.GetValue("DefaultSaveLocation"));
                }
                key.Close();

                if (!Directory.Exists(Path.GetDirectoryName(DefaultSaveLocation)))
                {
                    MessageBox.Show("Couldn't load default save location!",
                   "Error!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                var x = "Something went wrong while trying to load the default save location!\nMessage:\n";
                MessageBox.Show($"{x}{ex.Message}",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MainMenuDefaultSaveLocation.Text = DefaultSaveLocation;
        }

        private void MainMenuSetDefaultSaveLocation_Click(object sender, System.EventArgs e)
        {
            SetDefaultLocation();
        }

        private void MainMenuGotoDefaultSaveLocation_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", $@"{MainMenuDefaultSaveLocation.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:\n{ex.Message}",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private bool SaveEntry()
        {
            bool DefaultWasEnabled = false;
            string Name = string.Join("-", ProgramName.Split(" ")) +
                "_" +
                DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string SaveLocationPath = String.Empty;
            if (string.IsNullOrEmpty(MainMenuDefaultSaveLocation.Text))
            {
                // Save as ...
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.FileName = Name;
                sfd.Title = "Save file ...";
                sfd.CheckPathExists = true;
                var res = sfd.ShowDialog();
                if (res != DialogResult.OK || sfd.FileNames.Length > 1)
                {
                    return false;
                }

                SaveLocationPath = sfd.FileName;
                DefaultWasEnabled = false;
            }
            else
            {
                // Save in default location
                SaveLocationPath = MainMenuDefaultSaveLocation.Text;
                DefaultWasEnabled = true;
            }

            if (!Directory.Exists(Path.GetDirectoryName(SaveLocationPath)))
            {
                MessageBox.Show("Directory doesn't exist!",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            string SaveLocationAndName = String.Empty;
            if (DefaultWasEnabled)
            {
                SaveLocationAndName = Path.Combine(SaveLocationPath, Name) + ".txt";
            }
            else
            {
                SaveLocationAndName = SaveLocationPath;
            }
            try
            {
                using (FileStream stream = new FileStream(SaveLocationAndName, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(MainTextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong while trying to save your file!\nMessage:\n{ex.Message}",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void MainMenuSave_Click(object sender, System.EventArgs e)
        {
            if (SaveEntry())
            {
                var res2 = MessageBox.Show("Saved successfully. Exit now?",
                    "Success!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (res2 == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
