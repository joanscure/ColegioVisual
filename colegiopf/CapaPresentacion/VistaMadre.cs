using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class VistaMadre : Form
    {
        public int id_madre;
        public string nombre;
        
        public string apellido;
        public VistaMadre()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;

        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NMadre.buscarnombre(this.txtbuscar.Text, this.textBox4.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void VistaMadre_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_madre = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id_madre"].Value);
            nombre = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombres"].Value);
            apellido = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellidos"].Value);
           

            this.Hide();
        }
    }
}
