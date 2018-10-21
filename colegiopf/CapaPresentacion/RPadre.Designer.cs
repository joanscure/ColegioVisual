namespace CapaPresentacion
{
    partial class RPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPadre));
            this.padreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primeros_frutosDataSet = new CapaPresentacion.primeros_frutosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.padreTableAdapter = new CapaPresentacion.primeros_frutosDataSetTableAdapters.padreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.padreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeros_frutosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // padreBindingSource
            // 
            this.padreBindingSource.DataMember = "padre";
            this.padreBindingSource.DataSource = this.primeros_frutosDataSet;
            // 
            // primeros_frutosDataSet
            // 
            this.primeros_frutosDataSet.DataSetName = "primeros_frutosDataSet";
            this.primeros_frutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.padreBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(755, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // padreTableAdapter
            // 
            this.padreTableAdapter.ClearBeforeFill = true;
            // 
            // RPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 461);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I.E.P PRIMEROS FRUTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RPadre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.padreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeros_frutosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource padreBindingSource;
        private primeros_frutosDataSet primeros_frutosDataSet;
        private primeros_frutosDataSetTableAdapters.padreTableAdapter padreTableAdapter;

    }
}