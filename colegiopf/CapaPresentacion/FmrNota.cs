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
    public partial class FmrNota : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        Validacion v = new Validacion();
        public FmrNota()
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
            this.textBox6.Text = string.Empty;
            this.textBox7.Text = string.Empty;

        }
        private void habilitar(bool valor)
        {
            
            this.textBox2.Enabled = valor;
            this.textBox3.Enabled = valor;
            this.textBox4.Enabled = valor;
            this.textBox5.Enabled = valor;
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
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;


        }
     
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NNota.buscarnombre(this.txtbuscar.Text, this.textBox8.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FmrNota_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            this.botones();
            this.buscarnombre();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.txtiddamnificado.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtnombre.Text == string.Empty)
                {
                    mensajeerror("Falta ingresar algunos datos, serán remarcados");

                    if (this.textBox2.Text.Length == 0)
                        errorProvider1.SetError(this.textBox2, "ingrese la Nota 1");
                    else
                        errorProvider1.SetError(this.textBox2, "");

                    if (this.textBox3.Text.Length == 0)
                        errorProvider1.SetError(this.textBox3, "ingrese la Nota 2");
                    else
                        errorProvider1.SetError(this.textBox3, "");

                    if (this.textBox5.Text.Length == 0)
                        errorProvider1.SetError(this.textBox5, "ingrese la Nota 3");
                    else
                        errorProvider1.SetError(this.textBox5, "");

                    if (this.textBox4.Text.Length == 0)
                        errorProvider1.SetError(this.textBox4, "ingrese la Nota 4");
                    else
                        errorProvider1.SetError(this.textBox4, "");
                }
                else
                {

                    if (this.isnuevo)
                    {


                    }
                    else
                    {
                        rpta = NNota.Editar(Convert.ToInt32(this.txtiddamnificado.Text), Convert.ToInt32(this.textBox9.Text), Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(this.textBox5.Text), Convert.ToInt32(this.textBox3.Text), Convert.ToInt32(this.textBox4.Text));

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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        
            }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox9.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_curso_alumno"].Value);
            this.txtiddamnificado.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_nota"].Value);
            this.textBox10.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["NOMBRE"].Value);
            this.textBox11.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["APELLIDO"].Value);
            
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CURSO"].Value);
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["N1"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["N2"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["N3"].Value);
            this.textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["N4"].Value);
            this.textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Grado"].Value);
            this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Año"].Value);
            txtnombre.Text = textBox10.Text + "  " + textBox11.Text.ToString();
            
            this.tabControl1.SelectedIndex = 1;
        }

        private void txtiddamnificado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }


    }
}
