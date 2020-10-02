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
    public partial class actualizacion : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public actualizacion()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\TADEOEBEST\basededatoscompartida\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttipo.Text == "Pe")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "update pedidos set tipopedido='" + txtpedido.Text + "' , nombre='" + txtnombre.Text + "', numero='" + txtnumero.Text + "', observaciones='" + txtobser.Text + "'   where orden like ('" + txtorden.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }

            else if (txttipo.Text == "Co")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "update cotizaciones set tipopedido='" + txtpedido.Text + "' , nombre='" + txtnombre.Text + "', numero='" + txtnumero.Text + "', observaciones='" + txtobser.Text + "'   where orden like ('" + txtorden.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }

            else if (txttipo.Text == "Re")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "update revisiones set tipopedido='" + txtpedido.Text + "' , nombre='" + txtnombre.Text + "', numero='" + txtnumero.Text + "', observaciones='" + txtobser.Text + "'   where orden like ('" + txtorden.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados2");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "update clientes set tipopedido='" + txtpedido.Text + "' , nombre='" + txtnombre.Text + "', numero='" + txtnumero.Text + "', observaciones='" + txtobser.Text + "'   where id=" + txtid.Text + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Guardados3");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void actualizacion_Load(object sender, EventArgs e)
        {

        }
    }
}
