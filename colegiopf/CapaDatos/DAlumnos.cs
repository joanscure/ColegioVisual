using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DAlumnos
    {
        
        private int _id_alumno;

        public int Id_alumno
        {
            get { return _id_alumno; }
            set { _id_alumno = value; }
        }
      
        private string _nombres;

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        private string _apellidos;

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private DateTime _fecha_naci;

        public DateTime Fecha_naci
        {
            get { return _fecha_naci; }
            set { _fecha_naci = value; }
        }
        private string _sexo;

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        
        private int _id_padre;

        public int Id_padre
        {
            get { return _id_padre; }
            set { _id_padre = value; }
        }
        private int _id_madre;

        public int Id_madre
        {
            get { return _id_madre; }
            set { _id_madre = value; }
        }
        private int _id_año;

        public int Id_año
        {
            get { return _id_año; }
            set { _id_año = value; }
        }
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _edad;

        public string Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        private string _lugar_naci;

        public string Lugar_naci
        {
            get { return _lugar_naci; }
            set { _lugar_naci = value; }
        }
        private string _domi_actual;

        public string Domi_actual
        {
            get { return _domi_actual; }
            set { _domi_actual = value; }
        }
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _n_partida;

        public string N_partida
        {
            get { return _n_partida; }
            set { _n_partida = value; }
        }
        private string _religion;

        public string Religion
        {
            get { return _religion; }
            set { _religion = value; }
        }
        private string _len_materna;

        public string Len_materna
        {
            get { return _len_materna; }
            set { _len_materna = value; }
        }
        private string _n_hermanos;

        public string N_hermanos
        {
            get { return _n_hermanos; }
            set { _n_hermanos = value; }
        }
        private string _lugar_ocupa;

        public string Lugar_ocupa
        {
            get { return _lugar_ocupa; }
            set { _lugar_ocupa = value; }
        }
        private string _cole_procedencia;

        public string Cole_procedencia
        {
            get { return _cole_procedencia; }
            set { _cole_procedencia = value; }
        }
        private string _discapacidad;

        public string Discapacidad
        {
            get { return _discapacidad; }
            set { _discapacidad = value; }
        }
        private string _parto;

        public string Parto
        {
            get { return _parto; }
            set { _parto = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        private string _TextBuscar1;

        public string TextBuscar1
        {
            get { return _TextBuscar1; }
            set { _TextBuscar1 = value; }
        }
        public DAlumnos()
        {
        }


        public DAlumnos(int id_alumno, string nombres, string apellido, string dni, DateTime fecha_naci, string sexo,string edad ,int id_padre, int id_madre, int id_año, string codigo, string lugar_naci, string domi_actual, string direccion, string n_partida, string religion, string len_materna, string n_hermanos, string lugar_ocupa, string cole_procedencia, string discapacidad, string parto, string textbuscar, string textbuscar1)
        {
            this.Id_alumno = id_alumno;
            this.Nombres = nombres;
            this.Apellidos = apellido;
            this.Dni = dni;
            this.Fecha_naci = fecha_naci;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Id_padre = id_padre;
            this.Id_madre = id_madre;
            this.Id_año = id_año;
            this.Codigo = codigo;
            this.Lugar_naci = lugar_naci;
            this.Domi_actual = domi_actual;
            this.Direccion = direccion;
            this.N_partida = n_partida;
            this.Religion = religion;
            this.Len_materna = len_materna;
            this.N_hermanos = n_hermanos;
            this.Lugar_ocupa = lugar_ocupa;
            this.Cole_procedencia = cole_procedencia;
            this.Discapacidad = discapacidad;
            this.Parto = parto;
            this.TextBuscar = textbuscar;
            this.TextBuscar1 = textbuscar1;
        }
        public string Insertar(DAlumnos alumno)
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
                SqlCmd.CommandText = "spinsertar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_alumno";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombres";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = alumno.Nombres;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@apellidos";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 50;
                ParAPELLIDO.Value = alumno.Apellidos;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter Pardni = new SqlParameter();
                Pardni.ParameterName = "@dni";
                Pardni.SqlDbType = SqlDbType.Char;
                Pardni.Size = 8;
                Pardni.Value = alumno.Dni;
                SqlCmd.Parameters.Add(Pardni);

                SqlParameter Pardn = new SqlParameter();
                Pardn.ParameterName = "@fecha_naci";
                Pardn.SqlDbType = SqlDbType.Date;
                Pardn.Size = 8;
                Pardn.Value = alumno.Fecha_naci;
                SqlCmd.Parameters.Add(Pardn);

                SqlParameter ParAPELLID = new SqlParameter();
                ParAPELLID.ParameterName = "@sexo";
                ParAPELLID.SqlDbType = SqlDbType.VarChar;
                ParAPELLID.Size = 50;
                ParAPELLID.Value = alumno.Sexo;
                SqlCmd.Parameters.Add(ParAPELLID);

                SqlParameter ParAPELLIDx = new SqlParameter();
                ParAPELLIDx.ParameterName = "@edad";
                ParAPELLIDx.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDx.Size = 50;
                ParAPELLIDx.Value = alumno.Edad;
                SqlCmd.Parameters.Add(ParAPELLIDx);


                SqlParameter Pard = new SqlParameter();
                Pard.ParameterName = "@id_año";
                Pard.SqlDbType = SqlDbType.Int;
                Pard.Value = alumno.Id_año;
                SqlCmd.Parameters.Add(Pard);

                SqlParameter Pardnids = new SqlParameter();
                Pardnids.ParameterName = "@id_padre";
                Pardnids.SqlDbType = SqlDbType.Int;
                Pardnids.Value = alumno.Id_padre;
                SqlCmd.Parameters.Add(Pardnids);

                SqlParameter Pardnide = new SqlParameter();
                Pardnide.ParameterName = "@id_madre";
                Pardnide.SqlDbType = SqlDbType.Int;
                Pardnide.Value = alumno.Id_madre;
                SqlCmd.Parameters.Add(Pardnide);

                SqlParameter ParNombrehh = new SqlParameter();
                ParNombrehh.ParameterName = "@codigo";
                ParNombrehh.SqlDbType = SqlDbType.VarChar;
                ParNombrehh.Size = 50;
                ParNombrehh.Value = alumno.Codigo;
                SqlCmd.Parameters.Add(ParNombrehh);

                SqlParameter ParAPELLIDOkk = new SqlParameter();
                ParAPELLIDOkk.ParameterName = "@lugar_naci";
                ParAPELLIDOkk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkk.Size = 50;
                ParAPELLIDOkk.Value = alumno.Lugar_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkk);

                SqlParameter ParNombreh = new SqlParameter();
                ParNombreh.ParameterName = "@domi_actual";
                ParNombreh.SqlDbType = SqlDbType.VarChar;
                ParNombreh.Size = 50;
                ParNombreh.Value = alumno.Domi_actual;
                SqlCmd.Parameters.Add(ParNombreh);

                SqlParameter ParAPELLIDOk = new SqlParameter();
                ParAPELLIDOk.ParameterName = "@direccion";
                ParAPELLIDOk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOk.Size = 50;
                ParAPELLIDOk.Value = alumno.Direccion;
                SqlCmd.Parameters.Add(ParAPELLIDOk);

                SqlParameter ParNombrehll = new SqlParameter();
                ParNombrehll.ParameterName = "@n_partida";
                ParNombrehll.SqlDbType = SqlDbType.VarChar;
                ParNombrehll.Size = 50;
                ParNombrehll.Value = alumno.N_partida;
                SqlCmd.Parameters.Add(ParNombrehll);

                SqlParameter ParAPELLIDOkll = new SqlParameter();
                ParAPELLIDOkll.ParameterName = "@religion";
                ParAPELLIDOkll.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkll.Size = 50;
                ParAPELLIDOkll.Value = alumno.Religion;
                SqlCmd.Parameters.Add(ParAPELLIDOkll);

                SqlParameter ParNombrehl = new SqlParameter();
                ParNombrehl.ParameterName = "@len_materna";
                ParNombrehl.SqlDbType = SqlDbType.VarChar;
                ParNombrehl.Size = 50;
                ParNombrehl.Value = alumno.Len_materna;
                SqlCmd.Parameters.Add(ParNombrehl);

                SqlParameter ParAPELLIDOkl = new SqlParameter();
                ParAPELLIDOkl.ParameterName = "@n_hermanos";
                ParAPELLIDOkl.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkl.Size = 50;
                ParAPELLIDOkl.Value = alumno.N_hermanos;
                SqlCmd.Parameters.Add(ParAPELLIDOkl);

                SqlParameter ParNombrehlhh = new SqlParameter();
                ParNombrehlhh.ParameterName = "@lugar_ocupa";
                ParNombrehlhh.SqlDbType = SqlDbType.VarChar;
                ParNombrehlhh.Size = 50;
                ParNombrehlhh.Value = alumno.Lugar_ocupa;
                SqlCmd.Parameters.Add(ParNombrehlhh);

                SqlParameter ParAPELLIDOklhh = new SqlParameter();
                ParAPELLIDOklhh.ParameterName = "@cole_procedencia";
                ParAPELLIDOklhh.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOklhh.Size = 50;
                ParAPELLIDOklhh.Value = alumno.Cole_procedencia;
                SqlCmd.Parameters.Add(ParAPELLIDOklhh);

                SqlParameter ParNombrehlh = new SqlParameter();
                ParNombrehlh.ParameterName = "@discapacidad";
                ParNombrehlh.SqlDbType = SqlDbType.Char;
                ParNombrehlh.Size = 2;
                ParNombrehlh.Value = alumno.Discapacidad;
                SqlCmd.Parameters.Add(ParNombrehlh);

                SqlParameter ParAPELLIDOklh = new SqlParameter();
                ParAPELLIDOklh.ParameterName = "@parto";
                ParAPELLIDOklh.SqlDbType = SqlDbType.Char;
                ParAPELLIDOklh.Size = 2;
                ParAPELLIDOklh.Value = alumno.Parto;
                SqlCmd.Parameters.Add(ParAPELLIDOklh);

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

        public string Editar(DAlumnos alumno)
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
                SqlCmd.CommandText = "speditar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_alumno";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = alumno.Id_alumno;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombres";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = alumno.Nombres;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@apellidos";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 50;
                ParAPELLIDO.Value = alumno.Apellidos;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter Pardni = new SqlParameter();
                Pardni.ParameterName = "@dni";
                Pardni.SqlDbType = SqlDbType.Char;
                Pardni.Size = 8;
                Pardni.Value = alumno.Dni;
                SqlCmd.Parameters.Add(Pardni);

                SqlParameter Pardn = new SqlParameter();
                Pardn.ParameterName = "@fecha_naci";
                Pardn.SqlDbType = SqlDbType.Date;
                Pardn.Size = 8;
                Pardn.Value = alumno.Fecha_naci;
                SqlCmd.Parameters.Add(Pardn);

                SqlParameter ParAPELLID = new SqlParameter();
                ParAPELLID.ParameterName = "@sexo";
                ParAPELLID.SqlDbType = SqlDbType.VarChar;
                ParAPELLID.Size = 50;
                ParAPELLID.Value = alumno.Sexo;
                SqlCmd.Parameters.Add(ParAPELLID);

                SqlParameter ParAPELLIDx = new SqlParameter();
                ParAPELLIDx.ParameterName = "@edad";
                ParAPELLIDx.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDx.Size = 50;
                ParAPELLIDx.Value = alumno.Edad;
                SqlCmd.Parameters.Add(ParAPELLIDx);

                SqlParameter Pard = new SqlParameter();
                Pard.ParameterName = "@id_año";
                Pard.SqlDbType = SqlDbType.Int;
                Pard.Value = alumno.Id_año;
                SqlCmd.Parameters.Add(Pard);

                SqlParameter Pardnids = new SqlParameter();
                Pardnids.ParameterName = "@id_padre";
                Pardnids.SqlDbType = SqlDbType.Int;
                Pardnids.Value = alumno.Id_padre;
                SqlCmd.Parameters.Add(Pardnids);

                SqlParameter Pardnide = new SqlParameter();
                Pardnide.ParameterName = "@id_madre";
                Pardnide.SqlDbType = SqlDbType.Int;
                Pardnide.Value = alumno.Id_madre;
                SqlCmd.Parameters.Add(Pardnide);

                SqlParameter ParNombrehh = new SqlParameter();
                ParNombrehh.ParameterName = "@codigo";
                ParNombrehh.SqlDbType = SqlDbType.VarChar;
                ParNombrehh.Size = 50;
                ParNombrehh.Value = alumno.Codigo;
                SqlCmd.Parameters.Add(ParNombrehh);

                SqlParameter ParAPELLIDOkk = new SqlParameter();
                ParAPELLIDOkk.ParameterName = "@lugar_naci";
                ParAPELLIDOkk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkk.Size = 50;
                ParAPELLIDOkk.Value = alumno.Lugar_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkk);

                SqlParameter ParNombreh = new SqlParameter();
                ParNombreh.ParameterName = "@domi_actual";
                ParNombreh.SqlDbType = SqlDbType.VarChar;
                ParNombreh.Size = 50;
                ParNombreh.Value = alumno.Domi_actual;
                SqlCmd.Parameters.Add(ParNombreh);

                SqlParameter ParAPELLIDOk = new SqlParameter();
                ParAPELLIDOk.ParameterName = "@direccion";
                ParAPELLIDOk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOk.Size = 50;
                ParAPELLIDOk.Value = alumno.Direccion;
                SqlCmd.Parameters.Add(ParAPELLIDOk);

                SqlParameter ParNombrehll = new SqlParameter();
                ParNombrehll.ParameterName = "@n_partida";
                ParNombrehll.SqlDbType = SqlDbType.VarChar;
                ParNombrehll.Size = 50;
                ParNombrehll.Value = alumno.N_partida;
                SqlCmd.Parameters.Add(ParNombrehll);

                SqlParameter ParAPELLIDOkll = new SqlParameter();
                ParAPELLIDOkll.ParameterName = "@religion";
                ParAPELLIDOkll.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkll.Size = 50;
                ParAPELLIDOkll.Value = alumno.Religion;
                SqlCmd.Parameters.Add(ParAPELLIDOkll);

                SqlParameter ParNombrehl = new SqlParameter();
                ParNombrehl.ParameterName = "@len_materna";
                ParNombrehl.SqlDbType = SqlDbType.VarChar;
                ParNombrehl.Size = 50;
                ParNombrehl.Value = alumno.Len_materna;
                SqlCmd.Parameters.Add(ParNombrehl);

                SqlParameter ParAPELLIDOkl = new SqlParameter();
                ParAPELLIDOkl.ParameterName = "@n_hermanos";
                ParAPELLIDOkl.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkl.Size = 50;
                ParAPELLIDOkl.Value = alumno.N_hermanos;
                SqlCmd.Parameters.Add(ParAPELLIDOkl);

                SqlParameter ParNombrehlhh = new SqlParameter();
                ParNombrehlhh.ParameterName = "@lugar_ocupa";
                ParNombrehlhh.SqlDbType = SqlDbType.VarChar;
                ParNombrehlhh.Size = 50;
                ParNombrehlhh.Value = alumno.Lugar_ocupa;
                SqlCmd.Parameters.Add(ParNombrehlhh);

                SqlParameter ParAPELLIDOklhh = new SqlParameter();
                ParAPELLIDOklhh.ParameterName = "@cole_procedencia";
                ParAPELLIDOklhh.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOklhh.Size = 50;
                ParAPELLIDOklhh.Value = alumno.Cole_procedencia;
                SqlCmd.Parameters.Add(ParAPELLIDOklhh);

                SqlParameter ParNombrehlh = new SqlParameter();
                ParNombrehlh.ParameterName = "@discapacidad";
                ParNombrehlh.SqlDbType = SqlDbType.Char;
                ParNombrehlh.Size = 2;
                ParNombrehlh.Value = alumno.Discapacidad;
                SqlCmd.Parameters.Add(ParNombrehlh);

                SqlParameter ParAPELLIDOklh = new SqlParameter();
                ParAPELLIDOklh.ParameterName = "@parto";
                ParAPELLIDOklh.SqlDbType = SqlDbType.Char;
                ParAPELLIDOklh.Size = 2;
                ParAPELLIDOklh.Value = alumno.Parto;
                SqlCmd.Parameters.Add(ParAPELLIDOklh);

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
        public string Eliminar(DAlumnos Alumno)
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
                SqlCmd.CommandText = "speliminar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Paridcateper = new SqlParameter();
                Paridcateper.ParameterName = "@id_alumno";
                Paridcateper.SqlDbType = SqlDbType.Int;
                Paridcateper.Value = Alumno.Id_alumno;
                SqlCmd.Parameters.Add(Paridcateper);


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
            DataTable Dtcatepersona = new DataTable("alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(Dtcatepersona);

            }
            catch (Exception ex)
            {
                Dtcatepersona = null;
            }
            return Dtcatepersona;

        }

        public DataTable BuscarNombre(DAlumnos alumno)
        {
            DataTable Dtpersona = new DataTable("madre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = alumno.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscard = new SqlParameter();
                ParTextoBuscard.ParameterName = "@textbuscar1";
                ParTextoBuscard.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscard.Size = 50;
                ParTextoBuscard.Value = alumno.TextBuscar1;
                SqlCmd.Parameters.Add(ParTextoBuscard);

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
