namespace TellerB1
{
    partial class MenuAdministrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrar));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Minim = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teller-> Administracion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalToolStripMenuItem,
            this.manejoDeInventarioToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(6, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(209, 27);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajerosToolStripMenuItem});
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.sucursalToolStripMenuItem.Text = "Caja";
            // 
            // cajerosToolStripMenuItem
            // 
            this.cajerosToolStripMenuItem.Name = "cajerosToolStripMenuItem";
            this.cajerosToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.cajerosToolStripMenuItem.Text = "Cajeros";
            this.cajerosToolStripMenuItem.Click += new System.EventHandler(this.cajerosToolStripMenuItem_Click);
            // 
            // manejoDeInventarioToolStripMenuItem
            // 
            this.manejoDeInventarioToolStripMenuItem.Name = "manejoDeInventarioToolStripMenuItem";
            this.manejoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.manejoDeInventarioToolStripMenuItem.Text = "Inventario";
            this.manejoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.manejoDeInventarioToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(923, -1);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(29, 29);
            this.Cerrar.TabIndex = 13;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minim
            // 
            this.Minim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minim.FlatAppearance.BorderSize = 0;
            this.Minim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minim.Image = ((System.Drawing.Image)(resources.GetObject("Minim.Image")));
            this.Minim.Location = new System.Drawing.Point(884, 7);
            this.Minim.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Minim.Name = "Minim";
            this.Minim.Size = new System.Drawing.Size(30, 22);
            this.Minim.TabIndex = 14;
            this.Minim.UseVisualStyleBackColor = false;
            this.Minim.Click += new System.EventHandler(this.button3_Click);
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(-5, 61);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(957, 536);
            this.Panel2.TabIndex = 15;
            // 
            // MenuAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Minim);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAdministrar";
            this.Text = "MenuAdministrar";
            this.Load += new System.EventHandler(this.MenuAdministrar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Minim;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.ToolStripMenuItem cajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
    }
}