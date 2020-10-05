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
using System.Globalization;
using bpac;
using ZXing;
using System.Net.Http.Headers;
using IronBarCode;

namespace EBEST
{
    public partial class crearcotizacion : Form
    {
        String pedido = "";

        string espera = "";
        private OleDbConnection connection = new OleDbConnection();
        //private const string TEMPLATE_DIRECTORY = @"C:\Program Files\Brother bPAC3 SDK\Templates\"; // Template file path
        //private const string TEMPLATE_SIMPLE = "NamePlate1.LBX";    // Template file name
        //private const string TEMPLATE_FRAME = "NamePlate2.LBX";		// Template file name
        Correo c = new Correo();
        public crearcotizacion()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\TADEOEBEST\basededatoscompartida\Ebest_be.accdb; Persist Security Info=False;";
            timer1.Enabled = true;

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
        
            sincopia:
            string Name = txtnombre.Text;
            var rand = new Random();


            pedido = "Cotizacion";
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
                //txtorden.Text = "Reer548621579";
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
                                       command.CommandText = "insert into cotizaciones (orden,tipopedido,nombre,numero,horayfecha,modelo,parte1,precioparte1,parte2,precioparte2,parte3,precioparte3,parte4,precioparte4,parte5,precioparte5,parte6,precioparte6,importe,Espera) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "','" + txtparte1.Text + "','" + txtprecioparte1.Text + "','" + txtparte2.Text + "','" + txtprecioparte2.Text + "','" + txtparte3.Text + "','" + txtparteprecio3.Text + "','" + txtparte4.Text + "','" + txtparteprecio4.Text + "','" + txtparte5.Text + "','" + txtparteprecio5.Text + "','" + txtparte6.Text + "','" + txtparteprecio6.Text + "','" + txtcosto.Text + "','" + combodias.Text + "')";
                                       command.ExecuteNonQuery();
                                    }
                                   else if (checkBox1.Checked == true)
                                    {
                                        command.CommandText = "insert into cotizaciones (orden,tipopedido,nombre,numero,horayfecha,modelo,parte1,precioparte1,parte2,precioparte2,parte3,precioparte3,parte4,precioparte4,parte5,precioparte5,parte6,precioparte6,importe,Espera) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "','" + txtparte1.Text + "','" + txtprecioparte1.Text + "','" + txtparte2.Text + "','" + txtprecioparte2.Text + "','" + txtparte3.Text + "','" + txtparteprecio3.Text + "','" + txtparte4.Text + "','" + txtparteprecio4.Text + "','" + txtparte5.Text + "','" + txtparteprecio5.Text + "','" + txtparte6.Text + "','" + txtparteprecio6.Text + "','" + txtcosto.Text + "','" + combohoras.Text + "')";
                                        command.ExecuteNonQuery();
                                    }
                                     command.CommandText = "insert into clientes (orden,tipopedido,nombre,numero,observaciones,horayfecha,modelo) values ('" + txtorden.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobservaciones.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "')";
                                     command.ExecuteNonQuery();
                                     connection.Close();
                                    MessageBox.Show("Datos Guardados de lo nuevo");


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex);
                            }
                            String todo = "";
                            String destino = "erick.tadeo@hotmail.com";
                            string salto = "    Numero:  ";

                            //String obser = " \n   Observaciones:  ";


                            todo = salto + txtnumero.Text + "\n Nombre: " + txtnombre.Text +"\n    Hora y Fecha:   " + txthorayfecha.Text;
                            //Console.WriteLine(todo);
                            string asunto = txtnombre.Text + "   " + pedido + " Orden: " + txtorden.Text;
                            c.enviarCorreo(txtEmisor.Text, txtPassword.Text, todo, asunto, destino);


                GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode(txtorden.Text, BarcodeWriterEncoding.Code128);
                MyBarCode.ResizeTo(150, 50).SetMargins(0);
                Bitmap MyBarCodeBitmap = MyBarCode.ToBitmap();

                //pictureBox1.Image = MyBarCodeBitmap;
                pictureBox2.Image = MyBarCode.Image;
                /*txtnombre.Text = "";
                txtnumero.Text = "";
                txtobservaciones.Text = "";
                txtorden.Text = "";
                checkBoxpedido.Checked = false;
                checkBoxcotizacion.Checked = false;
                checkBoxrevision.Checked = false;*/

                int lonp1 = txtprecioparte1.Text.Length;
                int lonp2 = txtprecioparte2.Text.Length;
                int lonp3 = txtparteprecio3.Text.Length;
                int lonp4 = txtparteprecio4.Text.Length;
                int lonp5 = txtparteprecio5.Text.Length;
                int lonp6 = txtparteprecio6.Text.Length;
                int loncosto = txtcosto.Text.Length;

                if (lonp1 == 1)
                {
                    txtprecioparte1.Text = "        " + txtprecioparte1.Text;
                }
                else if (lonp1 == 2)
                {
                    txtprecioparte1.Text = "      " + txtprecioparte1.Text;
                }
                else if (lonp1 == 3)
                {
                    txtprecioparte1.Text = "    " + txtprecioparte1.Text;
                }
                else if (lonp1 == 4)
                {
                    txtprecioparte1.Text = "  " + txtprecioparte1.Text;
                }



                if (lonp2 == 1)
                {
                    txtprecioparte2.Text = "        " + txtprecioparte2.Text;
                }
                else if (lonp2 == 2)
                {
                    txtprecioparte2.Text = "      " + txtprecioparte2.Text;
                }
                else if (lonp2 == 3)
                {
                    txtprecioparte2.Text = "    " + txtprecioparte2.Text;
                }
                else if (lonp2 == 4)
                {
                    txtprecioparte2.Text = "  " + txtprecioparte2.Text;
                }


                if (lonp3 == 1)
                {
                    txtparteprecio3.Text = "        " + txtparteprecio3.Text;
                }
                else if (lonp3 == 2)
                {
                    txtparteprecio3.Text = "      " + txtparteprecio3.Text;
                }
                else if (lonp3 == 3)
                {
                    txtparteprecio3.Text = "    " + txtparteprecio3.Text;
                }
                else if (lonp3 == 4)
                {
                    txtparteprecio3.Text = "  " + txtparteprecio3.Text;
                }


                if (lonp4 == 1)
                {
                    txtparteprecio4.Text = "        " + txtparteprecio4.Text;
                }
                else if (lonp4 == 2)
                {
                    txtparteprecio4.Text = "      " + txtparteprecio4.Text;
                }
                else if (lonp4 == 3)
                {
                    txtparteprecio4.Text = "    " + txtparteprecio4.Text;
                }
                else if (lonp4 == 4)
                {
                    txtparteprecio4.Text = "  " + txtparteprecio4.Text;
                }

                if (lonp5 == 1)
                {
                    txtparteprecio5.Text = "        " + txtparteprecio5.Text;
                }
                else if (lonp5 == 2)
                {
                    txtparteprecio5.Text = "      " + txtparteprecio5.Text;
                }
                else if (lonp5 == 3)
                {
                    txtparteprecio5.Text = "    " + txtparteprecio5.Text;
                }
                else if (lonp5 == 4)
                {
                    txtparteprecio5.Text = "  " + txtparteprecio5.Text;
                }


                if (lonp6 == 1)
                {
                    txtparteprecio6.Text = "        " + txtparteprecio6.Text;
                }
                else if (lonp6 == 2)
                {
                    txtparteprecio6.Text = "      " + txtparteprecio6.Text;
                }
                else if (lonp6 == 3)
                {
                    txtparteprecio6.Text = "    " + txtparteprecio6.Text;
                }
                else if (lonp6 == 4)
                {
                    txtparteprecio6.Text = "  " + txtparteprecio6.Text;
                }

                if (loncosto == 1)
                {
                    txtcosto.Text = "        " + txtcosto.Text;
                }
                else if (loncosto == 2)
                {
                    txtcosto.Text = "      " + txtcosto.Text;
                }
                else if (loncosto == 3)
                {
                    txtcosto.Text = "    " + txtcosto.Text;
                }
                else if (loncosto == 4)
                {
                    txtcosto.Text = "  " + txtcosto.Text;
                }

                BrotherPrintThis();
                //printPreviewDialog1.Document = printDocument1;
                printDocument1.Print();
                //printDocument1.Print();

                //printPreviewDialog1.Show();



            }



            
        }

        private void crearcotizacion_Load(object sender, EventArgs e)
        {
            txtEmisor.Text = "ebestprueba@gmail.com";
            txtPassword.Text = "ebest1234";
            combodias.Text = "1 día";
            combohoras.Text = "1 hora";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();



            txthorayfecha.Text = fecha + "  " + hora;

        }

        private void btnimprimir2_Click(object sender, EventArgs e)
        {
            //BrotherPrintThis();
            Imprimirrecibo();
            txtnombre.Text = "";
            txtnumero.Text = "";
            txtobservaciones.Text = "";
            txtorden.Text = "";
        }


        public void BrotherPrintThis()
        {
            try
            {
                string path = @"D:\EBEST\cartaebest.lbx";

                bpac.Document doc = new bpac.Document();
                doc.Open(path);
                bool test = doc.SetPrinter("Brother QL - 800", true);
                string pedido2 = "Tipo pedido: " + pedido;
                string nombre = "Nombre: " + txtnombre.Text;
                string numero = "Numero: " + txtnumero.Text;
                string obser =  txtobservaciones.Text;
                string orden = "Numero orden: " + txtorden.Text;
                string orden2 = txtorden.Text;
                doc.GetObject("pedido").Text = pedido2;
                doc.GetObject("nombre").Text = nombre;
                doc.GetObject("numero").Text = numero;
                doc.GetObject("obser").Text = obser;
                //doc.GetObject("orden").Text = orden;
                doc.GetObject("codigo").Text = orden2;
                doc.GetObject("tiempo").Text = espera;
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
                Ticket1.TextoCentro("PEDIDO"); // imprime en el centro "Venta mostrador"
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
                Ticket1.TextoIzquierda("Cantidad: " + txtcantidad.Text);
                Ticket1.TextoIzquierda("Descripcion: " + txtobservaciones.Text);
                //Ticket1.TextoIzquierda("Importe: " + txtcosto.Text);
                //Ticket1.TextoIzquierda("Abono: " + txtabono.Text);
                //Ticket1.TextoIzquierda("Total: " + txtrestante.Text);
                //Ticket1.TextoCentro("Tiempo de espera: " + espera);
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("Orden: " + txtorden.Text);
                Ticket1.LineasIgual();
                Ticket1.LineasIgual();
                Ticket1.TextoCentro("No es un comprobante fiscal ");
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

        private void txtprecioparte1_TextChanged(object sender, EventArgs e)
        {
            txtcosto.Text = txtprecioparte1.Text.ToString();

        }

        private void txtprecioparte2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprecioparte1.Text != null && txtprecioparte2.Text != null)
                {
                    int suma1 = Convert.ToInt32(txtprecioparte1.Text);

                    if (txtprecioparte2.Text == "")
                    {
                        //MessageBox.Show("Introduce una cantidad");
                        //txtprecioparte2.Text = "0";


                    }
                    else
                    {
                        int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                        int res1 = suma1 + suma2;
                        txtcosto.Text = res1.ToString();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtparteprecio3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprecioparte1.Text != null && txtprecioparte2.Text != null && txtparteprecio3.Text != null)
                {
                    int suma1 = Convert.ToInt32(txtprecioparte1.Text);

                    if (txtparteprecio3.Text == "")
                    {
                        //MessageBox.Show("Introduce una cantidad");
                        //txtparteprecio3.Text = "0";

                    }
                    else
                    {
                        int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                        int suma3 = Convert.ToInt32(txtparteprecio3.Text);

                        int res1 = suma1 + suma2 + suma3;
                        txtcosto.Text = res1.ToString();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtparteprecio4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprecioparte1.Text != null && txtprecioparte2.Text != null && txtparteprecio3.Text != null && txtparteprecio4.Text != null)
                {
                    int suma1 = Convert.ToInt32(txtprecioparte1.Text);

                    if (txtparteprecio4.Text == "")
                    {
                        //MessageBox.Show("Introduce una cantidad");
                        //txtparteprecio4.Text = "0";

                    }
                    else
                    {
                        int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                        int suma3 = Convert.ToInt32(txtparteprecio3.Text);
                        int suma4 = Convert.ToInt32(txtparteprecio4.Text);


                        int res1 = suma1 + suma2 + suma3 + suma4;
                        txtcosto.Text = res1.ToString();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtparteprecio5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprecioparte1.Text != null && txtprecioparte2.Text != null && txtparteprecio3.Text != null && txtparteprecio4.Text != null && txtparteprecio5.Text != null)
                {
                    int suma1 = Convert.ToInt32(txtprecioparte1.Text);

                    if (txtparteprecio5.Text == "")
                    {
                       // MessageBox.Show("Introduce una cantidad");
                        //txtparteprecio5.Text = "0";

                    }
                    else
                    {
                        int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                        int suma3 = Convert.ToInt32(txtparteprecio3.Text);
                        int suma4 = Convert.ToInt32(txtparteprecio4.Text);
                        int suma5 = Convert.ToInt32(txtparteprecio5.Text);


                        int res1 = suma1 + suma2 + suma3 + suma4 + suma5;
                        txtcosto.Text = res1.ToString();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txtparteprecio6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtprecioparte1.Text != null && txtprecioparte2.Text != null && txtparteprecio3.Text != null && txtparteprecio4.Text != null && txtparteprecio5.Text != null && txtparteprecio6.Text != null)
                {
                    int suma1 = Convert.ToInt32(txtprecioparte1.Text);

                    if (txtparteprecio6.Text == "")
                    {
                        //MessageBox.Show("Introduce una cantidad");
                        //txtparteprecio6.Text = "0";

                    }

                    else
                    {
                        int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                        int suma3 = Convert.ToInt32(txtparteprecio3.Text);
                        int suma4 = Convert.ToInt32(txtparteprecio4.Text);
                        int suma5 = Convert.ToInt32(txtparteprecio5.Text);
                        int suma6 = Convert.ToInt32(txtparteprecio6.Text);


                        int res1 = suma1 + suma2 + suma3 + suma4 + suma5 + suma6;
                        txtcosto.Text = res1.ToString();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label9.Visible = true;
                label10.Visible = true;
                txtparte2.Visible = true;
                txtprecioparte2.Visible = true;



            }
            else
            {
                label9.Visible = false;
                label10.Visible = false;
                txtparte2.Visible = false;
                txtprecioparte2.Visible = false;
                //reecalcular();
                //txtabono_TextChanged(sender, e);
                txtparte2.Text = "";
                txtprecioparte2.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                label11.Visible = true;
                label12.Visible = true;
                txtparte3.Visible = true;
                txtparteprecio3.Visible = true;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
                txtparte3.Text = "";
                txtparteprecio3.Text = "0";

            }
            else
            {
                label11.Visible = false;
                label12.Visible = false;
                txtparte3.Visible = false;
                txtparteprecio3.Visible = false;
                txtparte3.Text = "";

                txtparteprecio3.Text = "0";

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
            {
                label13.Visible = true;
                label14.Visible = true;
                txtparte4.Visible = true;
                txtparteprecio4.Visible = true;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == true)
            {
                checkBox5.Checked = false;
                txtparte4.Text = "";
                txtparteprecio4.Text = "0";
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == true)
            {
                checkBox5.Checked = false;
                txtparte4.Text = "";

                txtparteprecio4.Text = "0";

            }

            else
            {
                label13.Visible = false;
                label14.Visible = false;
                txtparte4.Visible = false;
                txtparteprecio4.Visible = false;
                txtparte4.Text = "";

                txtparteprecio4.Text = "0";

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true)
            {
                label15.Visible = true;
                label16.Visible = true;
                txtparte5.Visible = true;
                txtparteprecio5.Visible = true;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == true)
            {
                checkBox6.Checked = false;
                txtparte5.Text = "";

                txtparteprecio5.Text = "0";
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == true)
            {
                checkBox6.Checked = false;
                txtparte5.Text = "";

                txtparteprecio5.Text = "0";

            }

            else
            {
                label15.Visible = false;
                label16.Visible = false;
                txtparte5.Visible = false;
                txtparteprecio5.Visible = false;
                txtparte5.Text = "";

                txtparteprecio5.Text = "0";

            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true && checkBox6.Checked == true && checkBox7.Checked == true)
            {
                label17.Visible = true;
                label18.Visible = true;
                txtparte6.Visible = true;
                txtparteprecio6.Visible = true;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == true && checkBox7.Checked == true)
            {
                checkBox7.Checked = false;
                txtparte6.Text = "";      
                txtparteprecio6.Text = "0";
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == true)
            {
                checkBox7.Checked = false;
                txtparte6.Text = "";
                txtparteprecio6.Text = "0";
            }

            else
            {
                label17.Visible = false;
                label18.Visible = false;
                txtparte6.Visible = false;
                txtparteprecio6.Visible = false;
                txtparte6.Text = "";

                txtparteprecio6.Text = "0";

            }
        }

        private void txtprecioparte1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprecioparte2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtparteprecio3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtparteprecio4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtparteprecio5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtparteprecio6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprecioparte1_Click(object sender, EventArgs e)
        {
            if (txtprecioparte1.Text == "0")
            {
            txtprecioparte1.Text = "";

            }
        }

        private void txtprecioparte2_Click(object sender, EventArgs e)
        {
            if (txtprecioparte2.Text == "0")
            txtprecioparte2.Text = "";
        }

        private void txtparteprecio3_Click(object sender, EventArgs e)
        {
            if (txtparteprecio3.Text == "0")
            txtparteprecio3.Text = "";
        }

        private void txtparteprecio4_Click(object sender, EventArgs e)
        {
            if (txtparteprecio4.Text == "0")
            txtparteprecio4.Text = "";

        }

        private void txtparteprecio5_Click(object sender, EventArgs e)
        {
            if (txtparteprecio5.Text == "0")
            txtparteprecio5.Text = "";

        }

        private void txtparteprecio6_Click(object sender, EventArgs e)
        {
            if (txtparteprecio6.Text == "0")
            txtparteprecio6.Text = "";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else if (checkBox2.Checked == false && checkBox1.Checked == false)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                combodias.Visible = false;
                combohoras.Visible = true;
            }
            else if (checkBox2.Checked == false && checkBox1.Checked == false)
            {

                checkBox2.Checked = true;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
            else
            {
                checkBox1.Checked = false;
                combodias.Visible = true;
                combohoras.Visible = false;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {

            }
            else
            {
            txtnombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text);
            txtnombre.SelectionStart = txtnombre.Text.Length;
            }
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {   

            Image newImage = Image.FromFile(@"D:\ebestimprimr4.jpg");

            
            printDocument1.PrinterSettings.PrinterName = "TM-T20II";

            // Create rectangle for source image.
            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 150.0F, 150.0F);
            e.Graphics.DrawImage(newImage, 30, 2);

            //e.Graphics.DrawImageUnscaledAndClipped(newImage,new Point(10,10));
            e.Graphics.DrawString("  Equipo en  cotización", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
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
            if (checkBox8.Checked == true && checkBox2.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            else if (checkBox8.Checked == true && checkBox3.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }


            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 405));



            if (checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false)
            {
                e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("    Descripcion " , new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("    "+txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                                      $"+txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                            Total: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 500));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 520));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 545));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 565));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 595);








               /* e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 535));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 550));*/
               
            }

               
            else if(checkBox3.Checked == true && txtparte2.Text !="" && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false)
            {
                int lon1 = txtprecioparte1.Text.Length;
                int lon2 = txtprecioparte2.Text.Length;

                e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("    Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("    " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                                      $" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                
                
                e.Graphics.DrawString("    " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                e.Graphics.DrawString("                                                      $" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));





                e.Graphics.DrawString("                                            Total: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 520));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 540));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 565));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 610);








                /* e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                 e.Graphics.DrawString("      Parte 1: " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 450));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                 e.Graphics.DrawString("      Parte 2: " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
              e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
              e.Graphics.DrawString("      Importe: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 550));
              e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 575));
              e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 590));
              e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 615));
              e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 630));
              e.Graphics.DrawImage(pictureBox2.Image, 70, 680);*/

            }
            else if (checkBox3.Checked == true && txtparte2.Text != "" && checkBox4.Checked == true && txtparte3.Text != "" && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false)
            {

                e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("    Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("    " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                                      $" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));


                e.Graphics.DrawString("    " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                e.Graphics.DrawString("                                                      $" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                e.Graphics.DrawString("    " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                e.Graphics.DrawString("                                                      $" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));






                e.Graphics.DrawString("                                            Total: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 540));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 560));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 585));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 635);







                /*e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                 e.Graphics.DrawString("      Parte 1: " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 450));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                 e.Graphics.DrawString("      Parte 2: " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                 e.Graphics.DrawString("      Parte 3: " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                 e.Graphics.DrawString("      Importe: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 570));

                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 590));
                 e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 615));
                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 630));
                 e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 655));
                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 670));
                 e.Graphics.DrawImage(pictureBox2.Image, 70, 720);*/
            }

            else if (checkBox3.Checked == true && txtparte2.Text != "" && checkBox4.Checked == true && txtparte3.Text != "" && checkBox5.Checked == true && txtparte4.Text != "" && checkBox6.Checked == false && checkBox7.Checked == false)
            {

                e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("    Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("    " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                                      $" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));


                e.Graphics.DrawString("    " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                e.Graphics.DrawString("                                                      $" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                e.Graphics.DrawString("    " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                e.Graphics.DrawString("                                                      $" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

               

                e.Graphics.DrawString("    " + txtparte4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                e.Graphics.DrawString("                                                      $" + txtparteprecio4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));

                e.Graphics.DrawString("                                            Total: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 560));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 580));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 605));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 655);

                /* e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                 e.Graphics.DrawString("      Parte 1: " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 450));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                 e.Graphics.DrawString("      Parte 2: " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                 e.Graphics.DrawString("      Parte 3: " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                 e.Graphics.DrawString("      Parte 4: " + txtparte4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 570));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 590));



                 e.Graphics.DrawString("      Importe: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 610));

                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 630));
                 e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 655));
                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 670));
                 e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 695));
                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 710));
                 e.Graphics.DrawImage(pictureBox2.Image, 70, 760);*/
            }

            else if (checkBox3.Checked == true && txtparte2.Text != "" && checkBox4.Checked == true && txtparte3.Text != "" && checkBox5.Checked == true && txtparte4.Text != "" && checkBox6.Checked == true && txtparte5.Text != "" && checkBox7.Checked == false)
            {

                e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("    Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("    " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                                      $" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));


                e.Graphics.DrawString("    " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                e.Graphics.DrawString("                                                      $" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                e.Graphics.DrawString("    " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                e.Graphics.DrawString("                                                      $" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

               

                e.Graphics.DrawString("    " + txtparte4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                e.Graphics.DrawString("                                                      $" + txtparteprecio4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));



                e.Graphics.DrawString("    " + txtparte5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                e.Graphics.DrawString("                                                      $" + txtparteprecio5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));








                e.Graphics.DrawString("                                            Total: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 580));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 600));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 625));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 675);








               /* e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("      Parte 1: " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("      Parte 2: " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                e.Graphics.DrawString("      Parte 3: " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                e.Graphics.DrawString("      Parte 4: " + txtparte4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 570));
                e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 590));
                e.Graphics.DrawString("      Parte 5: " + txtparte5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 610));
                e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 630));


                e.Graphics.DrawString("      Importe: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 650));

                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 670));
                e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 695));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 710));
                e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 730));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 750));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 800);*/
            }

            else if (checkBox3.Checked == true && txtparte2.Text != "" && checkBox4.Checked == true && txtparte3.Text != "" && checkBox5.Checked == true && txtparte4.Text != "" && checkBox6.Checked == true && txtparte5.Text != "" && checkBox7.Checked == true && txtparte6.Text != "")
            {
                e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                e.Graphics.DrawString("    Descripcion ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("                                                      Importe ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 450));
                e.Graphics.DrawString("    " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                e.Graphics.DrawString("                                                      $" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));


                e.Graphics.DrawString("    " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                e.Graphics.DrawString("                                                      $" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));

                e.Graphics.DrawString("    " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                e.Graphics.DrawString("                                                      $" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));

                
                e.Graphics.DrawString("    " + txtparte4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                e.Graphics.DrawString("                                                      $" + txtparteprecio4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));



                e.Graphics.DrawString("    " + txtparte5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                e.Graphics.DrawString("                                                      $" + txtparteprecio5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));


                e.Graphics.DrawString("    " + txtparte6.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 570));
                e.Graphics.DrawString("                                                      $" + txtparteprecio6.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 570));








                e.Graphics.DrawString("                                            Total: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(5, 600));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 620));
                e.Graphics.DrawString("                      Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 645));
                e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 665));
                e.Graphics.DrawImage(pictureBox2.Image, 70, 695);










                /* e.Graphics.DrawString("                       PARTES ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 430));
                 e.Graphics.DrawString("      Parte 1: " + txtparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 450));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
                 e.Graphics.DrawString("      Parte 2: " + txtparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
                 e.Graphics.DrawString("      Precio: " + "$" + txtprecioparte2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
                 e.Graphics.DrawString("      Parte 3: " + txtparte3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 550));
                 e.Graphics.DrawString("      Parte 4: " + txtparte4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 570));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 590));
                 e.Graphics.DrawString("      Parte 5: " + txtparte5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 610));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 630));
                 e.Graphics.DrawString("      Parte 6: " + txtparte6.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 650));
                 e.Graphics.DrawString("      Precio: " + "$" + txtparteprecio6.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 670));


                 e.Graphics.DrawString("      Importe: " + "$" + txtcosto.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 690));

                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 710));
                 e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 730));
                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 750));
                 e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 775));
                 e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 790));
                 e.Graphics.DrawImage(pictureBox2.Image, 70, 840);*/
            }














            /* e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 410));
             e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 435));
             e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 450));
             e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
             e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 490));
             e.Graphics.DrawImage(pictureBox1.Image, 70, 530);*/

            // e.Graphics.DrawImage(pictureBox1.Image, 70, 600);
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

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

            if(txtmodelo.Text == "")
            {

            }
            else
            {
            string upmodelo = txtmodelo.Text;
            upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
            txtmodelo.Text = upmodelo;
                txtmodelo.SelectionStart = txtmodelo.Text.Length;
            }
            



           /* txtnombre.Text = CultureInfo.ToTitleCase(txtnombre.Text);
            txtnombre.SelectionStart = txtnombre.Text.Length;*/
        }

        private void txtparte1_TextChanged(object sender, EventArgs e)
        {
            if (txtparte1.Text == "")
            {

            }
            else
            {
                string upmodelo = txtparte1.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtparte1.Text = upmodelo;
                txtparte1.SelectionStart = txtparte1.Text.Length;
            }

        }

        private void txtparte2_TextChanged(object sender, EventArgs e)
        {
            if (txtparte2.Text == "")
            {

            }
            else
            {
                string upmodelo = txtparte2.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtparte2.Text = upmodelo;
                txtparte2.SelectionStart = txtparte2.Text.Length;
            }

        }

        private void txtparte3_TextChanged(object sender, EventArgs e)
        {
            if (txtparte3.Text == "")
            {

            }
            else
            {
                string upmodelo = txtparte3.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtparte3.Text = upmodelo;
                txtparte3.SelectionStart = txtparte3.Text.Length;
            }

        }

        private void txtparte4_TextChanged(object sender, EventArgs e)
        {
            if (txtparte4.Text == "")
            {

            }
            else
            {
                string upmodelo = txtparte4.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtparte4.Text = upmodelo;
                txtparte4.SelectionStart = txtparte4.Text.Length;
            }

        }

        private void txtparte5_TextChanged(object sender, EventArgs e)
        {
            if (txtparte5.Text == "")
            {

            }
            else
            {
                string upmodelo = txtparte5.Text;
                upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
                txtparte5.Text = upmodelo;
                txtparte5.SelectionStart = txtparte5.Text.Length;
            }

        }

        private void txtparte6_TextChanged(object sender, EventArgs e)
        {

            if (txtparte6.Text == "")
            {

            }
            else
            {
            string upmodelo = txtparte6.Text;
            upmodelo = upmodelo.Substring(0, 1).ToUpper() + upmodelo.Substring(1).ToLower();
            txtparte6.Text = upmodelo;
            txtparte6.SelectionStart = txtparte6.Text.Length;
            }
           

        }
    }
}
