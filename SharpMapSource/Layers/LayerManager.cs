using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpMap;
using SharpMap.Layers;
using SharpMap.Data.Providers;
using System.Windows.Forms;

namespace SharpMapSource.Layers
{
    public class LayerManager
    {
        //interface iLayer, iz njega su nasledjeni svi layer-i
        private Map map;

        public LayerManager(Map map)
        {
            this.map = map;
        }

        public void AddVectorLayer(string name, IProvider provider)
        {
            VectorLayer layer = new VectorLayer(name);
            layer.DataSource = provider;
            layer.Style.Fill = Brushes.LightGreen;
            layer.Style.EnableOutline = true;
            layer.Style.Outline = Pens.DarkGreen;
            try
            {
                this.map.Layers.Add(layer);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        public void AddLabellayer(string name, string columnName, IProvider dataProvider)
        { 
            LabelLayer labelLayer = new LabelLayer(name);
            labelLayer.DataSource = dataProvider;
            labelLayer.LabelColumn = columnName;
            labelLayer.Style.CollisionDetection = true;
            //labelLayer.Style.CollisionBuffer = new SizeF(10, 10);
            labelLayer.LabelFilter = SharpMap.Rendering.LabelCollisionDetection.ThoroughCollisionDetection;
            labelLayer.MultipartGeometryBehaviour = SharpMap.Layers.LabelLayer.MultipartGeometryBehaviourEnum.Largest;
            labelLayer.Style.Font = new Font(FontFamily.GenericSansSerif, 8);
        }

        public void AddRasterLayer(string layerName, string path)
        {
            string fileName = Path.GetFileNameWithoutExtension(path);
            GdalRasterLayer rasterLayer = new GdalRasterLayer(fileName,path);
            rasterLayer.ReprojectToMap(this.map);
            this.map.Layers.Add(rasterLayer);
            this.map.ZoomToExtents();
        }

        //public void AddPostGisLayer(string LayerName, IProvider provider)
        //{
        //    VectorLayer layer = new VectorLayer(LayerName);
        //    layer.DataSource = provider;
        //    layer
        //}

        public void RemoveLayer(ILayer layer)
        {

        }
    }
}
