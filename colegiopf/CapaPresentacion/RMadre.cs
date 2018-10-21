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
    public partial class RMadre : Form
    {
        public RMadre()
        {
            InitializeComponent();
        }

        private void RMadre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primeros_frutosDataSet.madre' table. You can move, or remove it, as needed.
            this.madreTableAdapter.Fill(this.primeros_frutosDataSet.madre);

            this.reportViewer1.RefreshReport();
        }
    }
}
