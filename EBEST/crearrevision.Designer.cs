namespace EBEST
{
    partial class crearrevision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crearrevision));
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.txtorden = new System.Windows.Forms.Label();
            this.txtpruibea = new System.Windows.Forms.TextBox();
            this.txtorden2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthorayfecha = new System.Windows.Forms.Label();
            this.lblhorayfecha = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtrepetidos = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combodias = new System.Windows.Forms.ComboBox();
            this.combohoras = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(323, 252);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(310, 20);
            this.txtmodelo.TabIndex = 93;
            this.txtmodelo.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 93;
            this.label5.Text = "Modelo";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(323, 190);
            this.txtnumero.MaxLength = 10;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(310, 20);
            this.txtnumero.TabIndex = 92;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(323, 321);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(310, 54);
            this.txtobservaciones.TabIndex = 94;
            this.txtobservaciones.TextChanged += new System.EventHandler(this.txtobservaciones_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(323, 135);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(309, 20);
            this.txtnombre.TabIndex = 91;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.BackColor = System.Drawing.Color.White;
            this.lblobservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobservaciones.Location = new System.Drawing.Point(140, 321);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(110, 24);
            this.lblobservaciones.TabIndex = 89;
            this.lblobservaciones.Text = "Descripcion";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.White;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(140, 190);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(79, 24);
            this.lblnumero.TabIndex = 88;
            this.lblnumero.Text = "Numero";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.White;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(140, 130);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(79, 24);
            this.lblnombre.TabIndex = 87;
            this.lblnombre.Text = "Nombre";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(682, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 86;
            this.txtPassword.Visible = false;
            // 
            // txtEmisor
            // 
            this.txtEmisor.Location = new System.Drawing.Point(55, 103);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(100, 20);
            this.txtEmisor.TabIndex = 85;
            this.txtEmisor.Visible = false;
            // 
            // txtorden
            // 
            this.txtorden.AutoSize = true;
            this.txtorden.BackColor = System.Drawing.Color.White;
            this.txtorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorden.Location = new System.Drawing.Point(365, 562);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(59, 24);
            this.txtorden.TabIndex = 100;
            this.txtorden.Text = "*******";
            // 
            // txtpruibea
            // 
            this.txtpruibea.Location = new System.Drawing.Point(455, 594);
            this.txtpruibea.Name = "txtpruibea";
            this.txtpruibea.Size = new System.Drawing.Size(178, 20);
            this.txtpruibea.TabIndex = 99;
            this.txtpruibea.Visible = false;
            // 
            // txtorden2
            // 
            this.txtorden2.Location = new System.Drawing.Point(97, 594);
            this.txtorden2.Name = "txtorden2";
            this.txtorden2.Size = new System.Drawing.Size(304, 20);
            this.txtorden2.TabIndex = 98;
            this.txtorden2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Numero de Orden";
            // 
            // txthorayfecha
            // 
            this.txthorayfecha.AutoSize = true;
            this.txthorayfecha.BackColor = System.Drawing.Color.White;
            this.txthorayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorayfecha.Location = new System.Drawing.Point(312, 504);
            this.txthorayfecha.Name = "txthorayfecha";
            this.txthorayfecha.Size = new System.Drawing.Size(60, 24);
            this.txthorayfecha.TabIndex = 96;
            this.txthorayfecha.Text = "label1";
            // 
            // lblhorayfecha
            // 
            this.lblhorayfecha.AutoSize = true;
            this.lblhorayfecha.BackColor = System.Drawing.Color.White;
            this.lblhorayfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorayfecha.Location = new System.Drawing.Point(178, 504);
            this.lblhorayfecha.Name = "lblhorayfecha";
            this.lblhorayfecha.Size = new System.Drawing.Size(124, 24);
            this.lblhorayfecha.TabIndex = 95;
            this.lblhorayfecha.Text = "Hora y Fecha";
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimprimir.Location = new System.Drawing.Point(189, 678);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(425, 55);
            this.btnimprimir.TabIndex = 96;
            this.btnimprimir.Text = "Cerrar revision";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtrepetidos
            // 
            this.txtrepetidos.Location = new System.Drawing.Point(718, 158);
            this.txtrepetidos.Name = "txtrepetidos";
            this.txtrepetidos.Size = new System.Drawing.Size(29, 20);
            this.txtrepetidos.TabIndex = 103;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 96);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 176);
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "Tiempo de respuesta";
            // 
            // combodias
            // 
            this.combodias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.combodias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combodias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodias.ForeColor = System.Drawing.Color.White;
            this.combodias.FormattingEnabled = true;
            this.combodias.Items.AddRange(new object[] {
            "1 dia",
            "2 dias",
            "3 dias",
            "4 dias",
            "5 dias"});
            this.combodias.Location = new System.Drawing.Point(407, 397);
            this.combodias.Name = "combodias";
            this.combodias.Size = new System.Drawing.Size(121, 28);
            this.combodias.TabIndex = 107;
            // 
            // combohoras
            // 
            this.combohoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.combohoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combohoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combohoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combohoras.ForeColor = System.Drawing.Color.White;
            this.combohoras.FormattingEnabled = true;
            this.combohoras.Items.AddRange(new object[] {
            "1 hora",
            "2 horas",
            "3 horas",
            "4 horas",
            "5 horas"});
            this.combohoras.Location = new System.Drawing.Point(614, 396);
            this.combohoras.Name = "combohoras";
            this.combohoras.Size = new System.Drawing.Size(121, 28);
            this.combohoras.TabIndex = 110;
            this.combohoras.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(145, 442);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 28);
            this.checkBox1.TabIndex = 95;
            this.checkBox1.Text = "Mostrar en ticket";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(336, 397);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 28);
            this.checkBox2.TabIndex = 112;
            this.checkBox2.Text = "Dias";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.White;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(534, 397);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 28);
            this.checkBox3.TabIndex = 113;
            this.checkBox3.Text = "Horas";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // crearrevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EBEST.Properties.Resources.fondocrearrevision2;
            this.ClientSize = new System.Drawing.Size(780, 807);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.combohoras);
            this.Controls.Add(this.combodias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtrepetidos);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.txtpruibea);
            this.Controls.Add(this.txtorden2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthorayfecha);
            this.Controls.Add(this.lblhorayfecha);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblobservaciones);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmisor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "crearrevision";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.crearrevision_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.crearrevision_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblobservaciones;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.Label txtorden;
        private System.Windows.Forms.TextBox txtpruibea;
        private System.Windows.Forms.TextBox txtorden2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txthorayfecha;
        private System.Windows.Forms.Label lblhorayfecha;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtrepetidos;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combodias;
        private System.Windows.Forms.ComboBox combohoras;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}