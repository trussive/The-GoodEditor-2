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
            this.openTheSaveFileEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheGoodEditor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolTipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.listBoxAssets = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblFineScrollLayers = new System.Windows.Forms.Label();
            this.lblFineScroll = new System.Windows.Forms.Label();
            this.btnAssetDown = new System.Windows.Forms.Button();
            this.btnAssetUp = new System.Windows.Forms.Button();
            this.btnLayerDown = new System.Windows.Forms.Button();
            this.btnLayerUp = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.gHelpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.grupAssetOtherTools = new System.Windows.Forms.GroupBox();
            this.buttonExtractAll = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.btnOpenByteViewer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpByteViewerButtonContainer = new System.Windows.Forms.GroupBox();
            this.grpTextureControls = new System.Windows.Forms.GroupBox();
            this.grpPreviewContainer = new System.Windows.Forms.GroupBox();
            this.texturePreviewBox = new System.Windows.Forms.PictureBox();
            this.btnOpenTextureViewer = new System.Windows.Forms.Button();
            this.renderButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grupAssetOtherTools.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpByteViewerButtonContainer.SuspendLayout();
            this.grpTextureControls.SuspendLayout();
            this.grpPreviewContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texturePreviewBox)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
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
            this.exportAssetsListToTextFileToolStripMenuItem,
            this.openTheSaveFileEditorToolStripMenuItem});
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
            // openTheSaveFileEditorToolStripMenuItem
            // 
            this.openTheSaveFileEditorToolStripMenuItem.Name = "openTheSaveFileEditorToolStripMenuItem";
            this.openTheSaveFileEditorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.openTheSaveFileEditorToolStripMenuItem.Text = "Open the Save File Editor...";
            this.openTheSaveFileEditorToolStripMenuItem.Visible = false;
            this.openTheSaveFileEditorToolStripMenuItem.Click += new System.EventHandler(this.openTheSaveFileEditorToolStripMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblFineScrollLayers);
            this.groupBox1.Controls.Add(this.lblFineScroll);
            this.groupBox1.Controls.Add(this.btnAssetDown);
            this.groupBox1.Controls.Add(this.btnAssetUp);
            this.groupBox1.Controls.Add(this.btnLayerDown);
            this.groupBox1.Controls.Add(this.btnLayerUp);
            this.groupBox1.Controls.Add(this.listBoxLayers);
            this.groupBox1.Controls.Add(this.listBoxAssets);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 481);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers and Assets";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(4, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(322, 65);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Open Ho Parcel Details and Asset Size Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Size:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "File: None";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(331, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(150, 67);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc. Options";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 17);
            this.checkBox2.TabIndex = 48;
            this.checkBox2.Text = "Enable Discord RPC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Little Endian Ho File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // lblFineScrollLayers
            // 
            this.lblFineScrollLayers.AutoSize = true;
            this.lblFineScrollLayers.Location = new System.Drawing.Point(48, 93);
            this.lblFineScrollLayers.Name = "lblFineScrollLayers";
            this.lblFineScrollLayers.Size = new System.Drawing.Size(133, 13);
            this.lblFineScrollLayers.TabIndex = 50;
            this.lblFineScrollLayers.Text = "Fine Scroll Through Layers";
            // 
            // lblFineScroll
            // 
            this.lblFineScroll.AutoSize = true;
            this.lblFineScroll.Location = new System.Drawing.Point(292, 93);
            this.lblFineScroll.Name = "lblFineScroll";
            this.lblFineScroll.Size = new System.Drawing.Size(133, 13);
            this.lblFineScroll.TabIndex = 49;
            this.lblFineScroll.Text = "Fine Scroll Through Assets";
            // 
            // btnAssetDown
            // 
            this.btnAssetDown.Location = new System.Drawing.Point(362, 110);
            this.btnAssetDown.Name = "btnAssetDown";
            this.btnAssetDown.Size = new System.Drawing.Size(108, 23);
            this.btnAssetDown.TabIndex = 47;
            this.btnAssetDown.Text = "↓";
            this.btnAssetDown.UseVisualStyleBackColor = true;
            this.btnAssetDown.Click += new System.EventHandler(this.btnAssetDown_Click);
            // 
            // btnAssetUp
            // 
            this.btnAssetUp.Location = new System.Drawing.Point(236, 110);
            this.btnAssetUp.Name = "btnAssetUp";
            this.btnAssetUp.Size = new System.Drawing.Size(109, 23);
            this.btnAssetUp.TabIndex = 46;
            this.btnAssetUp.Text = "↑";
            this.btnAssetUp.UseVisualStyleBackColor = true;
            this.btnAssetUp.Click += new System.EventHandler(this.btnAssetUp_Click);
            // 
            // btnLayerDown
            // 
            this.btnLayerDown.Location = new System.Drawing.Point(123, 110);
            this.btnLayerDown.Name = "btnLayerDown";
            this.btnLayerDown.Size = new System.Drawing.Size(97, 23);
            this.btnLayerDown.TabIndex = 45;
            this.btnLayerDown.Text = "↓";
            this.btnLayerDown.UseVisualStyleBackColor = true;
            this.btnLayerDown.Click += new System.EventHandler(this.btnLayerDown_Click);
            this.btnLayerDown.MouseHover += new System.EventHandler(this.btnLayerDown_MouseHover);
            // 
            // btnLayerUp
            // 
            this.btnLayerUp.Location = new System.Drawing.Point(8, 110);
            this.btnLayerUp.Name = "btnLayerUp";
            this.btnLayerUp.Size = new System.Drawing.Size(98, 23);
            this.btnLayerUp.TabIndex = 44;
            this.btnLayerUp.Text = "↑";
            this.btnLayerUp.UseVisualStyleBackColor = true;
            this.btnLayerUp.Click += new System.EventHandler(this.btnLayerUp_Click);
            this.btnLayerUp.MouseHover += new System.EventHandler(this.btnLayerUp_MouseHover);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 140);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(329, 23);
            this.btnSendData.TabIndex = 37;
            this.btnSendData.Text = "Edit Selected Asset";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.button2_Click);
            // 
            // grupAssetOtherTools
            // 
            this.grupAssetOtherTools.Controls.Add(this.renderButton);
            this.grupAssetOtherTools.Controls.Add(this.buttonExtractAll);
            this.grupAssetOtherTools.Controls.Add(this.buttonExtract);
            this.grupAssetOtherTools.Controls.Add(this.buttonReplace);
            this.grupAssetOtherTools.Controls.Add(this.btnSendData);
            this.grupAssetOtherTools.Location = new System.Drawing.Point(504, 26);
            this.grupAssetOtherTools.Name = "grupAssetOtherTools";
            this.grupAssetOtherTools.Size = new System.Drawing.Size(341, 174);
            this.grupAssetOtherTools.TabIndex = 6;
            this.grupAssetOtherTools.TabStop = false;
            this.grupAssetOtherTools.Text = "Basic Asset Tools";
            this.grupAssetOtherTools.Enter += new System.EventHandler(this.grupAssetOtherTools_Enter);
            // 
            // buttonExtractAll
            // 
            this.buttonExtractAll.Location = new System.Drawing.Point(6, 82);
            this.buttonExtractAll.Name = "buttonExtractAll";
            this.buttonExtractAll.Size = new System.Drawing.Size(329, 23);
            this.buttonExtractAll.TabIndex = 7;
            this.buttonExtractAll.Text = "Extract All Assets";
            this.buttonExtractAll.UseVisualStyleBackColor = true;
            this.buttonExtractAll.Click += new System.EventHandler(this.buttonExtractAll_Click_2);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(6, 24);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(329, 23);
            this.buttonExtract.TabIndex = 5;
            this.buttonExtract.Text = "Extract Selected Asset";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click_2);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(6, 53);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(329, 23);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Replace Selected Asset";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click_2);
            // 
            // btnOpenByteViewer
            // 
            this.btnOpenByteViewer.Location = new System.Drawing.Point(6, 17);
            this.btnOpenByteViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenByteViewer.Name = "btnOpenByteViewer";
            this.btnOpenByteViewer.Size = new System.Drawing.Size(330, 32);
            this.btnOpenByteViewer.TabIndex = 38;
            this.btnOpenByteViewer.Text = "Open the Byte Viewer";
            this.btnOpenByteViewer.UseVisualStyleBackColor = true;
            this.btnOpenByteViewer.Click += new System.EventHandler(this.btnOpenByteViewer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "What\'s this asset type?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(504, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(341, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Help";
            // 
            // grpByteViewerButtonContainer
            // 
            this.grpByteViewerButtonContainer.Controls.Add(this.btnOpenByteViewer);
            this.grpByteViewerButtonContainer.Location = new System.Drawing.Point(504, 283);
            this.grpByteViewerButtonContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpByteViewerButtonContainer.Name = "grpByteViewerButtonContainer";
            this.grpByteViewerButtonContainer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpByteViewerButtonContainer.Size = new System.Drawing.Size(341, 58);
            this.grpByteViewerButtonContainer.TabIndex = 8;
            this.grpByteViewerButtonContainer.TabStop = false;
            this.grpByteViewerButtonContainer.Text = "Byte Viewer Controls";
            // 
            // grpTextureControls
            // 
            this.grpTextureControls.Controls.Add(this.grpPreviewContainer);
            this.grpTextureControls.Controls.Add(this.btnOpenTextureViewer);
            this.grpTextureControls.Location = new System.Drawing.Point(504, 345);
            this.grpTextureControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTextureControls.Name = "grpTextureControls";
            this.grpTextureControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTextureControls.Size = new System.Drawing.Size(341, 162);
            this.grpTextureControls.TabIndex = 9;
            this.grpTextureControls.TabStop = false;
            this.grpTextureControls.Text = "Texture Viewer Controls";
            // 
            // grpPreviewContainer
            // 
            this.grpPreviewContainer.Controls.Add(this.texturePreviewBox);
            this.grpPreviewContainer.Location = new System.Drawing.Point(6, 17);
            this.grpPreviewContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPreviewContainer.Name = "grpPreviewContainer";
            this.grpPreviewContainer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPreviewContainer.Size = new System.Drawing.Size(150, 141);
            this.grpPreviewContainer.TabIndex = 40;
            this.grpPreviewContainer.TabStop = false;
            this.grpPreviewContainer.Text = "Preview Selected Texture";
            // 
            // texturePreviewBox
            // 
            this.texturePreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texturePreviewBox.Location = new System.Drawing.Point(2, 15);
            this.texturePreviewBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.texturePreviewBox.Name = "texturePreviewBox";
            this.texturePreviewBox.Size = new System.Drawing.Size(146, 124);
            this.texturePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.texturePreviewBox.TabIndex = 0;
            this.texturePreviewBox.TabStop = false;
            // 
            // btnOpenTextureViewer
            // 
            this.btnOpenTextureViewer.Location = new System.Drawing.Point(160, 126);
            this.btnOpenTextureViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenTextureViewer.Name = "btnOpenTextureViewer";
            this.btnOpenTextureViewer.Size = new System.Drawing.Size(174, 32);
            this.btnOpenTextureViewer.TabIndex = 39;
            this.btnOpenTextureViewer.Text = "Open Previewed Texture";
            this.btnOpenTextureViewer.UseVisualStyleBackColor = true;
            this.btnOpenTextureViewer.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(6, 111);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(329, 23);
            this.renderButton.TabIndex = 38;
            this.renderButton.Text = "Open Renderer";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 524);
            this.Controls.Add(this.grpTextureControls);
            this.Controls.Add(this.grpByteViewerButtonContainer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupAssetOtherTools);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grupAssetOtherTools.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpByteViewerButtonContainer.ResumeLayout(false);
            this.grpTextureControls.ResumeLayout(false);
            this.grpPreviewContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.texturePreviewBox)).EndInit();
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
        private System.Windows.Forms.Label lblFineScrollLayers;
        private System.Windows.Forms.Label lblFineScroll;
        private System.Windows.Forms.Button btnOpenByteViewer;
        private System.Windows.Forms.GroupBox grpByteViewerButtonContainer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem openTheSaveFileEditorToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTextureControls;
        private System.Windows.Forms.Button btnOpenTextureViewer;
        private System.Windows.Forms.GroupBox grpPreviewContainer;
        private System.Windows.Forms.PictureBox texturePreviewBox;
        private System.Windows.Forms.Button renderButton;
    }
}

