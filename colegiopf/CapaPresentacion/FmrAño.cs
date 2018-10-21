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
    public partial class FmrAño : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        Validacion v = new Validacion();
        public FmrAño()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtnombre, "ingrese el Nombre del Año");
            this.toolTip1.SetToolTip(this.textBox1, "ingrese el Año");
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
            this.txtiddamnificado.Text = string.Empty;

        }
        private void habilitar(bool valor)
        {
            this.txtnombre.Enabled = valor;
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
            this.dataGridView1.Columns[1].Visible = false;
            



        }
        private void Mostrar()
        {
            this.dataGridView1.DataSource = NAño.Mostrar();
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);

        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NAño.buscarnombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void FmrAño_Load(object sender, EventArgs e)
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

                    if (this.textBox1.Text.Length == 0)
                        errorProvider1.SetError(this.textBox1, "ingrese el Año");
                    else
                        errorProvider1.SetError(this.textBox1, "");

                    if (this.txtnombre.Text.Length == 0)
                        errorProvider1.SetError(this.txtnombre, "ingrese el Nombre del Año");
                    else
                        errorProvider1.SetError(this.txtnombre, "");
                }
                else
                {
                    if (this.isnuevo)
                    {
                        rpta = NAño.Insertar(this.txtnombre.Text.Trim().ToUpper(), textBox1.Text);

                    }
                    else
                    {
                        rpta = NAño.Editar(Convert.ToInt32(this.txtiddamnificado.Text), this.txtnombre.Text.Trim().ToUpper(),
                            this.textBox1.Text.Trim().ToUpper());

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
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_año"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombre del Año"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Año"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.dataGridView1.Columns[0].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NAño.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.mensajeok("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.mensajeerror(Rpta);
                            }

                        }
                    }
                    this.buscarnombre();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
