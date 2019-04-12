namespace TellerB1
{
    partial class Cuadre
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
            this.label1 = new System.Windows.Forms.Label();
            this.reportCuadre = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Banco1 = new System.Windows.Forms.Label();
            this.cuadreDatos = new System.Windows.Forms.GroupBox();
            this.fechaFinal = new System.Windows.Forms.Label();
            this.fechaCiere1 = new System.Windows.Forms.Label();
            this.fechaInicial = new System.Windows.Forms.Label();
            this.fechaInicial1 = new System.Windows.Forms.Label();
            this.noCajero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceInicial = new System.Windows.Forms.Label();
            this.balanceFinal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firmas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cajero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nombreCajero = new System.Windows.Forms.Label();
            this.nombreSupervisor = new System.Windows.Forms.Label();
            this.cuadreDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu de Cuadre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportCuadre
            // 
            this.reportCuadre.Location = new System.Drawing.Point(4, 79);
            this.reportCuadre.Name = "reportCuadre";
            this.reportCuadre.ServerReport.BearerToken = null;
            this.reportCuadre.Size = new System.Drawing.Size(1428, 742);
            this.reportCuadre.TabIndex = 11;
            this.reportCuadre.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Banco1
            // 
            this.Banco1.AutoSize = true;
            this.Banco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banco1.Location = new System.Drawing.Point(575, 12);
            this.Banco1.Name = "Banco1";
            this.Banco1.Size = new System.Drawing.Size(135, 32);
            this.Banco1.TabIndex = 12;
            this.Banco1.Text = "Banco #1";
            // 
            // cuadreDatos
            // 
            this.cuadreDatos.Controls.Add(this.nombreSupervisor);
            this.cuadreDatos.Controls.Add(this.nombreCajero);
            this.cuadreDatos.Controls.Add(this.label8);
            this.cuadreDatos.Controls.Add(this.cajero);
            this.cuadreDatos.Controls.Add(this.label6);
            this.cuadreDatos.Controls.Add(this.firmas);
            this.cuadreDatos.Controls.Add(this.label5);
            this.cuadreDatos.Controls.Add(this.label11);
            this.cuadreDatos.Controls.Add(this.balanceFinal);
            this.cuadreDatos.Controls.Add(this.balanceInicial);
            this.cuadreDatos.Controls.Add(this.label3);
            this.cuadreDatos.Controls.Add(this.label4);
            this.cuadreDatos.Controls.Add(this.dataGridView1);
            this.cuadreDatos.Controls.Add(this.fechaFinal);
            this.cuadreDatos.Controls.Add(this.fechaCiere1);
            this.cuadreDatos.Controls.Add(this.fechaInicial);
            this.cuadreDatos.Controls.Add(this.fechaInicial1);
            this.cuadreDatos.Controls.Add(this.noCajero);
            this.cuadreDatos.Controls.Add(this.label2);
            this.cuadreDatos.Controls.Add(this.Banco1);
            this.cuadreDatos.Location = new System.Drawing.Point(4, 115);
            this.cuadreDatos.Name = "cuadreDatos";
            this.cuadreDatos.Size = new System.Drawing.Size(1428, 706);
            this.cuadreDatos.TabIndex = 13;
            this.cuadreDatos.TabStop = false;
            // 
            // fechaFinal
            // 
            this.fechaFinal.AutoSize = true;
            this.fechaFinal.Location = new System.Drawing.Point(1265, 59);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(49, 20);
            this.fechaFinal.TabIndex = 18;
            this.fechaFinal.Text = "fecha";
            // 
            // fechaCiere1
            // 
            this.fechaCiere1.AutoSize = true;
            this.fechaCiere1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCiere1.Location = new System.Drawing.Point(1049, 59);
            this.fechaCiere1.Name = "fechaCiere1";
            this.fechaCiere1.Size = new System.Drawing.Size(112, 20);
            this.fechaCiere1.TabIndex = 17;
            this.fechaCiere1.Text = "Fecha Cierre";
            // 
            // fechaInicial
            // 
            this.fechaInicial.AutoSize = true;
            this.fechaInicial.Location = new System.Drawing.Point(1265, 24);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(49, 20);
            this.fechaInicial.TabIndex = 16;
            this.fechaInicial.Text = "fecha";
            this.fechaInicial.Click += new System.EventHandler(this.label4_Click);
            // 
            // fechaInicial1
            // 
            this.fechaInicial1.AutoSize = true;
            this.fechaInicial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicial1.Location = new System.Drawing.Point(1049, 24);
            this.fechaInicial1.Name = "fechaInicial1";
            this.fechaInicial1.Size = new System.Drawing.Size(134, 20);
            this.fechaInicial1.TabIndex = 15;
            this.fechaInicial1.Text = "Fecha Apertura";
            // 
            // noCajero
            // 
            this.noCajero.AutoSize = true;
            this.noCajero.Location = new System.Drawing.Point(6, 32);
            this.noCajero.Name = "noCajero";
            this.noCajero.Size = new System.Drawing.Size(92, 20);
            this.noCajero.TabIndex = 14;
            this.noCajero.Text = "No de Cjaro";
            this.noCajero.Click += new System.EventHandler(this.noCajero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cajero";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaccion});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(10, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1345, 189);
            this.dataGridView1.TabIndex = 36;
            // 
            // Transaccion
            // 
            this.Transaccion.HeaderText = "Transaccion";
            this.Transaccion.Name = "Transaccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Balance Inicial";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Balance Final";
            // 
            // balanceInicial
            // 
            this.balanceInicial.AutoSize = true;
            this.balanceInicial.Location = new System.Drawing.Point(241, 545);
            this.balanceInicial.Name = "balanceInicial";
            this.balanceInicial.Size = new System.Drawing.Size(65, 20);
            this.balanceInicial.TabIndex = 39;
            this.balanceInicial.Text = "balance";
            // 
            // balanceFinal
            // 
            this.balanceFinal.AutoSize = true;
            this.balanceFinal.Location = new System.Drawing.Point(241, 605);
            this.balanceFinal.Name = "balanceFinal";
            this.balanceFinal.Size = new System.Drawing.Size(65, 20);
            this.balanceFinal.TabIndex = 40;
            this.balanceFinal.Text = "balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1129, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Firma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1129, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Firma";
            // 
            // firmas
            // 
            this.firmas.AutoSize = true;
            this.firmas.Location = new System.Drawing.Point(1254, 545);
            this.firmas.Name = "firmas";
            this.firmas.Size = new System.Drawing.Size(126, 20);
            this.firmas.TabIndex = 43;
            this.firmas.Text = "_____________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1254, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "_____________";
            // 
            // cajero
            // 
            this.cajero.AutoSize = true;
            this.cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajero.Location = new System.Drawing.Point(753, 545);
            this.cajero.Name = "cajero";
            this.cajero.Size = new System.Drawing.Size(61, 20);
            this.cajero.TabIndex = 45;
            this.cajero.Text = "Cajero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(753, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Supervisor";
            // 
            // nombreCajero
            // 
            this.nombreCajero.AutoSize = true;
            this.nombreCajero.Location = new System.Drawing.Point(955, 545);
            this.nombreCajero.Name = "nombreCajero";
            this.nombreCajero.Size = new System.Drawing.Size(63, 20);
            this.nombreCajero.TabIndex = 47;
            this.nombreCajero.Text = "nombre";
            // 
            // nombreSupervisor
            // 
            this.nombreSupervisor.AutoSize = true;
            this.nombreSupervisor.Location = new System.Drawing.Point(955, 605);
            this.nombreSupervisor.Name = "nombreSupervisor";
            this.nombreSupervisor.Size = new System.Drawing.Size(63, 20);
            this.nombreSupervisor.TabIndex = 48;
            this.nombreSupervisor.Text = "nombre";
            // 
            // Cuadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 825);
            this.Controls.Add(this.cuadreDatos);
            this.Controls.Add(this.reportCuadre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cuadre";
            this.Text = "Cuadre";
            this.Load += new System.EventHandler(this.Cuadre_Load);
            this.cuadreDatos.ResumeLayout(false);
            this.cuadreDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportCuadre;
        private System.Windows.Forms.Label Banco1;
        private System.Windows.Forms.GroupBox cuadreDatos;
        private System.Windows.Forms.Label noCajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fechaFinal;
        private System.Windows.Forms.Label fechaCiere1;
        private System.Windows.Forms.Label fechaInicial;
        private System.Windows.Forms.Label fechaInicial1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label balanceFinal;
        private System.Windows.Forms.Label balanceInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label nombreSupervisor;
        private System.Windows.Forms.Label nombreCajero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cajero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label firmas;
    }
}