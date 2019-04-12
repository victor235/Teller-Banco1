namespace TellerB1
{
    partial class Deposito
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.Recibo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbVerificarCuenta = new System.Windows.Forms.GroupBox();
            this.tbCuentaVerificada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVerificarCuenta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClienteVerificado = new System.Windows.Forms.TextBox();
            this.tbVerificarCuenta = new System.Windows.Forms.TextBox();
            this.gbRecibo = new System.Windows.Forms.GroupBox();
            this.dtgvDenominaciones = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbEfectivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRealDevuelta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDevuelta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvDevuelta = new System.Windows.Forms.DataGridView();
            this.Recibo.SuspendLayout();
            this.gbVerificarCuenta.SuspendLayout();
            this.gbRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDenominaciones)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDevuelta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu de Depositos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "No de Cuenta";
            // 
            // tbCuenta
            // 
            this.tbCuenta.BackColor = System.Drawing.SystemColors.Window;
            this.tbCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuenta.Location = new System.Drawing.Point(178, 63);
            this.tbCuenta.Name = "tbCuenta";
            this.tbCuenta.Size = new System.Drawing.Size(189, 23);
            this.tbCuenta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monto ";
            // 
            // tbMonto
            // 
            this.tbMonto.BackColor = System.Drawing.SystemColors.Window;
            this.tbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.Location = new System.Drawing.Point(178, 125);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(189, 23);
            this.tbMonto.TabIndex = 14;
            this.tbMonto.Leave += new System.EventHandler(this.tbMonto_Leave);
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposito.Enabled = false;
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.ForeColor = System.Drawing.Color.Black;
            this.btnDeposito.Location = new System.Drawing.Point(106, 187);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(149, 29);
            this.btnDeposito.TabIndex = 15;
            this.btnDeposito.Text = "Realizar Deposito";
            this.btnDeposito.UseVisualStyleBackColor = false;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // Recibo
            // 
            this.Recibo.Controls.Add(this.label6);
            this.Recibo.Controls.Add(this.label2);
            this.Recibo.Controls.Add(this.btnDeposito);
            this.Recibo.Controls.Add(this.tbCuenta);
            this.Recibo.Controls.Add(this.tbMonto);
            this.Recibo.Controls.Add(this.label3);
            this.Recibo.Location = new System.Drawing.Point(29, 219);
            this.Recibo.Margin = new System.Windows.Forms.Padding(2);
            this.Recibo.Name = "Recibo";
            this.Recibo.Padding = new System.Windows.Forms.Padding(2);
            this.Recibo.Size = new System.Drawing.Size(391, 245);
            this.Recibo.TabIndex = 19;
            this.Recibo.TabStop = false;
            this.Recibo.Text = "Finalizar Deposito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Entrada de efectivo";
            // 
            // gbVerificarCuenta
            // 
            this.gbVerificarCuenta.Controls.Add(this.tbCuentaVerificada);
            this.gbVerificarCuenta.Controls.Add(this.label7);
            this.gbVerificarCuenta.Controls.Add(this.btnVerificarCuenta);
            this.gbVerificarCuenta.Controls.Add(this.label5);
            this.gbVerificarCuenta.Controls.Add(this.tbClienteVerificado);
            this.gbVerificarCuenta.Controls.Add(this.tbVerificarCuenta);
            this.gbVerificarCuenta.Location = new System.Drawing.Point(29, 46);
            this.gbVerificarCuenta.Name = "gbVerificarCuenta";
            this.gbVerificarCuenta.Size = new System.Drawing.Size(350, 154);
            this.gbVerificarCuenta.TabIndex = 20;
            this.gbVerificarCuenta.TabStop = false;
            this.gbVerificarCuenta.Text = "Verificar Cuenta";
            // 
            // tbCuentaVerificada
            // 
            this.tbCuentaVerificada.BackColor = System.Drawing.SystemColors.Window;
            this.tbCuentaVerificada.Location = new System.Drawing.Point(182, 116);
            this.tbCuentaVerificada.Name = "tbCuentaVerificada";
            this.tbCuentaVerificada.ReadOnly = true;
            this.tbCuentaVerificada.Size = new System.Drawing.Size(118, 20);
            this.tbCuentaVerificada.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(59, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cuenta:";
            // 
            // btnVerificarCuenta
            // 
            this.btnVerificarCuenta.Location = new System.Drawing.Point(205, 41);
            this.btnVerificarCuenta.Name = "btnVerificarCuenta";
            this.btnVerificarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarCuenta.TabIndex = 1;
            this.btnVerificarCuenta.Text = "Verificar";
            this.btnVerificarCuenta.UseVisualStyleBackColor = true;
            this.btnVerificarCuenta.Click += new System.EventHandler(this.btnVerificarCuenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(59, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cliente:";
            // 
            // tbClienteVerificado
            // 
            this.tbClienteVerificado.BackColor = System.Drawing.SystemColors.Window;
            this.tbClienteVerificado.Location = new System.Drawing.Point(182, 95);
            this.tbClienteVerificado.Name = "tbClienteVerificado";
            this.tbClienteVerificado.ReadOnly = true;
            this.tbClienteVerificado.Size = new System.Drawing.Size(118, 20);
            this.tbClienteVerificado.TabIndex = 2;
            // 
            // tbVerificarCuenta
            // 
            this.tbVerificarCuenta.Location = new System.Drawing.Point(48, 43);
            this.tbVerificarCuenta.Name = "tbVerificarCuenta";
            this.tbVerificarCuenta.Size = new System.Drawing.Size(100, 20);
            this.tbVerificarCuenta.TabIndex = 0;
            // 
            // gbRecibo
            // 
            this.gbRecibo.Controls.Add(this.dtgvDenominaciones);
            this.gbRecibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRecibo.Location = new System.Drawing.Point(3, 3);
            this.gbRecibo.Name = "gbRecibo";
            this.gbRecibo.Size = new System.Drawing.Size(404, 335);
            this.gbRecibo.TabIndex = 21;
            this.gbRecibo.TabStop = false;
            this.gbRecibo.Text = "Denominaciones";
            // 
            // dtgvDenominaciones
            // 
            this.dtgvDenominaciones.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvDenominaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDenominaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDenominaciones.Location = new System.Drawing.Point(3, 16);
            this.dtgvDenominaciones.Name = "dtgvDenominaciones";
            this.dtgvDenominaciones.Size = new System.Drawing.Size(398, 316);
            this.dtgvDenominaciones.TabIndex = 0;
            this.dtgvDenominaciones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDenominaciones_CellEndEdit);
            this.dtgvDenominaciones.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgvDenominaciones_DataError);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(425, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 423);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.tbEfectivo);
            this.tabPage1.Controls.Add(this.gbRecibo);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Total Efectivo";
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.BackColor = System.Drawing.SystemColors.Window;
            this.tbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEfectivo.Location = new System.Drawing.Point(222, 355);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.ReadOnly = true;
            this.tbEfectivo.Size = new System.Drawing.Size(145, 23);
            this.tbEfectivo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total Efectivo";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.tbDevuelta);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.tbRealDevuelta);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devuelta";
            // 
            // tbRealDevuelta
            // 
            this.tbRealDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRealDevuelta.Location = new System.Drawing.Point(221, 360);
            this.tbRealDevuelta.Name = "tbRealDevuelta";
            this.tbRealDevuelta.ReadOnly = true;
            this.tbRealDevuelta.Size = new System.Drawing.Size(145, 23);
            this.tbRealDevuelta.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Total Denominaciones";
            // 
            // tbDevuelta
            // 
            this.tbDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDevuelta.Location = new System.Drawing.Point(221, 330);
            this.tbDevuelta.Name = "tbDevuelta";
            this.tbDevuelta.ReadOnly = true;
            this.tbDevuelta.Size = new System.Drawing.Size(145, 23);
            this.tbDevuelta.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Devuelta Requerida";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvDevuelta);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 310);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Denominaciones";
            // 
            // dtgvDevuelta
            // 
            this.dtgvDevuelta.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvDevuelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDevuelta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDevuelta.Enabled = false;
            this.dtgvDevuelta.Location = new System.Drawing.Point(3, 16);
            this.dtgvDevuelta.Name = "dtgvDevuelta";
            this.dtgvDevuelta.Size = new System.Drawing.Size(398, 291);
            this.dtgvDevuelta.TabIndex = 0;
            this.dtgvDevuelta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDevuelta_CellEndEdit);
            this.dtgvDevuelta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgvDevuelta_DataError);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(874, 474);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbVerificarCuenta);
            this.Controls.Add(this.Recibo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.Deposito_Load);
            this.Recibo.ResumeLayout(false);
            this.Recibo.PerformLayout();
            this.gbVerificarCuenta.ResumeLayout(false);
            this.gbVerificarCuenta.PerformLayout();
            this.gbRecibo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDenominaciones)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDevuelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.GroupBox Recibo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbVerificarCuenta;
        private System.Windows.Forms.TextBox tbCuentaVerificada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClienteVerificado;
        private System.Windows.Forms.Button btnVerificarCuenta;
        private System.Windows.Forms.TextBox tbVerificarCuenta;
        private System.Windows.Forms.GroupBox gbRecibo;
        private System.Windows.Forms.DataGridView dtgvDenominaciones;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbEfectivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDevuelta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDevuelta;
        private System.Windows.Forms.TextBox tbRealDevuelta;
        private System.Windows.Forms.Label label10;
    }
}