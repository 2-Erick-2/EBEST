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
using Tulpep.NotificationWindow;
using System.Windows.Media.Animation;
using System.Windows.Controls.Primitives;

namespace EBEST
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        string usuario;
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Login_be.accdb; Persist Security Info=False;";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from login Where contraseña like ('" + txtcontra.Text + "')";// aqui va contrase
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtrevisar.Text = Convert.ToString(reader["contraseña"]);
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
                PopupNotifier popup = new PopupNotifier();
                popup.IsRightToLeft = false;
                
               // popup.AnimationDuration = 30000000;
                
                popup.TitleText = "Contraseña correcta";
                popup.Image = Properties.Resources.profile_picture_user_icon_153847;
                popup.ContentText = "Bienvenid@ " + usuario;
                popup.Popup();

               // MessageBox.Show("Contraseña correcta");
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
                PopupNotifier popup = new PopupNotifier();
                popup.IsRightToLeft = false;

                // popup.AnimationDuration = 30000000;

                popup.TitleText = "Contraseña incorrecta";
                popup.Image = Properties.Resources.profile_picture_user_icon_153847;
                popup.ContentText = "Acceso denegado";
                popup.Popup();
                //MessageBox.Show("Contraseña incorrecta");

            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }*/
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {

        }

        private void Cerrar_DoubleClick(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }*/
        }

        private void txtcontra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
