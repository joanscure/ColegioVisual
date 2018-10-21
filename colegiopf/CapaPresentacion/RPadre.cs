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
    public partial class RPadre : Form
    {
        public RPadre()
        {
            InitializeComponent();
        }

        private void RPadre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primeros_frutosDataSet.padre' table. You can move, or remove it, as needed.
            this.padreTableAdapter.Fill(this.primeros_frutosDataSet.padre);

            this.reportViewer1.RefreshReport();
        }
    }
}
