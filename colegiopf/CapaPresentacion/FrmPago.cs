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
    public partial class FrmPago : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;

        public FrmPago()
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
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox3.Text = string.Empty;

        }
        private void habilitar(bool valor)
        {
            this.txtnombre.Enabled = valor;
            this.textBox1.Enabled = valor;
            this.textBox2.Enabled = valor;
            this.textBox4.Enabled = valor;
            this.textBox3.Enabled = valor;
            this.button1.Enabled = valor;
            this.button4.Enabled = valor;
            this.dateTimePicker1.Enabled = valor;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
             try
            {
                string rpta = "";
                if (this.txtnombre.Text == string.Empty)
                {
                    mensajeerror("Falta ingresar algunos datos, serán remarcados");

                    

                    if (this.textBox1.Text.Length == 0)
                        errorProvider1.SetError(this.textBox1, "ingrese el Nombre del Año");
                    else
                        errorProvider1.SetError(this.textBox1, "");
                }
                else
                {
                    if (this.isnuevo)
                    {
                        rpta = NPago.Insertar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(txtnombre.Text), dateTimePicker1.Value, Convert.ToInt32(textBox3.Text));

                    }
                    else
                    {
                        rpta = NPago.Editar(Convert.ToInt32(this.txtiddamnificado.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(txtnombre.Text), dateTimePicker1.Value, Convert.ToInt32(textBox3.Text));

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
                    this.habilitar(false);
                    this.botones();
                    this.Limpiar();
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        
        
        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;

           


        }
        
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NPago.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void FrmPago_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaDetalleDeuda form = new VistaDetalleDeuda();
            form.ShowDialog();
            txtnombre.Text = form.id_año.ToString(); 
            textBox5.Text = form.nombre;
            textBox6.Text = form.apellido;
            textBox2.Text = form.monto.ToString();
            textBox4.Text = form.descripcion;
            textBox4.Text = textBox5.Text + "  " + textBox6.Text;
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          //textBox3.Text =  Convert.ToString( textBox2.Text) - Convert.ToString( textBox1.Text);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtiddamnificado_TextChanged(object sender, EventArgs e)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_pago"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_deta_deuda"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombre"].Value);
            this.textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellido"].Value);
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Monto"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Cantidad a Pagar"].Value);
            this.dateTimePicker1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Fecha de Pago"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Debe"].Value);
            textBox4.Text = textBox5.Text + "  " + textBox6.Text;
            this.tabControl1.SelectedIndex = 1;
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
        }//

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          double total =double.Parse(textBox2.Text) - double.Parse(textBox1.Text);
           textBox3.Text = total.ToString();
        }
    }
}
