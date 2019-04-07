namespace TellerB1
{
    partial class MenuP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuP));
            this.Minim = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoInterbancarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiroInterbancarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minim
            // 
            this.Minim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minim.FlatAppearance.BorderSize = 0;
            this.Minim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minim.Image = ((System.Drawing.Image)(resources.GetObject("Minim.Image")));
            this.Minim.Location = new System.Drawing.Point(1334, 6);
            this.Minim.Margin = new System.Windows.Forms.Padding(2);
            this.Minim.Name = "Minim";
            this.Minim.Size = new System.Drawing.Size(45, 34);
            this.Minim.TabIndex = 7;
            this.Minim.UseVisualStyleBackColor = false;
            this.Minim.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1384, 1);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(44, 44);
            this.Cerrar.TabIndex = 8;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Teller-> Aplicacion de Caja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositoToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.pendientesToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.cuadreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 44);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 36);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositoToolStripMenuItem1,
            this.retiroToolStripMenuItem,
            this.depositoInterbancarioToolStripMenuItem,
            this.retiroInterbancarioToolStripMenuItem});
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(142, 32);
            this.depositoToolStripMenuItem.Text = "Transacciones";
            // 
            // depositoToolStripMenuItem1
            // 
            this.depositoToolStripMenuItem1.Name = "depositoToolStripMenuItem1";
            this.depositoToolStripMenuItem1.Size = new System.Drawing.Size(297, 32);
            this.depositoToolStripMenuItem1.Text = "Deposito";
            this.depositoToolStripMenuItem1.Click += new System.EventHandler(this.depositoToolStripMenuItem1_Click);
            // 
            // retiroToolStripMenuItem
            // 
            this.retiroToolStripMenuItem.Name = "retiroToolStripMenuItem";
            this.retiroToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.retiroToolStripMenuItem.Text = "Retiro";
            this.retiroToolStripMenuItem.Click += new System.EventHandler(this.retiroToolStripMenuItem_Click);
            // 
            // depositoInterbancarioToolStripMenuItem
            // 
            this.depositoInterbancarioToolStripMenuItem.Name = "depositoInterbancarioToolStripMenuItem";
            this.depositoInterbancarioToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.depositoInterbancarioToolStripMenuItem.Text = "Deposito Interbancario";
            this.depositoInterbancarioToolStripMenuItem.Click += new System.EventHandler(this.depositoInterbancarioToolStripMenuItem_Click);
            // 
            // retiroInterbancarioToolStripMenuItem
            // 
            this.retiroInterbancarioToolStripMenuItem.Name = "retiroInterbancarioToolStripMenuItem";
            this.retiroInterbancarioToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.retiroInterbancarioToolStripMenuItem.Text = "Retiro Interbancario";
            this.retiroInterbancarioToolStripMenuItem.Click += new System.EventHandler(this.retiroInterbancarioToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.pendientesToolStripMenuItem.Text = "Pendientes";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.pendientesToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // cuadreToolStripMenuItem
            // 
            this.cuadreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteToolStripMenuItem,
            this.cerrarCajaToolStripMenuItem});
            this.cuadreToolStripMenuItem.Name = "cuadreToolStripMenuItem";
            this.cuadreToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.cuadreToolStripMenuItem.Text = "Cuadre";
            this.cuadreToolStripMenuItem.Click += new System.EventHandler(this.cuadreToolStripMenuItem_Click);
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte";
            // 
            // cerrarCajaToolStripMenuItem
            // 
            this.cerrarCajaToolStripMenuItem.Name = "cerrarCajaToolStripMenuItem";
            this.cerrarCajaToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.cerrarCajaToolStripMenuItem.Text = "Cerrar Caja";
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(-3, 80);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1436, 825);
            this.Panel1.TabIndex = 11;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenuP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1438, 911);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Minim);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuP";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuP_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuP_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Minim;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ToolStripMenuItem cuadreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoInterbancarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retiroInterbancarioToolStripMenuItem;
    }
}