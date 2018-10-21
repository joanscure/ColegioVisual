using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            
  
            DataTable Datos = CapaNegocio.NLogin.Login(this.TxtUsuario.Text, this.TxtPassword.Text);
            //Evaluar si existe el Usuario
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm0 frm = new Frm0();
                this.Hide();
                frm.id_login = Datos.Rows[0][0].ToString();
                frm.id_profesor = Datos.Rows[0][1].ToString();
                frm.acceso = Datos.Rows[0][2].ToString();
                frm.textBox1.Text = TxtUsuario.Text;
                frm.Show();

                

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
