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
using System.Globalization;
using ZXing;
using System.Net.Http.Headers;

using IronBarCode;


namespace EBEST
{
    public partial class crearrevision : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        Correo c = new Correo();

        public crearrevision()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\EBEST-AB78DLU\ebest\Ebest_be.accdb; Persist Security Info=False;";
            timer1.Enabled = true;
        }
        String pedido = "";    

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(txtnombre.Text);
            //System.IO.File.Copy(@"\\TADEOEBEST\basededatoscompartida\Ebest_be.accdb", @"C:\Users\Windows 10\Desktop\respaldo\Ebest_be.accdb",true);
            sincopia:
            string Name = txtnombre.Text;
            var rand = new Random();
            pedido = "Revision";
            //checkBoxcotizacion.Checked = false;
            ///checkBoxrevision.Checked = false;
            string firstfour = Name.Substring(0, 2);
            txtorden2.Text = firstfour;
            string iniciodepedidos = pedido.Substring(0, 2);
            //generacion  de numero aleatorio de orden
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 9));
            var random = new Random(seed);

            txtpruibea.Text = seed.ToString();

            txtorden.Text = iniciodepedidos + firstfour + seed.ToString();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from revisiones Where orden like ('" + txtorden.Text + "%')";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtrepetidos.Text = Convert.ToString(reader["orden"]);


                    reader.Close();

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            if (txtorden.Text == txtrepetidos.Text)
            {
                MessageBox.Show("Se repitio la orden");
                goto sincopia;
                
            }
            else
             {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if(checkBox2.Checked == true)
                {
                command.CommandText = "insert into revisiones (orden,tipopedido,nombre,numero,horayfecha,modelo,descripcion,espera) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "','" + txtobservaciones.Text + "','" + combodias.Text + "')";
                command.ExecuteNonQuery();
                }
                else if(checkBox3.Checked == true)
                {
                 command.CommandText = "insert into revisiones (orden,tipopedido,nombre,numero,horayfecha,modelo,descripcion,espera) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "','" + txtobservaciones.Text + "','" + combohoras.Text + "')";
                 command.ExecuteNonQuery();
                }

                command.CommandText = "insert into clientes (orden,tipopedido,nombre,numero,observaciones,horayfecha,modelo) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobservaciones.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cliente guardado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
                c.enviarCorreo(txtEmisor.Text, txtPassword.Text, "Hora: " + txthorayfecha.Text +"\n Nombre: "+txtnombre.Text+"\nNumero: "+ txtnumero.Text+"\nModelo: "+ txtmodelo.Text+"\n Descripcion: "+txtobservaciones.Text+"\n Orden: "+txtorden.Text,txtnombre.Text + " " +txtmodelo.Text + " "+ txtorden.Text , "ebest-clientes@outlook.com");

                ZXing.BarcodeWriter br = new ZXing.BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write("http:sexto-a.epizy.com/"+txtorden.Text), 150, 150);
                pictureBox1.Image = bm;


                ZXing.BarcodeWriter bre = new ZXing.BarcodeWriter();
                bre.Format = BarcodeFormat.CODE_128;
                
                Bitmap bm2 = new Bitmap(bre.Write(txtorden.Text), 150, 50);
                //pictureBox2.Image = bm2;




                GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode(txtorden.Text, BarcodeWriterEncoding.Code128);
                MyBarCode.ResizeTo(150, 50).SetMargins(0);
                Bitmap MyBarCodeBitmap = MyBarCode.ToBitmap();

                //pictureBox1.Image = MyBarCodeBitmap;
                pictureBox2.Image = MyBarCode.Image;


                //Imprimirrecibo();

                //printPreviewDialog1.Document = printDocument1;
                BrotherPrintThis();

                printDocument1.Print();
             


                //printPreviewDialog1.Show();

                //printDocument1.Print();


            }


        }

        public void BrotherPrintThis()
        {
            try
            {
                string path = @"D:\EBEST\cartaebest3.lbx";
                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                bool test = doc.SetPrinter("Brother QL - 800", true);
                string pedido2 = "Tipo pedido: " + pedido;
                string nombre = "Nombre: " + txtnombre.Text;
                string numero = "Numero: " + txtnumero.Text;
                string obser = "Obs.: " + txtobservaciones.Text;
                string orden = "Numero orden: " + txtorden.Text;
                string orden2 = txtorden.Text;
                doc.GetObject("pedido").Text = pedido2;
                doc.GetObject("nombre").Text = nombre;
                doc.GetObject("numero").Text = numero;
                doc.GetObject("modelo").Text = "Modelo: "+ txtmodelo.Text;
                doc.GetObject("fecha").Text = txthorayfecha.Text;
                doc.GetObject("obser").Text = obser;
                //doc.GetObject("orden").Text = orden;
                doc.GetObject("codigo").Text = orden2;
                //doc.GetObject("tiempo").Text = espera;
                doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        public void Imprimirrecibo()
        {
            try
            {
                CreaTicket Ticket1 = new CreaTicket();
                Ticket1.AbreCajon();  //abre el cajon
                Ticket1.TextoCentro("Revision"); // imprime en el centro "Venta mostrador"
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("E-BEST"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("Servicio y solucion en tecnologia"); // imprime en el centro "Venta mostrador"
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("GUGE900514C70"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("Calle Pedro J. Mendez No.  1082-A OTE."); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("Reynosa Tamaulipas"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("88500"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("e-best@live.com.mx"); // imprime en el centro "Venta mostrador"
                Ticket1.TextoCentro("8999222312"); // imprime en el centro "Venta mostrador"
                Ticket1.LineasGuion(); // imprime una linea de guiones
                Ticket1.TextoIzquierda("Fecha: " + txthorayfecha.Text);
                Ticket1.TextoIzquierda("Nombre: " + txtnombre.Text);
                //Ticket1.TextoIzquierda("Cantidad: " + txtcantidad.Text)
                ;
                Ticket1.TextoIzquierda("Modelo: " + txtmodelo.Text);

                //Ticket1.TextoIzquierda("Descripcion: " + txtobservaciones.Text);
                //Ticket1.TextoIzquierda("Importe: " + txtcosto.Text);
                //Ticket1.TextoIzquierda("Abono: " + txtabono.Text);
                //Ticket1.TextoIzquierda("Total: " + txtrestante.Text);
                //Ticket1.TextoCentro("Tiempo de espera: " + espera);
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("Orden: " + txtorden.Text);
                Ticket1.LineasIgual();
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("Diagnostico");
                Ticket1.TextoCentro("gratis ");

                Ticket1.LineasIgual();
                //Ticket1.TextoIzquierda("Numero: " + txtnumero.Text);
                //Ticket1.LineasGuion(); // imprime una linea de guiones
                //Ticket1.TextoIzquierda("Fecha: " + txthorayfecha.Text);
                //Ticket1.LineasGuion(); // imprime una linea de guiones
                //Ticket1.EncabezadoVenta(); // imprime encabezados
                // Ticket1.AgregaArticulo(descripcion, cantidad, precio, total); //imprime una linea de descripcion
                ;
                


                //Ticket1.LineasTotales(); // imprime linea
                //Ticket1.AgregaTotales("Total", total); // imprime linea con total
                Ticket1.CortaTicket(); // corta el ticket

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txthorayfecha.Text = DateTime.Now.ToString();
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();



            txthorayfecha.Text = fecha + "  "+hora;

        }

        private void crearrevision_Load(object sender, EventArgs e)
        {
            txtEmisor.Text = "ebestprueba@gmail.com";
            txtPassword.Text = "ebest1234";
            combodias.Text = "1 día";
            combohoras.Text = "1 hora";
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            //txtnombre.Text = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtnombre.Text.ToLower()));
            //txtnombre.Text = (CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtnombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtnombre.SelectionStart = txtnombre.Text.Length;
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {


            if (txtmodelo.Text == "")
            {

            }
            else
            {
                string upmodelo = txtmodelo.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtmodelo.Text = upmodelo;
                txtmodelo.SelectionStart = txtmodelo.Text.Length;
            }
        }

        private void txtobservaciones_TextChanged(object sender, EventArgs e)
        {
            if (txtobservaciones.Text == "")
            {

            }
            else
            {
                string upmodelo = txtobservaciones.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtobservaciones.Text = upmodelo;
                txtobservaciones.SelectionStart = txtobservaciones.Text.Length;
            }

            



        }

        private void crearrevision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnimprimir_Click(sender, e);
            }
        }

        private void btnimprimir2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image newImage = Image.FromFile(@"D:\ebestimprimr4.jpg");

            
            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("   Equipo en  revisión", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 150));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 180));
            e.Graphics.DrawString("     Calle Pedro J. Méndez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 200));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 240));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 260));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 300));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("      Modelo: " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            else if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 410));
            e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 435));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 450));
            e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 475));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 490));
            e.Graphics.DrawImage(pictureBox2.Image, 70, 520);

           // e.Graphics.DrawImage(pictureBox1.Image, 70, 600);
            
        }

        private void txtnumero_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else if(checkBox2.Checked == false && checkBox3.Checked == false)
            {
                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
            else if (checkBox2.Checked == false && checkBox3.Checked == false)
            {
                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;

            }
            else
            {
                checkBox3.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
        }

      
    }
}
