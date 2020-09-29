using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EBEST
{
    public partial class cotizaciones : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public cotizaciones()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\TADEOEBEST\basededatoscompartida\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void checkBoxorden_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxorden.Checked)
            {
                txtbusqueda.Enabled = true;
                checkBoxnumero.Checked = false;
            }
            else if (checkBoxnumero.Checked == false && checkBoxorden.Checked == false)
            {
                txtbusqueda.Enabled = false;
            }
        }

        private void checkBoxnumero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxnumero.Checked)
            {
                txtbusqueda.Enabled = true;

                checkBoxorden.Checked = false;
            }
            else if (checkBoxnumero.Checked == false && checkBoxorden.Checked == false)
            {
                txtbusqueda.Enabled = false;
            }
        }

        private void cotizaciones_Load(object sender, EventArgs e)
        {
            comboBoxbusqueda.Text = "Orden";

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from cotizaciones";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightYellow;

            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[4].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[5].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[6].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[8].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[9].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[10].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[11].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[12].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[12].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[13].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[13].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[14].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[14].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[15].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[15].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[16].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[16].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[17].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[17].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[18].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView1.Columns[19].HeaderCell.Style.BackColor = Color.White;
            dataGridView1.Columns[19].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

            if (comboBoxbusqueda.Text == "Orden")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where orden like ('" + txtbusqueda.Text + "%')";
                    command.CommandText = query;
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }

            else if (comboBoxbusqueda.Text == "Numero")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where numero like ('" + txtbusqueda.Text + "%')";
                    command.CommandText = query;

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }

            else if (comboBoxbusqueda.Text == "Nombre")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where nombre like ('" + txtbusqueda.Text + "%')";
                    command.CommandText = query;

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }

            if (comboBoxbusqueda.Text == "Fecha")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where horayfecha like ('" + txtbusqueda.Text + "%')";
                    command.CommandText = query;

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }

            }





            
           
        }

        private void comboBoxbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
