
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
            this.MainMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuItemSetDefaultLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuDefaultSaveLocation = new System.Windows.Forms.ToolStripTextBox();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuItemSave,
            this.MainMenuItemSetDefaultLocation,
            this.MainMenuDefaultSaveLocation});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 35);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            //this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // MainMenuItemSave
            // 
            this.MainMenuItemSave.Name = "MainMenuItemSave";
            this.MainMenuItemSave.Size = new System.Drawing.Size(65, 31);
            this.MainMenuItemSave.Text = "Save";
            this.MainMenuItemSave.ToolTipText = "Save your diary file (to default location when set, otherwise somewhere else).";
            // 
            // MainMenuItemSetDefaultLocation
            // 
            this.MainMenuItemSetDefaultLocation.Name = "MainMenuItemSetDefaultLocation";
            this.MainMenuItemSetDefaultLocation.Size = new System.Drawing.Size(53, 31);
            this.MainMenuItemSetDefaultLocation.Text = "Set";
            this.MainMenuItemSetDefaultLocation.ToolTipText = "Sets the default (directory) location entered on the right text box and saves it." +
    "";
            // 
            // MainMenuDefaultSaveLocation
            // 
            this.MainMenuDefaultSaveLocation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MainMenuDefaultSaveLocation.AutoSize = false;
            this.MainMenuDefaultSaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuDefaultSaveLocation.Name = "MainMenuDefaultSaveLocation";
            this.MainMenuDefaultSaveLocation.Size = new System.Drawing.Size(100, 31);
            this.MainMenuDefaultSaveLocation.ToolTipText = "The default (directory) location where your diary will be saved.";
            // 
            // MainTextBox
            // 
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Location = new System.Drawing.Point(0, 35);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(800, 415);
            this.MainTextBox.TabIndex = 1;
            this.MainTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
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
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemSave;
        private System.Windows.Forms.ToolStripTextBox MainMenuDefaultSaveLocation;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.ToolStripMenuItem MainMenuItemSetDefaultLocation;
    }
}

