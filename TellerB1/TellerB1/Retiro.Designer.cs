namespace TellerB1
{
    partial class Retiro
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
            this.label3 = new System.Windows.Forms.Label();
            this.noCuenta = new System.Windows.Forms.TextBox();
            this.dmonto = new System.Windows.Forms.TextBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu de Retiros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "No de Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Monto a Retirar";
            // 
            // noCuenta
            // 
            this.noCuenta.Location = new System.Drawing.Point(221, 58);
            this.noCuenta.Name = "noCuenta";
            this.noCuenta.Size = new System.Drawing.Size(205, 20);
            this.noCuenta.TabIndex = 15;
            // 
            // dmonto
            // 
            this.dmonto.Location = new System.Drawing.Point(221, 103);
            this.dmonto.Name = "dmonto";
            this.dmonto.Size = new System.Drawing.Size(205, 20);
            this.dmonto.TabIndex = 16;
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.Transparent;
            this.btnRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.ForeColor = System.Drawing.Color.Black;
            this.btnRetiro.Location = new System.Drawing.Point(243, 162);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(149, 29);
            this.btnRetiro.TabIndex = 17;
            this.btnRetiro.Text = "Completar Retiro";
            this.btnRetiro.UseVisualStyleBackColor = false;
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 536);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.dmonto);
            this.Controls.Add(this.noCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Retiro";
            this.Text = "Retiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox noCuenta;
        private System.Windows.Forms.TextBox dmonto;
        private System.Windows.Forms.Button btnRetiro;
    }
}