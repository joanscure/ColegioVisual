using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class Alumnogite : Form
    {
        private String _Textbuscar;

        public String Textbuscar
        {
            get { return _Textbuscar; }
            set { _Textbuscar = value; }
        }
        private String _Textbuscar1;

        public String Textbuscar1
        {
            get { return _Textbuscar1; }
            set { _Textbuscar1 = value; }
        }
        public Alumnogite()
        {
            InitializeComponent();
        }

        private void Alumnogite_Load(object sender, EventArgs e)
        {
            try
            {
                this.spbuscar_alumnogiteTableAdapter.Fill(this.primeros_frutosDataSet.spbuscar_alumnogite, Textbuscar, Textbuscar1);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
            
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void spbuscar_alumnogiteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
