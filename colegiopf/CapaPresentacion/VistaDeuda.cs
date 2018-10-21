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

    public partial class VistaDeuda : Form
    {
        public int id_año;
        public string nombre;
        public int apellido;
        public VistaDeuda()
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
            this.dataGridView1.DataSource = NDeuda.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void VistaDeuda_Load(object sender, EventArgs e)
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
            id_año = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id_deuda"].Value);
            nombre = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Descripcion"].Value);

            apellido = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["Monto a Pagar"].Value);
            this.Hide();

        }
    }
}
