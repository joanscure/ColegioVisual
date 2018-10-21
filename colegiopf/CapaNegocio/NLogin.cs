using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NLogin
    {
        public static string Insertar( string id, string contraseña, string acceso, int id_profesor)
        {
            DLogin Obj = new DLogin();

            Obj.Id = id;
            Obj.Contraseña = contraseña;
            Obj.Acceso = acceso;
            Obj.Id_profesor = id_profesor;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_login, string id, string contraseña, string acceso, int id_profesor)
        {
            DLogin Obj = new DLogin();
            Obj.Id_login = id_login;
            Obj.Id = id;
            Obj.Contraseña = contraseña;
            Obj.Acceso = acceso;
            Obj.Id_profesor = id_profesor;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_curso)
        {
            DCurso Obj = new DCurso();
            Obj.Id_curso = id_curso;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Login(string id, string contraseña)
        {
            DLogin Obj = new DLogin();
            Obj.Id = id;
            Obj.Contraseña = contraseña;
            return Obj.Login(Obj);
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DLogin Obj = new DLogin();
            Obj.TextBuscar = textbuscar;
           
            return Obj.BuscarNombre(Obj);
        }
    }
}
