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
            this.btnSendData = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grupAssetProperties = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.saveDataEdited = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCollWarning = new System.Windows.Forms.Label();
            this.lblCollInfo = new System.Windows.Forms.Label();
            this.txtCollFlag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlag = new System.Windows.Forms.TextBox();
            this.grupAssetOtherTools = new System.Windows.Forms.GroupBox();
            this.buttonExtractAll = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
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
            this.gHelpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grupAssetProperties.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupAssetOtherTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadHoParcelToolStripMenuItem
            // 
            this.loadHoParcelToolStripMenuItem.Name = "loadHoParcelToolStripMenuItem";
            this.loadHoParcelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loadHoParcelToolStripMenuItem.Text = "Load Ho Parcel";
            this.loadHoParcelToolStripMenuItem.Click += new System.EventHandler(this.loadHoParcelToolStripMenuItem_Click);
            // 
            // saveHoParcelToolStripMenuItem
            // 
            this.saveHoParcelToolStripMenuItem.Name = "saveHoParcelToolStripMenuItem";
            this.saveHoParcelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveHoParcelToolStripMenuItem.Text = "Save Ho Parcel";
            this.saveHoParcelToolStripMenuItem.Click += new System.EventHandler(this.saveHoParcelToolStripMenuItem_Click);
            // 
            // saveHoParcelAsToolStripMenuItem
            // 
            this.saveHoParcelAsToolStripMenuItem.Name = "saveHoParcelAsToolStripMenuItem";
            this.saveHoParcelAsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveHoParcelAsToolStripMenuItem.Text = "Save Ho Parcel As";
            this.saveHoParcelAsToolStripMenuItem.Click += new System.EventHandler(this.saveHoParcelAsToolStripMenuItem_Click);
            // 
            // exitTheGoodEditor2ToolStripMenuItem
            // 
            this.exitTheGoodEditor2ToolStripMenuItem.Name = "exitTheGoodEditor2ToolStripMenuItem";
            this.exitTheGoodEditor2ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitTheGoodEditor2ToolStripMenuItem.Text = "Exit The GoodEditor 2";
            this.exitTheGoodEditor2ToolStripMenuItem.Click += new System.EventHandler(this.exitTheGoodEditor2ToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportLayerListToTextFileToolStripMenuItem,
            this.exportAssetsListToTextFileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportLayerListToTextFileToolStripMenuItem
            // 
            this.exportLayerListToTextFileToolStripMenuItem.Name = "exportLayerListToTextFileToolStripMenuItem";
            this.exportLayerListToTextFileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exportLayerListToTextFileToolStripMenuItem.Text = "Export Layer List To Text File";
            this.exportLayerListToTextFileToolStripMenuItem.Click += new System.EventHandler(this.exportLayerListToTextFileToolStripMenuItem_Click);
            // 
            // exportAssetsListToTextFileToolStripMenuItem
            // 
            this.exportAssetsListToTextFileToolStripMenuItem.Name = "exportAssetsListToTextFileToolStripMenuItem";
            this.exportAssetsListToTextFileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
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
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // aboutTheGoodEditor2ToolStripMenuItem
            // 
            this.aboutTheGoodEditor2ToolStripMenuItem.Name = "aboutTheGoodEditor2ToolStripMenuItem";
            this.aboutTheGoodEditor2ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.aboutTheGoodEditor2ToolStripMenuItem.Text = "About the GoodEditor 2";
            this.aboutTheGoodEditor2ToolStripMenuItem.Click += new System.EventHandler(this.aboutTheGoodEditor2ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.helpToolStripMenuItem.Text = "Enable ToolTips";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // disableToolTipsToolStripMenuItem
            // 
            this.disableToolTipsToolStripMenuItem.Name = "disableToolTipsToolStripMenuItem";
            this.disableToolTipsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.disableToolTipsToolStripMenuItem.Text = "Disable ToolTips";
            this.disableToolTipsToolStripMenuItem.Click += new System.EventHandler(this.disableToolTipsToolStripMenuItem_Click);
            // 
            // listBoxLayers
            // 
            this.listBoxLayers.FormattingEnabled = true;
            this.listBoxLayers.Location = new System.Drawing.Point(6, 136);
            this.listBoxLayers.Name = "listBoxLayers";
            this.listBoxLayers.Size = new System.Drawing.Size(224, 329);
            this.listBoxLayers.TabIndex = 2;
            this.listBoxLayers.SelectedIndexChanged += new System.EventHandler(this.listBoxLayers_SelectedIndexChanged);
            this.listBoxLayers.MouseHover += new System.EventHandler(this.listBoxLayers_MouseHover);
            // 
            // listBoxAssets
            // 
            this.listBoxAssets.FormattingEnabled = true;
            this.listBoxAssets.Location = new System.Drawing.Point(236, 136);
            this.listBoxAssets.Name = "listBoxAssets";
            this.listBoxAssets.Size = new System.Drawing.Size(235, 329);
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
            this.groupBox1.Controls.Add(this.btnSendData);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxLayers);
            this.groupBox1.Controls.Add(this.listBoxAssets);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 481);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers and Assets";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 75);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 17);
            this.checkBox2.TabIndex = 48;
            this.checkBox2.Text = "Enable Discord RPC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnAssetDown
            // 
            this.btnAssetDown.Location = new System.Drawing.Point(430, 108);
            this.btnAssetDown.Name = "btnAssetDown";
            this.btnAssetDown.Size = new System.Drawing.Size(25, 23);
            this.btnAssetDown.TabIndex = 47;
            this.btnAssetDown.Text = "↓";
            this.btnAssetDown.UseVisualStyleBackColor = true;
            this.btnAssetDown.Click += new System.EventHandler(this.btnAssetDown_Click);
            // 
            // btnAssetUp
            // 
            this.btnAssetUp.Location = new System.Drawing.Point(399, 108);
            this.btnAssetUp.Name = "btnAssetUp";
            this.btnAssetUp.Size = new System.Drawing.Size(25, 23);
            this.btnAssetUp.TabIndex = 46;
            this.btnAssetUp.Text = "↑";
            this.btnAssetUp.UseVisualStyleBackColor = true;
            this.btnAssetUp.Click += new System.EventHandler(this.btnAssetUp_Click);
            // 
            // btnLayerDown
            // 
            this.btnLayerDown.Location = new System.Drawing.Point(193, 110);
            this.btnLayerDown.Name = "btnLayerDown";
            this.btnLayerDown.Size = new System.Drawing.Size(25, 23);
            this.btnLayerDown.TabIndex = 45;
            this.btnLayerDown.Text = "↓";
            this.btnLayerDown.UseVisualStyleBackColor = true;
            this.btnLayerDown.Click += new System.EventHandler(this.btnLayerDown_Click);
            this.btnLayerDown.MouseHover += new System.EventHandler(this.btnLayerDown_MouseHover);
            // 
            // btnLayerUp
            // 
            this.btnLayerUp.Location = new System.Drawing.Point(164, 110);
            this.btnLayerUp.Name = "btnLayerUp";
            this.btnLayerUp.Size = new System.Drawing.Size(25, 23);
            this.btnLayerUp.TabIndex = 44;
            this.btnLayerUp.Text = "↑";
            this.btnLayerUp.UseVisualStyleBackColor = true;
            this.btnLayerUp.Click += new System.EventHandler(this.btnLayerUp_Click);
            this.btnLayerUp.MouseHover += new System.EventHandler(this.btnLayerUp_MouseHover);
            // 
            // btnFindAsset
            // 
            this.btnFindAsset.Location = new System.Drawing.Point(352, 109);
            this.btnFindAsset.Name = "btnFindAsset";
            this.btnFindAsset.Size = new System.Drawing.Size(43, 23);
            this.btnFindAsset.TabIndex = 43;
            this.btnFindAsset.Text = "Find";
            this.btnFindAsset.UseVisualStyleBackColor = true;
            this.btnFindAsset.Click += new System.EventHandler(this.btnFindAsset_Click);
            // 
            // btnFindLayer
            // 
            this.btnFindLayer.Location = new System.Drawing.Point(113, 109);
            this.btnFindLayer.Name = "btnFindLayer";
            this.btnFindLayer.Size = new System.Drawing.Size(43, 23);
            this.btnFindLayer.TabIndex = 42;
            this.btnFindLayer.Text = "Find";
            this.btnFindLayer.UseVisualStyleBackColor = true;
            this.btnFindLayer.Click += new System.EventHandler(this.btnFindLayer_Click);
            this.btnFindLayer.MouseHover += new System.EventHandler(this.btnFindLayer_MouseHover);
            // 
            // lblAssetSearch
            // 
            this.lblAssetSearch.AutoSize = true;
            this.lblAssetSearch.Location = new System.Drawing.Point(317, 95);
            this.lblAssetSearch.Name = "lblAssetSearch";
            this.lblAssetSearch.Size = new System.Drawing.Size(70, 13);
            this.lblAssetSearch.TabIndex = 41;
            this.lblAssetSearch.Text = "Asset Search";
            // 
            // txtAssetSearch
            // 
            this.txtAssetSearch.Location = new System.Drawing.Point(236, 110);
            this.txtAssetSearch.Name = "txtAssetSearch";
            this.txtAssetSearch.Size = new System.Drawing.Size(110, 20);
            this.txtAssetSearch.TabIndex = 40;
            // 
            // lblLayerSearch
            // 
            this.lblLayerSearch.AutoSize = true;
            this.lblLayerSearch.Location = new System.Drawing.Point(80, 95);
            this.lblLayerSearch.Name = "lblLayerSearch";
            this.lblLayerSearch.Size = new System.Drawing.Size(70, 13);
            this.lblLayerSearch.TabIndex = 39;
            this.lblLayerSearch.Text = "Layer Search";
            // 
            // txtLayerSearch
            // 
            this.txtLayerSearch.Location = new System.Drawing.Point(9, 110);
            this.txtLayerSearch.Name = "txtLayerSearch";
            this.txtLayerSearch.Size = new System.Drawing.Size(98, 20);
            this.txtLayerSearch.TabIndex = 38;
            this.txtLayerSearch.MouseHover += new System.EventHandler(this.txtLayerSearch_MouseHover);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(236, 57);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(235, 23);
            this.btnSendData.TabIndex = 37;
            this.btnSendData.Text = "Send Selected Asset Data to the Editor";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Little Endian Ho File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Size:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "File: None";
            // 
            // grupAssetProperties
            // 
            this.grupAssetProperties.Controls.Add(this.button3);
            this.grupAssetProperties.Controls.Add(this.saveDataEdited);
            this.grupAssetProperties.Controls.Add(this.button1);
            this.grupAssetProperties.Controls.Add(this.groupBox2);
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
            this.grupAssetProperties.Location = new System.Drawing.Point(504, 27);
            this.grupAssetProperties.Name = "grupAssetProperties";
            this.grupAssetProperties.Size = new System.Drawing.Size(637, 481);
            this.grupAssetProperties.TabIndex = 6;
            this.grupAssetProperties.TabStop = false;
            this.grupAssetProperties.Text = "Selected Asset Properties";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Clear all fields";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveDataEdited
            // 
            this.saveDataEdited.Location = new System.Drawing.Point(135, 233);
            this.saveDataEdited.Name = "saveDataEdited";
            this.saveDataEdited.Size = new System.Drawing.Size(182, 23);
            this.saveDataEdited.TabIndex = 35;
            this.saveDataEdited.Text = "Save All Data in Editor to Asset";
            this.saveDataEdited.UseVisualStyleBackColor = true;
            this.saveDataEdited.Click += new System.EventHandler(this.saveDataEdited_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 24);
            this.button1.TabIndex = 34;
            this.button1.Text = "Randomize Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCollWarning);
            this.groupBox2.Controls.Add(this.lblCollInfo);
            this.groupBox2.Controls.Add(this.txtCollFlag);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFlag);
            this.groupBox2.Controls.Add(this.grupAssetOtherTools);
            this.groupBox2.Location = new System.Drawing.Point(6, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 204);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Flag Editor";
            // 
            // lblCollWarning
            // 
            this.lblCollWarning.AutoSize = true;
            this.lblCollWarning.Location = new System.Drawing.Point(43, 136);
            this.lblCollWarning.Name = "lblCollWarning";
            this.lblCollWarning.Size = new System.Drawing.Size(198, 13);
            this.lblCollWarning.TabIndex = 11;
            this.lblCollWarning.Text = "Note: Only Works for SimpleObjects Too";
            // 
            // lblCollInfo
            // 
            this.lblCollInfo.AutoSize = true;
            this.lblCollInfo.Location = new System.Drawing.Point(33, 123);
            this.lblCollInfo.Name = "lblCollInfo";
            this.lblCollInfo.Size = new System.Drawing.Size(215, 13);
            this.lblCollInfo.TabIndex = 10;
            this.lblCollInfo.Text = "Enter Custom Collision Flag (Must Be 0 or 2!)";
            // 
            // txtCollFlag
            // 
            this.txtCollFlag.Location = new System.Drawing.Point(6, 152);
            this.txtCollFlag.Name = "txtCollFlag";
            this.txtCollFlag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCollFlag.Size = new System.Drawing.Size(265, 20);
            this.txtCollFlag.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Note: Only Works for SimpleObjects";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter Custom Visibility Flag (Must Be 1 or 0!)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(6, 69);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(266, 20);
            this.txtFlag.TabIndex = 6;
            this.txtFlag.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grupAssetOtherTools
            // 
            this.grupAssetOtherTools.Controls.Add(this.buttonExtractAll);
            this.grupAssetOtherTools.Controls.Add(this.buttonExtract);
            this.grupAssetOtherTools.Controls.Add(this.buttonReplace);
            this.grupAssetOtherTools.Location = new System.Drawing.Point(278, 11);
            this.grupAssetOtherTools.Name = "grupAssetOtherTools";
            this.grupAssetOtherTools.Size = new System.Drawing.Size(341, 187);
            this.grupAssetOtherTools.TabIndex = 5;
            this.grupAssetOtherTools.TabStop = false;
            this.grupAssetOtherTools.Text = "Other Asset Tools";
            // 
            // buttonExtractAll
            // 
            this.buttonExtractAll.Location = new System.Drawing.Point(6, 158);
            this.buttonExtractAll.Name = "buttonExtractAll";
            this.buttonExtractAll.Size = new System.Drawing.Size(329, 23);
            this.buttonExtractAll.TabIndex = 7;
            this.buttonExtractAll.Text = "Extract All Assets";
            this.buttonExtractAll.UseVisualStyleBackColor = true;
            this.buttonExtractAll.Click += new System.EventHandler(this.buttonExtractAll_Click_1);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(6, 24);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(329, 23);
            this.buttonExtract.TabIndex = 5;
            this.buttonExtract.Text = "Extract Selected Asset";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click_1);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(6, 53);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(329, 23);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Replace Selected Asset";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_1);
            // 
            // btnApplyScaleX
            // 
            this.btnApplyScaleX.Location = new System.Drawing.Point(505, 204);
            this.btnApplyScaleX.Name = "btnApplyScaleX";
            this.btnApplyScaleX.Size = new System.Drawing.Size(126, 43);
            this.btnApplyScaleX.TabIndex = 32;
            this.btnApplyScaleX.Text = "Apply Scale X To All Fields";
            this.btnApplyScaleX.UseVisualStyleBackColor = true;
            this.btnApplyScaleX.Click += new System.EventHandler(this.btnApplyScaleX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Scale";
            // 
            // lblScaleZ
            // 
            this.lblScaleZ.AutoSize = true;
            this.lblScaleZ.Location = new System.Drawing.Point(445, 181);
            this.lblScaleZ.Name = "lblScaleZ";
            this.lblScaleZ.Size = new System.Drawing.Size(44, 13);
            this.lblScaleZ.TabIndex = 30;
            this.lblScaleZ.Text = "Scale Z";
            // 
            // lblScaleY
            // 
            this.lblScaleY.AutoSize = true;
            this.lblScaleY.Location = new System.Drawing.Point(445, 135);
            this.lblScaleY.Name = "lblScaleY";
            this.lblScaleY.Size = new System.Drawing.Size(44, 13);
            this.lblScaleY.TabIndex = 29;
            this.lblScaleY.Text = "Scale Y";
            // 
            // lblScaleX
            // 
            this.lblScaleX.AutoSize = true;
            this.lblScaleX.Location = new System.Drawing.Point(445, 89);
            this.lblScaleX.Name = "lblScaleX";
            this.lblScaleX.Size = new System.Drawing.Size(44, 13);
            this.lblScaleX.TabIndex = 28;
            this.lblScaleX.Text = "Scale X";
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(505, 178);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(126, 20);
            this.txtScaleZ.TabIndex = 27;
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(505, 132);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(126, 20);
            this.txtScaleY.TabIndex = 26;
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(505, 86);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(126, 20);
            this.txtScaleX.TabIndex = 25;
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(324, 55);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(47, 13);
            this.lblRotation.TabIndex = 24;
            this.lblRotation.Text = "Rotation";
            // 
            // lblRotZ
            // 
            this.lblRotZ.AutoSize = true;
            this.lblRotZ.Location = new System.Drawing.Point(224, 181);
            this.lblRotZ.Name = "lblRotZ";
            this.lblRotZ.Size = new System.Drawing.Size(57, 13);
            this.lblRotZ.TabIndex = 23;
            this.lblRotZ.Text = "Rotation Z";
            // 
            // lblRotY
            // 
            this.lblRotY.AutoSize = true;
            this.lblRotY.Location = new System.Drawing.Point(224, 135);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(57, 13);
            this.lblRotY.TabIndex = 22;
            this.lblRotY.Text = "Rotation Y";
            // 
            // lblRotX
            // 
            this.lblRotX.AutoSize = true;
            this.lblRotX.Location = new System.Drawing.Point(224, 89);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(57, 13);
            this.lblRotX.TabIndex = 21;
            this.lblRotX.Text = "Rotation X";
            // 
            // txtRotZ
            // 
            this.txtRotZ.Location = new System.Drawing.Point(284, 178);
            this.txtRotZ.Name = "txtRotZ";
            this.txtRotZ.Size = new System.Drawing.Size(126, 20);
            this.txtRotZ.TabIndex = 20;
            // 
            // txtRotY
            // 
            this.txtRotY.Location = new System.Drawing.Point(284, 132);
            this.txtRotY.Name = "txtRotY";
            this.txtRotY.Size = new System.Drawing.Size(126, 20);
            this.txtRotY.TabIndex = 19;
            // 
            // txtRotX
            // 
            this.txtRotX.Location = new System.Drawing.Point(284, 86);
            this.txtRotX.Name = "txtRotX";
            this.txtRotX.Size = new System.Drawing.Size(126, 20);
            this.txtRotX.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Position, Rotation, and Scale Controls";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(110, 55);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position";
            // 
            // lblPosZ
            // 
            this.lblPosZ.AutoSize = true;
            this.lblPosZ.Location = new System.Drawing.Point(10, 181);
            this.lblPosZ.Name = "lblPosZ";
            this.lblPosZ.Size = new System.Drawing.Size(54, 13);
            this.lblPosZ.TabIndex = 15;
            this.lblPosZ.Text = "Position Z";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(10, 135);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(54, 13);
            this.lblPosY.TabIndex = 14;
            this.lblPosY.Text = "Position Y";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(10, 89);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(54, 13);
            this.lblPosX.TabIndex = 13;
            this.lblPosX.Text = "Position X";
            // 
            // txtPosZ
            // 
            this.txtPosZ.Location = new System.Drawing.Point(70, 178);
            this.txtPosZ.Name = "txtPosZ";
            this.txtPosZ.Size = new System.Drawing.Size(126, 20);
            this.txtPosZ.TabIndex = 12;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(70, 132);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(126, 20);
            this.txtPosY.TabIndex = 11;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(70, 86);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(126, 20);
            this.txtPosX.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 524);
            this.Controls.Add(this.grupAssetProperties);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "The GoodEditor 2";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupAssetProperties.ResumeLayout(false);
            this.grupAssetProperties.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupAssetOtherTools.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grupAssetProperties;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grupAssetOtherTools;
        private System.Windows.Forms.Button buttonExtractAll;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button buttonReplace;
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
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button saveDataEdited;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem saveHoParcelAsToolStripMenuItem;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.TextBox txtCollFlag;
        private System.Windows.Forms.Label lblCollWarning;
        private System.Windows.Forms.Label lblCollInfo;
        private System.Windows.Forms.ToolStripMenuItem disableToolTipsToolStripMenuItem;
        private System.Windows.Forms.ToolTip gHelpToolTips;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

