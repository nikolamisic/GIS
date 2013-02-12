namespace SharpMapSource
{
    partial class Main
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomFull = new System.Windows.Forms.Button();
            this.pbxMapa = new System.Windows.Forms.PictureBox();
            this.lbCoord = new System.Windows.Forms.Label();
            this.brnAddLayer = new System.Windows.Forms.Button();
            this.btnRemoveLayer = new System.Windows.Forms.Button();
            this.lbxLayers = new System.Windows.Forms.ListBox();
            this.btnEditLayer = new System.Windows.Forms.Button();
            this.btnAddRaster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(12, 12);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.Text = "Zoom in";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(93, 12);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomFull
            // 
            this.btnZoomFull.Location = new System.Drawing.Point(174, 12);
            this.btnZoomFull.Name = "btnZoomFull";
            this.btnZoomFull.Size = new System.Drawing.Size(75, 23);
            this.btnZoomFull.TabIndex = 2;
            this.btnZoomFull.Text = "Zoom to full";
            this.btnZoomFull.UseVisualStyleBackColor = true;
            this.btnZoomFull.Click += new System.EventHandler(this.btnZoomFull_Click);
            // 
            // pbxMapa
            // 
            this.pbxMapa.Location = new System.Drawing.Point(12, 41);
            this.pbxMapa.Name = "pbxMapa";
            this.pbxMapa.Size = new System.Drawing.Size(492, 288);
            this.pbxMapa.TabIndex = 3;
            this.pbxMapa.TabStop = false;
            this.pbxMapa.Click += new System.EventHandler(this.pbxMapa_Click);
            this.pbxMapa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxMapa_MouseMove);
            // 
            // lbCoord
            // 
            this.lbCoord.AutoSize = true;
            this.lbCoord.Location = new System.Drawing.Point(9, 332);
            this.lbCoord.Name = "lbCoord";
            this.lbCoord.Size = new System.Drawing.Size(66, 13);
            this.lbCoord.TabIndex = 4;
            this.lbCoord.Text = "Coordinates:";
            // 
            // brnAddLayer
            // 
            this.brnAddLayer.Location = new System.Drawing.Point(501, 12);
            this.brnAddLayer.Name = "brnAddLayer";
            this.brnAddLayer.Size = new System.Drawing.Size(75, 23);
            this.brnAddLayer.TabIndex = 5;
            this.brnAddLayer.Text = "Add Layer";
            this.brnAddLayer.UseVisualStyleBackColor = true;
            this.brnAddLayer.Click += new System.EventHandler(this.brnAddLayer_Click);
            // 
            // btnRemoveLayer
            // 
            this.btnRemoveLayer.Location = new System.Drawing.Point(663, 12);
            this.btnRemoveLayer.Name = "btnRemoveLayer";
            this.btnRemoveLayer.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveLayer.TabIndex = 6;
            this.btnRemoveLayer.Text = "Remove Layer";
            this.btnRemoveLayer.UseVisualStyleBackColor = true;
            this.btnRemoveLayer.Click += new System.EventHandler(this.btnRemoveLayer_Click);
            // 
            // lbxLayers
            // 
            this.lbxLayers.FormattingEnabled = true;
            this.lbxLayers.Location = new System.Drawing.Point(511, 41);
            this.lbxLayers.Name = "lbxLayers";
            this.lbxLayers.Size = new System.Drawing.Size(248, 277);
            this.lbxLayers.TabIndex = 7;
            // 
            // btnEditLayer
            // 
            this.btnEditLayer.Location = new System.Drawing.Point(684, 327);
            this.btnEditLayer.Name = "btnEditLayer";
            this.btnEditLayer.Size = new System.Drawing.Size(75, 23);
            this.btnEditLayer.TabIndex = 8;
            this.btnEditLayer.Text = "Edit Layer";
            this.btnEditLayer.UseVisualStyleBackColor = true;
            this.btnEditLayer.Click += new System.EventHandler(this.btnEditLayer_Click);
            // 
            // btnAddRaster
            // 
            this.btnAddRaster.Location = new System.Drawing.Point(582, 13);
            this.btnAddRaster.Name = "btnAddRaster";
            this.btnAddRaster.Size = new System.Drawing.Size(75, 23);
            this.btnAddRaster.TabIndex = 9;
            this.btnAddRaster.Text = "Add Raster";
            this.btnAddRaster.UseVisualStyleBackColor = true;
            this.btnAddRaster.Click += new System.EventHandler(this.btnAddRaster_Click);
