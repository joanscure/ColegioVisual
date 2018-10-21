using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DSiage
    {
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
        public DSiage ()
   {

   }
        public DSiage(string textbuscar, string textbuscar1)
   {
            this.TextBuscar = textbuscar;
            this.TextBuscar1 = textbuscar1;
   }


        public DataTable Mostrar()
        {
            DataTable Dtpersona = new DataTable("alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_alumnoSIGE";
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
        public DataTable BuscarNombre(DSiage siage)
        {
            DataTable Dtpersona = new DataTable("alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_alumnogite";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = siage.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscars = new SqlParameter();
                ParTextoBuscars.ParameterName = "@textbuscar1";
                ParTextoBuscars.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscars.Size = 50;
                ParTextoBuscars.Value = siage.TextBuscar1;
                SqlCmd.Parameters.Add(ParTextoBuscars);

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