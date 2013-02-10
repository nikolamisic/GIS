using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpMapSource.Interface
{
    public partial class SpatialQuery : Form
    {

        private SharpMap.Map _map;

        public SpatialQuery()
        {
            InitializeComponent();
        }

        public SpatialQuery(SharpMap.Map mapa)
        {
            InitializeComponent();
            this._map = mapa;
        }

        private void SpatialQuery_Load(object sender, EventArgs e)
        {
            foreach (object o in _map.Layers)
            {
                SharpMap.Layers.VectorLayer layer = o as SharpMap.Layers.VectorLayer;
                if (layer != null)
                {
                    this._cmbLayer1.Items.Add(layer.LayerName);
                    this._cmbLayer2.Items.Add(layer.LayerName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_cmbLayer1.SelectedIndex >= 0 && _cmbLayer2.SelectedIndex >= 0 && _cmbOperation.SelectedIndex >= 0)
            {
                //obrada forme
                if (_cmbOperation.SelectedIndex == 0) //intersect
                {
                    SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                    SharpMap.Layers.VectorLayer layer1 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer1.SelectedItem.ToString());
                    SharpMap.Layers.VectorLayer layer2 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer2.SelectedItem.ToString());

                    if (layer1.LayerName == "selected layer")
                        layer1.ExecuteIntersectionQuery(layer2.DataSource.GetExtents(), ds);
                    else
                    {
                        SharpMap.Data.Providers.NtsProvider nts = new SharpMap.Data.Providers.NtsProvider(layer1.DataSource);
                        nts.ExecuteIntersectionQuery(layer2.DataSource.GetExtents(), ds);
                    }

                    LayerInfo info = new LayerInfo(ds.Tables[0]);
                    info.Show();
                    //ubacivane u selekciju
                    SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer("selected layer", new SharpMap.Data.Providers.GeometryFeatureProvider(ds.Tables[0]));
                    lay.Style.Fill = Brushes.Yellow;
                    //_manager.AddVectorLayer(lay.LayerName,lay.DataSource);
                    SharpMap.Layers.ILayer layerToRemove = _map.GetLayerByName("selected layer");
                    if (layerToRemove != null)
                    {
                        _map.Layers.Remove(layerToRemove);
                    }
                    _map.Layers.Add(lay);
                }
                else if (_cmbOperation.SelectedIndex == 1)//within
                {
                    SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                    SharpMap.Layers.VectorLayer layer1 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer1.SelectedItem.ToString());
                    SharpMap.Layers.VectorLayer layer2 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer2.SelectedItem.ToString());

                    SharpMap.Data.Providers.NtsProvider nts = new SharpMap.Data.Providers.NtsProvider(layer1.DataSource);
                    SharpMap.Data.Providers.NtsProvider nts2 = new SharpMap.Data.Providers.NtsProvider(layer2.DataSource, CreateBuffers);

                    nts.ExecuteIntersectionQuery(nts2.GetExtents(), ds);
                    LayerInfo info = new LayerInfo(ds.Tables[0]);
                    info.Show();
                    //ubacivanje u selekciju
                    SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer("selected layer", new SharpMap.Data.Providers.GeometryFeatureProvider(ds.Tables[0]));
                    lay.Style.Fill = Brushes.Yellow;
                    //_manager.AddVectorLayer(lay.LayerName,lay.DataSource);
                    SharpMap.Layers.ILayer layerToRemove = _map.GetLayerByName("selected layer");
                    if (layerToRemove != null)
                    {
                        _map.Layers.Remove(layerToRemove);
                    }
                    _map.Layers.Add(lay);
                }
                else//van
                {
                    SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                    SharpMap.Layers.VectorLayer layer1 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer1.SelectedItem.ToString());
                    SharpMap.Layers.VectorLayer layer2 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer2.SelectedItem.ToString());

                    SharpMap.Data.Providers.NtsProvider nts = new SharpMap.Data.Providers.NtsProvider(layer1.DataSource);
                    SharpMap.Data.Providers.NtsProvider nts2 = new SharpMap.Data.Providers.NtsProvider(layer2.DataSource, CreateBuffers);

                    nts.ExecuteIntersectionQuery(nts2.GetExtents(), ds);
                    LayerInfo info = new LayerInfo(ds.Tables[0]);
                    info.Show();
                    //ubacivanje u selekciju
                    SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer("selected layer", new SharpMap.Data.Providers.GeometryFeatureProvider(ds.Tables[0]));
                    lay.Style.Fill = Brushes.Yellow;
                    //_manager.AddVectorLayer(lay.LayerName,lay.DataSource);
                    SharpMap.Layers.ILayer layerToRemove = _map.GetLayerByName("selected layer");
                    if (layerToRemove != null)
                    {
                        _map.Layers.Remove(layerToRemove);
                    }
                    _map.Layers.Add(lay);
                }
            }
        }

        private void CreateBuffers(List<GisSharpBlog.NetTopologySuite.Features.Feature> features)
        {
            double buff = Double.Parse(_txtbDistance.Text);
            switch (_cmbUnits.SelectedIndex)
            {
                case 1: buff /= 100; break; //cm
                case 2: buff *= 1000; break; //km
                default: break;
            }

            foreach (GisSharpBlog.NetTopologySuite.Features.Feature feature in features)
            {
                feature.Geometry = feature.Geometry.Buffer(buff);
            }
        }
    }
}
