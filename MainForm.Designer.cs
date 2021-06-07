
namespace MinimalDiary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuGotoDefaultSaveLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuSetDefaultSaveLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuDefaultSaveLocation = new System.Windows.Forms.ToolStripTextBox();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuSave,
            this.MainMenuGotoDefaultSaveLocation,
            this.MainMenuSetDefaultSaveLocation,
            this.MainMenuDefaultSaveLocation});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MainMenu.Size = new System.Drawing.Size(560, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // MainMenuSave
            // 
            this.MainMenuSave.Name = "MainMenuSave";
            this.MainMenuSave.Size = new System.Drawing.Size(43, 23);
            this.MainMenuSave.Text = "Save";
            this.MainMenuSave.ToolTipText = "Save (Ctrl + S) | Save and exit (Ctrl + Shift + S)";
            // 
            // MainMenuGotoDefaultSaveLocation
            // 
            this.MainMenuGotoDefaultSaveLocation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MainMenuGotoDefaultSaveLocation.Name = "MainMenuGotoDefaultSaveLocation";
            this.MainMenuGotoDefaultSaveLocation.Size = new System.Drawing.Size(48, 23);
            this.MainMenuGotoDefaultSaveLocation.Text = "Go to";
            // 
            // MainMenuSetDefaultSaveLocation
            // 
            this.MainMenuSetDefaultSaveLocation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MainMenuSetDefaultSaveLocation.Name = "MainMenuSetDefaultSaveLocation";
            this.MainMenuSetDefaultSaveLocation.Size = new System.Drawing.Size(35, 23);
            this.MainMenuSetDefaultSaveLocation.Text = "Set";
            this.MainMenuSetDefaultSaveLocation.ToolTipText = "Sets the default (directory) location entered on the right text box and saves it." +
    "";
            // 
            // MainMenuDefaultSaveLocation
            // 
            this.MainMenuDefaultSaveLocation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MainMenuDefaultSaveLocation.AutoSize = false;
            this.MainMenuDefaultSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuDefaultSaveLocation.Name = "MainMenuDefaultSaveLocation";
            this.MainMenuDefaultSaveLocation.Size = new System.Drawing.Size(71, 23);
            this.MainMenuDefaultSaveLocation.ToolTipText = "The default (directory) location where your diary will be saved.";
            // 
            // MainTextBox
            // 
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Location = new System.Drawing.Point(0, 25);
            this.MainTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(560, 245);
            this.MainTextBox.TabIndex = 1;
            this.MainTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.MainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Minimal Diary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuSave;
        private System.Windows.Forms.ToolStripTextBox MainMenuDefaultSaveLocation;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.ToolStripMenuItem MainMenuSetDefaultSaveLocation;
        private System.Windows.Forms.ToolStripMenuItem MainMenuGotoDefaultSaveLocation;
    }
}

