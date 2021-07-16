
namespace TheGoodEditor2.EditorWindows
{
    partial class FloatingCollectibleEditorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloatingCollectibleEditorWindow));
            this.grupAssetProperties = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveDataEdited = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPosZ = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.txtPosZ = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.grupAssetProperties.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupAssetProperties
            // 
            this.grupAssetProperties.Controls.Add(this.groupBox1);
            this.grupAssetProperties.Controls.Add(this.label5);
            this.grupAssetProperties.Controls.Add(this.lblPosZ);
            this.grupAssetProperties.Controls.Add(this.lblPosY);
            this.grupAssetProperties.Controls.Add(this.lblPosX);
            this.grupAssetProperties.Controls.Add(this.txtPosZ);
            this.grupAssetProperties.Controls.Add(this.txtPosY);
            this.grupAssetProperties.Controls.Add(this.txtPosX);
            this.grupAssetProperties.Location = new System.Drawing.Point(13, 13);
            this.grupAssetProperties.Margin = new System.Windows.Forms.Padding(4);
            this.grupAssetProperties.Name = "grupAssetProperties";
            this.grupAssetProperties.Padding = new System.Windows.Forms.Padding(4);
            this.grupAssetProperties.Size = new System.Drawing.Size(849, 414);
            this.grupAssetProperties.TabIndex = 9;
            this.grupAssetProperties.TabStop = false;
            this.grupAssetProperties.Text = "FloatingCollectible Properties";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveDataEdited);
            this.groupBox1.Location = new System.Drawing.Point(7, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 251);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saving Controls (Not Editable Yet)";
            // 
            // saveDataEdited
            // 
            this.saveDataEdited.Location = new System.Drawing.Point(7, 22);
            this.saveDataEdited.Margin = new System.Windows.Forms.Padding(4);
            this.saveDataEdited.Name = "saveDataEdited";
            this.saveDataEdited.Size = new System.Drawing.Size(818, 222);
            this.saveDataEdited.TabIndex = 35;
            this.saveDataEdited.Text = "Save All Data Here to Asset";
            this.saveDataEdited.UseVisualStyleBackColor = true;
            this.saveDataEdited.Visible = false;
            this.saveDataEdited.Click += new System.EventHandler(this.saveDataEdited_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Position View";
            // 
            // lblPosZ
            // 
            this.lblPosZ.AutoSize = true;
            this.lblPosZ.Location = new System.Drawing.Point(523, 108);
            this.lblPosZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosZ.Name = "lblPosZ";
            this.lblPosZ.Size = new System.Drawing.Size(71, 17);
            this.lblPosZ.TabIndex = 15;
            this.lblPosZ.Text = "Position Z";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(264, 109);
            this.lblPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(71, 17);
            this.lblPosY.TabIndex = 14;
            this.lblPosY.Text = "Position Y";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(13, 110);
            this.lblPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(71, 17);
            this.lblPosX.TabIndex = 13;
            this.lblPosX.Text = "Position X";
            // 
            // txtPosZ
            // 
            this.txtPosZ.Location = new System.Drawing.Point(603, 104);
            this.txtPosZ.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosZ.Name = "txtPosZ";
            this.txtPosZ.Size = new System.Drawing.Size(167, 22);
            this.txtPosZ.TabIndex = 12;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(344, 105);
            this.txtPosY.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(167, 22);
            this.txtPosY.TabIndex = 11;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(93, 106);
            this.txtPosX.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(167, 22);
            this.txtPosX.TabIndex = 10;
            // 
            // FloatingCollectibleEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 430);
            this.Controls.Add(this.grupAssetProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FloatingCollectibleEditorWindow";
            this.Text = "Edit FloatingCollectible";
            this.Load += new System.EventHandler(this.FloatingCollectibleEditorWindow_Load);
            this.grupAssetProperties.ResumeLayout(false);
            this.grupAssetProperties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupAssetProperties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveDataEdited;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPosZ;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox txtPosZ;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
    }
}