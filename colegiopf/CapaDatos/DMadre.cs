using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DMadre
    {
        private int _id_madre;

        public int Id_madre
        {
            get { return _id_madre; }
            set { _id_madre = value; }
        }
        private string _nombre_ma;

        public string Nombre_ma
        {
            get { return _nombre_ma; }
            set { _nombre_ma = value; }
        }
        private string _apellido_materno_ma;

        public string Apellido_materno_ma
        {
            get { return _apellido_materno_ma; }
            set { _apellido_materno_ma = value; }
        }
        private string _dni_ma;

        public string Dni_ma
        {
            get { return _dni_ma; }
            set { _dni_ma = value; }
        }
        private string _email_ma;

        public string Email_ma
        {
            get { return _email_ma; }
            set { _email_ma = value; }
        }
        private string _ocuacion_ma;

        public string Ocuacion_ma
        {
            get { return _ocuacion_ma; }
            set { _ocuacion_ma = value; }
        }
        private string _esta_civil_ma;

        public string Esta_civil_ma
        {
            get { return _esta_civil_ma; }
            set { _esta_civil_ma = value; }
        }
        private string _celular_ma;

        public string Celular_ma
        {
            get { return _celular_ma; }
            set { _celular_ma = value; }
        }
        private string _grado_estudio_ma;

        public string Grado_estudio_ma
        {
            get { return _grado_estudio_ma; }
            set { _grado_estudio_ma = value; }
        }
        private string _centro_trabajo_ma;

        public string Centro_trabajo_ma
        {
            get { return _centro_trabajo_ma; }
            set { _centro_trabajo_ma = value; }
        }
        private string _domi_actual_ma;

        public string Domi_actual_ma
        {
            get { return _domi_actual_ma; }
            set { _domi_actual_ma = value; }
        }
        private string _fecha_defu;

        public string Fecha_defu
        {
            get { return _fecha_defu; }
            set { _fecha_defu = value; }
        }
        private DateTime _fecha_naci;

        public DateTime Fecha_naci
        {
            get { return _fecha_naci; }
            set { _fecha_naci = value; }
        }
        private string _lugar_naci;

        public string Lugar_naci
        {
            get { return _lugar_naci; }
            set { _lugar_naci = value; }
        }
        private string _vive;

        public string Vive
        {
            get { return _vive; }
            set { _vive = value; }
        }
        private string _vive_con_estu;

        public string Vive_con_estu
        {
            get { return _vive_con_estu; }
            set { _vive_con_estu = value; }
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
        public DMadre()
        {

        }
        public DMadre(int id_madre, string nombre_ma, string apellido_ma, string dni_ma, string email_ma, string ocuacion_ma, string esta_civil_ma, string celular_ma, string grado_estudio_ma, string centro_trabajo_ma, string domi_actual_ma,string fecha_defu, DateTime fecha_naci, string lugar_naci, string vive, string vive_con_estu, string textbuscar, string textbuscar1)
        {
            this.Id_madre = id_madre;
            this.Nombre_ma = nombre_ma;
            this.Apellido_materno_ma = apellido_ma;
            this.Dni_ma = dni_ma;
            this.Email_ma = email_ma;
            this.Ocuacion_ma = ocuacion_ma;
            this.Esta_civil_ma = esta_civil_ma;
            this.Celular_ma = celular_ma;
            this.Grado_estudio_ma = grado_estudio_ma;
            this.Centro_trabajo_ma = centro_trabajo_ma;
            this.Domi_actual_ma = domi_actual_ma;
            this.Fecha_defu = fecha_defu;
            this.Fecha_naci = fecha_naci;
            this.Lugar_naci = lugar_naci;
            this.Vive = vive;
            this.Vive_con_estu = vive_con_estu;
            this.TextBuscar = textbuscar;
            this.TextBuscar1 = textbuscar1;
        }
        public string Insertar(DMadre madre)
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
                SqlCmd.CommandText = "spinsertar_madre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_madre";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_ma";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = madre.Nombre_ma;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@apellido_materno_ma";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 50;
                ParAPELLIDO.Value = madre.Apellido_materno_ma;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter Pardni = new SqlParameter();
                Pardni.ParameterName = "@dni_ma";
                Pardni.SqlDbType = SqlDbType.VarChar;
                Pardni.Size = 50;
                Pardni.Value = madre.Dni_ma;
                SqlCmd.Parameters.Add(Pardni);

                SqlParameter Pardn = new SqlParameter();
                Pardn.ParameterName = "@email_ma";
                Pardn.SqlDbType = SqlDbType.VarChar;
                Pardn.Size = 50;
                Pardn.Value = madre.Email_ma;
                SqlCmd.Parameters.Add(Pardn);

                SqlParameter ParAPELLID = new SqlParameter();
                ParAPELLID.ParameterName = "@ocuacion_ma";
                ParAPELLID.SqlDbType = SqlDbType.VarChar;
                ParAPELLID.Size = 50;
                ParAPELLID.Value = madre.Ocuacion_ma;
                SqlCmd.Parameters.Add(ParAPELLID);

                SqlParameter Pardnid = new SqlParameter();
                Pardnid.ParameterName = "@esta_civil_ma";
                Pardnid.SqlDbType = SqlDbType.VarChar;
                Pardnid.Size = 50;
                Pardnid.Value = madre.Esta_civil_ma;
                SqlCmd.Parameters.Add(Pardnid);

                SqlParameter Pard = new SqlParameter();
                Pard.ParameterName = "@celular_ma";
                Pard.SqlDbType = SqlDbType.VarChar;
                Pard.Size = 50;
                Pard.Value = madre.Celular_ma;
                SqlCmd.Parameters.Add(Pard);

                SqlParameter ParNombrehh = new SqlParameter();
                ParNombrehh.ParameterName = "@grado_estudio_ma";
                ParNombrehh.SqlDbType = SqlDbType.VarChar;
                ParNombrehh.Size = 50;
                ParNombrehh.Value = madre.Grado_estudio_ma;
                SqlCmd.Parameters.Add(ParNombrehh);

                SqlParameter ParAPELLIDOkk = new SqlParameter();
                ParAPELLIDOkk.ParameterName = "@centro_trabajo_ma";
                ParAPELLIDOkk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkk.Size = 50;
                ParAPELLIDOkk.Value = madre.Centro_trabajo_ma;
                SqlCmd.Parameters.Add(ParAPELLIDOkk);

                SqlParameter ParNombreh = new SqlParameter();
                ParNombreh.ParameterName = "@domi_actual";
                ParNombreh.SqlDbType = SqlDbType.VarChar;
                ParNombreh.Size = 50;
                ParNombreh.Value = madre.Domi_actual_ma;
                SqlCmd.Parameters.Add(ParNombreh);

                SqlParameter ParAPELLIDOk = new SqlParameter();
                ParAPELLIDOk.ParameterName = "@fecha_defu";
                ParAPELLIDOk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOk.Size = 50;
                ParAPELLIDOk.Value = madre.Fecha_defu;
                SqlCmd.Parameters.Add(ParAPELLIDOk);

                SqlParameter ParAPELLIDOkf = new SqlParameter();
                ParAPELLIDOkf.ParameterName = "@fecha_naci";
                ParAPELLIDOkf.SqlDbType = SqlDbType.Date;
                ParAPELLIDOkf.Value = madre.Fecha_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkf);

                SqlParameter ParAPELLIDOkll = new SqlParameter();
                ParAPELLIDOkll.ParameterName = "@lugar_naci";
                ParAPELLIDOkll.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkll.Size = 50;
                ParAPELLIDOkll.Value = madre.Lugar_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkll);

                SqlParameter ParNombrehl = new SqlParameter();
                ParNombrehl.ParameterName = "@vive";
                ParNombrehl.SqlDbType = SqlDbType.VarChar;
                ParNombrehl.Size = 50;
                ParNombrehl.Value = madre.Vive;
                SqlCmd.Parameters.Add(ParNombrehl);

                SqlParameter ParAPELLIDOkl = new SqlParameter();
                ParAPELLIDOkl.ParameterName = "@vive_con_estu";
                ParAPELLIDOkl.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkl.Size = 50;
                ParAPELLIDOkl.Value = madre.Vive_con_estu;
                SqlCmd.Parameters.Add(ParAPELLIDOkl);


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
        public string Editar(DMadre madre)
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
                SqlCmd.CommandText = "spinsertar_madre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_madre";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = madre.Id_madre;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_ma";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = madre.Nombre_ma;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@apellido_materno_ma";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 50;
                ParAPELLIDO.Value = madre.Apellido_materno_ma;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter Pardni = new SqlParameter();
                Pardni.ParameterName = "@dni_ma";
                Pardni.SqlDbType = SqlDbType.VarChar;
                Pardni.Size = 50;
                Pardni.Value = madre.Dni_ma;
                SqlCmd.Parameters.Add(Pardni);

                SqlParameter Pardn = new SqlParameter();
                Pardn.ParameterName = "@email_ma";
                Pardn.SqlDbType = SqlDbType.VarChar;
                Pardn.Size = 50;
                Pardn.Value = madre.Email_ma;
                SqlCmd.Parameters.Add(Pardn);

                SqlParameter ParAPELLID = new SqlParameter();
                ParAPELLID.ParameterName = "@ocuacion_ma";
                ParAPELLID.SqlDbType = SqlDbType.VarChar;
                ParAPELLID.Size = 50;
                ParAPELLID.Value = madre.Ocuacion_ma;
                SqlCmd.Parameters.Add(ParAPELLID);

                SqlParameter Pardnid = new SqlParameter();
                Pardnid.ParameterName = "@esta_civil_ma";
                Pardnid.SqlDbType = SqlDbType.VarChar;
                Pardnid.Size = 50;
                Pardnid.Value = madre.Esta_civil_ma;
                SqlCmd.Parameters.Add(Pardnid);

                SqlParameter Pard = new SqlParameter();
                Pard.ParameterName = "@celular_ma";
                Pard.SqlDbType = SqlDbType.VarChar;
                Pard.Size = 50;
                Pard.Value = madre.Celular_ma;
                SqlCmd.Parameters.Add(Pard);

                SqlParameter ParNombrehh = new SqlParameter();
                ParNombrehh.ParameterName = "@grado_estudio_ma";
                ParNombrehh.SqlDbType = SqlDbType.VarChar;
                ParNombrehh.Size = 50;
                ParNombrehh.Value = madre.Grado_estudio_ma;
                SqlCmd.Parameters.Add(ParNombrehh);

                SqlParameter ParAPELLIDOkk = new SqlParameter();
                ParAPELLIDOkk.ParameterName = "@centro_trabajo_ma";
                ParAPELLIDOkk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkk.Size = 50;
                ParAPELLIDOkk.Value = madre.Centro_trabajo_ma;
                SqlCmd.Parameters.Add(ParAPELLIDOkk);

                SqlParameter ParNombreh = new SqlParameter();
                ParNombreh.ParameterName = "@domi_actual";
                ParNombreh.SqlDbType = SqlDbType.VarChar;
                ParNombreh.Size = 50;
                ParNombreh.Value = madre.Domi_actual_ma;
                SqlCmd.Parameters.Add(ParNombreh);

                SqlParameter ParAPELLIDOk = new SqlParameter();
                ParAPELLIDOk.ParameterName = "@fecha_defu";
                ParAPELLIDOk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOk.Size = 50;
                ParAPELLIDOk.Value = madre.Fecha_defu;
                SqlCmd.Parameters.Add(ParAPELLIDOk);

                SqlParameter ParAPELLIDOkf = new SqlParameter();
                ParAPELLIDOkf.ParameterName = "@fecha_naci";
                ParAPELLIDOkf.SqlDbType = SqlDbType.Date;
                ParAPELLIDOkf.Value = madre.Fecha_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkf);

                SqlParameter ParAPELLIDOkll = new SqlParameter();
                ParAPELLIDOkll.ParameterName = "@lugar_naci";
                ParAPELLIDOkll.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkll.Size = 50;
                ParAPELLIDOkll.Value = madre.Lugar_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkll);

                SqlParameter ParNombrehl = new SqlParameter();
                ParNombrehl.ParameterName = "@vive";
                ParNombrehl.SqlDbType = SqlDbType.VarChar;
                ParNombrehl.Size = 50;
                ParNombrehl.Value = madre.Vive;
                SqlCmd.Parameters.Add(ParNombrehl);

                SqlParameter ParAPELLIDOkl = new SqlParameter();
                ParAPELLIDOkl.ParameterName = "@vive_con_estu";
                ParAPELLIDOkl.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkl.Size = 50;
                ParAPELLIDOkl.Value = madre.Vive_con_estu;
                SqlCmd.Parameters.Add(ParAPELLIDOkl);


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
        public string Eliminar(DMadre madre)
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
                SqlCmd.CommandText = "speliminar_madre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Paridcateper = new SqlParameter();
                Paridcateper.ParameterName = "@id_madre";
                Paridcateper.SqlDbType = SqlDbType.Int;
                Paridcateper.Value = madre.Id_madre;
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
            DataTable Dtcatepersona = new DataTable("madre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_madre";
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
        public DataTable BuscarNombre(DMadre madre)
        {
            DataTable Dtpersona = new DataTable("madre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_madre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = madre.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscarq = new SqlParameter();
                ParTextoBuscarq.ParameterName = "@textbuscar1";
                ParTextoBuscarq.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscarq.Size = 50;
                ParTextoBuscarq.Value = madre.TextBuscar1;
                SqlCmd.Parameters.Add(ParTextoBuscarq);

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