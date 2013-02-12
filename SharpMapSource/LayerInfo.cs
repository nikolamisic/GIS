using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpMap;

namespace SharpMapSource
{
    public partial class LayerInfo : Form
    {
        SharpMap.Data.FeatureDataTable _tabela;
        public LayerInfo()
        {
            InitializeComponent();
        }

        public LayerInfo(SharpMap.Data.FeatureDataTable tabela)
        {
            InitializeComponent();
            this._tabela = tabela;

            //MessageBox.Show("Success!");
            //DataGridViewColumnCollection kolone = new DataGridViewColumnCollection(this._layersDataGrid);
            foreach (DataColumn kol in _tabela.Columns)
            {
                DataGridViewTextBoxColumn kolona = new DataGridViewTextBoxColumn();
                kolona.DataPropertyName = kol.ColumnName;
                kolona.HeaderText = kol.ColumnName;
                kolona.Name = kol.ColumnName;
                kolona.Width = 200;
                this._layersDataGrid.Columns.Add(kolona);
            }
            //this._layersDataGrid.Rows.Add(_tabela.Rows);
            foreach (SharpMap.Data.FeatureDataRow red in _tabela.Rows)
            {
                this._layersDataGrid.Rows.Add(red.ItemArray);
            }
            //this._layersDataGrid.DataSource = tabela.Rows;


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void LayerInfo_Load(object sender, EventArgs e)
        {
        }
    }
}
