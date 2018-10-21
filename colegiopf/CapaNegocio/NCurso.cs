using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NCurso
    {
        public static string Insertar(string nombre,string grado,string año)
        {
            DCurso Obj = new DCurso();

            Obj.Nombre = nombre;
            Obj.Grado = grado;
            Obj.Año = año;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_curso, string nombre, string grado, string año)
        {
            DCurso Obj = new DCurso();
            Obj.Id_curso = id_curso;
            Obj.Nombre = nombre;
            Obj.Grado = grado;
            Obj.Año = año;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_curso)
        {
            DCurso Obj = new DCurso();
            Obj.Id_curso = id_curso;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DCurso().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DCurso Obj = new DCurso();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
