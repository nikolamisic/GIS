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

namespace SharpMapSource.Interface
{
    public partial class AddPostGisLayer : Form
    {
        public AddPostGisLayer()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=reflex.elfak.rs" + this.txtUrl.Text + ";";
            connectionString += "Port=5433" + this.txtPort.Text + ";";
            connectionString += "Database=nisfinal2012" + this.txtDatabase.Text + ";";
            connectionString += "User Id=grupa5" + this.txtUsername.Text + ";";
            connectionString += "Password=FBa13ACc" + this.txtPassword.Text + ";";
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
