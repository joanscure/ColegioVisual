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
    public partial class VistaDetalleDeuda : Form
    {
        public int id_año;
        public string nombre;
        public string apellido;
        public string descripcion;
        public int monto;
        public VistaDetalleDeuda()
        {
            InitializeComponent();
        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NDetalleDeuda.buscarnombre(this.txtbuscar.Text);

            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void VistaDetalleDeuda_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_año = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id_deta_deuda"].Value);
            nombre = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombre"].Value);
            apellido = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellido"].Value);
            descripcion = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Deuda"].Value);
            monto = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["Monto"].Value);
            this.Hide();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }
    }
}
