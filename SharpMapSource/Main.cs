using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSGeo.GDAL;

namespace SharpMapSource
{
    public partial class Main : Form
    {
        private SharpMap.Map _sharpMap;
        private const float ZOOM_FACTOR = 0.3f;
        private String DATA_NAME = "World Countries";
        private String DATA_PATH = "Data//world_adm0.shp";

        public Main()
        {
            InitializeComponent();
            _sharpMap = new SharpMap.Map(this.pbxMapa.Size);
            _sharpMap.BackColor = Color.WhiteSmoke;

            /*String path;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "shp Files (.shp)|*.shp|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
                path = dialog.FileName;
            else
                path = DATA_PATH;
            //SharpMap.Layers.VectorLayer layer = new SharpMap.Layers.VectorLayer(DATA_NAME);
            //layer.DataSource = new SharpMap.Data.Providers.ShapeFile(DATA_PATH);
            SharpMap.Layers.VectorLayer layer = new SharpMap.Layers.VectorLayer(dialog.SafeFileName);
            layer.DataSource = new SharpMap.Data.Providers.ShapeFile(path);
            layer.Style.Fill = Brushes.LightGreen;
            layer.Style.EnableOutline = true;
            layer.Style.Outline = Pens.DarkGreen;*/
            //dodavanje labele
            /*SharpMap.Layers.LabelLayer labelLayer = new SharpMap.Layers.LabelLayer("Country Names");
            labelLayer.DataSource = layer.DataSource;
            labelLayer.LabelColumn = "NAME";
            labelLayer.Style.CollisionDetection = true;
            //labelLayer.Style.CollisionBuffer = new SizeF(10, 10);
            labelLayer.LabelFilter = SharpMap.Rendering.LabelCollisionDetection.ThoroughCollisionDetection;
            labelLayer.MultipartGeometryBehaviour = SharpMap.Layers.LabelLayer.MultipartGeometryBehaviourEnum.Largest;
            labelLayer.Style.Font = new Font(FontFamily.GenericSansSerif, 8);

            _sharpMap.Layers.Add(labelLayer);*/
           /* _sharpMap.Layers.Add(layer);
            this.lbxLayers.Items.Add(layer.LayerName);
            _sharpMap.ZoomToExtents();*/

            RefreshMap();
        }

        public void RefreshMap()
        {
            if (_sharpMap.Layers.Count != 0)
                pbxMapa.Image = _sharpMap.GetMap();
            else
                pbxMapa.Image = null;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            _sharpMap.Zoom -= _sharpMap.Zoom * ZOOM_FACTOR; 
            RefreshMap();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            _sharpMap.Zoom += _sharpMap.Zoom * ZOOM_FACTOR;
            RefreshMap();
        }

        private void btnZoomFull_Click(object sender, EventArgs e)
        {
            if(_sharpMap.Layers.Count != 0)
                _sharpMap.ZoomToExtents();
            RefreshMap();
        }

        private void pbxMapa_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                MouseEventArgs m = e as MouseEventArgs;
                //--> Convert mouse click point from image coordinates to world coordinates
                SharpMap.Geometries.Point p = _sharpMap.ImageToWorld(new PointF(m.X, m.Y));
                //--> Recenter map
                _sharpMap.Center.X = p.X;
                _sharpMap.Center.Y = p.Y;
                RefreshMap();
            }
        }

        private void pbxMapa_MouseMove(object sender, MouseEventArgs e)
        {
            SharpMap.Geometries.Point p = _sharpMap.ImageToWorld(new PointF(e.X, e.Y));
            lbCoord.Text = "Coord:" + p.X + " : " + p.Y;
        }

        private void brnAddLayer_Click(object sender, EventArgs e)
        {
            String path;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "shp Files (.shp)|*.shp|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.Multiselect = false;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
                path = dialog.FileName;
            else
                path = DATA_PATH;
            SharpMap.Layers.VectorLayer layer = new SharpMap.Layers.VectorLayer(dialog.SafeFileName);
            //layer.DataSource = new SharpMap.Data.Providers.ShapeFile(DATA_PATH);
            layer.DataSource = new SharpMap.Data.Providers.ShapeFile(path);
            layer.Style.Fill = Brushes.Red;
            layer.Style.EnableOutline = true;
            layer.Style.Outline = Pens.OrangeRed;

            try
            {
                _sharpMap.Layers.Add(layer);
                _sharpMap.ZoomToExtents();
                RefreshMap();
                this.lbxLayers.Items.Add(layer.LayerName);
            }
            catch (Exception)
            {
                MessageBox.Show("Layer already inserted");
            }
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            if (this.lbxLayers.SelectedIndex >= 0)
            {
                _sharpMap.Layers.RemoveAt(lbxLayers.SelectedIndex);
                lbxLayers.Items.RemoveAt(lbxLayers.SelectedIndex);
                if (_sharpMap.Layers.Count != 0)
                {
                    _sharpMap.ZoomToExtents();
                }
                RefreshMap();
            }
                
        }

        private void btnEditLayer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRaster_Click(object sender, EventArgs e)
        {
            SharpMap.Layers.ILayer layer = _sharpMap.Layers["RasterLayer"];
            String path;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                path = dialog.FileName;
                /*SharpMap.Layers.GdalRasterLayer rasterLayer = new SharpMap.Layers.GdalRasterLayer(dialog.SafeFileName, path);
                rasterLayer.ReprojectToMap(_sharpMap);
                _sharpMap.Layers.Add(rasterLayer);
                _sharpMap.ZoomToExtents();
                lbxLayers.Items.Add(dialog.SafeFileName);
                RefreshMap();*/
            }
            else
                path = DATA_PATH;
        }
    }
}
