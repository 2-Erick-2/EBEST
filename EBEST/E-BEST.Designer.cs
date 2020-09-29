namespace EBEST
{
    partial class Form1
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
            this.checkBoxpedido = new System.Windows.Forms.CheckBox();
            this.checkBoxcotizacion = new System.Windows.Forms.CheckBox();
            this.checkBoxrevision = new System.Windows.Forms.CheckBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblhorayfecha = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txthorayfecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.txtpruibea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrestante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxpedido
            // 
            this.checkBoxpedido.AutoSize = true;
            this.checkBoxpedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpedido.Location = new System.Drawing.Point(120, 100);
            this.checkBoxpedido.Name = "checkBoxpedido";
            this.checkBoxpedido.Size = new System.Drawing.Size(117, 35);
            this.checkBoxpedido.TabIndex = 0;
            this.checkBoxpedido.Text = "Pedido";
            this.checkBoxpedido.UseVisualStyleBackColor = true;
            this.checkBoxpedido.CheckedChanged += new System.EventHandler(this.checkBoxpedido_CheckedChanged);
            // 
            // checkBoxcotizacion
            // 
            this.checkBoxcotizacion.AutoSize = true;
            this.checkBoxcotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxcotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxcotizacion.Location = new System.Drawing.Point(292, 100);
            this.checkBoxcotizacion.Name = "checkBoxcotizacion";
            this.checkBoxcotizacion.Size = new System.Drawing.Size(161, 35);
            this.checkBoxcotizacion.TabIndex = 1;
            this.checkBoxcotizacion.Text = "Cotizacion";
            this.checkBoxcotizacion.UseVisualStyleBackColor = true;
            this.checkBoxcotizacion.CheckedChanged += new System.EventHandler(this.checkBoxcotizacion_CheckedChanged);
            // 
            // checkBoxrevision
            // 
            this.checkBoxrevision.AutoSize = true;
            this.checkBoxrevision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxrevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxrevision.Location = new System.Drawing.Point(525, 100);
            this.checkBoxrevision.Name = "checkBoxrevision";
            this.checkBoxrevision.Size = new System.Drawing.Size(138, 35);
            this.checkBoxrevision.TabIndex = 2;
            this.checkBoxrevision.Text = "Revision";
            this.checkBoxrevision.UseVisualStyleBackColor = true;
            this.checkBoxrevision.CheckedChanged += new System.EventHandler(this.checkBoxrevision_CheckedChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(117, 162);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(79, 24);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(117, 221);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(79, 24);
            this.lblnumero.TabIndex = 4;
            this.lblnumero.Text = "Numero";
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobservaciones.Location = new System.Drawing.Point(117, 408);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(137, 24);
            this.lblobservaciones.TabIndex = 5;
            this.lblobservaciones.Text = "Observaciones";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblhorayfecha
            // 
            this.lblhorayfecha.AutoSize = true;
            this.lblhorayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorayfecha.Location = new System.Drawing.Point(117, 506);
            this.lblhorayfecha.Name = "lblhorayfecha";
            this.lblhorayfecha.Size = new System.Drawing.Size(124, 24);
            this.lblhorayfecha.TabIndex = 6;
            this.lblhorayfecha.Text = "Hora y Fecha";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(304, 167);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(304, 20);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Enabled = false;
            this.txtobservaciones.Location = new System.Drawing.Point(304, 408);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(304, 86);
            this.txtobservaciones.TabIndex = 11;
            this.txtobservaciones.TextChanged += new System.EventHandler(this.txtobservaciones_TextChanged);
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(304, 221);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(304, 20);
            this.txtnumero.TabIndex = 12;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.Location = new System.Drawing.Point(24, 611);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(274, 53);
            this.btnimprimir.TabIndex = 13;
            this.btnimprimir.Text = "Guardar y Enviar correo";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // txtEmisor
            // 
            this.txtEmisor.Location = new System.Drawing.Point(81, 41);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(100, 20);
            this.txtEmisor.TabIndex = 14;
            this.txtEmisor.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(466, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "PrintDocument";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txthorayfecha
            // 
            this.txthorayfecha.AutoSize = true;
            this.txthorayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorayfecha.Location = new System.Drawing.Point(300, 506);
            this.txthorayfecha.Name = "txthorayfecha";
            this.txthorayfecha.Size = new System.Drawing.Size(60, 24);
            this.txthorayfecha.TabIndex = 16;
            this.txthorayfecha.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EBEST.Properties.Resources.eBestLogo__transparente_web_03;
            this.pictureBox1.Location = new System.Drawing.Point(235, -54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Numero de Orden";
            // 
            // txtorden
            // 
            this.txtorden.Location = new System.Drawing.Point(304, 557);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(304, 20);
            this.txtorden.TabIndex = 19;
            // 
            // txtpruibea
            // 
            this.txtpruibea.Location = new System.Drawing.Point(506, 579);
            this.txtpruibea.Name = "txtpruibea";
            this.txtpruibea.Size = new System.Drawing.Size(178, 20);
            this.txtpruibea.TabIndex = 20;
            this.txtpruibea.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "Imprimir etiqueta y recibo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Abono";
            // 
            // txtabono
            // 
            this.txtabono.Location = new System.Drawing.Point(304, 326);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(304, 20);
            this.txtabono.TabIndex = 24;
            this.txtabono.TextChanged += new System.EventHandler(this.txtabono_TextChanged);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(304, 276);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(304, 20);
            this.txtcosto.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Restante";
            // 
            // txtrestante
            // 
            this.txtrestante.Location = new System.Drawing.Point(304, 363);
            this.txtrestante.Name = "txtrestante";
            this.txtrestante.Size = new System.Drawing.Size(304, 20);
            this.txtrestante.TabIndex = 27;
            this.txtrestante.TextChanged += new System.EventHandler(this.txtrestante_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 695);
            this.Controls.Add(this.txtrestante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpruibea);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthorayfecha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblhorayfecha);
            this.Controls.Add(this.lblobservaciones);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.checkBoxrevision);
            this.Controls.Add(this.checkBoxcotizacion);
            this.Controls.Add(this.checkBoxpedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "E-BEST";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxpedido;
        private System.Windows.Forms.CheckBox checkBoxcotizacion;
        private System.Windows.Forms.CheckBox checkBoxrevision;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblobservaciones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhorayfecha;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label txthorayfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.TextBox txtpruibea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrestante;
    }
}

