using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DDeuda
    {
        private int _id_deuda;

        public int Id_deuda
        {
            get { return _id_deuda; }
            set { _id_deuda = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private decimal _monto;

        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        public DDeuda()
        {

        }
        public DDeuda(int id_deuda, string descripcion, decimal monto, string textbuscar)
        {
            this.Id_deuda = id_deuda;
            this.Descripcion = descripcion;
            this.Monto = monto;
            this.TextBuscar = textbuscar;
        }
        public string Insertar(DDeuda deuda)
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
                SqlCmd.CommandText = "spinsertar_deuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_deuda";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@descripcion";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = deuda.Descripcion;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParNombred = new SqlParameter();
                ParNombred.ParameterName = "@monto";
                ParNombred.SqlDbType = SqlDbType.Int;
                ParNombred.Value = deuda.Monto;
                SqlCmd.Parameters.Add(ParNombred);

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
        public string Editar(DDeuda deuda)
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
                SqlCmd.CommandText = "speditar_deuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_deuda";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = deuda.Id_deuda;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@descripcion";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = deuda.Descripcion;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParNombred = new SqlParameter();
                ParNombred.ParameterName = "@monto";
                ParNombred.SqlDbType = SqlDbType.Int;
                ParNombred.Value = deuda.Monto;
                SqlCmd.Parameters.Add(ParNombred);

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
        public string Eliminar(DDeuda deuda)
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
                SqlCmd.CommandText = "speliminar_deuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_deuda";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = deuda.Id_deuda;
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
            DataTable Dtpersona = new DataTable("deuda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_deuda";
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
        public DataTable BuscarNombre(DDeuda deuda)
        {
            DataTable Dtpersona = new DataTable("deuda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_deuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = deuda.TextBuscar;
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
