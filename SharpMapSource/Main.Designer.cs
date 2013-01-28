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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menyAddVectorLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddRasterLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddLabelLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sharpMapImage = new SharpMap.Forms.MapImage();
            this._dataGridLayers = new System.Windows.Forms.DataGridView();
            this.layerEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.layer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomToExtends = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolEditLayer = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteLayer = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblImageCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWorldCoordiantes = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sharpMapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLayers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // layersToolStripMenuItem
            // 
            this.layersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyAddVectorLayer,
            this.menuAddRasterLayer,
            this.menuAddLabelLayer,
            this.toolStripSeparator2,
            this.removeLayerToolStripMenuItem});
            this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
            this.layersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.layersToolStripMenuItem.Text = "Layers";
            // 
            // menyAddVectorLayer
            // 
            this.menyAddVectorLayer.Name = "menyAddVectorLayer";
            this.menyAddVectorLayer.Size = new System.Drawing.Size(164, 22);
            this.menyAddVectorLayer.Text = "Add Vector Layer";
            this.menyAddVectorLayer.Click += new System.EventHandler(this.menyAddVectorLayer_Click);
            // 
            // menuAddRasterLayer
            // 
            this.menuAddRasterLayer.Name = "menuAddRasterLayer";
            this.menuAddRasterLayer.Size = new System.Drawing.Size(164, 22);
            this.menuAddRasterLayer.Text = "Add Raster Layer";
            this.menuAddRasterLayer.Click += new System.EventHandler(this.menuAddRasterLayer_Click);
            // 
            // menuAddLabelLayer
            // 
            this.menuAddLabelLayer.Name = "menuAddLabelLayer";
            this.menuAddLabelLayer.Size = new System.Drawing.Size(164, 22);
            this.menuAddLabelLayer.Text = "Add Label Layer";
            this.menuAddLabelLayer.Click += new System.EventHandler(this.menuAddLabelLayer_Click);
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
            // 
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
            this._dataGridLayers.Location = new System.Drawing.Point(12, 56);
            this._dataGridLayers.Name = "_dataGridLayers";
            this._dataGridLayers.RowHeadersVisible = false;
            this._dataGridLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridLayers.Size = new System.Drawing.Size(190, 292);
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
            this.layer.Width = 135;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolZoomToExtends,
            this.toolStripSeparator1,
            this.toolEditLayer,
            this.toolDeleteLayer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(794, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomIn.Image")));
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolZoomIn.Text = "Zoom In";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomOut.Image")));
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolZoomOut.Text = "Zoom Out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolZoomToExtends
            // 
            this.toolZoomToExtends.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToExtends.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomToExtends.Image")));
            this.toolZoomToExtends.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToExtends.Name = "toolZoomToExtends";
            this.toolZoomToExtends.Size = new System.Drawing.Size(23, 22);
            this.toolZoomToExtends.Text = "Zoom To Extends";
            this.toolZoomToExtends.Click += new System.EventHandler(this.toolZoomToExtends_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolEditLayer
            // 
            this.toolEditLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditLayer.Image = ((System.Drawing.Image)(resources.GetObject("toolEditLayer.Image")));
            this.toolEditLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditLayer.Name = "toolEditLayer";
            this.toolEditLayer.Size = new System.Drawing.Size(23, 22);
            this.toolEditLayer.Text = "Edit Layer";
            this.toolEditLayer.Click += new System.EventHandler(this.toolEditLayer_Click);
            // 
            // toolDeleteLayer
            // 
            this.toolDeleteLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteLayer.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteLayer.Image")));
            this.toolDeleteLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteLayer.Name = "toolDeleteLayer";
            this.toolDeleteLayer.Size = new System.Drawing.Size(23, 22);
            this.toolDeleteLayer.Text = "Remove Layer";
            this.toolDeleteLayer.Click += new System.EventHandler(this.toolDeleteLayer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImageCoordinates,
            this.lblWorldCoordiantes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 373);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._dataGridLayers);
            this.Controls.Add(this._sharpMapImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._sharpMapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridLayers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomToExtends;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolEditLayer;
        private System.Windows.Forms.ToolStripButton toolDeleteLayer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblImageCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel lblWorldCoordiantes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn layerEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem removeLayerToolStripMenuItem;
    }
}

