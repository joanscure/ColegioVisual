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
    public partial class RProfesores : Form
    {
        public RProfesores()
        {
            InitializeComponent();
        }

        private void RProfesores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primeros_frutosDataSet.profesor' table. You can move, or remove it, as needed.
            this.profesorTableAdapter.Fill(this.primeros_frutosDataSet.profesor);

            this.reportViewer1.RefreshReport();
        }
    }
}