=======
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menyAddVectorLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddRasterLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddLabelLayer = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.addPostGisVectorLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._dataGridLayers = new System.Windows.Forms.DataGridView();
            this.layerEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.layer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
=======
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sharpMapImage = new SharpMap.Forms.MapImage();
            this._dataGridLayers = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomToExtends = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditLayer = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteLayer = new System.Windows.Forms.ToolStripButton();
<<<<<<< HEAD
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.toolIdentifyFeature = new System.Windows.Forms.ToolStripButton();
            this.toolSelectByRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolSelectByPolygon = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblImageCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWorldCoordiantes = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLayerUp = new System.Windows.Forms.Button();
            this.btnLayerDown = new System.Windows.Forms.Button();
            this._sharpMapImage = new SharpMap.Forms.MapImage();
            this.spatialQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLayers)).BeginInit();
            this.mainToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sharpMapImage)).BeginInit();
=======
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblImageCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWorldCoordiantes = new System.Windows.Forms.ToolStripStatusLabel();
            this.layerEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.layer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sharpMapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLayers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.layersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
=======
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
<<<<<<< HEAD
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
=======
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // layersToolStripMenuItem
            // 
            this.layersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyAddVectorLayer,
            this.menuAddRasterLayer,
            this.menuAddLabelLayer,
<<<<<<< HEAD
            this.addPostGisVectorLayerToolStripMenuItem,
            this.toolStripSeparator2,
            this.removeLayerToolStripMenuItem,
            this.spatialQueryToolStripMenuItem});
=======
            this.toolStripSeparator2,
            this.removeLayerToolStripMenuItem});
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
            this.layersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.layersToolStripMenuItem.Text = "Layers";
            // 
            // menyAddVectorLayer
            // 
            this.menyAddVectorLayer.Name = "menyAddVectorLayer";
<<<<<<< HEAD
            this.menyAddVectorLayer.Size = new System.Drawing.Size(209, 22);
