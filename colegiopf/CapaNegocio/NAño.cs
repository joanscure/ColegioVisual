using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
        public  class NAño
    {
        public static string Insertar(string descripcion, string año)
        {
            DAño Obj = new DAño();
            Obj.Descripcion = descripcion;
            Obj.Año = año;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_año, string descripcion, string año)
        {
            DAño Obj = new DAño();
            Obj.Id_año = id_año;
            Obj.Descripcion = descripcion;
            Obj.Año = año;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_año)
        {
            DAño Obj = new DAño();
            Obj.Id_año = id_año;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DAño().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DAño Obj = new DAño();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
