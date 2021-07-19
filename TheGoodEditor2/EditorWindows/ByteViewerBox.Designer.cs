
namespace TheGoodEditor2.EditorWindows
{
    partial class ByteViewerBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByteViewerBox));
            this.grpHexBoxContainer = new System.Windows.Forms.GroupBox();
            this.hexViewerBox = new Be.Windows.Forms.HexBox();
            this.grpButtonContainer = new System.Windows.Forms.GroupBox();
            this.noteTakerOpen = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.grpHexBoxContainer.SuspendLayout();
            this.grpButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHexBoxContainer
            // 
            this.grpHexBoxContainer.Controls.Add(this.hexViewerBox);
            this.grpHexBoxContainer.Location = new System.Drawing.Point(11, 12);
            this.grpHexBoxContainer.Name = "grpHexBoxContainer";
            this.grpHexBoxContainer.Size = new System.Drawing.Size(834, 824);
            this.grpHexBoxContainer.TabIndex = 1;
            this.grpHexBoxContainer.TabStop = false;
            this.grpHexBoxContainer.Text = "Hex Editor";
            // 
            // hexViewerBox
            // 
            this.hexViewerBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexViewerBox.LineInfoVisible = true;
            this.hexViewerBox.Location = new System.Drawing.Point(6, 21);
            this.hexViewerBox.Name = "hexViewerBox";
            this.hexViewerBox.SelectionBackColor = System.Drawing.Color.Fuchsia;
            this.hexViewerBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexViewerBox.Size = new System.Drawing.Size(822, 797);
            this.hexViewerBox.StringViewVisible = true;
            this.hexViewerBox.TabIndex = 0;
            this.hexViewerBox.VScrollBarVisible = true;
            // 
            // grpButtonContainer
            // 
            this.grpButtonContainer.Controls.Add(this.noteTakerOpen);
            this.grpButtonContainer.Controls.Add(this.btnSaveData);
            this.grpButtonContainer.Location = new System.Drawing.Point(849, 12);
            this.grpButtonContainer.Name = "grpButtonContainer";
            this.grpButtonContainer.Size = new System.Drawing.Size(188, 824);
            this.grpButtonContainer.TabIndex = 2;
            this.grpButtonContainer.TabStop = false;
            this.grpButtonContainer.Text = "Hex Editing Controls";
            // 
            // noteTakerOpen
            // 
            this.noteTakerOpen.Location = new System.Drawing.Point(6, 83);
            this.noteTakerOpen.Name = "noteTakerOpen";
            this.noteTakerOpen.Size = new System.Drawing.Size(176, 66);
            this.noteTakerOpen.TabIndex = 1;
            this.noteTakerOpen.Text = "Open the \r\nNote Taker";
            this.noteTakerOpen.UseVisualStyleBackColor = true;
            this.noteTakerOpen.Click += new System.EventHandler(this.noteTakerOpen_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(6, 38);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(176, 39);
            this.btnSaveData.TabIndex = 0;
            this.btnSaveData.Text = "Save Edited Bytes";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // ByteViewerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 848);
            this.Controls.Add(this.grpButtonContainer);
            this.Controls.Add(this.grpHexBoxContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ByteViewerBox";
            this.Text = "Edit Selected Asset\'s Raw Bytes";
            this.Load += new System.EventHandler(this.ByteViewerBox_Load);
            this.grpHexBoxContainer.ResumeLayout(false);
            this.grpButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpHexBoxContainer;
        private System.Windows.Forms.GroupBox grpButtonContainer;
        private System.Windows.Forms.Button noteTakerOpen;
        private System.Windows.Forms.Button btnSaveData;
        private Be.Windows.Forms.HexBox hexViewerBox;
    }
}