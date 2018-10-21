using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DProfeCurso1
    {

        private int _id_profesor;

        public int Id_profesor
        {
            get { return _id_profesor; }
            set { _id_profesor = value; }
        }
        private int _id_curso;

        public int Id_curso
        {
            get { return _id_curso; }
            set { _id_curso = value; }
        }
        private int _id_profe_curso;

        public int Id_profe_curso
        {
            get { return _id_profe_curso; }
            set { _id_profe_curso = value; }
        }
        private string _TextBuscar;

        public string TextBuscar
        {
            get { return _TextBuscar; }
            set { _TextBuscar = value; }
        }
        public DProfeCurso1()
        {

        }
        public DProfeCurso1(int id_profesor, int id_curso, int id_profe_curso, string textbuscar)
        {

            this.Id_profesor = id_profesor;
            this.Id_curso = id_curso;
            this.Id_profe_curso = id_profe_curso;
            this.TextBuscar = textbuscar;
            
        }
        public string Insertar(DProfeCurso1 profeCurso1)
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
                SqlCmd.CommandText = "spinsertar_profe_Curso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_profe_curso";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@id_profesor";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = profeCurso1.Id_profesor;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@id_curso";
                ParAPELLIDO.SqlDbType = SqlDbType.Int;
                ParAPELLIDO.Value = profeCurso1.Id_curso;
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
        public string Editar(DProfeCurso1 profeCurso1)
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
                SqlCmd.CommandText = "speditar_profe_Curso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_profe_curso";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = profeCurso1.Id_profe_curso;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@id_profesor";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = profeCurso1.Id_profesor;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@id_curso";
                ParAPELLIDO.SqlDbType = SqlDbType.Int;
                ParAPELLIDO.Value = profeCurso1.Id_curso;
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
        public string Eliminar(DProfeCurso1 profeCurso1)
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
                SqlCmd.CommandText = "speliminar_profe_curso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_profe_curso";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = profeCurso1.Id_profe_curso;
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
        public DataTable BuscarNombre(DProfeCurso1 profeCurso1)
        {
            DataTable Dtpersona = new DataTable("PROFE");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cursoprofesor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = profeCurso1.TextBuscar;
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
