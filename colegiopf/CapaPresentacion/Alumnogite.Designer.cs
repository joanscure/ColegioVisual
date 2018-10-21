namespace CapaPresentacion.Reportes
{
    partial class Alumnogite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnogite));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spbuscar_alumnogiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primeros_frutosDataSet = new CapaPresentacion.primeros_frutosDataSet();
            this.spbuscaralumnogiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spbuscar_alumnogiteTableAdapter = new CapaPresentacion.primeros_frutosDataSetTableAdapters.spbuscar_alumnogiteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_alumnogiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeros_frutosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscaralumnogiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscar_alumnogiteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 415);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spbuscar_alumnogiteBindingSource
            // 
            this.spbuscar_alumnogiteBindingSource.DataMember = "spbuscar_alumnogite";
            this.spbuscar_alumnogiteBindingSource.DataSource = this.primeros_frutosDataSet;
            this.spbuscar_alumnogiteBindingSource.CurrentChanged += new System.EventHandler(this.spbuscar_alumnogiteBindingSource_CurrentChanged);
            // 
            // primeros_frutosDataSet
            // 
            this.primeros_frutosDataSet.DataSetName = "primeros_frutosDataSet";
            this.primeros_frutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spbuscaralumnogiteBindingSource
            // 
            this.spbuscaralumnogiteBindingSource.DataMember = "spbuscar_alumnogite";
            this.spbuscaralumnogiteBindingSource.DataSource = this.primeros_frutosDataSet;
            // 
            // spbuscar_alumnogiteTableAdapter
            // 
            this.spbuscar_alumnogiteTableAdapter.ClearBeforeFill = true;
            // 
            // Alumnogite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 415);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alumnogite";
            this.Text = "I.E.P PRIMEROS FRUTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Alumnogite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_alumnogiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primeros_frutosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscaralumnogiteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private primeros_frutosDataSet primeros_frutosDataSet;
        private System.Windows.Forms.BindingSource spbuscar_alumnogiteBindingSource;
        private System.Windows.Forms.BindingSource spbuscaralumnogiteBindingSource;
        private primeros_frutosDataSetTableAdapters.spbuscar_alumnogiteTableAdapter spbuscar_alumnogiteTableAdapter;

    }
}