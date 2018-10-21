using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCursoProfe
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
        private string _TextBuscar2;

        public string TextBuscar2
        {
            get { return _TextBuscar2; }
            set { _TextBuscar2 = value; }
        }
        private string _TextBuscar3;

        public string TextBuscar3
        {
            get { return _TextBuscar3; }
            set { _TextBuscar3 = value; }
        }
        public DCursoProfe ()
   {

   }
        public DCursoProfe(string textbuscar, string textbuscar1, string textbuscar2, string textbuscar3)
   {
            this.TextBuscar = textbuscar;
            this.TextBuscar1 = textbuscar1;
            this.TextBuscar2 = textbuscar2;
            this.TextBuscar3 = textbuscar3;
   }

        public DataTable Mostrar()
        {
            DataTable Dtpersona = new DataTable("profe_curso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_persona";
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
        public DataTable BuscarNombre(DCursoProfe cursoprofe)
        {
            DataTable Dtpersona = new DataTable("persona");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tablamaestro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = cursoprofe.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscars = new SqlParameter();
                ParTextoBuscars.ParameterName = "@textbuscar1";
                ParTextoBuscars.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscars.Size = 50;
                ParTextoBuscars.Value = cursoprofe.TextBuscar1;
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
        public DataTable BuscarNombre2(DCursoProfe cursoprofe)
        {
            DataTable Dtpersona = new DataTable("cursoprofe");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_tablamaestro2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar1";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = cursoprofe.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscarsa = new SqlParameter();
                ParTextoBuscarsa.ParameterName = "@textbuscar3";
                ParTextoBuscarsa.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscarsa.Size = 50;
                ParTextoBuscarsa.Value = cursoprofe.TextBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscarsa);

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

