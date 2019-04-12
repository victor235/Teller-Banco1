namespace TellerB1
{
    partial class Inventario
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
            this.gbRecibo = new System.Windows.Forms.GroupBox();
            this.dtgvDenominaciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.gbRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDenominaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventario DIsponible";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbRecibo
            // 
            this.gbRecibo.Controls.Add(this.dtgvDenominaciones);
            this.gbRecibo.Location = new System.Drawing.Point(16, 60);
            this.gbRecibo.Name = "gbRecibo";
            this.gbRecibo.Size = new System.Drawing.Size(569, 370);
            this.gbRecibo.TabIndex = 23;
            this.gbRecibo.TabStop = false;
            this.gbRecibo.Text = "Inventario de Efectivo";
            // 
            // dtgvDenominaciones
            // 
            this.dtgvDenominaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDenominaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDenominaciones.Location = new System.Drawing.Point(3, 16);
            this.dtgvDenominaciones.Name = "dtgvDenominaciones";
            this.dtgvDenominaciones.Size = new System.Drawing.Size(563, 351);
            this.dtgvDenominaciones.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Balance Total";
            // 
            // tbBalance
            // 
            this.tbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.Location = new System.Drawing.Point(631, 225);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(190, 23);
            this.tbBalance.TabIndex = 26;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.gbRecibo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.gbRecibo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDenominaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRecibo;
        private System.Windows.Forms.DataGridView dtgvDenominaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBalance;
    }
}