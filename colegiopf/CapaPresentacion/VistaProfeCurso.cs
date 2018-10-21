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
    public partial class VistaProfeCurso : Form
    {
        
        public int id_curso;
        public string nombre;
        public string curso;
        public string apellido;
        public VistaProfeCurso()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;


        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NProfeCurso1.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void VistaProfeCurso_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            id_curso = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id_profe_curso"].Value);
            nombre = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombres"].Value);
            apellido = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellidos"].Value);
            curso = Convert.ToString(this.dataGridView1.CurrentRow.Cells["curso"].Value);

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
