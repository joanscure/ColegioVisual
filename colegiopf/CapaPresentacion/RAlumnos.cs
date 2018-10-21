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
    public partial class RAlumnos : Form
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
        public RAlumnos()
        {
            InitializeComponent();
        }

        private void RAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primeros_frutosDataSet.spbuscar_alumnogite' table. You can move, or remove it, as needed.
            this.spbuscar_alumnogiteTableAdapter.Fill(this.primeros_frutosDataSet.spbuscar_alumnogite ,Textbuscar, Textbuscar1);

            this.reportViewer1.RefreshReport();
        }
    }
}
