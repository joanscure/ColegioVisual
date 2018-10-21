using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NDeuda
    {
        public static string Insertar(string descipcion, int monto)
        {
            DDeuda Obj = new DDeuda();

            Obj.Descripcion = descipcion;
            Obj.Monto = monto ;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_deuda, string descipcion, int monto)
        {
            DDeuda Obj = new DDeuda();
            Obj.Id_deuda = id_deuda;
            Obj.Descripcion = descipcion;
            Obj.Monto = monto;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_deuda)
        {
            DDeuda Obj = new DDeuda();
            Obj.Id_deuda = id_deuda;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DDeuda().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DDeuda Obj = new DDeuda();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
