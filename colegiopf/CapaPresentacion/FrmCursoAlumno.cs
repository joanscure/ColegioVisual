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
    public partial class FrmCursoAlumno : Form
    {
        
        private bool isnuevo = false;
        private bool iseditar = false;
        public FrmCursoAlumno()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtnombre, "ingrese nombre");
            this.toolTip1.SetToolTip(this.textBox4, "ingrese el Curso");
            this.toolTip1.SetToolTip(this.textBox2, "ingrese el Nombre del profesor");
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
            this.textBox3.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox2.Text = string.Empty;
         

        }
        private void habilitar(bool valor)
        {
            
            this.textBox3.Enabled = valor;
            this.textBox4.Enabled = valor;
            this.textBox2.Enabled = valor;
            this.button1.Enabled = valor;
            this.button3.Enabled = valor;
       

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
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                        errorProvider1.SetError(this.textBox3, "ingrese una Nombre");
                    else
                        errorProvider1.SetError(this.textBox3, "");

                    if (this.textBox2.Text.Length == 0)
                        errorProvider1.SetError(this.textBox2, "ingrese una Nombre");
                    else
                        errorProvider1.SetError(this.textBox2, "");

                    if (this.textBox4.Text.Length == 0)
                        errorProvider1.SetError(this.textBox4, "ingrese una Nombre");
                    else
                        errorProvider1.SetError(this.textBox4, "");
                }
                else
                {

                    if (this.isnuevo)
                    {
                        rpta = NCursoAlumno.Insertar(Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(this.txtnombre.Text)); ;

                    }
                    else
                    {
                        rpta = NCursoAlumno.Editar(Convert.ToInt32(this.txtiddamnificado.Text), Convert.ToInt32(this.textBox1.Text), Convert.ToInt32(this.txtnombre.Text));

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
                        this.mensajeok("Se Insertó de forma correcta el registro");
                    }

                    this.isnuevo = false;
                    this.iseditar = false;
                    this.buscarnombre();


                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;


        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NCursoAlumno.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void FrmCursoAlumno_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
            
            this.habilitar(false);
            this.botones();
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
             this.buscarnombre();
        }
        //rpta = NCursoAlumno.Insertar(Convert.ToInt32(this.txtnombre.Text), Convert.ToInt32(this.textBox1.Text));
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.txtiddamnificado.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VistaAlumno form = new VistaAlumno();
            form.ShowDialog();

            txtnombre.Text = form.id_alumno.ToString(); 
            textBox7.Text = form.nombre;
            textBox8.Text = form.apellido;
            textBox3.Text = textBox7.Text + "  " + textBox8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VistaProfeCurso form = new VistaProfeCurso();
            form.ShowDialog();
            
            textBox1.Text = form.id_curso.ToString();
            textBox5.Text = form.nombre;
            textBox4.Text = form.curso;
            textBox6.Text = form.apellido;
            textBox2.Text = textBox5.Text +"  "+ textBox6.Text;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_curso_alumno"].Value);
            
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_alumno"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_profe_curso"].Value);
            this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombres"].Value);
            this.textBox8.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellidos"].Value);
            this.textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Curso"].Value);
            this.textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["apellidos"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["nombres"].Value);
            textBox3.Text = textBox7.Text + "  " + textBox8.Text;
            textBox2.Text = textBox5.Text + "  " + textBox6.Text;
            this.tabControl1.SelectedIndex = 1;
        }
        }
    }

