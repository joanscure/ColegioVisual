using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NSiage
    {
        public static DataTable Mostrar()
        {
            return new DSiage().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar, string textbuscar1)
        {
            DSiage Obj = new DSiage();
            Obj.TextBuscar = textbuscar;
            Obj.TextBuscar1 = textbuscar1;
            return Obj.BuscarNombre(Obj);
        }
    }
}
