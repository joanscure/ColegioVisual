using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
   public  class NCursoAlumno
    {

        public static string Insertar( int id_profe_curso, int id_alumno)
        {
            DCursoAlumno Obj = new DCursoAlumno();

            Obj.Id_profe_curso = id_profe_curso;
            Obj.Id_alumno = id_alumno;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_curso_alumno, int id_profe_curso, int id_alumno)
        {
            DCursoAlumno Obj = new DCursoAlumno();
            Obj.Id_curso_alumno = id_curso_alumno;
            Obj.Id_profe_curso = id_profe_curso;
            Obj.Id_alumno = id_alumno;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_curso_alumno)
        {
            DCursoAlumno Obj = new DCursoAlumno();
            Obj.Id_curso_alumno = id_curso_alumno;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DCursoAlumno().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DCursoAlumno Obj = new DCursoAlumno();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
