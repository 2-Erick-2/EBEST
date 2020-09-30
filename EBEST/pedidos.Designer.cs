namespace EBEST
{
    partial class pedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBoxnumero = new System.Windows.Forms.CheckBox();
            this.checkBoxorden = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnpagado = new System.Windows.Forms.Button();
            this.comboBoxbusqueda = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxnumero
            // 
            this.checkBoxnumero.AutoSize = true;
            this.checkBoxnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxnumero.Location = new System.Drawing.Point(719, 2);
            this.checkBoxnumero.Name = "checkBoxnumero";
            this.checkBoxnumero.Size = new System.Drawing.Size(63, 17);
            this.checkBoxnumero.TabIndex = 16;
            this.checkBoxnumero.Text = "Numero";
            this.checkBoxnumero.UseVisualStyleBackColor = true;
            this.checkBoxnumero.Visible = false;
            this.checkBoxnumero.CheckedChanged += new System.EventHandler(this.checkBoxnumero_CheckedChanged);
            // 
            // checkBoxorden
            // 
            this.checkBoxorden.AutoSize = true;
            this.checkBoxorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxorden.Location = new System.Drawing.Point(719, 25);
            this.checkBoxorden.Name = "checkBoxorden";
            this.checkBoxorden.Size = new System.Drawing.Size(55, 17);
            this.checkBoxorden.TabIndex = 15;
            this.checkBoxorden.Text = "Orden";
            this.checkBoxorden.UseVisualStyleBackColor = true;
            this.checkBoxorden.Visible = false;
            this.checkBoxorden.CheckedChanged += new System.EventHandler(this.checkBoxorden_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busqueda:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(495, 23);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(203, 28);
            this.txtbusqueda.TabIndex = 12;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // btnpagado
            // 
            this.btnpagado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnpagado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagado.Location = new System.Drawing.Point(626, 95);
            this.btnpagado.Name = "btnpagado";
            this.btnpagado.Size = new System.Drawing.Size(130, 44);
            this.btnpagado.TabIndex = 30;
            this.btnpagado.Text = "Pedidos pagados";
            this.btnpagado.UseVisualStyleBackColor = false;
            this.btnpagado.Click += new System.EventHandler(this.btnpagado_Click);
            // 
            // comboBoxbusqueda
            // 
            this.comboBoxbusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxbusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxbusqueda.FormattingEnabled = true;
            this.comboBoxbusqueda.Items.AddRange(new object[] {
            "Orden-SKU",
            "Numero",
            "Nombre",
            "Fecha"});
            this.comboBoxbusqueda.Location = new System.Drawing.Point(309, 23);
            this.comboBoxbusqueda.Name = "comboBoxbusqueda";
            this.comboBoxbusqueda.Size = new System.Drawing.Size(163, 28);
            this.comboBoxbusqueda.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(780, 592);
            this.dataGridView1.TabIndex = 32;
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EBEST.Properties.Resources.fondoupdate2;
            this.ClientSize = new System.Drawing.Size(780, 792);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxbusqueda);
            this.Controls.Add(this.btnpagado);
            this.Controls.Add(this.checkBoxnumero);
            this.Controls.Add(this.checkBoxorden);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pedidos";
            this.Text = "pedidos";
            this.Load += new System.EventHandler(this.pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxnumero;
        private System.Windows.Forms.CheckBox checkBoxorden;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnpagado;
        private System.Windows.Forms.ComboBox comboBoxbusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}