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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Caja_AppDataSet1 = new TellerB1.Caja_AppDataSet1();
            this.tblUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsuariosTableAdapter = new TellerB1.Caja_AppDataSet1TableAdapters.tblUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Caja_AppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TellerB1.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Caja_AppDataSet1
            // 
            this.Caja_AppDataSet1.DataSetName = "Caja_AppDataSet1";
            this.Caja_AppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsuariosBindingSource
            // 
            this.tblUsuariosBindingSource.DataMember = "tblUsuarios";
            this.tblUsuariosBindingSource.DataSource = this.Caja_AppDataSet1;
            // 
            // tblUsuariosTableAdapter
            // 
            this.tblUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Caja_AppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblUsuariosBindingSource;
        private Caja_AppDataSet1 Caja_AppDataSet1;
        private Caja_AppDataSet1TableAdapters.tblUsuariosTableAdapter tblUsuariosTableAdapter;
    }
}