using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NCursoProfe
    {
        public static DataTable Mostrar()
        {
            return new DCursoProfe().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar, string textbuscar1)
        {
            DCursoProfe Obj = new DCursoProfe();
            Obj.TextBuscar = textbuscar;
            Obj.TextBuscar1 = textbuscar1;
            return Obj.BuscarNombre(Obj);
        }
        public static DataTable buscarnombre2(string textbuscar, string textbuscar2)
        {
            DCursoProfe Obj = new DCursoProfe();
            Obj.TextBuscar = textbuscar;
            Obj.TextBuscar2 = textbuscar2;
            return Obj.BuscarNombre2(Obj);
        }
    }
}
