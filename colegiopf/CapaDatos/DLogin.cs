using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DLogin
    {
        private int _id_login;

        public int Id_login
        {
            get { return _id_login; }
            set { _id_login = value; }
        }
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        private string _acceso;

        public string Acceso
        {
            get { return _acceso; }
            set { _acceso = value; }
        }
        private int _id_profesor;


        public int Id_profesor
        {
            get { return _id_profesor; }
            set { _id_profesor = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        public DLogin()
        {

        }
        public DLogin(int id_login, string id, string contraseña, string acceso, int id_profesor, string textbuscar)
        {

            this.Id_login = id_login;
            this.Id = id;
            this.Contraseña = contraseña;
            this.Acceso = acceso;
            this.Id_profesor = id_profesor;
            this.TextBuscar = textbuscar;
        }
        public string Insertar(DLogin login)
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
                SqlCmd.CommandText = "spinsertar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_login";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@id";
                ParNombre.SqlDbType = SqlDbType.Char;
                ParNombre.Size = 8;
                ParNombre.Value = login.Id;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@contraseña";
                ParAPELLIDO.SqlDbType = SqlDbType.Char;
                ParAPELLIDO.Size = 8;
                ParAPELLIDO.Value = login.Contraseña;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@acceso";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = login.Acceso;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParAPELLIDOs = new SqlParameter();
                ParAPELLIDOs.ParameterName = "@id_profesor";
                ParAPELLIDOs.SqlDbType = SqlDbType.Int;
                
                ParAPELLIDOs.Value = login.Id_profesor;
                SqlCmd.Parameters.Add(ParAPELLIDOs);

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
        public string Editar(DLogin login)
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
                SqlCmd.CommandText = "speditar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_login";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = login.Id_login;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@id";
                ParNombre.SqlDbType = SqlDbType.Char;
                ParNombre.Size = 8;
                ParNombre.Value = login.Id;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@contraseña";
                ParAPELLIDO.SqlDbType = SqlDbType.Char;
                ParAPELLIDO.Size = 8;
                ParAPELLIDO.Value = login.Contraseña;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter ParNombres = new SqlParameter();
                ParNombres.ParameterName = "@acceso";
                ParNombres.SqlDbType = SqlDbType.VarChar;
                ParNombres.Size = 50;
                ParNombres.Value = login.Acceso;
                SqlCmd.Parameters.Add(ParNombres);

                SqlParameter ParAPELLIDOs = new SqlParameter();
                ParAPELLIDOs.ParameterName = "@id_profesor";
                ParAPELLIDOs.SqlDbType = SqlDbType.Int;
         
                ParAPELLIDOs.Value = login.Id_profesor;
                SqlCmd.Parameters.Add(ParAPELLIDOs);

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
        public DataTable Login(DLogin login)
        {
            DataTable DtResultado = new DataTable("login");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@id";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = login.Id;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@contraseña";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 20;
                ParPassword.Value = login.Contraseña;
                SqlCmd.Parameters.Add(ParPassword);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable BuscarNombre(DLogin login)
        {
            DataTable Dtpersona = new DataTable("login");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = login.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
