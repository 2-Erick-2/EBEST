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
    public partial class clientes : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public clientes()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\TADEOEBEST\basededatoscompartida\Ebest_be.accdb; Persist Security Info=False;";


        }

        private void clientes_Load(object sender, EventArgs e)
        {
            comboBoxbusqueda.Text = "Orden";

            txtbusqueda_Click(sender, e);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from clientes";
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
                    string query = "select * from clientes Where orden like ('" + txtbusqueda.Text + "%')";
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
                    string query = "select * from clientes Where numero like ('" + txtbusqueda.Text + "%')";
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
                    string query = "select * from clientes Where nombre like ('" + txtbusqueda.Text + "%')";
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
                    string query = "select * from clientes Where horayfecha like ('" + txtbusqueda.Text + "%')";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBoxorden_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxorden.Checked)
            {
                txtbusqueda.Enabled = true;
                checkBoxnumero.Checked = false;
            }
        }

        private void checkBoxnumero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxnumero.Checked)
            {
                txtbusqueda.Enabled = true;

                checkBoxorden.Checked = false;
            }

        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }

        private void txtbusqueda_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";

        }
    }
}
