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
using CapaPresentacion.Reportes;
namespace CapaPresentacion
{
    public partial class vistacursoprofe : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        public vistacursoprofe()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            this.textBox9.Text = string.Empty;
            this.textBox8.Text = string.Empty;
            this.textBox16.Text = string.Empty;
            this.textBox17.Text = string.Empty;
            this.textBox18.Text = string.Empty;
            this.textBox19.Text = string.Empty;
            this.textBox20.Text = string.Empty;
        }

        private void habilitar(bool valor)
        {
            this.textBox9.ReadOnly = !valor;
            this.textBox8.ReadOnly = !valor;
            this.textBox16.Enabled = valor;
            this.textBox17.Enabled = valor;
            this.textBox18.Enabled = valor;
            this.textBox19.Enabled = valor;
            this.textBox20.Enabled = valor;
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
            
            
            
            
        }
       

        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NCursoProfe.buscarnombre(this.txtbuscar.Text, this.textBox1.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        private void buscarnombre2()
        {
            this.dataGridView2.DataSource = NCursoProfe.buscarnombre2(this.textBox3.Text, this.textBox2.Text);
          
            label1.Text = "Total de Registros: " + Convert.ToString(dataGridView2.Rows.Count);
        }
        private void vistacursoprofe_Load(object sender, EventArgs e)
        {
            this.buscarnombre();
            
            this.buscarnombre2();
           
            this.habilitar(false);
            this.botones();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumnogite frm = new Alumnogite();
            frm.Textbuscar = txtbuscar.Text;
            frm.Textbuscar1 = textBox1.Text;
            frm.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_profe_curso"].Value);
            
            this.tabControl1.SelectedIndex = 1;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.buscarnombre2();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.textBox21.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["id_curso_alumno"].Value);
            this.tabControl1.SelectedIndex = 2;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            
            try
            {
                string rpta = "";


                if (this.isnuevo)
                {
                    rpta = NNota.Insertar(Convert.ToInt32(this.textBox21.Text), Convert.ToInt32(this.textBox16.Text), Convert.ToInt32(this.textBox17.Text), Convert.ToInt32(this.textBox18.Text), Convert.ToInt32(this.textBox19.Text));
                }
                else
                {
                    rpta = NNota.Editar(Convert.ToInt32(this.textBox26.Text), Convert.ToInt32(this.textBox21.Text), Convert.ToInt32(this.textBox16.Text), Convert.ToInt32(this.textBox17.Text), Convert.ToInt32(this.textBox18.Text), Convert.ToInt32(this.textBox19.Text));
                }
                textBox20.Text = ((Convert.ToDecimal(textBox16.Text) + Convert.ToDecimal(textBox17.Text) + Convert.ToDecimal(textBox18.Text) + Convert.ToDecimal(textBox19.Text)) / 4).ToString();

                if (rpta.Equals("OK"))
                {
                    if (this.isnuevo)
                    {
                        this.mensajeok("Se Insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.mensajeok("Se Actualizó de forma correcta el registro");
                        this.mensajeok("Promedio del Alumno:  " + textBox20.Text);
                    }
                }
                else
                {
                    this.mensajeerror(rpta);
                }

                this.isnuevo = false;
                this.iseditar = false;

                
        
                this.buscarnombre2();
                this.bt();
                this.tabControl1.SelectedIndex = 0;
                

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
private void bt()
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.botones();
            this.Limpiar();
            this.textBox2.Text = string.Empty;
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
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        
        }

        private void dataGridView2_DoubleClick_1(object sender, EventArgs e)
        {
            this.textBox21.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["id_curso_alumno"].Value);
            this.textBox26.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["id_nota"].Value);
            this.textBox22.Text=Convert.ToString(this.dataGridView2.CurrentRow.Cells["NOMBRE"].Value);
            this.textBox23.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["APELLIDO"].Value);
            this.textBox24.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["NOMBREP"].Value);
            this.textBox25.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["PELLIDOP"].Value);
            this.textBox15.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["CURSO"].Value);
            this.textBox16.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["n1"].Value);
            this.textBox17.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["n2"].Value);
            this.textBox18.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["n3"].Value);
            this.textBox19.Text = Convert.ToString(this.dataGridView2.CurrentRow.Cells["n4"].Value);
            textBox13.Text = textBox22.Text +"  "+ textBox23.Text.ToString();
            textBox14.Text = textBox24.Text + "  " + textBox25.Text.ToString();
             this.tabControl1.SelectedIndex = 2;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double total =( double.Parse(textBox16.Text) + double.Parse(textBox17.Text) + double.Parse(textBox18.Text) + double.Parse(textBox19.Text))/4;
            textBox20.Text = total.ToString();
        }
    }
}
