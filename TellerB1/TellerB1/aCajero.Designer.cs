namespace TellerB1
{
    partial class aCajero
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
            this.agregarCajero = new System.Windows.Forms.Button();
            this.eliminarCajero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarCajero
            // 
            this.agregarCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCajero.Location = new System.Drawing.Point(113, 683);
            this.agregarCajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarCajero.Name = "agregarCajero";
            this.agregarCajero.Size = new System.Drawing.Size(202, 49);
            this.agregarCajero.TabIndex = 0;
            this.agregarCajero.Text = "Agregar Cajero";
            this.agregarCajero.UseVisualStyleBackColor = true;
            this.agregarCajero.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarCajero
            // 
            this.eliminarCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCajero.Location = new System.Drawing.Point(966, 683);
            this.eliminarCajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarCajero.Name = "eliminarCajero";
            this.eliminarCajero.Size = new System.Drawing.Size(202, 49);
            this.eliminarCajero.TabIndex = 1;
            this.eliminarCajero.Text = "Eliminar Cajero";
            this.eliminarCajero.UseVisualStyleBackColor = true;
            // 
            // aCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.eliminarCajero);
            this.Controls.Add(this.agregarCajero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aCajero";
            this.Text = "aCajero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarCajero;
        private System.Windows.Forms.Button eliminarCajero;
    }
}