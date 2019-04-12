namespace TellerB1
{
    partial class Report
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
            this.reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Banco1 = new System.Windows.Forms.Label();
            this.reciboDatos = new System.Windows.Forms.GroupBox();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noCajero = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuenta = new System.Windows.Forms.Label();
            this.noRecibo = new System.Windows.Forms.Label();
            this.reciboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.Location = new System.Drawing.Point(3, 0);
            this.reporte.Name = "reporte";
            this.reporte.ServerReport.BearerToken = null;
            this.reporte.Size = new System.Drawing.Size(801, 513);
            this.reporte.TabIndex = 0;
            this.reporte.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Banco1
            // 
            this.Banco1.AutoSize = true;
            this.Banco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banco1.Location = new System.Drawing.Point(202, 12);
            this.Banco1.Name = "Banco1";
            this.Banco1.Size = new System.Drawing.Size(135, 32);
            this.Banco1.TabIndex = 1;
            this.Banco1.Text = "Banco #1";
            // 
            // reciboDatos
            // 
            this.reciboDatos.Controls.Add(this.noRecibo);
            this.reciboDatos.Controls.Add(this.cuenta);
            this.reciboDatos.Controls.Add(this.label5);
            this.reciboDatos.Controls.Add(this.label4);
            this.reciboDatos.Controls.Add(this.monto);
            this.reciboDatos.Controls.Add(this.noCajero);
            this.reciboDatos.Controls.Add(this.label2);
            this.reciboDatos.Controls.Add(this.label1);
            this.reciboDatos.Controls.Add(this.hora);
            this.reciboDatos.Controls.Add(this.fecha);
            this.reciboDatos.Controls.Add(this.Banco1);
            this.reciboDatos.Location = new System.Drawing.Point(81, 53);
            this.reciboDatos.Name = "reciboDatos";
            this.reciboDatos.Size = new System.Drawing.Size(532, 437);
            this.reciboDatos.TabIndex = 2;
            this.reciboDatos.TabStop = false;
            this.reciboDatos.Enter += new System.EventHandler(this.reciboDatos_Enter);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(402, 12);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(54, 20);
            this.fecha.TabIndex = 2;
            this.fecha.Text = "Fecha";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(402, 41);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(44, 20);
            this.hora.TabIndex = 3;
            this.hora.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "No de Recibo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cajero";
            // 
            // noCajero
            // 
            this.noCajero.AutoSize = true;
            this.noCajero.Location = new System.Drawing.Point(6, 61);
            this.noCajero.Name = "noCajero";
            this.noCajero.Size = new System.Drawing.Size(92, 20);
            this.noCajero.TabIndex = 6;
            this.noCajero.Text = "No de Cjaro";
            this.noCajero.Click += new System.EventHandler(this.label3_Click);
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(270, 210);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(67, 25);
            this.monto.TabIndex = 7;
            this.monto.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deposito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuenta";
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuenta.Location = new System.Drawing.Point(271, 167);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(91, 25);
            this.cuenta.TabIndex = 10;
            this.cuenta.Text = "@cuenta";
            // 
            // noRecibo
            // 
            this.noRecibo.AutoSize = true;
            this.noRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecibo.Location = new System.Drawing.Point(272, 115);
            this.noRecibo.Name = "noRecibo";
            this.noRecibo.Size = new System.Drawing.Size(65, 25);
            this.noRecibo.TabIndex = 11;
            this.noRecibo.Text = "recibo";
            this.noRecibo.Click += new System.EventHandler(this.recibo_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.reciboDatos);
            this.Controls.Add(this.reporte);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.reciboDatos.ResumeLayout(false);
            this.reciboDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte;
        private System.Windows.Forms.Label Banco1;
        private System.Windows.Forms.GroupBox reciboDatos;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label noCajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Label noRecibo;
        private System.Windows.Forms.Label cuenta;
    }
}