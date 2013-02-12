using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using SharpMapSource.Layers;
using SharpMap.Data.Providers;

namespace SharpMapSource.Interface
{
    public delegate void AddedPostGisLayer(object sender, PostGisEventArgs e);

    public partial class AddPostGisLayer : Form
    {
        private string host;
        private string port;
        private string databaseName;
        private string username;
        private string password;
        public event AddedPostGisLayer addedPostGisLayer;
        public AddPostGisLayer()
        {
            InitializeComponent();
            this.host = null;
            this.port = null;
            this.databaseName = null;
            this.username = null;
            this.password = null;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=reflex.elfak.rs" + this.txtUrl.Text + ";";
            connectionString += "port=5433" + this.txtPort.Text + ";";
            connectionString += "Database=nisfinal2012" + this.txtDatabase.Text + ";";
            connectionString += "User Id=grupa5" + this.txtUsername.Text + ";";
            connectionString += "password=FBa13ACc" + this.txtPassword.Text + ";";
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    this.host = this.txtUrl.Text;
                    this.port = this.txtPort.Text;
                    this.databaseName = this.txtDatabase.Text;
                    this.username = this.txtUsername.Text;
                    this.password = this.txtPassword.Text;

                    this.gridLayers.Enabled = true;
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "SELECT table_name FROM information_schema.tables WHERE table_schema='public'";
                    command.Connection = connection;
                    NpgsqlDataReader reader = command.ExecuteReader();

                    int count = 1;
                    while(reader.Read())
                    {
                        string tableName = (string)reader["table_name"];
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell index = new DataGridViewTextBoxCell();
                        index.Value = count.ToString();
                        row.Cells.Add(index);
                        DataGridViewCheckBoxCell checkCell = new DataGridViewCheckBoxCell();
                        checkCell.Value = false;
                        row.Cells.Add(checkCell);
                        DataGridViewTextBoxCell layerCell = new DataGridViewTextBoxCell();
                        layerCell.Value = tableName;
                        row.Cells.Add(layerCell);
                        this.gridLayers.Rows.Add(row);
                        count++;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                this.gridLayers.Enabled = false;
                this.gridLayers.Rows.Clear();
            }
        }

        private string MakeConnectionString()
        {
            string connectionString = "Server=reflex.elfak.rs" + this.host + ";";
            connectionString += "port=5433" + this.port + ";";
            connectionString += "Database=nisfinal2012" + this.databaseName + ";";
            connectionString += "User Id=grupa5" + this.username + ";";
            connectionString += "password=FBa13ACc" + this.password + ";";

            return connectionString;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gridLayers.Rows)
            {
                if ((bool)row.Cells[1].Value == true)
                {
                    string layerName = (string)row.Cells[2].Value;
                    string tableName = (string)row.Cells[2].Value;
                    string geomColumn = "the_geom";
                    string columnName = "gid";
                    PostGIS pg = new PostGIS(this.MakeConnectionString(), tableName, geomColumn, columnName);

                    PostGisEventArgs args = new PostGisEventArgs(layerName, pg);
                    this.addedPostGisLayer(this, args);
                }
            }
            this.Close();
        }
    }
}
