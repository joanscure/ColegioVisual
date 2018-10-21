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
namespace CapaPresentacion.Reportes
{
    public partial class VistaSiage : Form
    {
        public VistaSiage()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;

        }
        private void Mostrar()
        {
            this.dataGridView1.DataSource = NSiage.Mostrar();
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }

        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NSiage.buscarnombre(this.txtbuscar.Text, this.textBox1.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void VistaSiage_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Alumnogite frm = new Alumnogite();
            frm.Textbuscar = txtbuscar.Text;
            frm.Textbuscar1 = textBox1.Text;
            frm.ShowDialog();
        }
    }
}
