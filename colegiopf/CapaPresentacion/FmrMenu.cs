using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Reportes;
namespace CapaPresentacion
{
    public partial class FmrMenu : Form
    {

        private int childFormNumber = 0;
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }
        private void FmrMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void añoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FmrAño frm = new FmrAño();
                frm.MdiParent = this;

                frm.Show();
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmAlumno frm = new FrmAlumno();

                frm.MdiParent = this;

                frm.Show();
            }
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmCurso frm = new FrmCurso();
                frm.MdiParent = this;

                frm.Show();
            }
        }

        private void padreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FmrPadre frm = new FmrPadre();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void madreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmMadre frm = new FrmMadre();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void FmrMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
            FrmPago frm = new FrmPago();
            frm.MdiParent = this;
            frm.Show();
            }
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmNlogin frm = new FrmNlogin();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmProfesor frm = new FrmProfesor();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void deudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmCursoAlumno frm = new FrmCursoAlumno();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void deudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmDetalleDeuda frm = new FrmDetalleDeuda();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void ffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                VistaSiage frm = new VistaSiage();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cursoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cursosDelProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void detalleDeDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmDetalleDeuda frm = new FrmDetalleDeuda();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length == 0)
            {
                FmrNota frm = new FmrNota();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void deudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmDeuda frm = new FrmDeuda();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cursoDeAlumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length == 0)
            {
                FrmCursoAlumno frm = new FrmCursoAlumno();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cursosDelProfesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                FrmProfeCurso frm = new FrmProfeCurso();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void acercaDelProgramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void acercaDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                COP frm = new COP();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RProfesores frm = new RProfesores();
            
            frm.Show();
        }

        private void listaDePadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPadre frm = new RPadre();

            frm.Show();
        }

        private void listaDeMadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMadre frm = new RMadre();

            frm.Show();
        }

        private void listaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RNotas frm = new RNotas();

            frm.Show();
        }
    }
}
