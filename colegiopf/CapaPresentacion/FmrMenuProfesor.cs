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
    public partial class FmrMenuProfesor : Form
    {
        public FmrMenuProfesor()
        {
            InitializeComponent();
        }

        private void FmrMenuProfesor_Load(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                vistacursoprofe frm = new vistacursoprofe();
                frm.txtbuscar.Text = textBox1.Text;
                frm.textBox3.Text = textBox1.Text;
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm=new FrmLogin();
            frm.Show();
 
        }

        private void FmrMenuProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
