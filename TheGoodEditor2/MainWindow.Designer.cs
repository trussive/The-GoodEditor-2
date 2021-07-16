namespace TheGoodEditor2
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHoParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHoParcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHoParcelAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTheGoodEditor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLayerListToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAssetsListToTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheGoodEditor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolTipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.listBoxAssets = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnAssetDown = new System.Windows.Forms.Button();
            this.btnAssetUp = new System.Windows.Forms.Button();
            this.btnLayerDown = new System.Windows.Forms.Button();
            this.btnLayerUp = new System.Windows.Forms.Button();
            this.btnFindAsset = new System.Windows.Forms.Button();
            this.btnFindLayer = new System.Windows.Forms.Button();
            this.lblAssetSearch = new System.Windows.Forms.Label();
            this.txtAssetSearch = new System.Windows.Forms.TextBox();
            this.lblLayerSearch = new System.Windows.Forms.Label();
            this.txtLayerSearch = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendData = new System.Windows.Forms.Button();
            this.gHelpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.grupAssetOtherTools = new System.Windows.Forms.GroupBox();
            this.buttonExtractAll = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grupAssetOtherTools.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadHoParcelToolStripMenuItem,
            this.saveHoParcelToolStripMenuItem,
            this.saveHoParcelAsToolStripMenuItem,
            this.exitTheGoodEditor2ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadHoParcelToolStripMenuItem
            // 
            this.loadHoParcelToolStripMenuItem.Name = "loadHoParcelToolStripMenuItem";
            this.loadHoParcelToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.loadHoParcelToolStripMenuItem.Text = "Load Ho Parcel";
            this.loadHoParcelToolStripMenuItem.Click += new System.EventHandler(this.loadHoParcelToolStripMenuItem_Click);
            // 
            // saveHoParcelToolStripMenuItem
            // 
            this.saveHoParcelToolStripMenuItem.Name = "saveHoParcelToolStripMenuItem";
            this.saveHoParcelToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveHoParcelToolStripMenuItem.Text = "Save Ho Parcel";
            this.saveHoParcelToolStripMenuItem.Click += new System.EventHandler(this.saveHoParcelToolStripMenuItem_Click);
            // 
            // saveHoParcelAsToolStripMenuItem
            // 
            this.saveHoParcelAsToolStripMenuItem.Name = "saveHoParcelAsToolStripMenuItem";
            this.saveHoParcelAsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveHoParcelAsToolStripMenuItem.Text = "Save Ho Parcel As";
            this.saveHoParcelAsToolStripMenuItem.Click += new System.EventHandler(this.saveHoParcelAsToolStripMenuItem_Click);
            // 
            // exitTheGoodEditor2ToolStripMenuItem
            // 
            this.exitTheGoodEditor2ToolStripMenuItem.Name = "exitTheGoodEditor2ToolStripMenuItem";
            this.exitTheGoodEditor2ToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.exitTheGoodEditor2ToolStripMenuItem.Text = "Exit The GoodEditor 2";
            this.exitTheGoodEditor2ToolStripMenuItem.Click += new System.EventHandler(this.exitTheGoodEditor2ToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportLayerListToTextFileToolStripMenuItem,
            this.exportAssetsListToTextFileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportLayerListToTextFileToolStripMenuItem
            // 
            this.exportLayerListToTextFileToolStripMenuItem.Name = "exportLayerListToTextFileToolStripMenuItem";
            this.exportLayerListToTextFileToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.exportLayerListToTextFileToolStripMenuItem.Text = "Export Layer List To Text File";
            this.exportLayerListToTextFileToolStripMenuItem.Click += new System.EventHandler(this.exportLayerListToTextFileToolStripMenuItem_Click);
            // 
            // exportAssetsListToTextFileToolStripMenuItem
            // 
            this.exportAssetsListToTextFileToolStripMenuItem.Name = "exportAssetsListToTextFileToolStripMenuItem";
            this.exportAssetsListToTextFileToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.exportAssetsListToTextFileToolStripMenuItem.Text = "Export Asset List To Text File";
            this.exportAssetsListToTextFileToolStripMenuItem.Click += new System.EventHandler(this.exportAssetsListToTextFileToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheGoodEditor2ToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.disableToolTipsToolStripMenuItem});
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // aboutTheGoodEditor2ToolStripMenuItem
            // 
            this.aboutTheGoodEditor2ToolStripMenuItem.Name = "aboutTheGoodEditor2ToolStripMenuItem";
            this.aboutTheGoodEditor2ToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.aboutTheGoodEditor2ToolStripMenuItem.Text = "About the GoodEditor 2";
            this.aboutTheGoodEditor2ToolStripMenuItem.Click += new System.EventHandler(this.aboutTheGoodEditor2ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.helpToolStripMenuItem.Text = "Enable ToolTips";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // disableToolTipsToolStripMenuItem
            // 
            this.disableToolTipsToolStripMenuItem.Name = "disableToolTipsToolStripMenuItem";
            this.disableToolTipsToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.disableToolTipsToolStripMenuItem.Text = "Disable ToolTips";
            this.disableToolTipsToolStripMenuItem.Click += new System.EventHandler(this.disableToolTipsToolStripMenuItem_Click);
            // 
            // listBoxLayers
            // 
            this.listBoxLayers.FormattingEnabled = true;
            this.listBoxLayers.ItemHeight = 16;
            this.listBoxLayers.Location = new System.Drawing.Point(8, 167);
            this.listBoxLayers.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLayers.Name = "listBoxLayers";
            this.listBoxLayers.Size = new System.Drawing.Size(297, 404);
            this.listBoxLayers.TabIndex = 2;
            this.listBoxLayers.SelectedIndexChanged += new System.EventHandler(this.listBoxLayers_SelectedIndexChanged);
            this.listBoxLayers.MouseHover += new System.EventHandler(this.listBoxLayers_MouseHover);
            // 
            // listBoxAssets
            // 
            this.listBoxAssets.FormattingEnabled = true;
            this.listBoxAssets.ItemHeight = 16;
            this.listBoxAssets.Location = new System.Drawing.Point(315, 167);
            this.listBoxAssets.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAssets.Name = "listBoxAssets";
            this.listBoxAssets.Size = new System.Drawing.Size(312, 404);
            this.listBoxAssets.TabIndex = 1;
            this.listBoxAssets.SelectedIndexChanged += new System.EventHandler(this.listBoxAssets_SelectedIndexChanged_1);
            this.listBoxAssets.MouseHover += new System.EventHandler(this.listBoxAssets_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.btnAssetDown);
            this.groupBox1.Controls.Add(this.btnAssetUp);
            this.groupBox1.Controls.Add(this.btnLayerDown);
            this.groupBox1.Controls.Add(this.btnLayerUp);
            this.groupBox1.Controls.Add(this.btnFindAsset);
            this.groupBox1.Controls.Add(this.btnFindLayer);
            this.groupBox1.Controls.Add(this.lblAssetSearch);
            this.groupBox1.Controls.Add(this.txtAssetSearch);
            this.groupBox1.Controls.Add(this.lblLayerSearch);
            this.groupBox1.Controls.Add(this.txtLayerSearch);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxLayers);
            this.groupBox1.Controls.Add(this.listBoxAssets);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(648, 592);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers and Assets";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 92);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 21);
            this.checkBox2.TabIndex = 48;
            this.checkBox2.Text = "Enable Discord RPC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnAssetDown
            // 
            this.btnAssetDown.Location = new System.Drawing.Point(573, 133);
            this.btnAssetDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssetDown.Name = "btnAssetDown";
            this.btnAssetDown.Size = new System.Drawing.Size(33, 28);
            this.btnAssetDown.TabIndex = 47;
            this.btnAssetDown.Text = "↓";
            this.btnAssetDown.UseVisualStyleBackColor = true;
            this.btnAssetDown.Click += new System.EventHandler(this.btnAssetDown_Click);
            // 
            // btnAssetUp
            // 
            this.btnAssetUp.Location = new System.Drawing.Point(532, 133);
            this.btnAssetUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssetUp.Name = "btnAssetUp";
            this.btnAssetUp.Size = new System.Drawing.Size(33, 28);
            this.btnAssetUp.TabIndex = 46;
            this.btnAssetUp.Text = "↑";
            this.btnAssetUp.UseVisualStyleBackColor = true;
            this.btnAssetUp.Click += new System.EventHandler(this.btnAssetUp_Click);
            // 
            // btnLayerDown
            // 
            this.btnLayerDown.Location = new System.Drawing.Point(257, 135);
            this.btnLayerDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayerDown.Name = "btnLayerDown";
            this.btnLayerDown.Size = new System.Drawing.Size(33, 28);
            this.btnLayerDown.TabIndex = 45;
            this.btnLayerDown.Text = "↓";
            this.btnLayerDown.UseVisualStyleBackColor = true;
            this.btnLayerDown.Click += new System.EventHandler(this.btnLayerDown_Click);
            this.btnLayerDown.MouseHover += new System.EventHandler(this.btnLayerDown_MouseHover);
            // 
            // btnLayerUp
            // 
            this.btnLayerUp.Location = new System.Drawing.Point(219, 135);
            this.btnLayerUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayerUp.Name = "btnLayerUp";
            this.btnLayerUp.Size = new System.Drawing.Size(33, 28);
            this.btnLayerUp.TabIndex = 44;
            this.btnLayerUp.Text = "↑";
            this.btnLayerUp.UseVisualStyleBackColor = true;
            this.btnLayerUp.Click += new System.EventHandler(this.btnLayerUp_Click);
            this.btnLayerUp.MouseHover += new System.EventHandler(this.btnLayerUp_MouseHover);
            // 
            // btnFindAsset
            // 
            this.btnFindAsset.Location = new System.Drawing.Point(469, 134);
            this.btnFindAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindAsset.Name = "btnFindAsset";
            this.btnFindAsset.Size = new System.Drawing.Size(57, 28);
            this.btnFindAsset.TabIndex = 43;
            this.btnFindAsset.Text = "Find";
            this.btnFindAsset.UseVisualStyleBackColor = true;
            this.btnFindAsset.Click += new System.EventHandler(this.btnFindAsset_Click);
            // 
            // btnFindLayer
            // 
            this.btnFindLayer.Location = new System.Drawing.Point(151, 134);
            this.btnFindLayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindLayer.Name = "btnFindLayer";
            this.btnFindLayer.Size = new System.Drawing.Size(57, 28);
            this.btnFindLayer.TabIndex = 42;
            this.btnFindLayer.Text = "Find";
            this.btnFindLayer.UseVisualStyleBackColor = true;
            this.btnFindLayer.Click += new System.EventHandler(this.btnFindLayer_Click);
            this.btnFindLayer.MouseHover += new System.EventHandler(this.btnFindLayer_MouseHover);
            // 
            // lblAssetSearch
            // 
            this.lblAssetSearch.AutoSize = true;
            this.lblAssetSearch.Location = new System.Drawing.Point(423, 117);
            this.lblAssetSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssetSearch.Name = "lblAssetSearch";
            this.lblAssetSearch.Size = new System.Drawing.Size(92, 17);
            this.lblAssetSearch.TabIndex = 41;
            this.lblAssetSearch.Text = "Asset Search";
            // 
            // txtAssetSearch
            // 
            this.txtAssetSearch.Location = new System.Drawing.Point(315, 135);
            this.txtAssetSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssetSearch.Name = "txtAssetSearch";
            this.txtAssetSearch.Size = new System.Drawing.Size(145, 22);
            this.txtAssetSearch.TabIndex = 40;
            // 
            // lblLayerSearch
            // 
            this.lblLayerSearch.AutoSize = true;
            this.lblLayerSearch.Location = new System.Drawing.Point(107, 117);
            this.lblLayerSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLayerSearch.Name = "lblLayerSearch";
            this.lblLayerSearch.Size = new System.Drawing.Size(93, 17);
            this.lblLayerSearch.TabIndex = 39;
            this.lblLayerSearch.Text = "Layer Search";
            // 
            // txtLayerSearch
            // 
            this.txtLayerSearch.Location = new System.Drawing.Point(12, 135);
            this.txtLayerSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtLayerSearch.Name = "txtLayerSearch";
            this.txtLayerSearch.Size = new System.Drawing.Size(129, 22);
            this.txtLayerSearch.TabIndex = 38;
            this.txtLayerSearch.MouseHover += new System.EventHandler(this.txtLayerSearch_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 71);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 21);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Little Endian Ho File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Size:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "File: None";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(8, 187);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(439, 28);
            this.btnSendData.TabIndex = 37;
            this.btnSendData.Text = "Edit Selected Asset";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.button2_Click);
            // 
            // grupAssetOtherTools
            // 
            this.grupAssetOtherTools.Controls.Add(this.buttonExtractAll);
            this.grupAssetOtherTools.Controls.Add(this.buttonExtract);
            this.grupAssetOtherTools.Controls.Add(this.buttonReplace);
            this.grupAssetOtherTools.Controls.Add(this.btnSendData);
            this.grupAssetOtherTools.Location = new System.Drawing.Point(672, 32);
            this.grupAssetOtherTools.Margin = new System.Windows.Forms.Padding(4);
            this.grupAssetOtherTools.Name = "grupAssetOtherTools";
            this.grupAssetOtherTools.Padding = new System.Windows.Forms.Padding(4);
            this.grupAssetOtherTools.Size = new System.Drawing.Size(455, 233);
            this.grupAssetOtherTools.TabIndex = 6;
            this.grupAssetOtherTools.TabStop = false;
            this.grupAssetOtherTools.Text = "Basic Asset Tools";
            this.grupAssetOtherTools.Enter += new System.EventHandler(this.grupAssetOtherTools_Enter);
            // 
            // buttonExtractAll
            // 
            this.buttonExtractAll.Location = new System.Drawing.Point(8, 101);
            this.buttonExtractAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtractAll.Name = "buttonExtractAll";
            this.buttonExtractAll.Size = new System.Drawing.Size(439, 28);
            this.buttonExtractAll.TabIndex = 7;
            this.buttonExtractAll.Text = "Extract All Assets";
            this.buttonExtractAll.UseVisualStyleBackColor = true;
            this.buttonExtractAll.Click += new System.EventHandler(this.buttonExtractAll_Click_2);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(8, 30);
            this.buttonExtract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(439, 28);
            this.buttonExtract.TabIndex = 5;
            this.buttonExtract.Text = "Extract Selected Asset";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click_2);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(8, 65);
            this.buttonReplace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(439, 28);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Replace Selected Asset";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "What\'s this asset type?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(672, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Help";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 645);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupAssetOtherTools);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "The GoodEditor 2";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupAssetOtherTools.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadHoParcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHoParcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitTheGoodEditor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLayerListToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAssetsListToTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheGoodEditor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxLayers;
        private System.Windows.Forms.ListBox listBoxAssets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ToolStripMenuItem saveHoParcelAsToolStripMenuItem;
        private System.Windows.Forms.Label lblAssetSearch;
        private System.Windows.Forms.TextBox txtAssetSearch;
        private System.Windows.Forms.Label lblLayerSearch;
        private System.Windows.Forms.TextBox txtLayerSearch;
        private System.Windows.Forms.Button btnFindAsset;
        private System.Windows.Forms.Button btnFindLayer;
        private System.Windows.Forms.Button btnAssetDown;
        private System.Windows.Forms.Button btnAssetUp;
        private System.Windows.Forms.Button btnLayerDown;
        private System.Windows.Forms.Button btnLayerUp;
        private System.Windows.Forms.ToolStripMenuItem disableToolTipsToolStripMenuItem;
        private System.Windows.Forms.ToolTip gHelpToolTips;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grupAssetOtherTools;
        private System.Windows.Forms.Button buttonExtractAll;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

