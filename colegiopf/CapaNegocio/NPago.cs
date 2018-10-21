using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NPago
    {
        public static string Insertar( int cantidad_pagar, int id_deta_deuda, DateTime fecha_pago, int debe)
        {
            DPago Obj = new DPago();
            Obj.Cantidad_pagar = cantidad_pagar;
            Obj.Id_deta_deuda = id_deta_deuda;
            Obj.Fecha_pago = fecha_pago;
            Obj.Debe = debe;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_pago, int cantidad_pagar, int id_deta_deuda, DateTime fecha_pago, int debe)
        {
            DPago Obj = new DPago();
            Obj.Id_pago = id_pago;
            Obj.Cantidad_pagar = cantidad_pagar;
            Obj.Id_deta_deuda= id_deta_deuda;
            Obj.Fecha_pago = fecha_pago;
            Obj.Debe = debe;
            return Obj.Editar(Obj);
        }
        public static DataTable buscarnombre(string textbuscar)
        {
            DPago Obj = new DPago();
            Obj.TextBuscar = textbuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
