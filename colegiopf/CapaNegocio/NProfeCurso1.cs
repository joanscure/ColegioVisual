using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NProfeCurso1
    {
        public static string Insertar(int id_profesor, int id_curso)
        {
            DProfeCurso1 Obj = new DProfeCurso1();
            Obj.Id_profesor = id_profesor;
            Obj.Id_curso = id_curso;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_profesor, int id_curso, int id_profe_curso)
        {
            DProfeCurso1 Obj = new DProfeCurso1();
            Obj.Id_profe_curso = id_profe_curso;
            Obj.Id_profesor = id_profesor;
            Obj.Id_curso = id_curso;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_profe_curso)
        {
            DProfeCurso1 Obj = new DProfeCurso1();
            Obj.Id_profe_curso = id_profe_curso;

            return Obj.Eliminar(Obj);
        }

        public static DataTable buscarnombre(string textbuscar)
        {
            DProfeCurso1 Obj = new DProfeCurso1();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
