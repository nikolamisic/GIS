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
<<<<<<< HEAD
using SharpMap;
=======
using SharpMapSource.Layers;
>>>>>>> odradjen interfejs i proradio unos rasterskog sloja

namespace SharpMapSource
{
    public partial class Main : Form
    {
        private SharpMap.Map _sharpMap;
        private LayerManager _manager;

        private const float ZOOM_FACTOR = 0.3f;
<<<<<<< HEAD
        private String DATA_NAME = "World Countries";
        private String DATA_PATH = "Data//world_adm0.shp";
        SharpMap.Geometries.LinearRing select;
=======
        //private String DATA_NAME = "World Countries";
        //private String DATA_PATH = "Data//world_adm0.shp";
        //pan image
        private Point _panCoordinate;

>>>>>>> odradjen interfejs i proradio unos rasterskog sloja

        public Main()
        {
            InitializeComponent();
<<<<<<< HEAD
            select = new SharpMap.Geometries.LinearRing();
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
=======
            _sharpMap = new SharpMap.Map(this._sharpMapImage.Size);
            _sharpMap.BackColor = Color.White;
            this._manager = new LayerManager(this._sharpMap);
>>>>>>> odradjen interfejs i proradio unos rasterskog sloja

            RefreshMap();
        }

        public void RefreshMap()
        {
            if (_sharpMap.Layers.Count != 0)
                this._sharpMapImage.Image = _sharpMap.GetMap();
            else
                this._sharpMapImage.Image = null;
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            if (this._dataGridLayers.SelectedRows.Count > 0)
            {
<<<<<<< HEAD
                if (Control.ModifierKeys != Keys.Control)
                    this.select.Vertices.Clear();

                MouseEventArgs m = e as MouseEventArgs;
                if (Control.ModifierKeys == Keys.Shift)
                {
                    var pp = _sharpMap.ImageToWorld(m.Location);
                    SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                    String str = "";
                    foreach (var layer in _sharpMap.Layers)
                    {
                        var queryLayer = layer as SharpMap.Layers.ICanQueryLayer;
                        if (queryLayer != null)
                        {
                            queryLayer.ExecuteIntersectionQuery(pp.GetBoundingBox().Grow(_sharpMap.Zoom/1000), ds);
                            foreach (SharpMap.Data.FeatureDataTable tab in ds.Tables)
                            {
                                foreach (SharpMap.Data.FeatureDataRow dr in tab)
                                {
                                    foreach (object o in dr.ItemArray)
                                    {
                                        str += o.ToString() + " | " + _sharpMap.Zoom.ToString();
                                    }
                                    str += "\n";
                                }
                            }
                        }
                    }
                    MessageBox.Show(str);
                    /*SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer(new System.Random().ToString(), new SharpMap.Data.Providers.GeometryProvider(ds.Tables[0]));
                    lay.Style.Fill = Brushes.Yellow;
                    _sharpMap.Layers.Add(lay);

                    this.RefreshMap();*/
                }
                else if(Control.ModifierKeys == Keys.Control)
                {
                    SharpMap.Geometries.Point point = new SharpMap.Geometries.Point(m.X,m.Y);
                    select.Vertices.Add(point);
                    if (m.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        var pp = _sharpMap.ImageToWorld(m.Location);
                        SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                        String str = "";
                        foreach (var layer in _sharpMap.Layers)
                        {
                            var queryLayer = layer as SharpMap.Layers.ICanQueryLayer;
                            if (queryLayer != null)
                            {
                                SharpMap.Geometries.Polygon poly = new SharpMap.Geometries.Polygon(select);
                                queryLayer.ExecuteIntersectionQuery(select, ds);
                                foreach (SharpMap.Data.FeatureDataTable tab in ds.Tables)
                                {
                                    foreach (SharpMap.Data.FeatureDataRow dr in tab)
                                    {
                                        foreach (object o in dr.ItemArray)
                                        {
                                            str += o.ToString() + " | " + _sharpMap.Zoom.ToString();
                                        }
                                        str += "\n";
                                    }
                                }

                            }
                        }
                        foreach (SharpMap.Geometries.Point niz in select.Vertices)
                            str += niz.ToString();
                        MessageBox.Show(str);
                        select.Vertices.Clear();
                    }
                }
                else
                {
                    //--> Convert mouse click point from image coordinates to world coordinates
                    SharpMap.Geometries.Point p = _sharpMap.ImageToWorld(new PointF(m.X, m.Y));
                    //--> Recenter map
                    _sharpMap.Center.X = p.X;
                    _sharpMap.Center.Y = p.Y;
=======
                if (this._dataGridLayers.SelectedRows[0].Index >= 0)
                {
                    _sharpMap.Layers.RemoveAt(this._dataGridLayers.SelectedRows[0].Index);
                    this._dataGridLayers.Rows.RemoveAt(this._dataGridLayers.SelectedRows[0].Index);
                    if (_sharpMap.Layers.Count != 0)
                    {
                        _sharpMap.ZoomToExtents();
                    }
>>>>>>> odradjen interfejs i proradio unos rasterskog sloja
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
<<<<<<< HEAD
            else
                path = DATA_PATH;
            SharpMap.Layers.VectorLayer layer = new SharpMap.Layers.VectorLayer(dialog.SafeFileName);
            //layer.DataSource = new SharpMap.Data.Providers.ShapeFile(DATA_PATH);
            layer.DataSource = new SharpMap.Data.Providers.ShapeFile(path);
            layer.Style.Fill = Brushes.Red;
            layer.Style.EnableOutline = true;
            layer.Style.Outline = Pens.OrangeRed;

            //MessageBox.Show(layer.DataSource.GetFeatureCount().ToString());

=======
                if (File.Exists(path))
                {
                    string layerName = Path.GetFileNameWithoutExtension(path);
                    this._manager.AddVectorLayer(layerName, new SharpMap.Data.Providers.ShapeFile(path));
                    this._dataGridLayers.Rows.Add( true,layerName);
                }
            }
>>>>>>> odradjen interfejs i proradio unos rasterskog sloja
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
    }
}
