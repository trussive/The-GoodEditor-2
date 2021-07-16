
namespace TheGoodEditor2.EditorWindows
{
    partial class PlatformEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformEditor));
            this.grupAssetProperties = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveDataEdited = new System.Windows.Forms.Button();
            this.btnApplyScaleX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScaleZ = new System.Windows.Forms.Label();
            this.lblScaleY = new System.Windows.Forms.Label();
            this.lblScaleX = new System.Windows.Forms.Label();
            this.txtScaleZ = new System.Windows.Forms.TextBox();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.lblRotation = new System.Windows.Forms.Label();
            this.lblRotZ = new System.Windows.Forms.Label();
            this.lblRotY = new System.Windows.Forms.Label();
            this.lblRotX = new System.Windows.Forms.Label();
            this.txtRotZ = new System.Windows.Forms.TextBox();
            this.txtRotY = new System.Windows.Forms.TextBox();
            this.txtRotX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
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
            this.grupAssetProperties.Controls.Add(this.btnApplyScaleX);
            this.grupAssetProperties.Controls.Add(this.label1);
            this.grupAssetProperties.Controls.Add(this.lblScaleZ);
            this.grupAssetProperties.Controls.Add(this.lblScaleY);
            this.grupAssetProperties.Controls.Add(this.lblScaleX);
            this.grupAssetProperties.Controls.Add(this.txtScaleZ);
            this.grupAssetProperties.Controls.Add(this.txtScaleY);
            this.grupAssetProperties.Controls.Add(this.txtScaleX);
            this.grupAssetProperties.Controls.Add(this.lblRotation);
            this.grupAssetProperties.Controls.Add(this.lblRotZ);
            this.grupAssetProperties.Controls.Add(this.lblRotY);
            this.grupAssetProperties.Controls.Add(this.lblRotX);
            this.grupAssetProperties.Controls.Add(this.txtRotZ);
            this.grupAssetProperties.Controls.Add(this.txtRotY);
            this.grupAssetProperties.Controls.Add(this.txtRotX);
            this.grupAssetProperties.Controls.Add(this.label5);
            this.grupAssetProperties.Controls.Add(this.lblPosition);
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
            this.grupAssetProperties.Size = new System.Drawing.Size(849, 592);
            this.grupAssetProperties.TabIndex = 8;
            this.grupAssetProperties.TabStop = false;
            this.grupAssetProperties.Text = "Platform Properties";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveDataEdited);
            this.groupBox1.Location = new System.Drawing.Point(8, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 251);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saving Controls";
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
            this.saveDataEdited.Click += new System.EventHandler(this.saveDataEdited_Click);
            // 
            // btnApplyScaleX
            // 
            this.btnApplyScaleX.Location = new System.Drawing.Point(653, 288);
            this.btnApplyScaleX.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyScaleX.Name = "btnApplyScaleX";
            this.btnApplyScaleX.Size = new System.Drawing.Size(187, 27);
            this.btnApplyScaleX.TabIndex = 32;
            this.btnApplyScaleX.Text = "Apply Scale X To All Fields";
            this.btnApplyScaleX.UseVisualStyleBackColor = true;
            this.btnApplyScaleX.Click += new System.EventHandler(this.btnApplyScaleX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Scale";
            // 
            // lblScaleZ
            // 
            this.lblScaleZ.AutoSize = true;
            this.lblScaleZ.Location = new System.Drawing.Point(593, 223);
            this.lblScaleZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaleZ.Name = "lblScaleZ";
            this.lblScaleZ.Size = new System.Drawing.Size(56, 17);
            this.lblScaleZ.TabIndex = 30;
            this.lblScaleZ.Text = "Scale Z";
            // 
            // lblScaleY
            // 
            this.lblScaleY.AutoSize = true;
            this.lblScaleY.Location = new System.Drawing.Point(593, 166);
            this.lblScaleY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaleY.Name = "lblScaleY";
            this.lblScaleY.Size = new System.Drawing.Size(56, 17);
            this.lblScaleY.TabIndex = 29;
            this.lblScaleY.Text = "Scale Y";
            // 
            // lblScaleX
            // 
            this.lblScaleX.AutoSize = true;
            this.lblScaleX.Location = new System.Drawing.Point(593, 110);
            this.lblScaleX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScaleX.Name = "lblScaleX";
            this.lblScaleX.Size = new System.Drawing.Size(56, 17);
            this.lblScaleX.TabIndex = 28;
            this.lblScaleX.Text = "Scale X";
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(673, 219);
            this.txtScaleZ.Margin = new System.Windows.Forms.Padding(4);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(167, 22);
            this.txtScaleZ.TabIndex = 27;
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(673, 162);
            this.txtScaleY.Margin = new System.Windows.Forms.Padding(4);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(167, 22);
            this.txtScaleY.TabIndex = 26;
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(673, 106);
            this.txtScaleX.Margin = new System.Windows.Forms.Padding(4);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(167, 22);
            this.txtScaleX.TabIndex = 25;
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(432, 68);
            this.lblRotation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(61, 17);
            this.lblRotation.TabIndex = 24;
            this.lblRotation.Text = "Rotation";
            // 
            // lblRotZ
            // 
            this.lblRotZ.AutoSize = true;
            this.lblRotZ.Location = new System.Drawing.Point(299, 223);
            this.lblRotZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotZ.Name = "lblRotZ";
            this.lblRotZ.Size = new System.Drawing.Size(74, 17);
            this.lblRotZ.TabIndex = 23;
            this.lblRotZ.Text = "Rotation Z";
            // 
            // lblRotY
            // 
            this.lblRotY.AutoSize = true;
            this.lblRotY.Location = new System.Drawing.Point(299, 166);
            this.lblRotY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(74, 17);
            this.lblRotY.TabIndex = 22;
            this.lblRotY.Text = "Rotation Y";
            // 
            // lblRotX
            // 
            this.lblRotX.AutoSize = true;
            this.lblRotX.Location = new System.Drawing.Point(299, 110);
            this.lblRotX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(74, 17);
            this.lblRotX.TabIndex = 21;
            this.lblRotX.Text = "Rotation X";
            // 
            // txtRotZ
            // 
            this.txtRotZ.Location = new System.Drawing.Point(379, 219);
            this.txtRotZ.Margin = new System.Windows.Forms.Padding(4);
            this.txtRotZ.Name = "txtRotZ";
            this.txtRotZ.Size = new System.Drawing.Size(167, 22);
            this.txtRotZ.TabIndex = 20;
            // 
            // txtRotY
            // 
            this.txtRotY.Location = new System.Drawing.Point(379, 162);
            this.txtRotY.Margin = new System.Windows.Forms.Padding(4);
            this.txtRotY.Name = "txtRotY";
            this.txtRotY.Size = new System.Drawing.Size(167, 22);
            this.txtRotY.TabIndex = 19;
            // 
            // txtRotX
            // 
            this.txtRotX.Location = new System.Drawing.Point(379, 106);
            this.txtRotX.Margin = new System.Windows.Forms.Padding(4);
            this.txtRotX.Name = "txtRotX";
            this.txtRotX.Size = new System.Drawing.Size(167, 22);
            this.txtRotX.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Position, Rotation, and Scale Controls";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(147, 68);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position";
            // 
            // lblPosZ
            // 
            this.lblPosZ.AutoSize = true;
            this.lblPosZ.Location = new System.Drawing.Point(13, 223);
            this.lblPosZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosZ.Name = "lblPosZ";
            this.lblPosZ.Size = new System.Drawing.Size(71, 17);
            this.lblPosZ.TabIndex = 15;
            this.lblPosZ.Text = "Position Z";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(13, 166);
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
            this.txtPosZ.Location = new System.Drawing.Point(93, 219);
            this.txtPosZ.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosZ.Name = "txtPosZ";
            this.txtPosZ.Size = new System.Drawing.Size(167, 22);
            this.txtPosZ.TabIndex = 12;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(93, 162);
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
            // PlatformEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 619);
            this.Controls.Add(this.grupAssetProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlatformEditor";
            this.Text = "Edit Selected Platform Asset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlatformEditor_FormClosed);
            this.Load += new System.EventHandler(this.PlatformEditor_Load);
            this.grupAssetProperties.ResumeLayout(false);
            this.grupAssetProperties.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupAssetProperties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveDataEdited;
        private System.Windows.Forms.Button btnApplyScaleX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScaleZ;
        private System.Windows.Forms.Label lblScaleY;
        private System.Windows.Forms.Label lblScaleX;
        private System.Windows.Forms.TextBox txtScaleZ;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.Label lblRotZ;
        private System.Windows.Forms.Label lblRotY;
        private System.Windows.Forms.Label lblRotX;
        private System.Windows.Forms.TextBox txtRotZ;
        private System.Windows.Forms.TextBox txtRotY;
        private System.Windows.Forms.TextBox txtRotX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPosZ;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox txtPosZ;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
    }
}