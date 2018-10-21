using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NNota
    {
        public static string Insertar(int id_curso_alumno, int n1, int n2, int n3, int n4)
        {
            DNota Obj = new DNota();

            Obj.Id_curso_alumno = id_curso_alumno;
            Obj.N1 = n1;
            Obj.N2 = n2;
            Obj.N3 = n3;
            Obj.N4 = n4;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_nota,int id_curso_alumno, int n1, int n2, int n3, int n4)
        {
            DNota Obj = new DNota();
            Obj.Id_nota = id_nota;
            Obj.Id_curso_alumno = id_curso_alumno;
            Obj.N1 = n1;
            Obj.N2 = n2;
            Obj.N3   = n3;
            Obj.N4 = n4;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_nota)
        {
            DNota Obj = new DNota();
            Obj.Id_nota = id_nota;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DNota().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar1, string textbuscar3)
        {
            DNota Obj = new DNota();
            Obj.TextBuscar1 = textbuscar1;
            Obj.TextBuscar3 = textbuscar3;
            return Obj.BuscarNombre(Obj);
        }
    }
}
