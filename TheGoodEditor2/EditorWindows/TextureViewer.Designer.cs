
namespace TheGoodEditor2.EditorWindows
{
    partial class TextureViewer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textureViewerBox = new System.Windows.Forms.PictureBox();
            this.saveAsPng = new System.Windows.Forms.Button();
            this.grpSavingControls = new System.Windows.Forms.GroupBox();
            this.saveAsJpg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureViewerBox)).BeginInit();
            this.grpSavingControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textureViewerBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texture Viewer";
            // 
            // textureViewerBox
            // 
            this.textureViewerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textureViewerBox.Location = new System.Drawing.Point(3, 18);
            this.textureViewerBox.Name = "textureViewerBox";
            this.textureViewerBox.Size = new System.Drawing.Size(647, 534);
            this.textureViewerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.textureViewerBox.TabIndex = 0;
            this.textureViewerBox.TabStop = false;
            // 
            // saveAsPng
            // 
            this.saveAsPng.Location = new System.Drawing.Point(6, 36);
            this.saveAsPng.Name = "saveAsPng";
            this.saveAsPng.Size = new System.Drawing.Size(245, 38);
            this.saveAsPng.TabIndex = 1;
            this.saveAsPng.Text = "Save Texture As *.png";
            this.saveAsPng.UseVisualStyleBackColor = true;
            this.saveAsPng.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpSavingControls
            // 
            this.grpSavingControls.Controls.Add(this.saveAsJpg);
            this.grpSavingControls.Controls.Add(this.saveAsPng);
            this.grpSavingControls.Location = new System.Drawing.Point(671, 21);
            this.grpSavingControls.Name = "grpSavingControls";
            this.grpSavingControls.Size = new System.Drawing.Size(257, 543);
            this.grpSavingControls.TabIndex = 2;
            this.grpSavingControls.TabStop = false;
            this.grpSavingControls.Text = "Saving Controls";
            // 
            // saveAsJpg
            // 
            this.saveAsJpg.Location = new System.Drawing.Point(6, 80);
            this.saveAsJpg.Name = "saveAsJpg";
            this.saveAsJpg.Size = new System.Drawing.Size(245, 38);
            this.saveAsJpg.TabIndex = 2;
            this.saveAsJpg.Text = "Save Texture As *.jpg";
            this.saveAsJpg.UseVisualStyleBackColor = true;
            this.saveAsJpg.Click += new System.EventHandler(this.saveAsJpg_Click);
            // 
            // TextureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSavingControls);
            this.Name = "TextureViewer";
            this.Text = "TextureViewer";
            this.Load += new System.EventHandler(this.TextureViewer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textureViewerBox)).EndInit();
            this.grpSavingControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox textureViewerBox;
        private System.Windows.Forms.Button saveAsPng;
        private System.Windows.Forms.GroupBox grpSavingControls;
        private System.Windows.Forms.Button saveAsJpg;
    }
}