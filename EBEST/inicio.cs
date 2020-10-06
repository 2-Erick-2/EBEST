using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;


namespace EBEST
{
    public partial class inicio : Form
    {
        public string usuarios;
        public inicio()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }


        //ChromiumWebBrowser browser;

        private void inicio_Load(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new bienvenida());
            AbrirFormulario<bienvenida>();
            //MessageBox.Show("Bienvenido " + usuarios);
            if(usuarios == "usuario")
            {
                btninicio.Enabled = false;
                btnupdate.Enabled = false;
            }
           
            /*//AbrirFormEnPanel(new Form1());
            browser = new ChromiumWebBrowser("https://web.whatsapp.com/");

            browser.Dock = DockStyle.Fill;

            this.pContainer.Controls.Add(browser);

            browser.Load("https://web.whatsapp.com/");*/

        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.Clear();
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

        }

        private void AbrirFormEnPanel2()
        {
            revisiones fh = new revisiones();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

        }
        private void AbrirFormEnPanel3()
        {
            clientes fh = new clientes();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();

        }


        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panel_contenedor.Controls.OfType<T>().FirstOrDefault();
            if(panel_contenedor.Controls.Count > 0)
            {
                this.panel_contenedor.Controls.Clear();//.RemoveAt(0);

            }
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.Activate();
               
                formulario.BringToFront();
                
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            
            formulario.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(formulario);
            panel_contenedor.Tag = formulario;
            formulario.Show();
        }

        
        /*private void AbrirFormEnPanel2(object formhija2)
        {
            if (this.pContainer.Controls.Count > 0)
                this.pContainer.Controls.RemoveAt(0);
            Form fh = formhija2 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(fh);
            this.pContainer.Tag = fh;
            fh.Show();

        }*/
        private void button1_Click(object sender, EventArgs e)
        {      
             fotoebest.Visible = false;
            lblbienvenido.Visible = false;
            //AbrirFormEnPanel3();
            //AbrirFormEnPanel(new clientes());
            AbrirFormulario<clientes>();

            btnclientes.BackColor = Color.DarkBlue;
            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);





            if (btnclientes.Location == new Point(0,543))
            {
                btnclientes.Location = new Point(0,438);
                btnpedidos.Location = new Point(0,504);
                btncotizaciones.Location = new Point(0,576);
                btnrevisiones.Location = new Point(0,656);

                btnpedidos.Visible = true;
                btncotizaciones.Visible = true;
                btnrevisiones.Visible = true;

            }
            else if (btnclientes.Location == new Point(0,438))
            {

                btnpedidos.Visible = false;
                btncotizaciones.Visible = false;
                btnrevisiones.Visible = false;
                btnclientes.Location = new Point(0, 543);

            }

            


        



        }

        private void button3_Click(object sender, EventArgs e)
        {
            whatsapp wp = new whatsapp();
            wp.ShowDialog();
            btninicio.BackColor = Color.DarkBlue;
            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255); 
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);







            //AbrirFormEnPanel(new Form1());

        }

        private void button4_Click(object sender, EventArgs e)
        {    
            //AbrirFormEnPanel(new update());
            lblbienvenido.Visible = false;
            fotoebest.Visible = false;
            AbrirFormulario<update>();
            

            btnupdate.BackColor = Color.DarkBlue;
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);

            

        }

        private void btncotizaciones_Click(object sender, EventArgs e)
        {

            fotoebest.Visible = false;
            lblbienvenido.Visible = false;
            AbrirFormulario<cotizaciones>();

            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);


            btncotizaciones.BackColor = Color.DarkBlue;

            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);


            


            

           //AbrirFormEnPanel(new cotizaciones());


        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            fotoebest.Visible = false;
            lblbienvenido.Visible = false;
            AbrirFormulario<pedidos>();
            
            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.DarkBlue;
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);






            //AbrirFormEnPanel(new pedidos());


        }

        private void btnrevisiones_Click(object sender, EventArgs e)
        {
            revisiones rev = new revisiones();
            rev.txtactu.Text = "si";
            rev.timer1.Enabled = true;
            fotoebest.Visible = false;
            lblbienvenido.Visible = false;
            AbrirFormulario<revisiones>();
            //AbrirFormEnPanel2();
            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.DarkBlue;
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);




            //AbrirFormEnPanel(new revisiones());


        }

        private void btncrearcotizacion_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new crearcotizacion());
            AbrirFormulario<crearcotizacion>();
            fotoebest.Visible = false;
            lblbienvenido.Visible = false;
            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.DarkBlue;
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);



           



        }

        private void btncrearpedido_Click(object sender, EventArgs e)
        {

            //AbrirFormEnPanel(new crearpedido());
            AbrirFormulario<crearpedido>();
            lblbienvenido.Visible = false;
            fotoebest.Visible = false;

            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.DarkBlue;
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.FromArgb(0, 132, 255);

           



        }

        private void btncrearrevision_Click(object sender, EventArgs e)
        {

            //AbrirFormEnPanel(new crearrevision());
            AbrirFormulario<crearrevision>();

            lblbienvenido.Visible = false;
            btnupdate.BackColor = Color.FromArgb(0, 132, 255);
            btninicio.BackColor = Color.FromArgb(0, 132, 255);
            btnclientes.BackColor = Color.FromArgb(0, 132, 255);
            btnpedidos.BackColor = Color.FromArgb(0, 132, 255);
            btncotizaciones.BackColor = Color.FromArgb(0, 132, 255);
            btnrevisiones.BackColor = Color.FromArgb(0, 132, 255);
            btncrearpedido.BackColor = Color.FromArgb(0, 132, 255);
            btncrearcotizacion.BackColor = Color.FromArgb(0, 132, 255);
            btncrearrevision.BackColor = Color.DarkBlue;

            fotoebest.Visible = false;


            

        }
    }
}
