using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DPago
    {
        private int _id_pago;

        public int Id_pago
        {
            get { return _id_pago; }
            set { _id_pago = value; }
        }
        private int _debe;

        public int Debe
        {
            get { return _debe; }
            set { _debe = value; }
        }

        
        private int _cantidad_pagar;

        public int Cantidad_pagar
        {
            get { return _cantidad_pagar; }
            set { _cantidad_pagar = value; }
        }
        private int _id_deta_deuda;

        public int Id_deta_deuda
        {
            get { return _id_deta_deuda; }
            set { _id_deta_deuda = value; }
        }
        private DateTime _fecha_pago;

        public DateTime Fecha_pago
        {
            get { return _fecha_pago; }
            set { _fecha_pago = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        public DPago()
        {

        }
        public DPago(int id_pago, int cantidad_pagar, int id_deta_deuda, DateTime fecha_pago, int debe, string textbuscar)
        {
            this.Id_pago = id_pago;
            this.Cantidad_pagar=cantidad_pagar;
            this.Id_deta_deuda = id_deta_deuda;
            this.Fecha_pago = fecha_pago;
            this.Debe = debe;
            this.TextBuscar = textbuscar;
        }
        public string Insertar(DPago pago)
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
                SqlCmd.CommandText = "spinsertar_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_pago";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@cantidad_pagar";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = pago.Cantidad_pagar;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@id_deta_deuda";
                ParAPELLIDO.SqlDbType = SqlDbType.Int;
                ParAPELLIDO.Value = pago.Id_deta_deuda;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter ParAPELLIDOw = new SqlParameter();
                ParAPELLIDOw.ParameterName = "@fecha_pago";
                ParAPELLIDOw.SqlDbType = SqlDbType.Date;
                ParAPELLIDOw.Value = pago.Fecha_pago;
                SqlCmd.Parameters.Add(ParAPELLIDOw);

                SqlParameter ParAPELLIDOwd = new SqlParameter();
                ParAPELLIDOwd.ParameterName = "@debe";
                ParAPELLIDOwd.SqlDbType = SqlDbType.Int;
                ParAPELLIDOwd.Value = pago.Debe;
                SqlCmd.Parameters.Add(ParAPELLIDOwd);

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
        public string Editar(DPago pago)
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
                SqlCmd.CommandText = "spinsertar_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_pago";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = pago.Id_pago;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@cantidad_pagar";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = pago.Cantidad_pagar;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@id_deta_deuda";
                ParAPELLIDO.SqlDbType = SqlDbType.Int;
                ParAPELLIDO.Value = pago.Id_deta_deuda;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter ParAPELLIDOw = new SqlParameter();
                ParAPELLIDOw.ParameterName = "@fecha_pago";
                ParAPELLIDOw.SqlDbType = SqlDbType.Date;
                ParAPELLIDOw.Value = pago.Fecha_pago;
                SqlCmd.Parameters.Add(ParAPELLIDOw);

                SqlParameter ParAPELLIDOwd = new SqlParameter();
                ParAPELLIDOwd.ParameterName = "@debe";
                ParAPELLIDOwd.SqlDbType = SqlDbType.Int;
                ParAPELLIDOwd.Value = pago.Debe;
                SqlCmd.Parameters.Add(ParAPELLIDOwd);

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
        public DataTable BuscarNombre(DPago pago)
        {
            DataTable Dtpersona = new DataTable("madre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_pago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = pago.TextBuscar;
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



