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
using ZXing;


namespace EBEST
{
    public partial class update : Form
    {
        string espera = "";

        String pedido = "";

        private OleDbConnection connection = new OleDbConnection();
        Correo c = new Correo();
        
        public update()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= \\TADEOEBEST\basededatoscompartida\Ebest_be.accdb; Persist Security Info=False;";

        }

        private void update_Load(object sender, EventArgs e)
        {
            
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
           /* timer1.Enabled = true;
            comboBoxbusqueda.Text = "Orden";
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
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* txtpedido.Enabled = true;
            txtnombre.Enabled  = true;
            txtnumero.Enabled = true;
            txtobser.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtorden.Text = row.Cells["orden"].Value.ToString();
                txtpedido.Text = row.Cells["tipopedido"].Value.ToString();
                txtnombre.Text = row.Cells["nombre"].Value.ToString();
                txtnumero.Text = row.Cells["numero"].Value.ToString();
                txtobser.Text = row.Cells["observaciones"].Value.ToString();


            }*/
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string iniciodepedidos = txtorden.Text.Substring(0, 2);
            txttipo.Text = iniciodepedidos;
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
                command.CommandText = "update clientes set tipopedido='"+ txtpedido.Text + "' , nombre='" + txtnombre.Text + "', numero='" + txtnumero.Text + "', observaciones='" + txtobser.Text + "'   where id=" + txtid.Text +"";
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Guardados3");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


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


            txtpedido.Text = "";
            txtnombre.Text = "";
            txtnumero.Text = ""; 
            txtobser.Text = "";

            txtpedido.Enabled = false;
            txtnombre.Enabled = false;
            txtnumero.Enabled = false;
            txtobser.Enabled = false;
        }
        string iniciodepedidos;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            


            /*label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtorden.Visible = true;
            txtpedido.Visible = true;
            txtnombre.Visible = true;
            txtnumero.Visible = true;
            txtobser.Visible = true;
            label19.Visible = true;
            txtmodelo.Visible = true;*/



            //txtcosto.Visible = true;