=======
            this.menyAddVectorLayer.Size = new System.Drawing.Size(164, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.menyAddVectorLayer.Text = "Add Vector Layer";
            this.menyAddVectorLayer.Click += new System.EventHandler(this.menyAddVectorLayer_Click);
            // 
            // menuAddRasterLayer
            // 
            this.menuAddRasterLayer.Name = "menuAddRasterLayer";
<<<<<<< HEAD
            this.menuAddRasterLayer.Size = new System.Drawing.Size(209, 22);
=======
            this.menuAddRasterLayer.Size = new System.Drawing.Size(164, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.menuAddRasterLayer.Text = "Add Raster Layer";
            this.menuAddRasterLayer.Click += new System.EventHandler(this.menuAddRasterLayer_Click);
            // 
            // menuAddLabelLayer
            // 
            this.menuAddLabelLayer.Name = "menuAddLabelLayer";
<<<<<<< HEAD
            this.menuAddLabelLayer.Size = new System.Drawing.Size(209, 22);
            this.menuAddLabelLayer.Text = "Add Label Layer";
            this.menuAddLabelLayer.Click += new System.EventHandler(this.menuAddLabelLayer_Click);
            // 
            // addPostGisVectorLayerToolStripMenuItem
            // 
            this.addPostGisVectorLayerToolStripMenuItem.Name = "addPostGisVectorLayerToolStripMenuItem";
            this.addPostGisVectorLayerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addPostGisVectorLayerToolStripMenuItem.Text = "Add Post Gis Vector Layer";
            this.addPostGisVectorLayerToolStripMenuItem.Click += new System.EventHandler(this.addPostGisVectorLayerToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // removeLayerToolStripMenuItem
            // 
            this.removeLayerToolStripMenuItem.Name = "removeLayerToolStripMenuItem";
            this.removeLayerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.removeLayerToolStripMenuItem.Text = "Remove Layer";
            // 
=======
            this.menuAddLabelLayer.Size = new System.Drawing.Size(164, 22);
            this.menuAddLabelLayer.Text = "Add Label Layer";
            this.menuAddLabelLayer.Click += new System.EventHandler(this.menuAddLabelLayer_Click);
            // 
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
<<<<<<< HEAD
=======
            // _sharpMapImage
            // 
            this._sharpMapImage.ActiveTool = SharpMap.Forms.MapImage.Tools.Pan;
            this._sharpMapImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sharpMapImage.BackColor = System.Drawing.Color.White;
            this._sharpMapImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this._sharpMapImage.FineZoomFactor = 10D;
            this._sharpMapImage.Location = new System.Drawing.Point(208, 56);
            this._sharpMapImage.Name = "_sharpMapImage";
            this._sharpMapImage.PanOnClick = false;
            this._sharpMapImage.QueryLayerIndex = 0;
            this._sharpMapImage.Size = new System.Drawing.Size(574, 292);
            this._sharpMapImage.TabIndex = 11;
            this._sharpMapImage.TabStop = false;
            this._sharpMapImage.WheelZoomMagnitude = 2D;
            this._sharpMapImage.ZoomOnDblClick = false;
            this._sharpMapImage.MouseMove += new SharpMap.Forms.MapImage.MouseEventHandler(this.sharpMapImage_MouseMove);
            this._sharpMapImage.MouseDown += new SharpMap.Forms.MapImage.MouseEventHandler(this._sharpMapImage_MouseDown);
            this._sharpMapImage.MouseUp += new SharpMap.Forms.MapImage.MouseEventHandler(this.sharpMapImage_MouseUp);
            // 
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            // _dataGridLayers
            // 
            this._dataGridLayers.AllowUserToAddRows = false;
            this._dataGridLayers.AllowUserToDeleteRows = false;
            this._dataGridLayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._dataGridLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridLayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layerEnabled,
            this.layer});
<<<<<<< HEAD
            this._dataGridLayers.Location = new System.Drawing.Point(12, 64);
            this._dataGridLayers.MultiSelect = false;
            this._dataGridLayers.Name = "_dataGridLayers";
            this._dataGridLayers.RowHeadersVisible = false;
            this._dataGridLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridLayers.Size = new System.Drawing.Size(190, 293);
            this._dataGridLayers.TabIndex = 12;
            // 
            // layerEnabled
            // 
            this.layerEnabled.HeaderText = "Enabled";
            this.layerEnabled.Name = "layerEnabled";
            this.layerEnabled.Width = 50;
            // 
            // layer
            // 
            this.layer.HeaderText = "Layer";
            this.layer.Name = "layer";
            this.layer.ReadOnly = true;
            this.layer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.layer.Width = 135;
            // 
            // mainToolBar
            // 
            this.mainToolBar.AutoSize = false;
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
=======
            this._dataGridLayers.Location = new System.Drawing.Point(12, 56);
            this._dataGridLayers.Name = "_dataGridLayers";
            this._dataGridLayers.RowHeadersVisible = false;
            this._dataGridLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridLayers.Size = new System.Drawing.Size(190, 292);
            this._dataGridLayers.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolZoomToExtends,
            this.toolStripSeparator1,
            this.toolEditLayer,
<<<<<<< HEAD
            this.toolDeleteLayer,
            this.toolStripSeparator3,
            this.toolPan,
            this.toolIdentifyFeature,
            this.toolSelectByRectangle,
            this.toolSelectByPolygon});
            this.mainToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainToolBar.Location = new System.Drawing.Point(0, 24);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(853, 32);
            this.mainToolBar.TabIndex = 13;
            this.mainToolBar.Text = "Tools";
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.BackColor = System.Drawing.SystemColors.Control;
=======
            this.toolDeleteLayer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolZoomIn
            // 
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomIn.Image")));
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
<<<<<<< HEAD
            this.toolZoomIn.Size = new System.Drawing.Size(36, 29);
