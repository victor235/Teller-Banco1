﻿namespace TellerB1
{
    partial class ReciboRetiro
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
            this.reciboDatos = new System.Windows.Forms.GroupBox();
            this.firmas = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.Label();
            this.mntTotal = new System.Windows.Forms.Label();
            this.devuelta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Retiro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noRecibo = new System.Windows.Forms.Label();
            this.cuenta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.Label();
            this.noCajero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.Banco1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.Location = new System.Drawing.Point(1, -1);
            this.reporte.Name = "reporte";
            this.reporte.ServerReport.BearerToken = null;
            this.reporte.Size = new System.Drawing.Size(541, 663);
            this.reporte.TabIndex = 1;
            this.reporte.Load += new System.EventHandler(this.reporte_Load);
            // 
            // reciboDatos
            // 
            this.reciboDatos.Controls.Add(this.dataGridView1);
            this.reciboDatos.Controls.Add(this.firmas);
            this.reciboDatos.Controls.Add(this.nombre);
            this.reciboDatos.Controls.Add(this.label11);
            this.reciboDatos.Controls.Add(this.cliente);
            this.reciboDatos.Controls.Add(this.mntTotal);
            this.reciboDatos.Controls.Add(this.devuelta);
            this.reciboDatos.Controls.Add(this.label9);
            this.reciboDatos.Controls.Add(this.label8);
            this.reciboDatos.Controls.Add(this.Retiro);
            this.reciboDatos.Controls.Add(this.label7);
            this.reciboDatos.Controls.Add(this.label6);
            this.reciboDatos.Controls.Add(this.label3);
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
            this.reciboDatos.Location = new System.Drawing.Point(1, 31);
            this.reciboDatos.Name = "reciboDatos";
            this.reciboDatos.Size = new System.Drawing.Size(541, 631);
            this.reciboDatos.TabIndex = 3;
            this.reciboDatos.TabStop = false;
            // 
            // firmas
            // 
            this.firmas.AutoSize = true;
            this.firmas.Location = new System.Drawing.Point(323, 583);
            this.firmas.Name = "firmas";
            this.firmas.Size = new System.Drawing.Size(126, 20);
            this.firmas.TabIndex = 38;
            this.firmas.Text = "_____________";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(39, 583);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(63, 20);
            this.nombre.TabIndex = 37;
            this.nombre.Text = "nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Firma";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(39, 545);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(65, 20);
            this.cliente.TabIndex = 35;
            this.cliente.Text = "Cliente";
            // 
            // mntTotal
            // 
            this.mntTotal.AutoSize = true;
            this.mntTotal.Location = new System.Drawing.Point(320, 507);
            this.mntTotal.Name = "mntTotal";
            this.mntTotal.Size = new System.Drawing.Size(44, 20);
            this.mntTotal.TabIndex = 34;
            this.mntTotal.Text = "Total";
            // 
            // devuelta
            // 
            this.devuelta.AutoSize = true;
            this.devuelta.Location = new System.Drawing.Point(320, 468);
            this.devuelta.Name = "devuelta";
            this.devuelta.Size = new System.Drawing.Size(69, 20);
            this.devuelta.TabIndex = 33;
            this.devuelta.Text = "devuelta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Monto Retirado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Devuelta";
            // 
            // Retiro
            // 
            this.Retiro.AutoSize = true;
            this.Retiro.Location = new System.Drawing.Point(235, 41);
            this.Retiro.Name = "Retiro";
            this.Retiro.Size = new System.Drawing.Size(52, 20);
            this.Retiro.TabIndex = 30;
            this.Retiro.Text = "Retiro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Denominacion";
            // 
            // noRecibo
            // 
            this.noRecibo.AutoSize = true;
            this.noRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRecibo.Location = new System.Drawing.Point(264, 97);
            this.noRecibo.Name = "noRecibo";
            this.noRecibo.Size = new System.Drawing.Size(52, 20);
            this.noRecibo.TabIndex = 11;
            this.noRecibo.Text = "recibo";
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuenta.Location = new System.Drawing.Point(264, 129);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(74, 20);
            this.cuenta.TabIndex = 10;
            this.cuenta.Text = "@cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total de Efectivo";
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(320, 432);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(54, 20);
            this.monto.TabIndex = 7;
            this.monto.Text = "Monto";
            // 
            // noCajero
            // 
            this.noCajero.AutoSize = true;
            this.noCajero.Location = new System.Drawing.Point(6, 61);
            this.noCajero.Name = "noCajero";
            this.noCajero.Size = new System.Drawing.Size(92, 20);
            this.noCajero.TabIndex = 6;
            this.noCajero.Text = "No de Cjaro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cajero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "No de Recibo";
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
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(402, 12);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(54, 20);
            this.fecha.TabIndex = 2;
            this.fecha.Text = "Fecha";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denominacion,
            this.Cantidad,
            this.Montos});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(56, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(429, 189);
            this.dataGridView1.TabIndex = 39;
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.Name = "Denominacion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Montos
            // 
            this.Montos.HeaderText = "Monto";
            this.Montos.Name = "Montos";
            // 
            // ReciboRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 663);
            this.Controls.Add(this.reciboDatos);
            this.Controls.Add(this.reporte);
            this.Name = "ReciboRetiro";
            this.Text = "ReciboRetiro";
            this.reciboDatos.ResumeLayout(false);
            this.reciboDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporte;
        private System.Windows.Forms.GroupBox reciboDatos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.Label mntTotal;
        private System.Windows.Forms.Label devuelta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Retiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noRecibo;
        private System.Windows.Forms.Label cuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Label noCajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label Banco1;
        private System.Windows.Forms.Label firmas;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montos;
    }
}