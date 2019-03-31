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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbFotoCliente = new System.Windows.Forms.PictureBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCedula = new System.Windows.Forms.Button();
            this.Recibo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbVerificarCuenta = new System.Windows.Forms.GroupBox();
            this.tblyClienteCuenta = new System.Windows.Forms.TableLayoutPanel();
            this.tbCuentaVerificada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClienteVerificado = new System.Windows.Forms.TextBox();
            this.btnVerificarCuenta = new System.Windows.Forms.Button();
            this.tbVerificarCuenta = new System.Windows.Forms.TextBox();
            this.gbRecibo = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoCliente)).BeginInit();
            this.Recibo.SuspendLayout();
            this.gbVerificarCuenta.SuspendLayout();
            this.tblyClienteCuenta.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(-4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "No de Cuenta";
            // 
            // tbCuenta
            // 
            this.tbCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuenta.Location = new System.Drawing.Point(178, 63);
            this.tbCuenta.Name = "tbCuenta";
            this.tbCuenta.ReadOnly = true;
            this.tbCuenta.Size = new System.Drawing.Size(189, 23);
            this.tbCuenta.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monto a Depositar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonto.Location = new System.Drawing.Point(178, 125);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(189, 23);
            this.tbMonto.TabIndex = 14;
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.ForeColor = System.Drawing.Color.Black;
            this.btnDeposito.Location = new System.Drawing.Point(178, 187);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(149, 29);
            this.btnDeposito.TabIndex = 15;
            this.btnDeposito.Text = "Realizar Deposito";
            this.btnDeposito.UseVisualStyleBackColor = false;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbFotoCliente);
            this.groupBox1.Controls.Add(this.tbCedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCedula);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ptbFotoCliente
            // 
            this.ptbFotoCliente.Location = new System.Drawing.Point(11, 76);
            this.ptbFotoCliente.Name = "ptbFotoCliente";
            this.ptbFotoCliente.Size = new System.Drawing.Size(92, 78);
            this.ptbFotoCliente.TabIndex = 18;
            this.ptbFotoCliente.TabStop = false;
            // 
            // tbCedula
            // 
            this.tbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.Location = new System.Drawing.Point(145, 40);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(190, 23);
            this.tbCedula.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "No de Cedula";
            // 
            // btnCedula
            // 
            this.btnCedula.BackColor = System.Drawing.Color.Transparent;
            this.btnCedula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCedula.ForeColor = System.Drawing.Color.Black;
            this.btnCedula.Location = new System.Drawing.Point(160, 92);
            this.btnCedula.Name = "btnCedula";
            this.btnCedula.Size = new System.Drawing.Size(149, 29);
            this.btnCedula.TabIndex = 17;
            this.btnCedula.Text = "Verificar Cedula";
            this.btnCedula.UseVisualStyleBackColor = false;
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
            this.gbVerificarCuenta.Controls.Add(this.tblyClienteCuenta);
            this.gbVerificarCuenta.Controls.Add(this.btnVerificarCuenta);
            this.gbVerificarCuenta.Controls.Add(this.tbVerificarCuenta);
            this.gbVerificarCuenta.Location = new System.Drawing.Point(501, 42);
            this.gbVerificarCuenta.Name = "gbVerificarCuenta";
            this.gbVerificarCuenta.Size = new System.Drawing.Size(350, 154);
            this.gbVerificarCuenta.TabIndex = 20;
            this.gbVerificarCuenta.TabStop = false;
            this.gbVerificarCuenta.Text = "Verificar Cuenta";
            // 
            // tblyClienteCuenta
            // 
            this.tblyClienteCuenta.ColumnCount = 2;
            this.tblyClienteCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblyClienteCuenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblyClienteCuenta.Controls.Add(this.tbCuentaVerificada, 1, 1);
            this.tblyClienteCuenta.Controls.Add(this.label7, 0, 1);
            this.tblyClienteCuenta.Controls.Add(this.label5, 0, 0);
            this.tblyClienteCuenta.Controls.Add(this.tbClienteVerificado, 1, 0);
            this.tblyClienteCuenta.Location = new System.Drawing.Point(48, 92);
            this.tblyClienteCuenta.Name = "tblyClienteCuenta";
            this.tblyClienteCuenta.RowCount = 2;
            this.tblyClienteCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblyClienteCuenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblyClienteCuenta.Size = new System.Drawing.Size(247, 42);
            this.tblyClienteCuenta.TabIndex = 2;
            // 
            // tbCuentaVerificada
            // 
            this.tbCuentaVerificada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCuentaVerificada.Location = new System.Drawing.Point(126, 24);
            this.tbCuentaVerificada.Name = "tbCuentaVerificada";
            this.tbCuentaVerificada.ReadOnly = true;
            this.tbCuentaVerificada.Size = new System.Drawing.Size(118, 20);
            this.tbCuentaVerificada.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(3, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cliente:";
            // 
            // tbClienteVerificado
            // 
            this.tbClienteVerificado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClienteVerificado.Location = new System.Drawing.Point(126, 3);
            this.tbClienteVerificado.Name = "tbClienteVerificado";
            this.tbClienteVerificado.ReadOnly = true;
            this.tbClienteVerificado.Size = new System.Drawing.Size(118, 20);
            this.tbClienteVerificado.TabIndex = 2;
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
            // tbVerificarCuenta
            // 
            this.tbVerificarCuenta.Location = new System.Drawing.Point(48, 43);
            this.tbVerificarCuenta.Name = "tbVerificarCuenta";
            this.tbVerificarCuenta.Size = new System.Drawing.Size(100, 20);
            this.tbVerificarCuenta.TabIndex = 0;
            // 
            // gbRecibo
            // 
            this.gbRecibo.Location = new System.Drawing.Point(490, 219);
            this.gbRecibo.Name = "gbRecibo";
            this.gbRecibo.Size = new System.Drawing.Size(382, 245);
            this.gbRecibo.TabIndex = 21;
            this.gbRecibo.TabStop = false;
            this.gbRecibo.Text = "Recibo";
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.gbRecibo);
            this.Controls.Add(this.gbVerificarCuenta);
            this.Controls.Add(this.Recibo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoCliente)).EndInit();
            this.Recibo.ResumeLayout(false);
            this.Recibo.PerformLayout();
            this.gbVerificarCuenta.ResumeLayout(false);
            this.gbVerificarCuenta.PerformLayout();
            this.tblyClienteCuenta.ResumeLayout(false);
            this.tblyClienteCuenta.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCedula;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Recibo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox ptbFotoCliente;
        private System.Windows.Forms.GroupBox gbVerificarCuenta;
        private System.Windows.Forms.TableLayoutPanel tblyClienteCuenta;
        private System.Windows.Forms.TextBox tbCuentaVerificada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClienteVerificado;
        private System.Windows.Forms.Button btnVerificarCuenta;
        private System.Windows.Forms.TextBox tbVerificarCuenta;
        private System.Windows.Forms.GroupBox gbRecibo;
    }
}