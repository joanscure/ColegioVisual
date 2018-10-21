using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NDetalleDeuda
    {
        public static string Insertar(int id_deuda, int id_alumno)
        {
            DDetalleDeuda Obj = new DDetalleDeuda();
            Obj.Id_deuda = id_deuda;
            Obj.Id_alumno = id_alumno;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_deta_deuda, int id_deuda, int id_alumno)
        {
            DDetalleDeuda Obj = new DDetalleDeuda();
            Obj.Id_deta_deuda = id_deta_deuda;
            Obj.Id_deuda = id_deuda;
            Obj.Id_alumno = id_alumno;
            return Obj.Editar(Obj);
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DDetalleDeuda Obj = new DDetalleDeuda();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
