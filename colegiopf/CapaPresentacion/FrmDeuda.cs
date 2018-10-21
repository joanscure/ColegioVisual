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
    public partial class FrmDeuda : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        public FrmDeuda()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtnombre, "ingrese EL Nombre");
            this.toolTip1.SetToolTip(this.textBox1, "ingrese el Monto");
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
            this.txtiddamnificado.Text = string.Empty; 
            this.txtnombre.Text = string.Empty; 
            this.textBox1.Text = string.Empty;

        }
        private void habilitar(bool valor)
        { 
          
            this.txtnombre.Enabled =valor;
            this.textBox1.Enabled = valor;
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



        }
        private void Mostrar()
        {
            this.dataGridView1.DataSource = NDeuda.Mostrar();
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);

        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NDeuda.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void FrmDeuda_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
            
            this.habilitar(false);
            this.botones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             try
            {
                string rpta = "";
                if (this.txtnombre.Text == string.Empty)
                {
                    mensajeerror("Falta ingresar algunos datos, serán remarcados");

                    if (this.txtnombre.Text.Length == 0)
                        errorProvider1.SetError(this.txtnombre, "ingrese una Nombre");
                    else
                        errorProvider1.SetError(this.txtnombre, "");

                    if (this.textBox1.Text.Length == 0)
                        errorProvider1.SetError(this.textBox1, "ingrese una Nombre");
                    else
                        errorProvider1.SetError(this.textBox1, "");
                }
                else
                {

                    if (this.isnuevo)
                    {
                        rpta = NDeuda.Insertar(this.txtnombre.Text.Trim().ToUpper(), Convert.ToInt32(textBox1.Text));

                    }
                    else
                    {
                        rpta = NDeuda.Editar(Convert.ToInt32(this.txtiddamnificado.Text), this.txtnombre.Text.Trim().ToUpper(),
                            Convert.ToInt32(textBox1.Text));

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

        private void button3_Click(object sender, EventArgs e)
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_deuda"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Monto a Pagar"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Descripcion"].Value);
            
            this.tabControl1.SelectedIndex = 1;
        }

    }
}
