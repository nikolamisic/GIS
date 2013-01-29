using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSGeo.GDAL;
using SharpMap.Layers;
using SharpMapSource.Layers;
using SharpMapSource.Interface;

namespace SharpMapSource
{
    public partial class Main : Form
    {
        private SharpMap.Map _sharpMap;
        private LayerManager _manager;

        private const float ZOOM_FACTOR = 0.3f;
        //private String DATA_NAME = "World Countries";
        //private String DATA_PATH = "Data//world_adm0.shp";
        //pan image
        private Point _panCoordinate;


        public Main()
        {
            InitializeComponent();
            _sharpMap = new SharpMap.Map(this._sharpMapImage.Size);
            _sharpMap.BackColor = Color.White;
            this._manager = new LayerManager(this._sharpMap);

            RefreshMap();
        }

        public void RefreshMap()
        {
            if (this._sharpMap.Size.Width == 0 || this._sharpMap.Size.Height == 0)
            {
                this._sharpMapImage.Image = null;
            }
            else
            {
                if (_sharpMap.Layers.Count != 0)
                    this._sharpMapImage.Image = _sharpMap.GetMap();
                else
                    this._sharpMapImage.Image = null;
            }
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            if (this._dataGridLayers.SelectedRows.Count > 0)
            {
                if (this._dataGridLayers.SelectedRows[0].Index >= 0)
                {
                    _sharpMap.Layers.RemoveAt(this._dataGridLayers.SelectedRows[0].Index);
                    this._dataGridLayers.Rows.RemoveAt(this._dataGridLayers.SelectedRows[0].Index);
                    if (_sharpMap.Layers.Count != 0)
                    {
                        _sharpMap.ZoomToExtents();
                    }
                    RefreshMap();
                }
            }
        }

        private void menyAddVectorLayer_Click(object sender, EventArgs e)
        {
            String path;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "shp Files (.shp)|*.shp|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                path = dialog.FileName;
                if (File.Exists(path))
                {
                    string layerName = Path.GetFileNameWithoutExtension(path);
                    this._manager.AddVectorLayer(layerName, new SharpMap.Data.Providers.ShapeFile(path));
                    this._dataGridLayers.Rows.Add( true,layerName);
                }
            }
            try
            {
                _sharpMap.ZoomToExtents();
                RefreshMap();
            }
            catch (Exception)
            {
                //MessageBox.Show("Layer already inserted");
            }
        }

        private void menuAddRasterLayer_Click(object sender, EventArgs e)
        {
            SharpMap.Layers.ILayer layer = _sharpMap.Layers["RasterLayer"];
            String path;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                path = dialog.FileName;
                if (File.Exists(path))
                {
                    this._manager.AddRasterLayer(path);
                    this._dataGridLayers.Rows.Add( true, dialog.SafeFileName);
                    RefreshMap();
                }
            }
        }

        private void menuAddLabelLayer_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geografski informacioni sistemi i tehnologije");
        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            _sharpMap.Zoom -= _sharpMap.Zoom * ZOOM_FACTOR;
            RefreshMap();
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            _sharpMap.Zoom += _sharpMap.Zoom * ZOOM_FACTOR;
            RefreshMap();
        }

        private void toolZoomToExtends_Click(object sender, EventArgs e)
        {
            if (_sharpMap.Layers.Count != 0)
                _sharpMap.ZoomToExtents();
            RefreshMap();
        }

        private void toolEditLayer_Click(object sender, EventArgs e)
        {

        }

        private void toolDeleteLayer_Click(object sender, EventArgs e)
        {
            if (this._dataGridLayers.SelectedRows.Count > 0)
            {
                if (this._dataGridLayers.SelectedRows[0].Index >= 0)
                {
                    _sharpMap.Layers.RemoveAt(this._dataGridLayers.SelectedRows[0].Index);
                    this._dataGridLayers.Rows.RemoveAt(this._dataGridLayers.SelectedRows[0].Index);
                    if (_sharpMap.Layers.Count != 0)
                    {
                        _sharpMap.ZoomToExtents();
                    }
                    RefreshMap();
                }
            }
        }

        private void sharpMapImage_MouseMove(SharpMap.Geometries.Point WorldPos, MouseEventArgs ImagePos)
        {
            this.lblWorldCoordiantes.Text = "World Coordinates: " + WorldPos.X + ":" + WorldPos.Y;
            this.lblImageCoordinates.Text = "Image Coordinates: " + ImagePos.X + ":" + ImagePos.Y;
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            this._sharpMap.Size = this._sharpMapImage.Size;
            this.RefreshMap();
        }

        private void sharpMapImage_MouseUp(SharpMap.Geometries.Point WorldPos, MouseEventArgs ImagePos)
        {
            if (ImagePos.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mapCenter = new Point(this._sharpMapImage.Size.Width / 2 - ImagePos.Location.X + this._panCoordinate.X
                    , this._sharpMapImage.Size.Height / 2 - ImagePos.Location.Y + this._panCoordinate.Y);
                this._sharpMap.Center = this._sharpMap.ImageToWorld(mapCenter);
                this.RefreshMap();
            }
        }

        private void _sharpMapImage_MouseDown(SharpMap.Geometries.Point WorldPos, MouseEventArgs ImagePos)
        {
            if(ImagePos.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this._panCoordinate = ImagePos.Location;
            }
        }

        public void SortLayers()
        {
            LayerCollection collection = new LayerCollection();
            foreach (ILayer layer in this._sharpMap.Layers)
            {
                collection.Add(layer);
            }
            this._sharpMap.Layers.Clear();
            foreach(DataGridViewRow row in this._dataGridLayers.Rows)
            {
                string layerGridName = (string)row.Cells[1].Value;
                foreach (ILayer layer in collection)
                {
                    if (string.Equals(layerGridName, layer.LayerName))
                    {
                        this._sharpMap.Layers.Add(layer);
                        break;
                    }
                }
            }
            this.RefreshMap();
        }

        private void btnLayerDown_Click(object sender, EventArgs e)
        {
            if (this._dataGridLayers.SelectedRows.Count > 0)
            {
                int selectedRow = this._dataGridLayers.SelectedRows[0].Index;
                if (selectedRow < this._dataGridLayers.Rows.Count - 1)
                {
                    DataGridViewRow row = this._dataGridLayers.Rows[selectedRow];
                    this._dataGridLayers.Rows.Remove(row);
                    this._dataGridLayers.Rows.Insert(selectedRow + 1, row);
                    this._dataGridLayers.Rows[selectedRow + 1].Selected = true;
                    this.SortLayers();
                }
            }
        }

        private void btnLayerUp_Click(object sender, EventArgs e)
        {
            if (this._dataGridLayers.SelectedRows.Count > 0)
            { 
                int selectedIndex = this._dataGridLayers.SelectedRows[0].Index;
                if (selectedIndex > 0)
                {
                    DataGridViewRow row = this._dataGridLayers.Rows[selectedIndex];
                    this._dataGridLayers.Rows.Remove(row);
                    this._dataGridLayers.Rows.Insert( selectedIndex - 1,row);
                    this._dataGridLayers.Rows[selectedIndex - 1].Selected = true;
                    this.SortLayers();
                }
            }
        }

        private void addPostGisVectorLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPostGisLayer layerDialog = new AddPostGisLayer();
            layerDialog.StartPosition = FormStartPosition.CenterParent;
            //layerDialog.Parent = this;
            layerDialog.ShowDialog();
        }
    }
}