=======
            this.toolZoomIn.Size = new System.Drawing.Size(23, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolZoomIn.Text = "Zoom In";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomOut.Image")));
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
<<<<<<< HEAD
            this.toolZoomOut.Size = new System.Drawing.Size(36, 29);
=======
            this.toolZoomOut.Size = new System.Drawing.Size(23, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolZoomOut.Text = "Zoom Out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolZoomToExtends
            // 
<<<<<<< HEAD
            this.toolZoomToExtends.AutoSize = false;
            this.toolZoomToExtends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolZoomToExtends.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToExtends.Image = global::SharpMapSource.Properties.Resources._1359423542_xmag;
            this.toolZoomToExtends.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToExtends.Name = "toolZoomToExtends";
            this.toolZoomToExtends.Size = new System.Drawing.Size(32, 32);
=======
            this.toolZoomToExtends.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToExtends.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomToExtends.Image")));
            this.toolZoomToExtends.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToExtends.Name = "toolZoomToExtends";
            this.toolZoomToExtends.Size = new System.Drawing.Size(23, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolZoomToExtends.Text = "Zoom To Extends";
            this.toolZoomToExtends.Click += new System.EventHandler(this.toolZoomToExtends_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
<<<<<<< HEAD
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
=======
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            // 
            // toolEditLayer
            // 
            this.toolEditLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditLayer.Image = ((System.Drawing.Image)(resources.GetObject("toolEditLayer.Image")));
            this.toolEditLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditLayer.Name = "toolEditLayer";
<<<<<<< HEAD
            this.toolEditLayer.Size = new System.Drawing.Size(36, 29);
=======
            this.toolEditLayer.Size = new System.Drawing.Size(23, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.toolEditLayer.Text = "Edit Layer";
            this.toolEditLayer.Click += new System.EventHandler(this.toolEditLayer_Click);
            // 
            // toolDeleteLayer
            // 
            this.toolDeleteLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
<<<<<<< HEAD
            this.toolDeleteLayer.Image = global::SharpMapSource.Properties.Resources.remove;
            this.toolDeleteLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteLayer.Name = "toolDeleteLayer";
            this.toolDeleteLayer.Size = new System.Drawing.Size(36, 29);
            this.toolDeleteLayer.Text = "Remove Layer";
            this.toolDeleteLayer.Click += new System.EventHandler(this.toolDeleteLayer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = ((System.Drawing.Image)(resources.GetObject("toolPan.Image")));
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(36, 29);
            this.toolPan.Text = "toolStripButton1";
            this.toolPan.ToolTipText = "Pan";
            this.toolPan.Click += new System.EventHandler(this.toolPan_Click);
            // 
            // toolIdentifyFeature
            // 
            this.toolIdentifyFeature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolIdentifyFeature.Image = ((System.Drawing.Image)(resources.GetObject("toolIdentifyFeature.Image")));
            this.toolIdentifyFeature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolIdentifyFeature.Name = "toolIdentifyFeature";
            this.toolIdentifyFeature.Size = new System.Drawing.Size(36, 29);
            this.toolIdentifyFeature.Text = "Identify Feature";
            this.toolIdentifyFeature.Click += new System.EventHandler(this.toolIdentifyFeature_Click);
            // 
            // toolSelectByRectangle
            // 
            this.toolSelectByRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelectByRectangle.Image = global::SharpMapSource.Properties.Resources._1359603429_rounded_rectangle;
            this.toolSelectByRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelectByRectangle.Name = "toolSelectByRectangle";
            this.toolSelectByRectangle.Size = new System.Drawing.Size(36, 29);
            this.toolSelectByRectangle.Text = "Select By Rectangle";
            this.toolSelectByRectangle.Click += new System.EventHandler(this.toolSelectByRectangle_Click);
            // 
            // toolSelectByPolygon
            // 
            this.toolSelectByPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelectByPolygon.Image = global::SharpMapSource.Properties.Resources._1359603397_draw_polygon;
            this.toolSelectByPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelectByPolygon.Name = "toolSelectByPolygon";
            this.toolSelectByPolygon.Size = new System.Drawing.Size(36, 29);
            this.toolSelectByPolygon.Text = "Select By Polygon";
            this.toolSelectByPolygon.Click += new System.EventHandler(this.toolSelectByPolygon_Click);
            // 
=======
            this.toolDeleteLayer.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteLayer.Image")));
            this.toolDeleteLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteLayer.Name = "toolDeleteLayer";
            this.toolDeleteLayer.Size = new System.Drawing.Size(23, 22);
            this.toolDeleteLayer.Text = "Remove Layer";
            this.toolDeleteLayer.Click += new System.EventHandler(this.toolDeleteLayer_Click);
            // 
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImageCoordinates,
            this.lblWorldCoordiantes});
<<<<<<< HEAD
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(853, 22);
=======
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblImageCoordinates
            // 
            this.lblImageCoordinates.Name = "lblImageCoordinates";
            this.lblImageCoordinates.Size = new System.Drawing.Size(113, 17);
            this.lblImageCoordinates.Text = "Image Coordinates: ";
            // 
            // lblWorldCoordiantes
            // 
            this.lblWorldCoordiantes.Name = "lblWorldCoordiantes";
            this.lblWorldCoordiantes.Size = new System.Drawing.Size(104, 17);
            this.lblWorldCoordiantes.Text = "worldCoordiantes:";
            // 
<<<<<<< HEAD
            // btnLayerUp
            // 
            this.btnLayerUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLayerUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayerUp.BackgroundImage")));
            this.btnLayerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLayerUp.Location = new System.Drawing.Point(66, 363);
            this.btnLayerUp.Name = "btnLayerUp";
            this.btnLayerUp.Size = new System.Drawing.Size(48, 48);
            this.btnLayerUp.TabIndex = 17;
            this.btnLayerUp.UseVisualStyleBackColor = true;
            this.btnLayerUp.Click += new System.EventHandler(this.btnLayerUp_Click);
            // 
            // btnLayerDown
            // 
            this.btnLayerDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLayerDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLayerDown.BackgroundImage")));
            this.btnLayerDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLayerDown.Location = new System.Drawing.Point(12, 362);
            this.btnLayerDown.Name = "btnLayerDown";
            this.btnLayerDown.Size = new System.Drawing.Size(48, 48);
            this.btnLayerDown.TabIndex = 16;
            this.btnLayerDown.UseVisualStyleBackColor = true;
            this.btnLayerDown.Click += new System.EventHandler(this.btnLayerDown_Click);
            // 
            // _sharpMapImage
            // 
            this._sharpMapImage.ActiveTool = SharpMap.Forms.MapImage.Tools.Pan;
            this._sharpMapImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sharpMapImage.BackColor = System.Drawing.Color.White;
            this._sharpMapImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this._sharpMapImage.FineZoomFactor = 10D;
            this._sharpMapImage.Location = new System.Drawing.Point(208, 64);
            this._sharpMapImage.Name = "_sharpMapImage";
            this._sharpMapImage.PanOnClick = false;
            this._sharpMapImage.QueryLayerIndex = 0;
            this._sharpMapImage.Size = new System.Drawing.Size(633, 347);
            this._sharpMapImage.TabIndex = 11;
            this._sharpMapImage.TabStop = false;
            this._sharpMapImage.WheelZoomMagnitude = 2D;
            this._sharpMapImage.ZoomOnDblClick = false;
            this._sharpMapImage.MouseMove += new SharpMap.Forms.MapImage.MouseEventHandler(this.sharpMapImage_MouseMove);
            this._sharpMapImage.MouseDown += new SharpMap.Forms.MapImage.MouseEventHandler(this._sharpMapImage_MouseDown);
            this._sharpMapImage.MouseUp += new SharpMap.Forms.MapImage.MouseEventHandler(this.sharpMapImage_MouseUp);
            // 
            // spatialQueryToolStripMenuItem
            // 
            this.spatialQueryToolStripMenuItem.Name = "spatialQueryToolStripMenuItem";
            this.spatialQueryToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.spatialQueryToolStripMenuItem.Text = "Spatial Query";
            this.spatialQueryToolStripMenuItem.Click += new System.EventHandler(this.spatialQueryToolStripMenuItem_Click);
=======
            // layerEnabled
            // 
            this.layerEnabled.HeaderText = "Enabled";
            this.layerEnabled.Name = "layerEnabled";
            this.layerEnabled.Width = 50;
            // 
            // layer
            // 
            this.layer.HeaderText = "Layer";
            this.layer.Name = "layer";
            this.layer.ReadOnly = true;
            this.layer.Width = 135;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // removeLayerToolStripMenuItem
            // 
            this.removeLayerToolStripMenuItem.Name = "removeLayerToolStripMenuItem";
            this.removeLayerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeLayerToolStripMenuItem.Text = "Remove Layer";
>>>>>>> Inicijalna verzija
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(853, 436);
            this.Controls.Add(this.btnLayerUp);
            this.Controls.Add(this.btnLayerDown);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this._dataGridLayers);
            this.Controls.Add(this._sharpMapImage);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
=======
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(771, 354);
            this.Controls.Add(this.btnAddRaster);
            this.Controls.Add(this.btnEditLayer);
            this.Controls.Add(this.lbxLayers);
            this.Controls.Add(this.btnRemoveLayer);
            this.Controls.Add(this.brnAddLayer);
            this.Controls.Add(this.lbCoord);
            this.Controls.Add(this.pbxMapa);
            this.Controls.Add(this.btnZoomFull);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).EndInit();
=======
            this.ClientSize = new System.Drawing.Size(794, 373);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._dataGridLayers);
            this.Controls.Add(this._sharpMapImage);
            this.Controls.Add(this.menuStrip1);
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLayers)).EndInit();
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sharpMapImage)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this._sharpMapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLayers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
>>>>>>> Inicijalna verzija
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
=======
<<<<<<< HEAD
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomFull;
        private System.Windows.Forms.PictureBox pbxMapa;
        private System.Windows.Forms.Label lbCoord;
        private System.Windows.Forms.Button brnAddLayer;
        private System.Windows.Forms.Button btnRemoveLayer;
        private System.Windows.Forms.ListBox lbxLayers;
        private System.Windows.Forms.Button btnEditLayer;
        private System.Windows.Forms.Button btnAddRaster;
