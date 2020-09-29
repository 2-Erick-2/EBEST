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
using bpac;

namespace EBEST
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private const string TEMPLATE_DIRECTORY = @"C:\Program Files\Brother bPAC3 SDK\Templates\"; // Template file path
        private const string TEMPLATE_SIMPLE = "NamePlate1.LBX";    // Template file name
        private const string TEMPLATE_FRAME = "NamePlate2.LBX";		// Template file name
        Correo c = new Correo();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=..\Dulceria.mdb; Persist Security Info=False;";
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEmisor.Text = "ebestprueba@gmail.com";
            txtPassword.Text = "ebest1234";
           



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthorayfecha.Text = DateTime.Now.ToString();

        }
            String pedido = "";

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            string Name = txtnombre.Text;
            var rand = new Random();

           


         if (checkBoxpedido.Checked)
            {

              pedido = "Pedido";
                checkBoxcotizacion.Checked = false;
                checkBoxrevision.Checked = false;

            string firstfour = Name.Substring(0, 2);
            txtorden.Text = firstfour;

            string iniciodepedidos = pedido.Substring(0, 2);



           //generacion  de numero aleatorio de orden
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0,9));
            var random = new Random(seed);

            txtpruibea.Text = seed.ToString();

            txtorden.Text = iniciodepedidos +"-"+ firstfour + seed.ToString();

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into pedidos (orden,tipopedido,nombre,numero,observaciones,horayfecha) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobservaciones.Text + "','" + txthorayfecha.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }




            }
             else if (checkBoxcotizacion.Checked)
                 {
                    pedido = "Cotizacion";
                checkBoxpedido.Checked = false;
                checkBoxrevision.Checked = false;

                string firstfour = Name.Substring(0, 2);
                txtorden.Text = firstfour;

                string iniciodepedidos = pedido.Substring(0, 2);



                //generacion  de numero aleatorio de orden
                var guid = Guid.NewGuid();
                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 9));
                var random = new Random(seed);

                txtpruibea.Text = seed.ToString();

                txtorden.Text = iniciodepedidos + "-" + firstfour + seed.ToString();

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into cotizaciones (orden,tipopedido,nombre,numero,observaciones,horayfecha) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobservaciones.Text + "','" + txthorayfecha.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }



            }
               else if (checkBoxrevision.Checked)
                  {
                       pedido = "Revision";
                checkBoxpedido.Checked = false;
                checkBoxcotizacion.Checked = false;

                string firstfour = Name.Substring(0, 2);
                txtorden.Text = firstfour;

                string iniciodepedidos = pedido.Substring(0, 2);



                //generacion  de numero aleatorio de orden
                var guid = Guid.NewGuid();
                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 9));
                var random = new Random(seed);

                txtpruibea.Text = seed.ToString();

                txtorden.Text = iniciodepedidos + "-" + firstfour + seed.ToString();

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into revisiones (orden,tipopedido,nombre,numero,observaciones,horayfecha) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobservaciones.Text + "','" + txthorayfecha.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }






            }

            //generacion de numero de orden
            
            
           


           
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into clientes (orden,tipopedido,nombre,numero,observaciones,horayfecha) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobservaciones.Text + "','" + txthorayfecha.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Guardados");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            String todo = "";
            String destino = "erick.tadeo@hotmail.com";
            string salto = "    Numero:  ";
            String obser = " \n   Observaciones:  ";
             
           
            todo = salto + txtnumero.Text + obser +txtobservaciones.Text + "\n    Hora y Fecha:   "+ txthorayfecha.Text;
            Console.WriteLine(todo);
            string asunto = txtnombre.Text + "   "+ pedido + " Orden: "+txtorden.Text;
            c.enviarCorreo(txtEmisor.Text, txtPassword.Text,todo,asunto,destino);
            /*txtnombre.Text = "";
            txtnumero.Text = "";
            txtobservaciones.Text = "";
            txtorden.Text = "";
            checkBoxpedido.Checked = false;
            checkBoxcotizacion.Checked = false;
            checkBoxrevision.Checked = false;*/




        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txthorayfecha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxpedido_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpedido.Checked == true)
            {
                txtnombre.Enabled = true;
                checkBoxcotizacion.Checked = false;
                checkBoxrevision.Checked = false;
            }
        }

        private void checkBoxcotizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcotizacion.Checked == true)
            {
                txtnombre.Enabled = true;

                checkBoxpedido.Checked = false;
                checkBoxrevision.Checked = false;
            }
            
        }

        private void checkBoxrevision_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxrevision.Checked == true)
            {
                txtnombre.Enabled = true;

                checkBoxcotizacion.Checked = false;
                checkBoxpedido.Checked = false;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnumero.Enabled = true;
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            txtobservaciones.Enabled = true;
        }

        private void txtobservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string templatePath = TEMPLATE_DIRECTORY;
            // None decoration frame
            if (cmbTemplate.SelectedIndex == 0)
            {
                templatePath += TEMPLATE_SIMPLE;
            }
            // Decoration frame
            else
            {
                templatePath += TEMPLATE_FRAME;
            }

            bpac.DocumentClass doc = new DocumentClass();
            if (doc.Open(templatePath) != false)
            {
                doc.GetObject("objCompany").Text = txtnombre.Text;
                doc.GetObject("objName").Text = txtnumero.Text;
                // doc.SetMediaById(doc.Printer.GetMediaId(), true);
                doc.StartPrint("", PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            else
            {
                MessageBox.Show("Open() Error: " + doc.ErrorCode);
            }*/
            BrotherPrintThis();
            Imprimirrecibo();
          



            txtnombre.Text = "";
            txtnumero.Text = "";
            txtobservaciones.Text = "";
            txtorden.Text = "";
            checkBoxpedido.Checked = false;
            checkBoxcotizacion.Checked = false;
            checkBoxrevision.Checked = false;

        }

        public void BrotherPrintThis()
        {
            try
            {     
                string path = @"E:\EBEST\cartaebest.lbx";

                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                bool test = doc.SetPrinter("Brother QL - 800", true);
                string pedido2 = "Tipo pedido: "+ pedido;
                string nombre = "Nombre: "+ txtnombre.Text;
                string numero = "Numero: "+ txtnumero.Text;
                string obser = "Obs.: " + txtobservaciones.Text;
                string orden = "Numero orden: "+ txtorden.Text;
                doc.GetObject("pedido").Text = pedido2;
                doc.GetObject("nombre").Text = nombre;
                doc.GetObject("numero").Text = numero;
                doc.GetObject("obser").Text = obser;
                doc.GetObject("orden").Text = orden;
                doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
              
            }
        }
        
        public void Imprimirrecibo()
        {
            try
            {
                CreaTicket Ticket1 = new CreaTicket();
                Ticket1.AbreCajon();  //abre el cajon
                Ticket1.TextoCentro("E-BEST"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoIzquierda("Nombre: " + txtnombre.Text);
                Ticket1.TextoIzquierda("Numero: " + txtnumero.Text);
                Ticket1.TextoIzquierda("Descripcion: " + txtobservaciones.Text);
                Ticket1.TextoIzquierda("Costo: " + txtcosto.Text);
                Ticket1.TextoIzquierda("Abono: " + txtabono.Text);
                Ticket1.TextoIzquierda("Restante: " + txtrestante.Text);
                Ticket1.LineasGuion(); // imprime una linea de guiones
                Ticket1.TextoIzquierda("Fecha: " + txthorayfecha.Text);
                //Ticket1.LineasGuion(); // imprime una linea de guiones
                //Ticket1.EncabezadoVenta(); // imprime encabezados
                // Ticket1.AgregaArticulo(descripcion, cantidad, precio, total); //imprime una linea de descripcion
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("Orden: " + txtorden.Text);
                Ticket1.LineasIgual();


                //Ticket1.LineasTotales(); // imprime linea
                //Ticket1.AgregaTotales("Total", total); // imprime linea con total
                Ticket1.CortaTicket(); // corta el ticket

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtrestante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabono_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcosto.Text != null && txtabono.Text != null)
                            {
                                int a = Convert.ToInt32(txtcosto.Text);
                                int b = Convert.ToInt32(txtabono.Text);
                                int c = a - b;
                                txtrestante.Text = c.ToString();
                            }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            
            
        }
    }
}
