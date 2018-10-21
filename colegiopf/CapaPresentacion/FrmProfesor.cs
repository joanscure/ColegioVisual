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
    public partial class FrmProfesor : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        public FrmProfesor()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.textBox4, "ingrese Nombre");
            this.toolTip1.SetToolTip(this.textBox3, "ingrese Apellido");
            this.toolTip1.SetToolTip(this.textBox1, "ingrese el DNI");
            
            this.toolTip1.SetToolTip(this.textBox24, "ingrese el Celular");
            
            this.toolTip1.SetToolTip(this.textBox20, "ingrese el E-mail");
            this.toolTip1.SetToolTip(this.textBox7, "ingrese la Edad ");
            
            this.toolTip1.SetToolTip(this.comboBox1, "Selecione el Año");
         this.LlenarComboPresentacion();
        }
        private void Limpiar()
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.textBox20.Text = string.Empty;
            this.textBox24.Text = string.Empty;
            this.textBox7.Text = string.Empty;
            this.dateTimePicker1.Text = string.Empty;
           

        }

        private void habilitar(bool valor)
        {
            this.textBox1.Enabled = valor;
            
            this.textBox4.Enabled = valor;
            this.textBox3.Enabled = valor;
            this.textBox20.Enabled = valor;
            this.textBox24.Enabled = valor;
            this.textBox7.Enabled = valor;
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
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;

        }

        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NProfesor.buscarnombre(this.txtbuscar.Text, this.textBox5.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 8)
            {
                MessageBox.Show("Ingrese 8 caracteres para el DNI");
            }
            else
            {

                try
                {
                    string rpta = "";

                    if (this.textBox3.Text == string.Empty)
                    {
                        mensajeerror("Falta ingresar algunos datos, serán remarcados");

                        if (this.textBox4.Text.Length == 0)
                            errorProvider1.SetError(this.textBox4, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox4, "");

                        if (this.textBox3.Text.Length == 0)
                            errorProvider1.SetError(this.textBox3, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox3, "");

                        if (this.textBox1.Text.Length == 0)
                            errorProvider1.SetError(this.textBox1, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox1, "");
                        //

                        if (this.textBox24.Text.Length == 0)
                            errorProvider1.SetError(this.textBox24, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox24, "");

                        if (this.textBox20.Text.Length == 0)
                            errorProvider1.SetError(this.textBox20, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox20, "");

                        if (this.textBox7.Text.Length == 0)
                            errorProvider1.SetError(this.textBox7, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox7, "");

                        if (this.comboBox1.Text.Length == 0)
                            errorProvider1.SetError(this.comboBox1, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.comboBox1, "");


                    }
                    else
                    {

                        if (this.isnuevo)
                        {
                            rpta = NProfesor.Insertar(textBox4.Text, textBox3.Text, textBox1.Text,
                                textBox24.Text, textBox20.Text, dateTimePicker1.Value, textBox7.Text, Convert.ToInt32(this.comboBox1.Text));
                        }
                        else
                        {
                            rpta = NProfesor.Editar(Convert.ToInt32(this.textBox2.Text), textBox4.Text, textBox3.Text, textBox1.Text,
                                textBox24.Text, textBox20.Text, dateTimePicker1.Value, textBox7.Text, Convert.ToInt32(this.comboBox1.Text));
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
                        this.buscarnombre();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            
        }
        private void LlenarComboPresentacion()
        {
          

        }

        private void FrmProfesor_Load(object sender, EventArgs e)
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
            this.textBox2.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo = true;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.habilitar(true);
            this.textBox2.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.textBox2.Text.Equals(""))
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_profesor"].Value);
            this.textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombre"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellido"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["DNI"].Value);
            this.textBox24.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Celular"].Value);
            this.textBox20.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["E-mail"].Value);
            this.dateTimePicker1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Fecha de Nacimiento"].Value);
            this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Edad"].Value);
            this.comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_año"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                            Rpta = NProfesor.Eliminar(Convert.ToInt32(Codigo));

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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        
    }
}
