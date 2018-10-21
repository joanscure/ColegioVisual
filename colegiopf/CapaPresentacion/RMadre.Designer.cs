namespace CapaPresentacion
{
    partial class RMadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMadre));
            this.madreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primeros_frutosDataSet = new CapaPresentacion.primeros_frutosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.madreTableAdapter = new CapaPresentacion.primeros_frutosDataSetTableAdapters.madreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.madreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeros_frutosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // madreBindingSource
            // 
            this.madreBindingSource.DataMember = "madre";
            this.madreBindingSource.DataSource = this.primeros_frutosDataSet;
            // 
            // primeros_frutosDataSet
            // 
            this.primeros_frutosDataSet.DataSetName = "primeros_frutosDataSet";
            this.primeros_frutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.madreBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(930, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // madreTableAdapter
            // 
            this.madreTableAdapter.ClearBeforeFill = true;
            // 
            // RMadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 500);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RMadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I.E.P PRIMEROS FRUTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RMadre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.madreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeros_frutosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource madreBindingSource;
        private primeros_frutosDataSet primeros_frutosDataSet;
        private primeros_frutosDataSetTableAdapters.madreTableAdapter madreTableAdapter;
    }
}