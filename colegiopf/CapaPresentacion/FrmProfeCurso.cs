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
    public partial class FrmProfeCurso : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        public FrmProfeCurso()
        {
            InitializeComponent();
        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            this.textBox2.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.button1.Text = string.Empty;
            this.button4.Text = string.Empty;
        }
        private void habilitar(bool valor)
        {
            this.textBox2.Enabled = valor;
            this.textBox3.Enabled = valor;
            this.button1.Enabled = valor;
            this.button4.Enabled = valor;
        }
        private void botones()
        {
            if (this.isnuevo || this.iseditar) //Alt + 124
            {
                this.habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfeCurso_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            this.botones();
            this.buscarnombre();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.txtiddamnificado.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo = true;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.habilitar(true);
            this.txtnombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtnombre.Text == string.Empty)
                {
                    mensajeerror("Falta ingresar algunos datos, serán remarcados");

                    if (this.textBox3.Text.Length == 0)
                        errorProvider1.SetError(this.textBox3, "ingrese el Nombre del Profesor");
                    else
                        errorProvider1.SetError(this.textBox3, "");

                    if (this.textBox2.Text.Length == 0)
                        errorProvider1.SetError(this.textBox2, "ingrese el Curso");
                    else
                        errorProvider1.SetError(this.textBox2, "");
                }
                else
                {
                    if (this.isnuevo)
                    {
                        rpta = NProfeCurso1.Insertar(Convert.ToInt32(this.txtnombre.Text), Convert.ToInt32(textBox1.Text));

                    }
                    else
                    {
                        rpta = NProfeCurso1.Editar(Convert.ToInt32(this.txtiddamnificado.Text), Convert.ToInt32(this.txtnombre.Text), Convert.ToInt32(textBox1.Text));

                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.isnuevo)
                        {
                            this.mensajeok("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.mensajeok("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    this.isnuevo = false;
                    this.iseditar = false;
                    this.botones();
                    this.Limpiar();
                    this.buscarnombre();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtiddamnificado.Text.Equals(""))
            {
                this.iseditar = true;
                this.botones();
                this.habilitar(true);
            }
            else
            {
                this.mensajeerror("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_profe_curso"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_profesor"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_curso"].Value);
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Curso"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombres"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VistaCurso form = new VistaCurso();
            form.ShowDialog();
            textBox1.Text = form.id_alumno.ToString(); ;
            textBox2.Text = form.nombre;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaProfesor form = new VistaProfesor();
            form.ShowDialog();
            txtnombre.Text = form.id_padre.ToString(); 
            textBox4.Text = form.nombre;
            textBox5.Text = form.apellido;
            textBox3.Text = textBox4.Text + "  " + textBox5.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double total = double.Parse(textBox6.Text) + double.Parse(textBox7.Text);
            textBox8.Text = total.ToString();
        }
    }
}