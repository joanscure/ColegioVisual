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
    public partial class FrmDetalleDeuda : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        public FrmDetalleDeuda()
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
            this.txtnombre.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.txtiddamnificado.Text = string.Empty;
            this.textBox5.Text = string.Empty;
            this.textBox6.Text = string.Empty;
        }
        private void habilitar(bool valor)
        {
            this.txtnombre.Enabled = valor;
            this.textBox5.Enabled = valor;
            this.textBox4.Enabled = valor;
            this.textBox6.Enabled = valor;
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
            this.dataGridView1.DataSource = NDetalleDeuda.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
      
        private void FrmDetalleDeuda_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
            
            this.habilitar(false);
            this.botones();
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
                    errorProvider1.SetError(txtnombre, "Ingrese un Nombre");
                }
                else
                {
                    if (this.isnuevo)
                    {
                        rpta = NDetalleDeuda.Insertar(Convert.ToInt32(txtnombre.Text),Convert.ToInt32( textBox1.Text));

                    }
                    else
                    {
                        rpta = NDetalleDeuda.Editar(Convert.ToInt32(this.txtiddamnificado.Text), Convert.ToInt32(txtnombre.Text),Convert.ToInt32( textBox1.Text));

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
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaAlumno form = new VistaAlumno();
            form.ShowDialog();

            textBox1.Text = form.id_alumno.ToString(); 
            textBox2.Text = form.nombre;
            textBox3.Text = form.apellido;
            textBox4.Text = textBox2.Text + "  " + textBox3.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VistaDeuda form = new VistaDeuda();
            form.ShowDialog();
            txtnombre.Text = form.id_año.ToString(); 
            textBox6.Text = form.nombre;
            textBox5.Text = form.apellido.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_deta_deuda"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_deuda"].Value);
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombre"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellido"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_alumno"].Value);
            this.textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Deuda"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Monto"].Value);
            textBox4.Text = textBox2.Text +"  " +textBox3.Text;
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
