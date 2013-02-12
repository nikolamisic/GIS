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
        private Main _parent;

        public IEnumerable<SharpMap.Geometries.Geometry> getGeom(SharpMap.Geometries.GeometryCollection g)
        {

            foreach (SharpMap.Geometries.Geometry geo in g.Collection)
            {
                yield return geo;
            }
        }

        public SpatialQuery()
        {
            InitializeComponent();
        }

        public SpatialQuery(SharpMap.Map mapa)
        {
            InitializeComponent();
            this._map = mapa;
        }

        public SpatialQuery(SharpMap.Map mapa, Main caller)
        {
            InitializeComponent();
            this._map = mapa;
            this._parent = caller;
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

                    SharpMap.Data.Providers.NtsProvider nts = new SharpMap.Data.Providers.NtsProvider(layer1.DataSource);
                    SharpMap.Data.Providers.NtsProvider nts2 = new SharpMap.Data.Providers.NtsProvider(layer2.DataSource);

                    SharpMap.Geometries.GeometryCollection coll = new SharpMap.Geometries.GeometryCollection();
                    ds.Tables.Clear();

                    SharpMap.Data.FeatureDataSet set = new SharpMap.Data.FeatureDataSet();
                    nts.GetFeaturesInView(nts.GetExtents(), set);

                    SharpMap.Data.FeatureDataSet res = new SharpMap.Data.FeatureDataSet();
                    res.Tables.Add(set.Tables[0].Clone());
                    res.Tables[0].Rows.Clear();

                    ds.Tables.Clear();
                    foreach (SharpMap.Data.FeatureDataRow row in set.Tables[0].Rows)
                    {
                        nts2.ExecuteIntersectionQuery(row.Geometry, ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            SharpMap.Data.FeatureDataRow red = res.Tables[0].NewRow();
                            red.Geometry = row.Geometry;
                            red.ItemArray = row.ItemArray;
                            res.Tables[0].AddRow(red);
                        }
                        ds.Tables.Clear();
                    }

                    LayerInfo l = new LayerInfo(res.Tables[0]);
                    l.Show();

                    SharpMap.Data.Providers.GeometryFeatureProvider prov = new SharpMap.Data.Providers.GeometryFeatureProvider(res.Tables[0]);

                    SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer("selected layer", prov);
                    lay.Style.Fill = Brushes.Yellow;
                    SharpMap.Layers.ILayer layerToRemove = _map.GetLayerByName("selected layer");
                    if (layerToRemove != null)
                    {
                        _map.Layers.Remove(layerToRemove);
                    }
                    _map.Layers.Add(lay);
                    this._parent.RefreshMap();
                }
                else if (_cmbOperation.SelectedIndex == 1)//within
                {
                    SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                    SharpMap.Layers.VectorLayer layer1 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer1.SelectedItem.ToString());
                    SharpMap.Layers.VectorLayer layer2 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer2.SelectedItem.ToString());

                    SharpMap.Data.Providers.NtsProvider nts = new SharpMap.Data.Providers.NtsProvider(layer1.DataSource);
                    SharpMap.Data.Providers.NtsProvider nts2 = new SharpMap.Data.Providers.NtsProvider(layer2.DataSource, CreateBuffers);

                    SharpMap.Geometries.GeometryCollection coll = new SharpMap.Geometries.GeometryCollection();
                    ds.Tables.Clear();

                    SharpMap.Data.FeatureDataSet set = new SharpMap.Data.FeatureDataSet();
                    nts.GetFeaturesInView(nts.GetExtents(), set);

                    SharpMap.Data.FeatureDataSet res = new SharpMap.Data.FeatureDataSet();
                    res.Tables.Add(set.Tables[0].Clone());
                    res.Tables[0].Rows.Clear();

                    ds.Tables.Clear();
                    foreach (SharpMap.Data.FeatureDataRow row in set.Tables[0].Rows)
                    {
                        nts2.ExecuteIntersectionQuery(row.Geometry, ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            SharpMap.Data.FeatureDataRow red = res.Tables[0].NewRow();
                            red.Geometry = row.Geometry;
                            red.ItemArray = row.ItemArray;
                            res.Tables[0].AddRow(red);
                        }
                        ds.Tables.Clear();
                    }

                    LayerInfo l = new LayerInfo(res.Tables[0]);
                    l.Show();

                    SharpMap.Data.Providers.GeometryFeatureProvider prov = new SharpMap.Data.Providers.GeometryFeatureProvider(res.Tables[0]);

                    SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer("selected layer", prov);
                    lay.Style.Fill = Brushes.Yellow;
                    SharpMap.Layers.ILayer layerToRemove = _map.GetLayerByName("selected layer");
                    if (layerToRemove != null)
                    {
                        _map.Layers.Remove(layerToRemove);
                    }
                    _map.Layers.Add(lay);
                    this._parent.RefreshMap();
                }
                else//van
                {
                    SharpMap.Data.FeatureDataSet ds = new SharpMap.Data.FeatureDataSet();
                    SharpMap.Layers.VectorLayer layer1 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer1.SelectedItem.ToString());
                    SharpMap.Layers.VectorLayer layer2 = (SharpMap.Layers.VectorLayer)_map.GetLayerByName(_cmbLayer2.SelectedItem.ToString());

                    SharpMap.Data.Providers.NtsProvider nts = new SharpMap.Data.Providers.NtsProvider(layer1.DataSource);
                    SharpMap.Data.Providers.NtsProvider nts2 = new SharpMap.Data.Providers.NtsProvider(layer2.DataSource, CreateBuffers);

                    SharpMap.Geometries.GeometryCollection coll = new SharpMap.Geometries.GeometryCollection();
                    ds.Tables.Clear();

                    SharpMap.Data.FeatureDataSet set = new SharpMap.Data.FeatureDataSet();
                    nts.GetFeaturesInView(nts.GetExtents(),set);

                    SharpMap.Data.FeatureDataSet res = new SharpMap.Data.FeatureDataSet();
                    res.Tables.Add(set.Tables[0].Clone());
                    res.Tables[0].Rows.Clear();

                    ds.Tables.Clear();
                    foreach (SharpMap.Data.FeatureDataRow row in set.Tables[0].Rows)
                    {
                        nts2.ExecuteIntersectionQuery(row.Geometry, ds);

                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            SharpMap.Data.FeatureDataRow red = res.Tables[0].NewRow();
                            red.Geometry = row.Geometry;
                            red.ItemArray = row.ItemArray;
                            res.Tables[0].AddRow(red);
                        }
                        ds.Tables.Clear();
                    }

                    LayerInfo l = new LayerInfo(res.Tables[0]);
                    l.Show();

                    SharpMap.Data.Providers.GeometryFeatureProvider prov = new SharpMap.Data.Providers.GeometryFeatureProvider(res.Tables[0]);

                    SharpMap.Layers.VectorLayer lay = new SharpMap.Layers.VectorLayer("selected layer", prov);
                    lay.Style.Fill = Brushes.Yellow;
                    SharpMap.Layers.ILayer layerToRemove = _map.GetLayerByName("selected layer");
                    if (layerToRemove != null)
                    {
                        _map.Layers.Remove(layerToRemove);
                    }
                    _map.Layers.Add(lay);
                    this._parent.RefreshMap();
                }
            }
        }

        private void CreateBuffers(List<GisSharpBlog.NetTopologySuite.Features.Feature> features)
        {
            double buff = 0;
            if(_txtbDistance.Text != "")
                buff = Double.Parse(_txtbDistance.Text);
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
