using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DNota
    {
        private int _id_nota;

        public int Id_nota
        {
            get { return _id_nota; }
            set { _id_nota = value; }
        }


        private int _id_curso_alumno;

        public int Id_curso_alumno
        {
            get { return _id_curso_alumno; }
            set { _id_curso_alumno = value; }
        }

        
        private int _n1;

        public int N1
        {
            get { return _n1; }
            set { _n1 = value; }
        }
        private int _n2;

        public int N2
        {
            get { return _n2; }
            set { _n2 = value; }
        }
        private int _n3;

        public int N3
        {
            get { return _n3; }
            set { _n3 = value; }
        }
        private int _n4;

        public int N4
        {
            get { return _n4; }
            set { _n4 = value; }
        }

        private string _TextBuscar1;

        public string TextBuscar1
        {
            get { return _TextBuscar1; }
            set { _TextBuscar1 = value; }
        }
        private string _TextBuscar3;

        public string TextBuscar3
        {
            get { return _TextBuscar3; }
            set { _TextBuscar3 = value; }
        }
        public DNota()
        {
        }
        public DNota(int id_nota, int id_curso_alumno, int n1, int n2, int n3, int n4, string textbuscar1, string textbuscar3)
        {
            this.Id_nota = id_nota;
            this.Id_curso_alumno = id_curso_alumno;
            this.N1 = n1;
            this.N2 = n2;
            this.N3 = n3;
            this.N4 = n4;
            this.TextBuscar1 = textbuscar1;
            this.TextBuscar3 = textbuscar3;
        }

        public string Insertar(DNota nota)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //comandos de procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_nota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO1 = new SqlParameter();
                ParIdDAMNIFICADO1.ParameterName = "@id_nota";
                ParIdDAMNIFICADO1.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO1.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO1);

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_curso_alumno";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = nota.Id_curso_alumno;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@n1";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = nota.N1;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@n2";
                ParNombre2.SqlDbType = SqlDbType.Int;
                ParNombre2.Value = nota.N2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@n3";
                ParNombre3.SqlDbType = SqlDbType.Int;
                ParNombre3.Value = nota.N3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParNombre4 = new SqlParameter();
                ParNombre4.ParameterName = "@n4";
                ParNombre4.SqlDbType = SqlDbType.Int;
                ParNombre4.Value = nota.N4;
                SqlCmd.Parameters.Add(ParNombre4);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string Editar(DNota nota)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //comandos de procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_nota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO1 = new SqlParameter();
                ParIdDAMNIFICADO1.ParameterName = "@id_nota";
                ParIdDAMNIFICADO1.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO1.Value = nota.Id_nota;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO1);

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_curso_alumno";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = nota.Id_curso_alumno;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre1 = new SqlParameter();
                ParNombre1.ParameterName = "@n1";
                ParNombre1.SqlDbType = SqlDbType.Int;
                ParNombre1.Value = nota.N1;
                SqlCmd.Parameters.Add(ParNombre1);

                SqlParameter ParNombre2 = new SqlParameter();
                ParNombre2.ParameterName = "@n2";
                ParNombre2.SqlDbType = SqlDbType.Int;
                ParNombre2.Value = nota.N2;
                SqlCmd.Parameters.Add(ParNombre2);

                SqlParameter ParNombre3 = new SqlParameter();
                ParNombre3.ParameterName = "@n3";
                ParNombre3.SqlDbType = SqlDbType.Int;
                ParNombre3.Value = nota.N3;
                SqlCmd.Parameters.Add(ParNombre3);

                SqlParameter ParNombre4 = new SqlParameter();
                ParNombre4.ParameterName = "@n4";
                ParNombre4.SqlDbType = SqlDbType.Int;
                ParNombre4.Value = nota.N4;
                SqlCmd.Parameters.Add(ParNombre4);




                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string Eliminar(DNota nota)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //comandos de procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_nota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_nota";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = nota.Id_nota;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public DataTable Mostrar()
        {
            DataTable Dtpersona = new DataTable("curso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_curso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(Dtpersona);

            }
            catch (Exception ex)
            {
                Dtpersona = null;
            }
            return Dtpersona;

        }
        public DataTable BuscarNombre(DNota nota)
        {
            DataTable Dtpersona = new DataTable("nota");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nota";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar1";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = nota.TextBuscar1;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscarn = new SqlParameter();
                ParTextoBuscarn.ParameterName = "@textbuscar3";
                ParTextoBuscarn.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscarn.Size = 50;
                ParTextoBuscarn.Value = nota.TextBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscarn);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(Dtpersona);

            }
            catch (Exception ex)
            {
                Dtpersona = null;
            }
            return Dtpersona;

        }
    }
}
