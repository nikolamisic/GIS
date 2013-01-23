using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMapSource
{
    public partial class Main : Form
    {
        private SharpMap.Map _sharpMap;
        private const float ZOOM_FACTOR = 0.3f;
        const String DATA_NAME = "World Countries";
        const String DATA_PATH = "Data//world_adm0.shp";

        public Main()
        {
            InitializeComponent();
            _sharpMap = new SharpMap.Map(this.pbxMapa.Size);
            _sharpMap.BackColor = Color.WhiteSmoke;

            SharpMap.Layers.VectorLayer layer = new SharpMap.Layers.VectorLayer(DATA_NAME);
            layer.DataSource = new SharpMap.Data.Providers.ShapeFile(DATA_PATH);
            layer.Style.Fill = Brushes.LightGreen;
            layer.Style.EnableOutline = true;
            layer.Style.Outline = Pens.DarkGreen;

            SharpMap.Layers.LabelLayer labelLayer = new SharpMap.Layers.LabelLayer("Country Names");
            labelLayer.DataSource = layer.DataSource;
            labelLayer.LabelColumn = "NAME";
            labelLayer.Style.CollisionDetection = true;
            //labelLayer.Style.CollisionBuffer = new SizeF(10, 10);
            labelLayer.LabelFilter = SharpMap.Rendering.LabelCollisionDetection.ThoroughCollisionDetection;
            labelLayer.MultipartGeometryBehaviour = SharpMap.Layers.LabelLayer.MultipartGeometryBehaviourEnum.Largest;
            labelLayer.Style.Font = new Font(FontFamily.GenericSansSerif, 8);

            _sharpMap.Layers.Add(labelLayer);
            _sharpMap.Layers.Add(layer);
            _sharpMap.ZoomToExtents();

            RefreshMap();
        }

        public void RefreshMap()
        {
            pbxMapa.Image = _sharpMap.GetMap();
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
    }
}
