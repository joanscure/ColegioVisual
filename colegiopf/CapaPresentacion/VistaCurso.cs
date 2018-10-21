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
    public partial class VistaCurso : Form
    {
    public int id_alumno;
        public string nombre;
        public VistaCurso()
        {
            InitializeComponent();
        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NCurso.buscarnombre(this.txtbuscar.Text);
           
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void VistaAlumno_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id_alumno = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id_curso"].Value);
            nombre = Convert.ToString(this.dataGridView1.CurrentRow.Cells["nombre"].Value);
            
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
