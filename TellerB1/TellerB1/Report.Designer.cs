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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Caja_AppDataSet1 = new TellerB1.Caja_AppDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblUsuariosTableAdapter = new TellerB1.Caja_AppDataSet1TableAdapters.tblUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caja_AppDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblUsuariosBindingSource
            // 
            this.tblUsuariosBindingSource.DataMember = "tblUsuarios";
            this.tblUsuariosBindingSource.DataSource = this.Caja_AppDataSet1;
            // 
            // Caja_AppDataSet1
            // 
            this.Caja_AppDataSet1.DataSetName = "Caja_AppDataSet1";
            this.Caja_AppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TellerB1.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 692);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tblUsuariosTableAdapter
            // 
            this.tblUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caja_AppDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblUsuariosBindingSource;
        private Caja_AppDataSet1 Caja_AppDataSet1;
        private Caja_AppDataSet1TableAdapters.tblUsuariosTableAdapter tblUsuariosTableAdapter;
    }
}