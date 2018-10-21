using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DAño
    {
        private int _id_año;

        public int Id_año
        {
            get { return _id_año; }
            set { _id_año = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private string _año;

        public string Año
        {
            get { return _año; }
            set { _año = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        public DAño()
        {

        }
        public DAño(int id_año, string descripcion, string año,string textbuscar)
        {

            this.Id_año = id_año;
            this.Descripcion = descripcion;
            this.Año = año;
            this.TextBuscar = textbuscar;
        }
        public string Insertar(DAño año)
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
                SqlCmd.CommandText = "spinsertar_año";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_año";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@descripcion";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = año.Descripcion;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@año";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 10;
                ParAPELLIDO.Value = año.Año;
                SqlCmd.Parameters.Add(ParAPELLIDO);

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


        public string Editar(DAño año)
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
                SqlCmd.CommandText = "speditar_año";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_año";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = año.Id_año;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@descripcion";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = año.Descripcion;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@año";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 10;
                ParAPELLIDO.Value = año.Año;
                SqlCmd.Parameters.Add(ParAPELLIDO);



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
        public string Eliminar(DAño año)
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
                SqlCmd.CommandText = "speliminar_año";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_año";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = año.Id_año;
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
            DataTable Dtpersona = new DataTable("año");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_año";
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
        public DataTable BuscarNombre(DAño año)
        {
            DataTable Dtpersona = new DataTable("madre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_año";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = año.TextBuscar;
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
