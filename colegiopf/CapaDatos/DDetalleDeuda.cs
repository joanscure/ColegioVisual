using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DDetalleDeuda
    {
        private int _id_alumno;

        public int Id_alumno
        {
            get { return _id_alumno; }
            set { _id_alumno = value; }
        }
        private int _id_deuda;

        public int Id_deuda
        {
            get { return _id_deuda; }
            set { _id_deuda = value; }
        }
        private int _id_deta_deuda;

        public int Id_deta_deuda
        {
            get { return _id_deta_deuda; }
            set { _id_deta_deuda = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        public DDetalleDeuda()
        {

        }
        public DDetalleDeuda(int id_alumno, int id_deuda, int id_deta_deuda, string textbuscar)
        {
            this.Id_alumno = id_alumno;
            this.Id_deuda = id_deta_deuda;
            this.Id_deta_deuda = id_deta_deuda;
            this.TextBuscar = textbuscar;

        }
        public string Insertar(DDetalleDeuda detalledeuda)
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
                SqlCmd.CommandText = "spinsertar_detalle_deuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_deta_deuda";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@id_deuda";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = detalledeuda.Id_deuda;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@id_alumno";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 10;
                ParAPELLIDO.Value = detalledeuda.Id_alumno;
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
        public string Editar(DDetalleDeuda detalledeuda)
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
                SqlCmd.CommandText = "spinsertar_detalle_deuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_deta_deuda";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = detalledeuda.Id_deta_deuda;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@id_deuda";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = detalledeuda.Id_deuda;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@id_alumno";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 10;
                ParAPELLIDO.Value = detalledeuda.Id_alumno;
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
        public DataTable BuscarNombre(DDetalleDeuda detalleDeuda)
        {
            DataTable Dtpersona = new DataTable("detalleDeuda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_detadeuda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = detalleDeuda.TextBuscar;
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
