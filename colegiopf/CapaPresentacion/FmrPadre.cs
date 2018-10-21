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
    public partial class FmrPadre : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        Validacion v = new Validacion();
        public FmrPadre()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.textBox2, "ingrese Nombre");
            this.toolTip1.SetToolTip(this.textBox31, "ingrese Apellido");
            this.toolTip1.SetToolTip(this.textBox33, "ingrese el DNI");
            this.toolTip1.SetToolTip(this.textBox32, "ingrese el Estado Civil");
            this.toolTip1.SetToolTip(this.textBox28, "ingrese el Lugar de nacimiento ");
           
            this.toolTip1.SetToolTip(this.textBox17, "vive con el Estudiante ");
            
            this.toolTip1.SetToolTip(this.textBox5, "ingrese la Fecha de defuncion si la hubiese  ");
            this.toolTip1.SetToolTip(this.textBox1, "ingrese el Centro de Trabajo");
            this.toolTip1.SetToolTip(this.textBox24, "ingrese el Numero de Celular");
            this.toolTip1.SetToolTip(this.textBox25, "ingrese la Ocupacion");
            this.toolTip1.SetToolTip(this.textBox21, "ingrese el Grado de Estudios");
            this.toolTip1.SetToolTip(this.textBox20, "ingrese el E-mail");
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
            this.textBox28.Text = string.Empty;
            this.textBox31.Text = string.Empty;
            this.textBox33.Text = string.Empty;
            this.textBox32.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox17.Text = string.Empty;
            this.comboBox2.Text = string.Empty;
            this.comboBox1.Text = string.Empty;
            this.textBox5.Text = string.Empty;
            this.textBox1.Text = string.Empty;
            this.textBox24.Text = string.Empty;
            this.textBox25.Text = string.Empty;
            this.textBox21.Text = string.Empty;
            this.textBox20.Text = string.Empty;

        }
        private void habilitar(bool valor)
        {
            this.textBox28.Enabled = valor;
            this.textBox31.Enabled = valor;
            this.textBox33.Enabled = valor;
            this.textBox32.Enabled = valor;
            this.textBox2.Enabled = valor;
           
            this.textBox17.Enabled = valor;

            this.comboBox2.Enabled = valor;
            this.comboBox1.Enabled = valor;

            this.textBox5.Enabled = valor;
            this.textBox1.Enabled = valor;
            this.textBox24.Enabled = valor;
            this.textBox25.Enabled = valor;
            this.textBox21.Enabled = valor;
            this.textBox20.Enabled = valor;
            this.dateTimePicker2.Enabled = valor;

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
            this.dataGridView1.DataSource = NPadre.Mostrar();
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);

        }
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NPadre.buscarnombre(this.txtbuscar.Text, this.textBox4.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FmrPadre_Load(object sender, EventArgs e)
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
                

                    if (this.isnuevo)
                    {
                        rpta = NPadre.Insertar(textBox2.Text, textBox31.Text, textBox33.Text, textBox20.Text, textBox25.Text, textBox32.Text,
      textBox24.Text, textBox21.Text, textBox1.Text, textBox17.Text,
       (textBox5.Text), dateTimePicker2.Value, textBox28.Text, comboBox2.Text, comboBox1.Text);
                    }
                    else
                    {
                        rpta = NPadre.Editar(Convert.ToInt32(this.textBox3.Text), textBox2.Text, textBox31.Text, textBox33.Text, textBox20.Text, textBox25.Text, textBox32.Text,
      textBox24.Text, textBox21.Text, textBox1.Text, textBox17.Text,
       (textBox5.Text), dateTimePicker2.Value, textBox28.Text, comboBox2.Text, comboBox1.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }




            
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_padre"].Value);
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombres"].Value);
            this.textBox31.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellidos"].Value);
            this.textBox33.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["DNI"].Value);
            this.textBox20.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["E-mail"].Value);
            this.textBox25.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Ocupacion"].Value);
            this.textBox32.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Estado Civil"].Value);
            this.textBox24.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Celular"].Value);
            this.textBox21.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Grado de Estudios"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Centro de Trabajo"].Value);
            this.textBox17.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Domicilio Actual"].Value);
            this.dateTimePicker2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Fecha de Nacimiento"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Fecha de Defuncion"].Value);
            this.textBox28.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Lugar de Nacimiento"].Value);
            this.comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Vive con el Alumno"].Value);
            this.comboBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Vive"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.textBox3.Text.Equals(""))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.textBox3.Text = string.Empty;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
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
                            Rpta = NPadre.Eliminar(Convert.ToInt32(Codigo));

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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }
        
    }
}
