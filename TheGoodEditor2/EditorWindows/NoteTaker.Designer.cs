
namespace TheGoodEditor2.EditorWindows
{
    partial class NoteTaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTaker));
            this.mnuSaveNotes = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavedNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTakenNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTheNoteTakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtfNotes = new System.Windows.Forms.RichTextBox();
            this.mnuSaveNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSaveNotes
            // 
            this.mnuSaveNotes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSaveNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuSaveNotes.Location = new System.Drawing.Point(0, 0);
            this.mnuSaveNotes.Name = "mnuSaveNotes";
            this.mnuSaveNotes.Size = new System.Drawing.Size(925, 28);
            this.mnuSaveNotes.TabIndex = 0;
            this.mnuSaveNotes.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSavedNotesToolStripMenuItem,
            this.saveTakenNotesToolStripMenuItem,
            this.closeTheNoteTakerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSavedNotesToolStripMenuItem
            // 
            this.openSavedNotesToolStripMenuItem.Name = "openSavedNotesToolStripMenuItem";
            this.openSavedNotesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.openSavedNotesToolStripMenuItem.Text = "Open Saved Notes...";
            this.openSavedNotesToolStripMenuItem.Click += new System.EventHandler(this.openSavedNotesToolStripMenuItem_Click);
            // 
            // saveTakenNotesToolStripMenuItem
            // 
            this.saveTakenNotesToolStripMenuItem.Name = "saveTakenNotesToolStripMenuItem";
            this.saveTakenNotesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.saveTakenNotesToolStripMenuItem.Text = "Save Taken Notes...";
            this.saveTakenNotesToolStripMenuItem.Click += new System.EventHandler(this.saveTakenNotesToolStripMenuItem_Click);
            // 
            // closeTheNoteTakerToolStripMenuItem
            // 
            this.closeTheNoteTakerToolStripMenuItem.Name = "closeTheNoteTakerToolStripMenuItem";
            this.closeTheNoteTakerToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.closeTheNoteTakerToolStripMenuItem.Text = "Close the Note Taker";
            this.closeTheNoteTakerToolStripMenuItem.Click += new System.EventHandler(this.closeTheNoteTakerToolStripMenuItem_Click);
            // 
            // rtfNotes
            // 
            this.rtfNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfNotes.Location = new System.Drawing.Point(0, 28);
            this.rtfNotes.Name = "rtfNotes";
            this.rtfNotes.Size = new System.Drawing.Size(925, 525);
            this.rtfNotes.TabIndex = 1;
            this.rtfNotes.Text = "";
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 553);
            this.Controls.Add(this.rtfNotes);
            this.Controls.Add(this.mnuSaveNotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuSaveNotes;
            this.Name = "NoteTaker";
            this.Text = "Take Notes on Things Found in Hex Values";
            this.mnuSaveNotes.ResumeLayout(false);
            this.mnuSaveNotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSaveNotes;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTakenNotesToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtfNotes;
        private System.Windows.Forms.ToolStripMenuItem openSavedNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTheNoteTakerToolStripMenuItem;
    }
}