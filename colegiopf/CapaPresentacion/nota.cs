using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class nota : Form
    {
        private String _Textbuscar1;

        public String Textbuscar1
        {
            get { return _Textbuscar1; }
            set { _Textbuscar1 = value; }
        }
        private String _Textbuscar3;

        public String Textbuscar3
        {
            get { return _Textbuscar3; }
            set { _Textbuscar3 = value; }
        }
        public nota()
        {
            InitializeComponent();
        }

        private void nota_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'primeros_frutosDataSet.spbuscar_nota' table. You can move, or remove it, as needed.
                this.spbuscar_notaTableAdapter.Fill(this.primeros_frutosDataSet.spbuscar_nota, Textbuscar1, Textbuscar3);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();


            }
        }
    }
}