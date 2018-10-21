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
    public partial class FrmAlumno : Form
    {
        private bool isnuevo = false;
        private bool iseditar = false;
        public FrmAlumno()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.textBox4, "ingrese Nombre");
            this.toolTip1.SetToolTip(this.textBox3, "ingrese Apellido");
            this.toolTip1.SetToolTip(this.textBox1, "ingrese el DNI");
            this.toolTip1.SetToolTip(this.textBox6, "ingrese el Sexo");
            this.toolTip1.SetToolTip(this.textBox7, "ingrese la Edad");
            this.toolTip1.SetToolTip(this.textBox11, "ingrese el N° de Hermanos ");
            this.toolTip1.SetToolTip(this.textBox21, "ingrese el Lugar que Ocupa");
            this.toolTip1.SetToolTip(this.textBox20, "ingrese el Codigo del Estudiante");
            this.toolTip1.SetToolTip(this.textBox5, "ingrese el Codigo del Alumno ");
            this.toolTip1.SetToolTip(this.textBox18, "ingrese  el Lugar de Nacimiento ");
            this.toolTip1.SetToolTip(this.textBox1, "ingrese el Centro de Trabajo");
            this.toolTip1.SetToolTip(this.textBox17, "ingrese el domicilio actual");
            this.toolTip1.SetToolTip(this.textBox16, "ingrese la direccion ");
            this.toolTip1.SetToolTip(this.textBox12, "ingrese parto");
            this.toolTip1.SetToolTip(this.textBox19, "ingrese discapacidad");
            this.toolTip1.SetToolTip(this.textBox13, "ingrese la Lengua Materna");
            this.toolTip1.SetToolTip(this.textBox14, "ingrese la Religion");
                this.toolTip1.SetToolTip(this.textBox15, "ingrese el N° de Partida");
        }
        private void Limpiar()
        {

            this.textBox1.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.textBox6.Text = string.Empty;
            this.textBox7.Text = string.Empty;
            this.textBox11.Text = string.Empty;
            this.textBox21.Text = string.Empty;
            this.textBox20.Text = string.Empty;
            this.textBox5.Text = string.Empty;
            this.textBox18.Text = string.Empty;
            this.textBox17.Text = string.Empty;
            this.textBox16.Text = string.Empty;
            this.textBox15.Text = string.Empty;
            this.textBox14.Text = string.Empty;
            this.textBox13.Text = string.Empty;
            this.textBox12.Text = string.Empty;
            this.textBox19.Text = string.Empty;
            this.textBox9.Text = string.Empty;
            this.textBox8.Text = string.Empty;
            this.textBox10.Text = string.Empty;
            this.button3.Text = string.Empty;
            this.button1.Text = string.Empty;
            this.button4.Text = string.Empty;
            this.dateTimePicker1.Text = string.Empty;
            this.textBox23.Text = string.Empty;
            this.textBox24.Text = string.Empty;
            this.textBox25.Text = string.Empty;
            this.textBox28.Text = string.Empty;
            this.textBox29.Text = string.Empty;

        }
       
        private void habilitar(bool valor)
        {
            this.textBox1.Enabled = valor;
            this.textBox4.Enabled = valor;
            this.textBox3.Enabled = valor;
            this.textBox6.Enabled = valor;
            this.textBox7.Enabled = valor;
            this.textBox11.Enabled = valor;
            this.textBox21.Enabled = valor;
            this.textBox20.Enabled = valor;
            this.textBox5.Enabled = valor;
            this.textBox18.Enabled = valor;
            this.textBox17.Enabled = valor;
            this.textBox16.Enabled = valor;
            this.textBox15.Enabled = valor;
            this.textBox14.Enabled = valor;
            this.textBox13.Enabled = valor;
            this.textBox12.Enabled = valor;
            this.textBox19.Enabled = valor;
            this.textBox9.Enabled = valor;
            this.textBox8.Enabled = valor;
            this.textBox10.Enabled = valor;
            this.button3.Enabled = valor;
            this.button1.Enabled = valor;
            this.button4.Enabled = valor;
            this.dateTimePicker1.Enabled = valor;
            this.textBox23.Enabled = valor;
            this.textBox28.Enabled = valor;
            this.textBox29.Enabled = valor;
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
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[23].Visible = false;
            this.dataGridView1.Columns[24].Visible = false;
            this.dataGridView1.Columns[25].Visible = false;
            this.dataGridView1.Columns[26].Visible = false;
            this.dataGridView1.Columns[27].Visible = false;
            


        }
        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
        private void buscarnombre()
        {
            this.dataGridView1.DataSource = NAlumno.buscarnombre(this.txtbuscar.Text, this.textBox22.Text);
            this.OcultarColumnas();
            label10.Text = "Total de Registros: " + Convert.ToString(dataGridView1.Rows.Count);
        }
        
        private void FrmAlumno_Load(object sender, EventArgs e)
        {

            this.buscarnombre();
            this.habilitar(false);
            this.botones();
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

                        if (this.textBox11.Text.Length == 0)
                            errorProvider1.SetError(this.textBox11, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox11, "");

                        if (this.textBox15.Text.Length == 0)
                            errorProvider1.SetError(this.textBox15, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox15, "");

                        if (this.textBox14.Text.Length == 0)
                            errorProvider1.SetError(this.textBox14, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox14, "");
                        //
                        if (this.textBox19.Text.Length == 0)
                            errorProvider1.SetError(this.textBox19, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox19, "");

                        if (this.textBox23.Text.Length == 0)
                            errorProvider1.SetError(this.textBox23, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox23, "");

                        if (this.textBox29.Text.Length == 0)
                            errorProvider1.SetError(this.textBox29, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox29, "");

                        if (this.textBox12.Text.Length == 0)
                            errorProvider1.SetError(this.textBox12, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox12, "");

                        if (this.textBox13.Text.Length == 0)
                            errorProvider1.SetError(this.textBox13, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox13, "");

                        if (this.textBox4.Text.Length == 0)
                            errorProvider1.SetError(this.textBox4, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox4, "");

                        if (this.textBox3.Text.Length == 0)
                            errorProvider1.SetError(this.textBox3, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox3, "");

                        if (this.textBox6.Text.Length == 0)
                            errorProvider1.SetError(this.textBox6, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox6, "");

                        if (this.textBox7.Text.Length == 0)
                            errorProvider1.SetError(this.textBox7, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox7, "");

                        if (this.textBox28.Text.Length == 0)
                            errorProvider1.SetError(this.textBox28, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox28, "");

                        if (this.textBox18.Text.Length == 0)
                            errorProvider1.SetError(this.textBox18, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox18, "");

                        if (this.textBox17.Text.Length == 0)
                            errorProvider1.SetError(this.textBox17, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox17, "");

                        if (this.textBox16.Text.Length == 0)
                            errorProvider1.SetError(this.textBox16, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox16, "");

                        if (this.textBox5.Text.Length == 0)
                            errorProvider1.SetError(this.textBox5, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox5, "");

                        if (this.textBox1.Text.Length == 0)
                            errorProvider1.SetError(this.textBox1, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox1, "");

                        if (this.textBox24.Text.Length == 0)
                            errorProvider1.SetError(this.textBox24, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox24, "");

                        if (this.textBox25.Text.Length == 0)
                            errorProvider1.SetError(this.textBox25, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox25, "");

                        if (this.textBox21.Text.Length == 0)
                            errorProvider1.SetError(this.textBox21, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.textBox21, "");

                        if (this.textBox20.Text.Length == 0)
                            errorProvider1.SetError(this.textBox20, "ingrese el Año");
                        else
                            errorProvider1.SetError(this.textBox20, "");

                        if (this.dateTimePicker1.Text.Length == 0)
                            errorProvider1.SetError(this.dateTimePicker1, "ingrese el Nombre del Año");
                        else
                            errorProvider1.SetError(this.dateTimePicker1, "");
                    }
                    else
                    {


                        if (this.isnuevo)
                        {
                            rpta = NAlumno.Insertar(this.textBox4.Text.Trim().ToUpper(), textBox3.Text, textBox1.Text, dateTimePicker1.Value, textBox6.Text, textBox7.Text,
          Convert.ToInt32(this.textBox9.Text), Convert.ToInt32(this.textBox8.Text), Convert.ToInt32(this.textBox10.Text), textBox5.Text,
          textBox18.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text, textBox13.Text, textBox11.Text, textBox21.Text,
          textBox20.Text, textBox19.Text, textBox12.Text);
                        }
                        else
                        {
                            rpta = NAlumno.Editar(Convert.ToInt32(this.textBox2.Text), this.textBox4.Text.Trim().ToUpper(), textBox3.Text, textBox1.Text, dateTimePicker1.Value, textBox6.Text, textBox7.Text,
         Convert.ToInt32(this.textBox9.Text), Convert.ToInt32(this.textBox8.Text), Convert.ToInt32(this.textBox10.Text), textBox5.Text,
         textBox18.Text, textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text, textBox13.Text, textBox11.Text, textBox21.Text,
         textBox20.Text, textBox19.Text, textBox12.Text);
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.isnuevo = false;
            this.iseditar = false;
            this.botones();
            this.habilitar(false);
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_alumno"].Value);
            this.textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nombre"].Value);
            this.textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Apellido"].Value);
            this.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["DNI"].Value);
            this.dateTimePicker1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Fecha de Nacimiento"].Value);
            this.textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Sexo"].Value);
            this.textBox7.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Edad"].Value);
            this.textBox11.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["N° de Hermanos"].Value);
            this.textBox21.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Lugar que Ocupa"].Value);
            this.textBox20.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Colegio de Procedencia"].Value);
            this.textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Codigo"].Value);
            this.textBox18.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Lugar de nacimiento"].Value);
            this.textBox17.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Domicilio Actual"].Value);
            this.textBox16.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Direccion"].Value);
            this.textBox15.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["N° de Partida"].Value);
            this.textBox14.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Religion"].Value);
            this.textBox13.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Lengua Materna"].Value);
            this.textBox12.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Parto"].Value);
            this.textBox19.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Discapacidad"].Value);

            this.textBox9.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_madre"].Value);
            this.textBox24.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["nombre_ma"].Value);
            this.textBox25.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["apellido_materno_ma"].Value);
            this.textBox8.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_padre"].Value);
            this.textBox26.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["nombre_pa"].Value);
            this.textBox27.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["apellido_pa"].Value);
            this.textBox10.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_año"].Value);
            this.textBox29.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["descripcion"].Value);
            textBox23.Text = textBox24.Text + "  " + textBox25.Text;
            textBox28.Text = textBox26.Text + "  " + textBox27.Text;
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
                            Rpta = NAlumno.Eliminar(Convert.ToInt32(Codigo));

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

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            this.buscarnombre();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VistaMadre form = new VistaMadre();
            form.ShowDialog();

            textBox9.Text = form.id_madre.ToString(); ;
            textBox24.Text = form.nombre;
            textBox25.Text = form.apellido;
            textBox23.Text = textBox24.Text + "  " + textBox25.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            VistaPadre form = new VistaPadre();
            form.ShowDialog();

            textBox8.Text = form.id_padre.ToString(); ;
            textBox26.Text = form.nombre;
            textBox27.Text = form.apellido;
            textBox28.Text = textBox26.Text + "  " + textBox27.Text;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VistaAño form = new VistaAño();
            form.ShowDialog();

            textBox10.Text = form.id_año.ToString(); ;
            textBox29.Text = form.nombre;
           
            
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
}}
