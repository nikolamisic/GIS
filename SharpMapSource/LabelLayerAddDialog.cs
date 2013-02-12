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
    public partial class LabelLayerAddDialog : Form
    {

        SharpMap.Map _map;

        DialogResult res;

        public String retName;
        public String retLayer;

        public LabelLayerAddDialog()
        {
            InitializeComponent();
        }

        public LabelLayerAddDialog(SharpMap.Map mapa)
        {
            InitializeComponent();
            _map = mapa;
        }

        private void LabelLayerAddDialog_Load(object sender, EventArgs e)
        {
            foreach (object o in _map.Layers)
            {
                SharpMap.Layers.VectorLayer layer = o as SharpMap.Layers.VectorLayer;
                if(layer != null)
                    this._cmBoxLayer.Items.Add(layer.LayerName);
            }
        }

        private void _cmBoxLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharpMap.Layers.VectorLayer layer = _map.GetLayerByName(this._cmBoxLayer.SelectedItem.ToString()) as SharpMap.Layers.VectorLayer;
            if (layer != null)
            {
                SharpMap.Data.FeatureDataSet set = new SharpMap.Data.FeatureDataSet();
                layer.ExecuteIntersectionQuery(layer.DataSource.GetExtents(), set);
                foreach (DataColumn kol in set.Tables[0].Columns)
                {
                    this._cmBoxAttribute.Items.Add(kol.ColumnName);
                }
            }

        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            if(_cmBoxAttribute.SelectedItem != null)
                this.retName = this._cmBoxAttribute.SelectedItem.ToString();
            if(_cmBoxLayer.SelectedItem != null)
            this.retLayer = this._cmBoxLayer.SelectedItem.ToString();
            this.res = System.Windows.Forms.DialogResult.OK;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.res = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
