using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class DProfesor
    {
     
           private int _id_profesor;

           public int Id_profesor
           {
               get { return _id_profesor; }
               set { _id_profesor = value; }
           }

          
           private string _nombre;

           public string Nombre
           {
               get { return _nombre; }
               set { _nombre = value; }
           }
           private string _apellidos;

           public string Apellidos
           {
               get { return _apellidos; }
               set { _apellidos = value; }
           }
           private string _dni;

           public string Dni
           {
               get { return _dni; }
               set { _dni = value; }
           }
           private string _celular;

           public string Celular
           {
               get { return _celular; }
               set { _celular = value; }
           }
           private string _email;

           public string Email
           {
               get { return _email; }
               set { _email = value; }
           }
           private DateTime _fecha_naci;

           public DateTime Fecha_naci
           {
               get { return _fecha_naci; }
               set { _fecha_naci = value; }
           }
           private string _edad;

           public string Edad
           {
               get { return _edad; }
               set { _edad = value; }
           }
           private int _id_año;

           public int Id_año
           {
               get { return _id_año; }
               set { _id_año = value; }
           }
           private string _TextBuscar1;

           public string TextBuscar1
           {
               get { return _TextBuscar1; }
               set { _TextBuscar1 = value; }
           }
           private string _TextBuscar3;

           public string TextBuscar3
           {
               get { return _TextBuscar3; }
               set { _TextBuscar3 = value; }
           }
       
           public DProfesor()
           {

           }
           public DProfesor(int id_profesor, string nombre, string apellido, string dni, string celular, string email, DateTime fecha_naci, string edad, int id_año,string textbuscar1,string textbuscar3)
           {
               this.Id_profesor = id_profesor;
               this.Nombre = nombre;
               this.Apellidos = apellido;
               this.Dni = dni;
               this.Celular = celular;
               this.Email = email;
               this.Fecha_naci = fecha_naci;
               this.Edad = edad;
               this.Id_año = id_año;
               this.TextBuscar1 = textbuscar1;
               this.TextBuscar3 = textbuscar3;
           }

           public string Insertar(DProfesor profesor)
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
                   SqlCmd.CommandText = "spinsertar_profesor";
                   SqlCmd.CommandType = CommandType.StoredProcedure;

                   SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                   ParIdDAMNIFICADO.ParameterName = "@id_profesor";
                   ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                   ParIdDAMNIFICADO.Direction = ParameterDirection.Output;
                   SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                   SqlParameter ParNombre = new SqlParameter();
                   ParNombre.ParameterName = "@nombre";
                   ParNombre.SqlDbType = SqlDbType.VarChar;
                   ParNombre.Size = 50;
                   ParNombre.Value = profesor.Nombre;
                   SqlCmd.Parameters.Add(ParNombre);

                   SqlParameter ParAPELLIDO = new SqlParameter();
                   ParAPELLIDO.ParameterName = "@apellidos";
                   ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                   ParAPELLIDO.Size = 50;
                   ParAPELLIDO.Value = profesor.Apellidos;
                   SqlCmd.Parameters.Add(ParAPELLIDO);

                   SqlParameter Pardni = new SqlParameter();
                   Pardni.ParameterName = "@dni";
                   Pardni.SqlDbType = SqlDbType.Char;
                   Pardni.Size = 8;
                   Pardni.Value = profesor.Dni;
                   SqlCmd.Parameters.Add(Pardni);

                   SqlParameter ParAPELLID = new SqlParameter();
                   ParAPELLID.ParameterName = "@celular";
                   ParAPELLID.SqlDbType = SqlDbType.VarChar;
                   ParAPELLID.Size = 50;
                   ParAPELLID.Value = profesor.Celular;
                   SqlCmd.Parameters.Add(ParAPELLID);

                   SqlParameter ParNombrehh = new SqlParameter();
                   ParNombrehh.ParameterName = "@email";
                   ParNombrehh.SqlDbType = SqlDbType.VarChar;
                   ParNombrehh.Size = 50;
                   ParNombrehh.Value = profesor.Email;
                   SqlCmd.Parameters.Add(ParNombrehh);

                   SqlParameter Pardn = new SqlParameter();
                   Pardn.ParameterName = "@fecha_naci";
                   Pardn.SqlDbType = SqlDbType.DateTime;
                   Pardn.Size = 8;
                   Pardn.Value = profesor.Fecha_naci;
                   SqlCmd.Parameters.Add(Pardn);

                   SqlParameter Pardnid = new SqlParameter();
                   Pardnid.ParameterName = "@edad";
                   Pardnid.SqlDbType = SqlDbType.VarChar;
                   Pardnid.Size = 20;
                   Pardnid.Value = profesor.Edad;
                   SqlCmd.Parameters.Add(Pardnid);


                   SqlParameter ParNombrehlhh = new SqlParameter();
                   ParNombrehlhh.ParameterName = "@id_año";
                   ParNombrehlhh.SqlDbType = SqlDbType.Int;
                   ParNombrehlhh.Value = profesor.Id_año;
                   SqlCmd.Parameters.Add(ParNombrehlhh);


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
           public string Editar(DProfesor profesor)
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
                   SqlCmd.CommandText = "speditar_profesor";
                   SqlCmd.CommandType = CommandType.StoredProcedure;

                   SqlParameter ParIdDAMNIFICADO = new SqlParameter();
                   ParIdDAMNIFICADO.ParameterName = "@id_profesor";
                   ParIdDAMNIFICADO.SqlDbType = SqlDbType.Int;
                   ParIdDAMNIFICADO.Value = profesor.Id_profesor;
                   SqlCmd.Parameters.Add(ParIdDAMNIFICADO);

                   SqlParameter ParNombre = new SqlParameter();
                   ParNombre.ParameterName = "@nombre";
                   ParNombre.SqlDbType = SqlDbType.VarChar;
                   ParNombre.Size = 50;
                   ParNombre.Value = profesor.Nombre;
                   SqlCmd.Parameters.Add(ParNombre);

                   SqlParameter ParAPELLIDO = new SqlParameter();
                   ParAPELLIDO.ParameterName = "@apellidos";
                   ParAPELLIDO.SqlDbType = SqlDbType.VarChar;
                   ParAPELLIDO.Size = 50;
                   ParAPELLIDO.Value = profesor.Apellidos;
                   SqlCmd.Parameters.Add(ParAPELLIDO);

                   SqlParameter Pardni = new SqlParameter();
                   Pardni.ParameterName = "@dni";
                   Pardni.SqlDbType = SqlDbType.Char;
                   Pardni.Size = 8;
                   Pardni.Value = profesor.Dni;
                   SqlCmd.Parameters.Add(Pardni);

                   SqlParameter ParAPELLID = new SqlParameter();
                   ParAPELLID.ParameterName = "@celular";
                   ParAPELLID.SqlDbType = SqlDbType.VarChar;
                   ParAPELLID.Size = 50;
                   ParAPELLID.Value = profesor.Celular;
                   SqlCmd.Parameters.Add(ParAPELLID);

                   SqlParameter ParNombrehh = new SqlParameter();
                   ParNombrehh.ParameterName = "@email";
                   ParNombrehh.SqlDbType = SqlDbType.VarChar;
                   ParNombrehh.Size = 50;
                   ParNombrehh.Value = profesor.Email;
                   SqlCmd.Parameters.Add(ParNombrehh);

                   SqlParameter Pardn = new SqlParameter();
                   Pardn.ParameterName = "@fecha_naci";
                   Pardn.SqlDbType = SqlDbType.DateTime;
                   Pardn.Size = 8;
                   Pardn.Value = profesor.Fecha_naci;
                   SqlCmd.Parameters.Add(Pardn);

                   SqlParameter Pardnid = new SqlParameter();
                   Pardnid.ParameterName = "@edad";
                   Pardnid.SqlDbType = SqlDbType.VarChar;
                   Pardnid.Size = 20;
                   Pardnid.Value = profesor.Edad;
                   SqlCmd.Parameters.Add(Pardnid);


                   SqlParameter ParNombrehlhh = new SqlParameter();
                   ParNombrehlhh.ParameterName = "@id_año";
                   ParNombrehlhh.SqlDbType = SqlDbType.Int;
                   ParNombrehlhh.Value = profesor.Id_año;
                   SqlCmd.Parameters.Add(ParNombrehlhh);


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
           public string Eliminar(DProfesor profesor)
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
                   SqlCmd.CommandText = "speliminar_profesor";
                   SqlCmd.CommandType = CommandType.StoredProcedure;

                   SqlParameter Paridcateper = new SqlParameter();
                   Paridcateper.ParameterName = "@id_profesor";
                   Paridcateper.SqlDbType = SqlDbType.Int;
                   Paridcateper.Value = profesor.Id_profesor;
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
               DataTable Dtcatepersona = new DataTable("profesor");
               SqlConnection SqlCon = new SqlConnection();
               try
               {
                   SqlCon.ConnectionString = Conexion.Cn;
                   SqlCommand SqlCmd = new SqlCommand();
                   SqlCmd.Connection = SqlCon;
                   SqlCmd.CommandText = "spmostrar_profesor";
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
           public DataTable BuscarNombre(DProfesor profesor)
           {
               DataTable Dtpersona = new DataTable("profesor");
               SqlConnection SqlCon = new SqlConnection();
               try
               {
                   SqlCon.ConnectionString = Conexion.Cn;
                   SqlCommand SqlCmd = new SqlCommand();
                   SqlCmd.Connection = SqlCon;
                   SqlCmd.CommandText = "spbuscar_profesor";
                   SqlCmd.CommandType = CommandType.StoredProcedure;

                   SqlParameter ParTextoBuscar = new SqlParameter();
                   ParTextoBuscar.ParameterName = "@textbuscar1";
                   ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                   ParTextoBuscar.Size = 50;
                   ParTextoBuscar.Value = profesor.TextBuscar1;
                   SqlCmd.Parameters.Add(ParTextoBuscar);

                   SqlParameter ParTextoBuscara = new SqlParameter();
                   ParTextoBuscara.ParameterName = "@textbuscar3";
                   ParTextoBuscara.SqlDbType = SqlDbType.VarChar;
                   ParTextoBuscara.Size = 50;
                   ParTextoBuscara.Value = profesor.TextBuscar3;
                   SqlCmd.Parameters.Add(ParTextoBuscara);

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