=======
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menyAddVectorLayer;
        private System.Windows.Forms.ToolStripMenuItem menuAddRasterLayer;
        private System.Windows.Forms.ToolStripMenuItem menuAddLabelLayer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private SharpMap.Forms.MapImage _sharpMapImage;
        private System.Windows.Forms.DataGridView _dataGridLayers;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStrip mainToolBar;
=======
        private System.Windows.Forms.ToolStrip toolStrip1;
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomToExtends;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolEditLayer;
        private System.Windows.Forms.ToolStripButton toolDeleteLayer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblImageCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel lblWorldCoordiantes;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removeLayerToolStripMenuItem;
        private System.Windows.Forms.Button btnLayerDown;
        private System.Windows.Forms.Button btnLayerUp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolPan;
        private System.Windows.Forms.ToolStripButton toolIdentifyFeature;
        private System.Windows.Forms.DataGridViewCheckBoxColumn layerEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer;
        private System.Windows.Forms.ToolStripMenuItem addPostGisVectorLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolSelectByRectangle;
        private System.Windows.Forms.ToolStripButton toolSelectByPolygon;
        private System.Windows.Forms.ToolStripMenuItem spatialQueryToolStripMenuItem;
=======
        private System.Windows.Forms.DataGridViewCheckBoxColumn layerEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removeLayerToolStripMenuItem;
>>>>>>> Inicijalna verzija
>>>>>>> bc7451994f88444e30ac2ae7a99a55828e008677
    }
}

