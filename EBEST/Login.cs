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
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        string usuario;
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\TADEOEBEST\basededatoscompartida\Login2_be.accdb;";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from contras Where contrase like ('" + txtcontra.Text + "')";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtrevisar.Text = Convert.ToString(reader["contrase"]);
                    usuario = Convert.ToString(reader["usuario"]);


                    reader.Close();

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            if (txtcontra.Text == txtrevisar.Text)
            {
                MessageBox.Show("Contraseña correcta");
                //txtordenprueba.Text = "Reer548621579";
                inicio ini = new inicio();
               // Login lo = new Login();
                //lo.Hide();
                ini.usuarios = usuario;
                ini.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");

            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