            txtpedido.Enabled = true;
            txtnombre.Enabled = true;
            txtnumero.Enabled = true;
            txtobser.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtorden.Text = row.Cells["orden"].Value.ToString();
                txtpedido.Text = row.Cells["tipopedido"].Value.ToString();
                txtnombre.Text = row.Cells["nombre"].Value.ToString();
                txtnumero.Text = row.Cells["numero"].Value.ToString();
                txtobser.Text = row.Cells["observaciones"].Value.ToString();
                txtmodelo.Text = row.Cells["modelo"].Value.ToString();


            }


            iniciodepedidos  = txtorden.Text.Substring(0, 2);
            txttipo.Text = iniciodepedidos;

            timer2.Enabled = false;




        }



        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtbusqueda.Text == "")
            {
                timer2.Enabled = true;
            }



            if (comboBoxbusqueda.Text == "Orden-SKU")
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

        private void comboBoxbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //btnupdate.Enabled = true;
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //btnupdate.Enabled = true;

        }

        private void txtobser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //btnupdate.Enabled = true;

        }

        private void btnpagado_Click(object sender, EventArgs e)
        {
            if (btnpagado.Text == "Pasar revision")
            {
                sincopia:
                string Name = txtnombre.Text;
                var rand = new Random();
                pedido = "Cotizacion";
                string firstfour = Name.Substring(0, 2);
                txtorden2.Text = firstfour;
                string iniciodepedidos = pedido.Substring(0, 2);
                //generacion  de numero aleatorio de orden
                var guid = Guid.NewGuid();
                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 9));
                var random = new Random(seed);
                txtpruibea.Text = seed.ToString();
                txtorden3.Text = iniciodepedidos + firstfour + seed.ToString();
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where orden like ('" + txtorden3.Text + "%')";
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
                if (txtorden3.Text == txtrepetidos.Text)
                {
                    MessageBox.Show("Se repitio la orden");
                    //txtordenprueba.Text = "Reer548621579";
                    goto sincopia;

                }
                else
                {


                var sum1 = Convert.ToInt32(txtprecioparte1.Text);
                                var sum2 = Convert.ToInt32(txtprecioparte2.Text);
                                var sum3 = Convert.ToInt32(txtparteprecio3.Text);
                                var sum4 = Convert.ToInt32(txtparteprecio4.Text);
                                var sum5 = Convert.ToInt32(txtparteprecio5.Text);
                                var sum6 = Convert.ToInt32(txtparteprecio6.Text);
                                var res = sum1 + sum2 + sum3 + sum4 + +sum5 + sum6;
                                txtcosto.Text = res.ToString();
                                try
                                {
                                    connection.Open();
                                    OleDbCommand command = new OleDbCommand();
                                    command.Connection = connection;
                                    command.CommandText = "Delete * from revisiones where orden like ('" + txtorden.Text + "')";
                                    command.ExecuteNonQuery();
                                    command.CommandText = "insert into cotizaciones (orden,tipopedido,nombre,numero,horayfecha,modelo,parte1,precioparte1,parte2,precioparte2,parte3,precioparte3,parte4,precioparte4,parte5,precioparte5,parte6,precioparte6,importe) values ('" + txtorden3.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "','" + txtparte1.Text + "','" + txtprecioparte1.Text + "','" + txtparte2.Text + "','" + txtprecioparte2.Text + "','" + txtparte3.Text + "','" + txtparteprecio3.Text + "','" + txtparte4.Text + "','" + txtparteprecio4.Text + "','" + txtparte5.Text + "','" + txtparteprecio5.Text + "','" + txtparte6.Text + "','" + txtparteprecio6.Text + "','" + txtcosto.Text + "')";
                                    command.ExecuteNonQuery();
                                    command.CommandText = "insert into clientes (orden,tipopedido,nombre,numero,horayfecha,modelo) values ('" + txtorden3.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "')";
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                    MessageBox.Show("Datos Guardados3");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error " + ex);
                                }
                            c.enviarCorreo("ebestprueba@gmail.com", "ebest1234","Nombre: "+txtnombre.Text+"\n Numero: "+txtnumero.Text+"\n Hora y fecha: "+txthorayfecha.Text, "Actualizacion de revision a cotizacion. Orden: "+txtorden3.Text,"erick.tadeo@hotmail.com");
                    BarcodeWriter br = new BarcodeWriter();
                    br.Format = BarcodeFormat.QR_CODE;
                    Bitmap bm = new Bitmap(br.Write("http:sexto-a.epizy.com/" + txtorden.Text), 150, 150);
                    pictureBox1.Image = bm;

                    printPreviewDialog1.Document = printDocument1;

                    //printDocument1.Print();
                    //printDocument1.Print();

                    printPreviewDialog1.Show();

                    label25.Visible = false;
                                checkBox1.Visible = false;
                                checkBox2.Visible = false;


                                label24.Visible = false;
                                txtrequerido.Visible = false;

                                btnabonar.Visible = false;
                                label21.Visible = false;
                                txtcosto2.Visible = false;
                                label22.Visible = false;
                                label23.Visible = false;
                                txtabono.Visible = false;
                                txtrestante.Visible = false;


                                label20.Visible = false;
                                txtcosto.Visible = false;



                                btnpagado.Visible = false;
                                //btnpagado.Text = "Pagado";
                                label7.Visible = false;
                                label8.Visible = false;
                                txtparte1.Visible = false;
                                txtprecioparte1.Visible = false;

                                label9.Visible = false;
                                label10.Visible = false;
                                txtparte2.Visible = false;
                                txtprecioparte2.Visible = false;

                                label11.Visible = false;
                                label12.Visible = false;
                                txtparte3.Visible = false;
                                txtparteprecio3.Visible = false;

                                label13.Visible = false;
                                label14.Visible = false;
                                txtparte4.Visible = false;
                                txtparteprecio4.Visible = false;

                                label15.Visible = false;
                                label16.Visible = false;
                                txtparte5.Visible = false;
                                txtparteprecio5.Visible = false;

                                label17.Visible = false;
                                label18.Visible = false;
                                txtparte6.Visible = false;
                                txtparteprecio6.Visible = false;
                                txtbusqueda.Text = "";
                    label2.Visible = false;
                    checkBox4.Visible = false;
                    checkBox3.Visible = false;
                    combodias.Visible = false;
                    combohoras.Visible = false;
                    checkBox5.Visible = false;
                    timer2.Enabled = false;
                }
            }

            else if (btnpagado.Text == "Pasar Cotizacion")
            {
                sincopia:
                string Name = txtnombre.Text;
                var rand = new Random();
                pedido = "Pedido";
                string firstfour = Name.Substring(0, 2);
                txtorden2.Text = firstfour;
                string iniciodepedidos = pedido.Substring(0, 2);
                //generacion  de numero aleatorio de orden
                var guid = Guid.NewGuid();
                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 9));
                var random = new Random(seed);
                txtpruibea.Text = seed.ToString();
                txtorden3.Text = iniciodepedidos + firstfour + seed.ToString();

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where orden like ('" + txtorden3.Text + "%')";
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
                if (txtorden3.Text == txtrepetidos.Text)
                {
                    MessageBox.Show("Se repitio la orden");
                    //txtordenprueba.Text = "Reer548621579";
                    goto sincopia;

                }
                else
                {


            var sum1 = Convert.ToInt32(txtprecioparte1.Text);
                            var sum2 = Convert.ToInt32(txtprecioparte2.Text);
                            var sum3 = Convert.ToInt32(txtparteprecio3.Text);
                            var sum4 = Convert.ToInt32(txtparteprecio4.Text);
                            var sum5 = Convert.ToInt32(txtparteprecio5.Text);
                            var sum6 = Convert.ToInt32(txtparteprecio6.Text);
                            var res = sum1 + sum2 + sum3 + sum4 + +sum5 + sum6;
                            txtcosto.Text = res.ToString();
                            try
                            {
                                connection.Open();
                                OleDbCommand command = new OleDbCommand();
                                command.Connection = connection;
                                command.CommandText = "Delete * from cotizaciones where orden like ('" + txtorden.Text + "')";
                                command.ExecuteNonQuery();
                                command.CommandText = "insert into pedidos (orden,tipopedido,nombre,numero,horayfecha,modelo,parte1,precio1,parte2,precio2,parte3,precio3,parte4,precio4,parte5,precio5,parte6,precio6,importe,abono,pagorequerido,espera) values ('" + txtorden3.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "','" + txtparte1.Text + "','" + txtprecioparte1.Text + "','" + txtparte2.Text + "','" + txtprecioparte2.Text + "','" + txtparte3.Text + "','" + txtparteprecio3.Text + "','" + txtparte4.Text + "','" + txtparteprecio4.Text + "','" + txtparte5.Text + "','" + txtparteprecio5.Text + "','" + txtparte6.Text + "','" + txtparteprecio6.Text + "','" + txtcosto.Text + "','" + txtabono.Text + "','" + txtrestante.Text + "','" + espera + "')";
                                command.ExecuteNonQuery();
                                command.CommandText = "insert into clientes (orden,tipopedido,nombre,numero,horayfecha,modelo) values ('" + txtorden3.Text + "','" + pedido + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "')";
                                command.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("Datos Guardados3");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error " + ex);
                            }
                    c.enviarCorreo("ebestprueba@gmail.com", "ebest1234", "Nombre: " + txtnombre.Text + "\n Numero: " + txtnumero.Text + "\n Hora y fecha: " + txthorayfecha.Text, "Actualizacion de cotizacion a pedido. Orden: " + txtorden3.Text, "erick.tadeo@hotmail.com");

                            label25.Visible = false;
                            checkBox1.Visible = false;
                            checkBox2.Visible = false;


                            label24.Visible = false;
                            txtrequerido.Visible = false;

                            btnabonar.Visible = false;
                            label21.Visible = false;
                            txtcosto2.Visible = false;
                            label22.Visible = false;
                            label23.Visible = false;
                            txtabono.Visible = false;
                            txtrestante.Visible = false;


                            label20.Visible = false;
                            txtcosto.Visible = false;



                            btnpagado.Visible = false;
                            //btnpagado.Text = "Pagado";
                            label7.Visible = false;
                            label8.Visible = false;
                            txtparte1.Visible = false;
                            txtprecioparte1.Visible = false;

                            label9.Visible = false;
                            label10.Visible = false;
                            txtparte2.Visible = false;
                            txtprecioparte2.Visible = false;

                            label11.Visible = false;
                            label12.Visible = false;
                            txtparte3.Visible = false;
                            txtparteprecio3.Visible = false;

                            label13.Visible = false;
                            label14.Visible = false;
                            txtparte4.Visible = false;
                            txtparteprecio4.Visible = false;

                            label15.Visible = false;
                            label16.Visible = false;
                            txtparte5.Visible = false;
                            txtparteprecio5.Visible = false;

                            label17.Visible = false;
                            label18.Visible = false;
                            txtparte6.Visible = false;
                            txtparteprecio6.Visible = false;
                            txtbusqueda.Text = "";
                    timer2.Enabled = true;




                }





                
            }

            else if (btnpagado.Text == "Pagado")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "Delete * from pedidos where orden like ('" + txtorden.Text + "')";
                    command.ExecuteNonQuery();
                    command.CommandText = "Delete * from clientes where orden like ('" + txtorden.Text + "')";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into clientes (orden,tipopedido,nombre,numero,horayfecha,modelo) values ('" + txtorden.Text + "','" + "Pagado" + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txthorayfecha.Text + "','" + txtmodelo.Text + "')";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert into pedidospagados (orden,tipopedido,nombre,numero,observaciones,horayfecha,pagado) values ('" + txtorden.Text + "','" + txtpedido.Text + "','" + txtnombre.Text + "','" + txtnumero.Text + "','" + txtobser.Text + "','" + txthorayfecha.Text + "','" + "Pagado" + "')";
                    command.ExecuteNonQuery();



                    connection.Close();
                    MessageBox.Show("Datos Guardados3");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                c.enviarCorreo("ebestprueba@gmail.com", "ebest1234", "Nombre: " + txtnombre.Text + "\n Numero: " + txtnumero.Text + "\n Hora y fecha: " + txthorayfecha.Text, "Pagado. Orden: " + txtorden.Text, "erick.tadeo@hotmail.com");



                label25.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;


                label24.Visible = false;
                txtrequerido.Visible = false;

                btnabonar.Visible = false;
                label21.Visible = false;
                txtcosto2.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                txtabono.Visible = false;
                txtrestante.Visible = false;


                label20.Visible = false;
                txtcosto.Visible = false;



                btnpagado.Visible = false;
                //btnpagado.Text = "Pagado";
                label7.Visible = false;
                label8.Visible = false;
                txtparte1.Visible = false;
                txtprecioparte1.Visible = false;

                label9.Visible = false;
                label10.Visible = false;
                txtparte2.Visible = false;
                txtprecioparte2.Visible = false;

                label11.Visible = false;
                label12.Visible = false;
                txtparte3.Visible = false;
                txtparteprecio3.Visible = false;

                label13.Visible = false;
                label14.Visible = false;
                txtparte4.Visible = false;
                txtparteprecio4.Visible = false;

                label15.Visible = false;
                label16.Visible = false;
                txtparte5.Visible = false;
                txtparteprecio5.Visible = false;

                label17.Visible = false;
                label18.Visible = false;
                txtparte6.Visible = false;
                txtparteprecio6.Visible = false;
                txtbusqueda.Text = "";
                timer2.Enabled = true;

            }












            //label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;
            txtorden.Visible = false;
            txtpedido.Visible = false;
            txtnombre.Visible = false;
            txtnumero.Visible = false;
            txtobser.Visible = false;
            //label19.Visible = false;
            txtmodelo.Visible = false;
            txtcosto.Visible = false;
            comboBoxbusqueda.Text = "Orden";
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



            //label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;

            txtorden.Visible = false;
            txtpedido.Visible = false;
            txtnombre.Visible = false;
            txtnumero.Visible = false;
            txtobser.Visible = false;
            


            //update_Load(sender, e);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthorayfecha.Text = DateTime.Now.ToString();
        }

        private void txttipo_TextChanged(object sender, EventArgs e)
        {
            if (txttipo.Text == "Pe")
            {
                label2.Visible = false;
                checkBox4.Visible = false;
                checkBox3.Visible = false;
                combodias.Visible = false;
                combohoras.Visible = false;
                checkBox5.Visible = false;


                timer2.Enabled = false;

                label25.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;


                label24.Visible = true;
                txtrequerido.Visible = true;

                btnabonar.Visible = true;
                label21.Visible = true;
                txtcosto2.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                txtabono.Visible = true;
                txtrestante.Visible = true;


                label20.Visible = false;
                txtcosto.Visible = false;



                btnpagado.Visible = true;
                btnpagado.Text = "Pagado";
                label7.Visible = true;
                label8.Visible = true;
                txtparte1.Visible = true;
                txtprecioparte1.Visible = true;

                label9.Visible = true;
                label10.Visible = true;
                txtparte2.Visible = true;
                txtprecioparte2.Visible = true;

                label11.Visible = true;
                label12.Visible = true;
                txtparte3.Visible = true;
                txtparteprecio3.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                txtparte4.Visible = true;
                txtparteprecio4.Visible = true;

                label15.Visible = true;
                label16.Visible = true;
                txtparte5.Visible = true;
                txtparteprecio5.Visible = true;

                label17.Visible = true;
                label18.Visible = true;
                txtparte6.Visible = true;
                txtparteprecio6.Visible = true;







                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from pedidos Where orden like ('" + txtorden.Text + "%')";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtparte1.Text = Convert.ToString(reader["parte1"]);
                        txtprecioparte1.Text = Convert.ToString(reader["precio1"]);

                        txtparte2.Text = Convert.ToString(reader["parte2"]);
                        txtprecioparte2.Text = Convert.ToString(reader["precio2"]);

                        txtparte3.Text = Convert.ToString(reader["parte3"]);
                        txtparteprecio3.Text = Convert.ToString(reader["precio3"]);

                        txtparte4.Text = Convert.ToString(reader["parte4"]);
                        txtparteprecio4.Text = Convert.ToString(reader["precio4"]);

                        txtparte5.Text = Convert.ToString(reader["parte5"]);
                        txtparteprecio3.Text = Convert.ToString(reader["precio5"]);

                        txtparte6.Text = Convert.ToString(reader["parte6"]);
                        txtparteprecio6.Text = Convert.ToString(reader["precio6"]);

                        txtcosto2.Text = Convert.ToString(reader["pagorequerido"]);

                        reader.Close();

                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
            else if (txttipo.Text == "Re")
            {
                timer2.Enabled = false;

                label21.Visible = false;
                txtcosto2.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                txtabono.Visible = false;
                txtrestante.Visible = false;
                label25.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;








                label20.Visible = true;
                txtcosto.Visible = true;

                btnpagado.Visible = true;
                btnpagado.Text = "Pasar revision";
                label7.Visible = true;
                label8.Visible = true;
                txtparte1.Visible = true;
                txtprecioparte1.Visible = true;

                label9.Visible = true;
                label10.Visible = true;
                txtparte2.Visible = true;
                txtprecioparte2.Visible = true;

                label11.Visible = true;
                label12.Visible = true;
                txtparte3.Visible = true;
                txtparteprecio3.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                txtparte4.Visible = true;
                txtparteprecio4.Visible = true;

                label15.Visible = true;
                label16.Visible = true;
                txtparte5.Visible = true;
                txtparteprecio5.Visible = true;

                label17.Visible = true;
                label18.Visible = true;
                txtparte6.Visible = true;
                txtparteprecio6.Visible = true;



                label2.Visible = true;
                checkBox4.Visible = true;
                checkBox3.Visible = true;
                combodias.Visible = true;
                combohoras.Visible = true;
                checkBox5.Visible = true;
            }
            else if (txttipo.Text == "Co")
            {
                timer2.Enabled = false;

                label25.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;


                label21.Visible = true;
                txtcosto2.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                txtabono.Visible = true;
                txtrestante.Visible = true;


                label20.Visible = false;
                txtcosto.Visible = false;



                btnpagado.Visible = true;
                btnpagado.Text = "Pasar Cotizacion";
                label7.Visible = true;
                label8.Visible = true;
                txtparte1.Visible = true;
                txtprecioparte1.Visible = true;

                label9.Visible = true;
                label10.Visible = true;
                txtparte2.Visible = true;
                txtprecioparte2.Visible = true;

                label11.Visible = true;
                label12.Visible = true;
                txtparte3.Visible = true;
                txtparteprecio3.Visible = true;

                label13.Visible = true;
                label14.Visible = true;
                txtparte4.Visible = true;
                txtparteprecio4.Visible = true;

                label15.Visible = true;
                label16.Visible = true;
                txtparte5.Visible = true;
                txtparteprecio5.Visible = true;

                label17.Visible = true;
                label18.Visible = true;
                txtparte6.Visible = true;
                txtparteprecio6.Visible = true;

                label2.Visible = false;
                checkBox4.Visible = false;
                checkBox3.Visible = false;
                combodias.Visible = false;
                combohoras.Visible = false;
                checkBox5.Visible = false;

                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "select * from cotizaciones Where orden like ('" + txtorden.Text + "%')";
                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtparte1.Text = Convert.ToString(reader["parte1"]);
                        txtprecioparte1.Text = Convert.ToString(reader["precioparte1"]);

                        txtparte2.Text = Convert.ToString(reader["parte2"]);
                        txtprecioparte2.Text = Convert.ToString(reader["precioparte2"]);

                        txtparte3.Text = Convert.ToString(reader["parte3"]);
                        txtparteprecio3.Text = Convert.ToString(reader["precioparte3"]);

                        txtparte4.Text = Convert.ToString(reader["parte4"]);
                        txtparteprecio4.Text = Convert.ToString(reader["precioparte4"]);

                        txtparte5.Text = Convert.ToString(reader["parte5"]);
                        txtparteprecio3.Text = Convert.ToString(reader["precioparte5"]);

                        txtparte6.Text = Convert.ToString(reader["parte6"]);
                        txtparteprecio6.Text = Convert.ToString(reader["precioparte6"]);
                        reader.Close();

                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }





            }
        }

        private void txtpedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtabono_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcosto2.Text != null && txtabono.Text != null)
                {
                    if (txtabono.Text == "")
                    {

                    }
                    else
                    {
                        int a = Convert.ToInt32(txtcosto2.Text);
                        int b = Convert.ToInt32(txtabono.Text);
                        int c = a - b;
                        txtrestante.Text = c.ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtprecioparte1_TextChanged(object sender, EventArgs e)
        {
            if(txtprecioparte1.Text == "")
            {
                
            }
            txtcosto2.Text = txtprecioparte1.Text;
        }

        private void txtprecioparte2_TextChanged(object sender, EventArgs e)
        {
            if (txtprecioparte2.Text == "")
            {

            }
            else
            {
                int suma1 = Convert.ToInt32(txtprecioparte1.Text);
                int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                int res = suma1 + suma2;
                txtcosto2.Text = res.ToString();
            }

        }

        private void txtparteprecio3_TextChanged(object sender, EventArgs e)
        {
            if (txtparteprecio3.Text == "")
            {

            }
            else
            {
                int suma1 = Convert.ToInt32(txtprecioparte1.Text);
                int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                int suma3 = Convert.ToInt32(txtparteprecio3.Text);

                int res = suma1 + suma2 + suma3;
                txtcosto2.Text = res.ToString();
            }
        }

        private void txtparteprecio4_TextChanged(object sender, EventArgs e)
        {
            if (txtparteprecio4.Text == "")
            {

            }
            else
            {
                int suma1 = Convert.ToInt32(txtprecioparte1.Text);
                int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                int suma3 = Convert.ToInt32(txtparteprecio3.Text);
                int suma4 = Convert.ToInt32(txtparteprecio4.Text);

                int res = suma1 + suma2 + suma3 + suma4;
                txtcosto2.Text = res.ToString();
            }
        }

        private void txtparteprecio5_TextChanged(object sender, EventArgs e)
        {
            if (txtparteprecio5.Text == "")
            {

            }
            else
            {
                int suma1 = Convert.ToInt32(txtprecioparte1.Text);
                int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                int suma3 = Convert.ToInt32(txtparteprecio3.Text);
                int suma4 = Convert.ToInt32(txtparteprecio4.Text);
                int suma5 = Convert.ToInt32(txtparteprecio5.Text);

                int res = suma1 + suma2 + suma3 + suma4 + suma5;
                txtcosto2.Text = res.ToString();
            }
        }

        private void txtparteprecio6_TextChanged(object sender, EventArgs e)
        {
            if (txtparteprecio6.Text == "")
            {

            }
            else
            {
                int suma1 = Convert.ToInt32(txtprecioparte1.Text);
                int suma2 = Convert.ToInt32(txtprecioparte2.Text);
                int suma3 = Convert.ToInt32(txtparteprecio3.Text);
                int suma4 = Convert.ToInt32(txtparteprecio4.Text);
                int suma5 = Convert.ToInt32(txtparteprecio5.Text);
                int suma6 = Convert.ToInt32(txtparteprecio6.Text);

                int res = suma1 + suma2 + suma3 + suma4 + suma5 + suma6;
                txtcosto2.Text = res.ToString();
            }
        }

        private void btnabonar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "update pedidos set pagorequerido='" + txtrestante.Text + "'    where orden like ('" + txtorden.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Guardados");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            timer2.Enabled = true;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["id"].Value.ToString();
                txtorden.Text = row.Cells["orden"].Value.ToString();
                txtpedido.Text = row.Cells["tipopedido"].Value.ToString();
                txtnombre.Text = row.Cells["nombre"].Value.ToString();
                txtnumero.Text = row.Cells["numero"].Value.ToString();
                txtobser.Text = row.Cells["observaciones"].Value.ToString();
                txtmodelo.Text = row.Cells["modelo"].Value.ToString();


            }
            actualizacion act = new actualizacion();
            act.txtorden.Text = txtorden.Text;
            act.txtnombre.Text = txtnombre.Text;
            act.txtpedido.Text = txtpedido.Text;
            act.txtnumero.Text = txtnumero.Text;
            act.txtobser.Text = txtobser.Text;
            act.txtmodelo.Text = txtmodelo.Text;
            act.txttipo.Text = txttipo.Text;
            act.txtid.Text = txtid.Text;
            act.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                espera = "3-4 dias";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                espera = "7-15 dias";
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_DoubleClick(object sender, EventArgs e)
        {
            label25.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;


            label24.Visible = false;
            txtrequerido.Visible = false;

            btnabonar.Visible = false;
            label21.Visible = false;
            txtcosto2.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            txtabono.Visible = false;
            txtrestante.Visible = false;


            label20.Visible = false;
            txtcosto.Visible = false;



            btnpagado.Visible = false;
            //btnpagado.Text = "Pagado";
            label7.Visible = false;
            label8.Visible = false;
            txtparte1.Visible = false;
            txtprecioparte1.Visible = false;

            label9.Visible = false;
            label10.Visible = false;
            txtparte2.Visible = false;
            txtprecioparte2.Visible = false;

            label11.Visible = false;
            label12.Visible = false;
            txtparte3.Visible = false;
            txtparteprecio3.Visible = false;

            label13.Visible = false;
            label14.Visible = false;
            txtparte4.Visible = false;
            txtparteprecio4.Visible = false;

            label15.Visible = false;
            label16.Visible = false;
            txtparte5.Visible = false;
            txtparteprecio5.Visible = false;

            label17.Visible = false;
            label18.Visible = false;
            txtparte6.Visible = false;
            txtparteprecio6.Visible = false;
            txtbusqueda.Text = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(txtbusqueda.Text == "")
            {
                timer2.Enabled = true;
                //txtbusqueda.Text = "iugi";

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



            }
            else
            {
                timer2.Enabled = false;

            

            }
            
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            if(txtparte1.Visible == true)
            {
                timer2.Enabled = false;

            }
            else
            {
            timer2.Enabled = true;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            comboBoxbusqueda.Text = "Orden-SKU";
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
            timer3.Enabled = false;
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

        private void txtabono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtabono_MouseClick(object sender, MouseEventArgs e)
        {
            txtabono.Text = "";
        }

        private void txtrestante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecioparte1_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtprecioparte1.Text == "0")
            {
                txtprecioparte1.Text = "";
            }
        }

        private void txtprecioparte2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtprecioparte2.Text == "0")
            {
                txtprecioparte2.Text = "";
            }
        }

        private void txtparteprecio3_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtparteprecio3.Text == "0")
            {
                txtparteprecio3.Text = "";
            }
        }

        private void txtparteprecio4_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtparteprecio4.Text == "0")
            {
                txtparteprecio4.Text = "";
            }
        }

        private void txtparteprecio5_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtparteprecio5.Text == "0")
            {
                txtparteprecio5.Text = "";
            }
        }

        private void txtparteprecio6_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtparteprecio6.Text == "0")
            {
                txtparteprecio6.Text = "";
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
            e.Graphics.DrawString("  Equipo en  cotizacion", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 100));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 150));
            e.Graphics.DrawString("                    GUGE900514C70", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 180));
            e.Graphics.DrawString("     Calle Pedro J. Mendez No.1082-A OTE.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 200));
            e.Graphics.DrawString("                  Reynosa Tamaulipas", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString("                             88500", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 240));
            e.Graphics.DrawString("                  e-best@live.com.mx", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 260));
            e.Graphics.DrawString("                         8999222312", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 300));
            e.Graphics.DrawString("      Fecha: " + txthorayfecha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString("      Nombre: " + txtnombre.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("      Modelo: " + txtmodelo.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));
            if (checkBox5.Checked == true && checkBox4.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combodias.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            else if (checkBox5.Checked == true && checkBox3.Checked == true)
            {
                e.Graphics.DrawString("      Tiempo de espera: " + combohoras.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));

            }
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 410));
            e.Graphics.DrawString("               Orden: " + txtorden.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 435));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 450));
            e.Graphics.DrawString("                  Diagnóstico gratis", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 470));
            e.Graphics.DrawString("  =================", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(5, 490));
            e.Graphics.DrawImage(pictureBox1.Image, 70, 530);

            // e.Graphics.DrawImage(pictureBox1.Image, 70, 600);
        }
    }
}
