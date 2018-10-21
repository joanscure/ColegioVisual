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
    public partial class Frm0 : Form
    {
        
        public string id_login = "";
        public string id_profesor = "";
     
        public string acceso = "";
        public Frm0()
        {
            InitializeComponent();
        }

        private void Frm0_Load(object sender, EventArgs e)
        {
            GestionUsuario();
            
        }
        private void GestionUsuario()
        {
            //COntrolar los accesos
            if (acceso == "Administrador")
            {
                FmrMenu frm = new FmrMenu();
                frm.textBox1.Text = textBox1.Text;
                this.Hide();
                frm.Show();
                this.Dispose();
                

            }
            else if (acceso == "Profesor")
            {
                FmrMenuProfesor frm = new FmrMenuProfesor();
                frm.textBox1.Text = textBox1.Text;
                this.Hide();
                frm.Show();
                this.Dispose();
            }

            else
            {


            }
        }
    }
}
