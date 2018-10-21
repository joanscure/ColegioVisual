using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DPadre
    {
        private int _id_padre;

        public int Id_padre
        {
            get { return _id_padre; }
            set { _id_padre = value; }
        }
        private string _nombre_pa;

        public string Nombre_pa
        {
            get { return _nombre_pa; }
            set { _nombre_pa = value; }
        }
        private string _apellido_pa;

        public string Apellido_pa
        {
            get { return _apellido_pa; }
            set { _apellido_pa = value; }
        }
        private string _dni_pa;

        public string Dni_pa
        {
            get { return _dni_pa; }
            set { _dni_pa = value; }
        }
        private string _email_pa;

        public string Email_pa
        {
            get { return _email_pa; }
            set { _email_pa = value; }
        }
        private string _ocuacion_pa;

        public string Ocuacion_pa
        {
            get { return _ocuacion_pa; }
            set { _ocuacion_pa = value; }
        }
        private string _esta_civil_pa;

        public string Esta_civil_pa
        {
            get { return _esta_civil_pa; }
            set { _esta_civil_pa = value; }
        }
        private string _celular_pa;

        public string Celular_pa
        {
            get { return _celular_pa; }
            set { _celular_pa = value; }
        }
        private string _grado_estudio_pa;

        public string Grado_estudio_pa
        {
            get { return _grado_estudio_pa; }
            set { _grado_estudio_pa = value; }
        }
        private string _centro_trabajo_pa;

        public string Centro_trabajo_pa
        {
            get { return _centro_trabajo_pa; }
            set { _centro_trabajo_pa = value; }
        }
        private string _domi_actual_pa;

        public string Domi_actual_pa
        {
            get { return _domi_actual_pa; }
            set { _domi_actual_pa = value; }
        }
        private string _fecha_def;

        public string Fecha_def
        {
            get { return _fecha_def; }
            set { _fecha_def = value; }
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

        public DPadre()
        {

        }
        public DPadre(int id_padre, string nombre_pa, string apellido_pa, string dni_pa, string email_pa, string ocuacion_pa, string esta_civil_pa, string celular_pa, string grado_estudio_pa, string centro_trabajo_pa, string domi_actual_pa, string fecha_defu, DateTime fecha_naci, string lugar_naci, string vive, string vive_con_estu, string textbuscar, string textbuscar1)
        {
            this.Id_padre = id_padre;
            this.Nombre_pa = nombre_pa;
            this.Apellido_pa = apellido_pa;
            this.Dni_pa = dni_pa;
            this.Email_pa = email_pa;
            this.Ocuacion_pa = ocuacion_pa;
            this.Esta_civil_pa = esta_civil_pa;
            this.Celular_pa = celular_pa;
            this.Grado_estudio_pa = grado_estudio_pa;
            this.Centro_trabajo_pa = centro_trabajo_pa;
            this.Domi_actual_pa = domi_actual_pa;
            this.Fecha_def = fecha_defu;
            this.Fecha_naci = fecha_naci;
            this.Lugar_naci = lugar_naci;
            this.Vive = vive;
            this.Vive_con_estu = vive_con_estu;
            this.TextBuscar = textbuscar;
            this.TextBuscar1 = textbuscar1;
        }
        public string Insertar(DPadre padre)
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
                SqlCmd.CommandText = "spinsertar_padre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_padre";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_pa";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = padre.Nombre_pa;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@apellido_pa";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 50;
                ParAPELLIDO.Value = padre.Apellido_pa;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter Pardni = new SqlParameter();
                Pardni.ParameterName = "@dni_pa";
                Pardni.SqlDbType = SqlDbType.VarChar;
                Pardni.Size = 50;
                Pardni.Value = padre.Dni_pa;
                SqlCmd.Parameters.Add(Pardni);

                SqlParameter Pardn = new SqlParameter();
                Pardn.ParameterName = "@email_pa";
                Pardn.SqlDbType = SqlDbType.VarChar;
                Pardn.Size = 50;
                Pardn.Value = padre.Email_pa;
                SqlCmd.Parameters.Add(Pardn);

                SqlParameter ParAPELLID = new SqlParameter();
                ParAPELLID.ParameterName = "@ocuacion_pa";
                ParAPELLID.SqlDbType = SqlDbType.VarChar;
                ParAPELLID.Size = 50;
                ParAPELLID.Value = padre.Ocuacion_pa;
                SqlCmd.Parameters.Add(ParAPELLID);

                SqlParameter Pardnid = new SqlParameter();
                Pardnid.ParameterName = "@esta_civil_pa";
                Pardnid.SqlDbType = SqlDbType.VarChar;
                Pardnid.Size = 50;
                Pardnid.Value = padre.Esta_civil_pa;
                SqlCmd.Parameters.Add(Pardnid);

                SqlParameter Pard = new SqlParameter();
                Pard.ParameterName = "@celular_pa";
                Pard.SqlDbType = SqlDbType.VarChar;
                Pard.Size = 50;
                Pard.Value = padre.Celular_pa;
                SqlCmd.Parameters.Add(Pard);

                SqlParameter ParNombrehh = new SqlParameter();
                ParNombrehh.ParameterName = "@grado_estudio_pa";
                ParNombrehh.SqlDbType = SqlDbType.VarChar;
                ParNombrehh.Size = 50;
                ParNombrehh.Value = padre.Grado_estudio_pa;
                SqlCmd.Parameters.Add(ParNombrehh);

                SqlParameter ParAPELLIDOkk = new SqlParameter();
                ParAPELLIDOkk.ParameterName = "@centro_trabajo_pa";
                ParAPELLIDOkk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkk.Size = 50;
                ParAPELLIDOkk.Value = padre.Centro_trabajo_pa;
                SqlCmd.Parameters.Add(ParAPELLIDOkk);

                SqlParameter ParNombreh = new SqlParameter();
                ParNombreh.ParameterName = "@domi_actual";
                ParNombreh.SqlDbType = SqlDbType.VarChar;
                ParNombreh.Size = 50;
                ParNombreh.Value = padre.Domi_actual_pa;
                SqlCmd.Parameters.Add(ParNombreh);

                SqlParameter ParAPELLIDOk = new SqlParameter();
                ParAPELLIDOk.ParameterName = "@fecha_defu";
                ParAPELLIDOk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOk.Size = 50;
                ParAPELLIDOk.Value = padre.Fecha_def;
                SqlCmd.Parameters.Add(ParAPELLIDOk);

                SqlParameter ParAPELLIDOkf = new SqlParameter();
                ParAPELLIDOkf.ParameterName = "@fecha_naci";
                ParAPELLIDOkf.SqlDbType = SqlDbType.Date;
                ParAPELLIDOkf.Value = padre.Fecha_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkf);

                SqlParameter ParAPELLIDOkll = new SqlParameter();
                ParAPELLIDOkll.ParameterName = "@lugar_naci";
                ParAPELLIDOkll.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkll.Size = 50;
                ParAPELLIDOkll.Value = padre.Lugar_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkll);

                SqlParameter ParNombrehl = new SqlParameter();
                ParNombrehl.ParameterName = "@vive";
                ParNombrehl.SqlDbType = SqlDbType.VarChar;
                ParNombrehl.Size = 50;
                ParNombrehl.Value = padre.Vive;
                SqlCmd.Parameters.Add(ParNombrehl);

                SqlParameter ParAPELLIDOkl = new SqlParameter();
                ParAPELLIDOkl.ParameterName = "@vive_con_estu";
                ParAPELLIDOkl.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkl.Size = 50;
                ParAPELLIDOkl.Value = padre.Vive_con_estu;
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
        public string Editar(DPadre padre)
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
                SqlCmd.CommandText = "spinsertar_padre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                ParIdDAMNIFICADO.ParameterName = "@id_padre";
                ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                ParIdDAMNIFICADO.Value = padre.Id_padre;
                SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_pa";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = padre.Nombre_pa;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParAPELLIDO = new SqlParameter();
                ParAPELLIDO.ParameterName = "@apellido_pa";
                ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDO.Size = 50;
                ParAPELLIDO.Value = padre.Apellido_pa;
                SqlCmd.Parameters.Add(ParAPELLIDO);

                SqlParameter Pardni = new SqlParameter();
                Pardni.ParameterName = "@dni_pa";
                Pardni.SqlDbType = SqlDbType.VarChar;
                Pardni.Size = 50;
                Pardni.Value = padre.Dni_pa;
                SqlCmd.Parameters.Add(Pardni);

                SqlParameter Pardn = new SqlParameter();
                Pardn.ParameterName = "@email_pa";
                Pardn.SqlDbType = SqlDbType.VarChar;
                Pardn.Size = 50;
                Pardn.Value = padre.Email_pa;
                SqlCmd.Parameters.Add(Pardn);

                SqlParameter ParAPELLID = new SqlParameter();
                ParAPELLID.ParameterName = "@ocuacion_pa";
                ParAPELLID.SqlDbType = SqlDbType.VarChar;
                ParAPELLID.Size = 50;
                ParAPELLID.Value = padre.Ocuacion_pa;
                SqlCmd.Parameters.Add(ParAPELLID);

                SqlParameter Pardnid = new SqlParameter();
                Pardnid.ParameterName = "@esta_civil_pa";
                Pardnid.SqlDbType = SqlDbType.VarChar;
                Pardnid.Size = 50;
                Pardnid.Value = padre.Esta_civil_pa;
                SqlCmd.Parameters.Add(Pardnid);

                SqlParameter Pard = new SqlParameter();
                Pard.ParameterName = "@celular_pa";
                Pard.SqlDbType = SqlDbType.VarChar;
                Pard.Size = 50;
                Pard.Value = padre.Celular_pa;
                SqlCmd.Parameters.Add(Pard);

                SqlParameter ParNombrehh = new SqlParameter();
                ParNombrehh.ParameterName = "@grado_estudio_pa";
                ParNombrehh.SqlDbType = SqlDbType.VarChar;
                ParNombrehh.Size = 50;
                ParNombrehh.Value = padre.Grado_estudio_pa;
                SqlCmd.Parameters.Add(ParNombrehh);

                SqlParameter ParAPELLIDOkk = new SqlParameter();
                ParAPELLIDOkk.ParameterName = "@centro_trabajo_pa";
                ParAPELLIDOkk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkk.Size = 50;
                ParAPELLIDOkk.Value = padre.Centro_trabajo_pa;
                SqlCmd.Parameters.Add(ParAPELLIDOkk);

                SqlParameter ParNombreh = new SqlParameter();
                ParNombreh.ParameterName = "@domi_actual_pa";
                ParNombreh.SqlDbType = SqlDbType.VarChar;
                ParNombreh.Size = 50;
                ParNombreh.Value = padre.Domi_actual_pa;
                SqlCmd.Parameters.Add(ParNombreh);

                SqlParameter ParAPELLIDOk = new SqlParameter();
                ParAPELLIDOk.ParameterName = "@fecha_defu";
                ParAPELLIDOk.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOk.Size = 50;
                ParAPELLIDOk.Value = padre.Fecha_def;
                SqlCmd.Parameters.Add(ParAPELLIDOk);

                SqlParameter ParNombrehll = new SqlParameter();
                ParNombrehll.ParameterName = "@fecha_naci";
                ParNombrehll.SqlDbType = SqlDbType.Date;
                ParNombrehll.Value = padre.Fecha_naci;
                SqlCmd.Parameters.Add(ParNombrehll);

                SqlParameter ParAPELLIDOkll = new SqlParameter();
                ParAPELLIDOkll.ParameterName = "@lugar_naci";
                ParAPELLIDOkll.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkll.Size = 50;
                ParAPELLIDOkll.Value = padre.Lugar_naci;
                SqlCmd.Parameters.Add(ParAPELLIDOkll);

                SqlParameter ParNombrehl = new SqlParameter();
                ParNombrehl.ParameterName = "@vive";
                ParNombrehl.SqlDbType = SqlDbType.VarChar;
                ParNombrehl.Size = 50;
                ParNombrehl.Value = padre.Vive;
                SqlCmd.Parameters.Add(ParNombrehl);

                SqlParameter ParAPELLIDOkl = new SqlParameter();
                ParAPELLIDOkl.ParameterName = "@vive_con_estu";
                ParAPELLIDOkl.SqlDbType = SqlDbType.VarChar;
                ParAPELLIDOkl.Size = 50;
                ParAPELLIDOkl.Value = padre.Vive_con_estu;
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
        public string Eliminar(DPadre padre)
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
                SqlCmd.CommandText = "speliminar_padre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Paridcateper = new SqlParameter();
                Paridcateper.ParameterName = "@id_padre";
                Paridcateper.SqlDbType = SqlDbType.Int;
                Paridcateper.Value = padre.Id_padre;
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
            DataTable Dtcatepersona = new DataTable("padre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_padre";
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
        public DataTable BuscarNombre(DPadre padre)
        {
            DataTable Dtpersona = new DataTable("padre");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_padre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textbuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = padre.TextBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscarq = new SqlParameter();
                ParTextoBuscarq.ParameterName = "@textbuscar1";
                ParTextoBuscarq.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscarq.Size = 50;
                ParTextoBuscarq.Value = padre.TextBuscar1;
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
