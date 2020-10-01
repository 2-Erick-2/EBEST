namespace EBEST
{
    partial class crearpedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearpedido));
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtrestante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnimprimir2 = new System.Windows.Forms.Button();
            this.txtpruibea = new System.Windows.Forms.TextBox();
            this.txtorden2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorayfecha = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblhorayfecha = new System.Windows.Forms.Label();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtorden = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtparte1 = new System.Windows.Forms.TextBox();
            this.txtprecioparte1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecioparte2 = new System.Windows.Forms.TextBox();
            this.txtparte2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtparteprecio3 = new System.Windows.Forms.TextBox();
            this.txtparte3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtparteprecio4 = new System.Windows.Forms.TextBox();
            this.txtparte4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtparteprecio5 = new System.Windows.Forms.TextBox();
            this.txtparte5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtparteprecio6 = new System.Windows.Forms.TextBox();
            this.txtparte6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrepetidos = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmisor
            // 
            this.txtEmisor.Location = new System.Drawing.Point(12, 43);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(45, 20);
            this.txtEmisor.TabIndex = 15;
            this.txtEmisor.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(640, 114);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Visible = false;
            // 
            // txtrestante
            // 
            this.txtrestante.Location = new System.Drawing.Point(310, 547);
            this.txtrestante.Name = "txtrestante";
            this.txtrestante.ReadOnly = true;
            this.txtrestante.Size = new System.Drawing.Size(308, 20);
            this.txtrestante.TabIndex = 46;
            this.txtrestante.TextChanged += new System.EventHandler(this.txtrestante_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(310, 487);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.ReadOnly = true;
            this.txtcosto.Size = new System.Drawing.Size(308, 20);
            this.txtcosto.TabIndex = 44;
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            // 
            // txtabono
            // 
            this.txtabono.Location = new System.Drawing.Point(310, 517);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(308, 20);
            this.txtabono.TabIndex = 47;
            this.txtabono.Text = "0";
            this.txtabono.TextChanged += new System.EventHandler(this.txtabono_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Abono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Importe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnimprimir2
            // 
            this.btnimprimir2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnimprimir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir2.Location = new System.Drawing.Point(257, 742);
            this.btnimprimir2.Name = "btnimprimir2";
            this.btnimprimir2.Size = new System.Drawing.Size(233, 53);
            this.btnimprimir2.TabIndex = 40;
            this.btnimprimir2.Text = "Imprimir etiqueta y recibo";
            this.btnimprimir2.UseVisualStyleBackColor = false;
            this.btnimprimir2.Visible = false;
            this.btnimprimir2.Click += new System.EventHandler(this.btnimprimir2_Click);
            // 
            // txtpruibea
            // 
            this.txtpruibea.Location = new System.Drawing.Point(721, 536);
            this.txtpruibea.Name = "txtpruibea";
            this.txtpruibea.Size = new System.Drawing.Size(36, 20);
            this.txtpruibea.TabIndex = 39;
            this.txtpruibea.Visible = false;
            this.txtpruibea.TextChanged += new System.EventHandler(this.txtpruibea_TextChanged);
            // 
            // txtorden2
            // 
            this.txtorden2.Location = new System.Drawing.Point(12, 384);
            this.txtorden2.Name = "txtorden2";
            this.txtorden2.Size = new System.Drawing.Size(70, 20);
            this.txtorden2.TabIndex = 38;
            this.txtorden2.Visible = false;
            this.txtorden2.TextChanged += new System.EventHandler(this.txtorden_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Numero de Orden";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txthorayfecha
            // 
            this.txthorayfecha.AutoSize = true;
            this.txthorayfecha.BackColor = System.Drawing.Color.White;
            this.txthorayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorayfecha.Location = new System.Drawing.Point(314, 611);
            this.txthorayfecha.Name = "txthorayfecha";
            this.txthorayfecha.Size = new System.Drawing.Size(60, 24);
            this.txthorayfecha.TabIndex = 36;
            this.txthorayfecha.Text = "label1";
            this.txthorayfecha.Click += new System.EventHandler(this.txthorayfecha_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.Location = new System.Drawing.Point(191, 679);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(419, 57);
            this.btnimprimir.TabIndex = 50;
            this.btnimprimir.Text = "Cerrar pedido";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(308, 162);
            this.txtnumero.MaxLength = 10;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(310, 20);
            this.txtnumero.TabIndex = 33;
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(721, 43);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(47, 50);
            this.txtobservaciones.TabIndex = 33;
            this.txtobservaciones.Visible = false;
            this.txtobservaciones.TextChanged += new System.EventHandler(this.txtobservaciones_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(309, 130);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(309, 20);
            this.txtnombre.TabIndex = 32;
            // 
            // lblhorayfecha
            // 
            this.lblhorayfecha.AutoSize = true;
            this.lblhorayfecha.BackColor = System.Drawing.Color.White;
            this.lblhorayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorayfecha.Location = new System.Drawing.Point(126, 611);
            this.lblhorayfecha.Name = "lblhorayfecha";
            this.lblhorayfecha.Size = new System.Drawing.Size(124, 24);
            this.lblhorayfecha.TabIndex = 31;
            this.lblhorayfecha.Text = "Hora y Fecha";
            this.lblhorayfecha.Click += new System.EventHandler(this.lblhorayfecha_Click);
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobservaciones.Location = new System.Drawing.Point(604, 9);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(110, 24);
            this.lblobservaciones.TabIndex = 30;
            this.lblobservaciones.Text = "Descripcion";
            this.lblobservaciones.Visible = false;
            this.lblobservaciones.Click += new System.EventHandler(this.lblobservaciones_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.White;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(123, 162);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(79, 24);
            this.lblnumero.TabIndex = 29;
            this.lblnumero.Text = "Numero";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.White;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(122, 125);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(79, 24);
            this.lblnombre.TabIndex = 28;
            this.lblnombre.Text = "Nombre";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtorden
            // 
            this.txtorden.AutoSize = true;
            this.txtorden.BackColor = System.Drawing.Color.White;
            this.txtorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorden.Location = new System.Drawing.Point(318, 649);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(52, 24);
            this.txtorden.TabIndex = 49;
            this.txtorden.Text = "******";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tiempo de espera";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(319, 574);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 33);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "3-4 dias";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(480, 574);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(130, 33);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "7-15 dias";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Parte 1";
            // 
            // txtparte1
            // 
            this.txtparte1.Location = new System.Drawing.Point(308, 256);
            this.txtparte1.Name = "txtparte1";
            this.txtparte1.Size = new System.Drawing.Size(124, 20);
            this.txtparte1.TabIndex = 35;
            // 
            // txtprecioparte1
            // 
            this.txtprecioparte1.Location = new System.Drawing.Point(523, 255);
            this.txtprecioparte1.Name = "txtprecioparte1";
            this.txtprecioparte1.Size = new System.Drawing.Size(93, 20);
            this.txtprecioparte1.TabIndex = 36;
            this.txtprecioparte1.Text = "0";
            this.txtprecioparte1.Click += new System.EventHandler(this.txtprecioparte1_Click);
            this.txtprecioparte1.TextChanged += new System.EventHandler(this.txtprecioparte1_TextChanged);
            this.txtprecioparte1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioparte1_KeyPress);
            this.txtprecioparte1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprecioparte1_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "Precio 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 60;
            this.label9.Text = "Precio 2";
            this.label9.Visible = false;
            // 
            // txtprecioparte2
            // 
            this.txtprecioparte2.Location = new System.Drawing.Point(523, 296);
            this.txtprecioparte2.Name = "txtprecioparte2";
            this.txtprecioparte2.Size = new System.Drawing.Size(93, 20);
            this.txtprecioparte2.TabIndex = 38;
            this.txtprecioparte2.Text = "0";
            this.txtprecioparte2.Visible = false;
            this.txtprecioparte2.Click += new System.EventHandler(this.txtprecioparte2_Click);
            this.txtprecioparte2.TextChanged += new System.EventHandler(this.txtprecioparte2_TextChanged);
            this.txtprecioparte2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioparte2_KeyPress);
            // 
            // txtparte2
            // 
            this.txtparte2.Location = new System.Drawing.Point(308, 297);
            this.txtparte2.Name = "txtparte2";
            this.txtparte2.Size = new System.Drawing.Size(124, 20);
            this.txtparte2.TabIndex = 37;
            this.txtparte2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(125, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 57;
            this.label10.Text = "Parte 2";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(439, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 24);
            this.label11.TabIndex = 64;
            this.label11.Text = "Precio 3";
            this.label11.Visible = false;
            // 
            // txtparteprecio3
            // 
            this.txtparteprecio3.Location = new System.Drawing.Point(524, 339);
            this.txtparteprecio3.Name = "txtparteprecio3";
            this.txtparteprecio3.Size = new System.Drawing.Size(93, 20);
            this.txtparteprecio3.TabIndex = 40;
            this.txtparteprecio3.Text = "0";
            this.txtparteprecio3.Visible = false;
            this.txtparteprecio3.Click += new System.EventHandler(this.txtparteprecio3_Click);
            this.txtparteprecio3.TextChanged += new System.EventHandler(this.txtparteprecio3_TextChanged);
            this.txtparteprecio3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparteprecio3_KeyPress);
            // 
            // txtparte3
            // 
            this.txtparte3.Location = new System.Drawing.Point(309, 340);
            this.txtparte3.Name = "txtparte3";
            this.txtparte3.Size = new System.Drawing.Size(124, 20);
            this.txtparte3.TabIndex = 39;
            this.txtparte3.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(126, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 61;
            this.label12.Text = "Parte 3";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(438, 371);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 24);
            this.label13.TabIndex = 68;
            this.label13.Text = "Precio 4";
            this.label13.Visible = false;
            // 
            // txtparteprecio4
            // 
            this.txtparteprecio4.Location = new System.Drawing.Point(523, 375);
            this.txtparteprecio4.Name = "txtparteprecio4";
            this.txtparteprecio4.Size = new System.Drawing.Size(93, 20);
            this.txtparteprecio4.TabIndex = 42;
            this.txtparteprecio4.Text = "0";
            this.txtparteprecio4.Visible = false;
            this.txtparteprecio4.Click += new System.EventHandler(this.txtparteprecio4_Click);
            this.txtparteprecio4.TextChanged += new System.EventHandler(this.txtparteprecio4_TextChanged);
            this.txtparteprecio4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparteprecio4_KeyPress);
            // 
            // txtparte4
            // 
            this.txtparte4.Location = new System.Drawing.Point(308, 376);
            this.txtparte4.Name = "txtparte4";
            this.txtparte4.Size = new System.Drawing.Size(124, 20);
            this.txtparte4.TabIndex = 41;
            this.txtparte4.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(125, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 24);
            this.label14.TabIndex = 65;
            this.label14.Text = "Parte 4";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(439, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 24);
            this.label15.TabIndex = 72;
            this.label15.Text = "Precio 5";
            this.label15.Visible = false;
            // 
            // txtparteprecio5
            // 
            this.txtparteprecio5.Location = new System.Drawing.Point(524, 411);
            this.txtparteprecio5.Name = "txtparteprecio5";
            this.txtparteprecio5.Size = new System.Drawing.Size(93, 20);
            this.txtparteprecio5.TabIndex = 44;
            this.txtparteprecio5.Text = "0";
            this.txtparteprecio5.Visible = false;
            this.txtparteprecio5.Click += new System.EventHandler(this.txtparteprecio5_Click);
            this.txtparteprecio5.TextChanged += new System.EventHandler(this.txtparteprecio5_TextChanged);
            this.txtparteprecio5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparteprecio5_KeyPress);
            // 
            // txtparte5
            // 
            this.txtparte5.Location = new System.Drawing.Point(309, 412);
            this.txtparte5.Name = "txtparte5";
            this.txtparte5.Size = new System.Drawing.Size(124, 20);
            this.txtparte5.TabIndex = 43;
            this.txtparte5.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(126, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 24);
            this.label16.TabIndex = 69;
            this.label16.Text = "Parte 5";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(440, 447);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 24);
            this.label17.TabIndex = 76;
            this.label17.Text = "Precio 6";
            this.label17.Visible = false;
            // 
            // txtparteprecio6
            // 
            this.txtparteprecio6.Location = new System.Drawing.Point(525, 451);
            this.txtparteprecio6.Name = "txtparteprecio6";
            this.txtparteprecio6.Size = new System.Drawing.Size(93, 20);
            this.txtparteprecio6.TabIndex = 46;
            this.txtparteprecio6.Text = "0";
            this.txtparteprecio6.Visible = false;
            this.txtparteprecio6.Click += new System.EventHandler(this.txtparteprecio6_Click);
            this.txtparteprecio6.TextChanged += new System.EventHandler(this.txtparteprecio6_TextChanged);
            this.txtparteprecio6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparteprecio6_KeyPress);
            // 
            // txtparte6
            // 
            this.txtparte6.Location = new System.Drawing.Point(310, 452);
            this.txtparte6.Name = "txtparte6";
            this.txtparte6.Size = new System.Drawing.Size(124, 20);
            this.txtparte6.TabIndex = 45;
            this.txtparte6.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(127, 447);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 24);
            this.label18.TabIndex = 73;
            this.label18.Text = "Parte 6";
            this.label18.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.White;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Location = new System.Drawing.Point(640, 299);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 17);
            this.checkBox3.TabIndex = 77;
            this.checkBox3.Text = "Parte 2";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.White;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Location = new System.Drawing.Point(641, 343);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 17);
            this.checkBox4.TabIndex = 78;
            this.checkBox4.Text = "Parte 3";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.White;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.Location = new System.Drawing.Point(640, 379);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(60, 17);
            this.checkBox5.TabIndex = 79;
            this.checkBox5.Text = "Parte 4";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.White;
            this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6.Location = new System.Drawing.Point(640, 413);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(63, 17);
            this.checkBox6.TabIndex = 80;
            this.checkBox6.Text = "Parte 5 ";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.Color.White;
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.Location = new System.Drawing.Point(640, 451);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(60, 17);
            this.checkBox7.TabIndex = 81;
            this.checkBox7.Text = "Parte 6";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(308, 194);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(310, 20);
            this.txtmodelo.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Modelo";
            // 
            // txtrepetidos
            // 
            this.txtrepetidos.Location = new System.Drawing.Point(714, 163);
            this.txtrepetidos.Name = "txtrepetidos";
            this.txtrepetidos.Size = new System.Drawing.Size(100, 20);
            this.txtrepetidos.TabIndex = 114;
            this.txtrepetidos.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(304, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(208, 24);
            this.label19.TabIndex = 121;
            this.label19.Text = "PARTES EN PEDIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-14, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 178);
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // crearpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EBEST.Properties.Resources.fondocrearrevision2;
            this.ClientSize = new System.Drawing.Size(780, 807);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtrepetidos);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtparteprecio6);
            this.Controls.Add(this.txtparte6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtparteprecio5);
            this.Controls.Add(this.txtparte5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtparteprecio4);
            this.Controls.Add(this.txtparte4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtparteprecio3);
            this.Controls.Add(this.txtparte3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprecioparte2);
            this.Controls.Add(this.txtparte2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprecioparte1);
            this.Controls.Add(this.txtparte1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.txtrestante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnimprimir2);
            this.Controls.Add(this.txtpruibea);
            this.Controls.Add(this.txtorden2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthorayfecha);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblhorayfecha);
            this.Controls.Add(this.lblobservaciones);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearpedido";
            this.Load += new System.EventHandler(this.crearpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtrestante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnimprimir2;
        private System.Windows.Forms.TextBox txtpruibea;
        private System.Windows.Forms.TextBox txtorden2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txthorayfecha;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblhorayfecha;
        private System.Windows.Forms.Label lblobservaciones;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtorden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtparte1;
        private System.Windows.Forms.TextBox txtprecioparte1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecioparte2;
        private System.Windows.Forms.TextBox txtparte2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtparteprecio3;
        private System.Windows.Forms.TextBox txtparte3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtparteprecio4;
        private System.Windows.Forms.TextBox txtparte4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtparteprecio5;
        private System.Windows.Forms.TextBox txtparte5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtparteprecio6;
        private System.Windows.Forms.TextBox txtparte6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrepetidos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}