using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NPadre
    {
        public static string Insertar(string nombre_pa, string apellido_pa, string dni_pa, string email_pa, string ocuacion_pa, string esta_civil_pa, string celular_pa, string grado_estudio_pa, string centro_trabajo_pa,string domi_actual_pa, string fecha_defu, DateTime fecha_naci, string lugar_naci, string vive, string vive_con_estu)
        {
            DPadre Obj = new DPadre();
            Obj.Nombre_pa = nombre_pa;
            Obj.Apellido_pa = apellido_pa;
            Obj.Dni_pa = dni_pa;
            Obj.Email_pa = email_pa;
            Obj.Ocuacion_pa = ocuacion_pa;
            Obj.Esta_civil_pa = esta_civil_pa;
            Obj.Celular_pa = celular_pa;
            Obj.Grado_estudio_pa = grado_estudio_pa;
            Obj.Centro_trabajo_pa = centro_trabajo_pa;
            Obj.Domi_actual_pa = domi_actual_pa;
            Obj.Fecha_def = fecha_defu;
            Obj.Fecha_naci = fecha_naci;
            Obj.Lugar_naci = lugar_naci;
            Obj.Vive = vive;
            Obj.Vive_con_estu = vive_con_estu;
            
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_padre,string nombre_pa, string apellido_pa, string dni_pa, string email_pa, string ocuacion_pa, string esta_civil_pa, string celular_pa, string grado_estudio_pa, string centro_trabajo_pa, string domi_actual_pa, string fecha_defu, DateTime fecha_naci, string lugar_naci, string vive, string vive_con_estu)
        {
            DPadre Obj = new DPadre();
            Obj.Id_padre = id_padre;
            Obj.Nombre_pa = nombre_pa;
            Obj.Apellido_pa = apellido_pa;
            Obj.Dni_pa = dni_pa;
            Obj.Email_pa = email_pa;
            Obj.Ocuacion_pa = ocuacion_pa;
            Obj.Esta_civil_pa = esta_civil_pa;
            Obj.Celular_pa = celular_pa;
            Obj.Grado_estudio_pa = grado_estudio_pa;
            Obj.Centro_trabajo_pa = centro_trabajo_pa;
            Obj.Domi_actual_pa = domi_actual_pa;
            Obj.Fecha_def = fecha_defu;
            Obj.Fecha_naci = fecha_naci;
            Obj.Lugar_naci = lugar_naci;
            Obj.Vive = vive;
            Obj.Vive_con_estu = vive_con_estu;
            
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_padre)
        {
            DPadre Obj = new DPadre();
            Obj.Id_padre = id_padre;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DPadre().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar, string textbuscar1)
        {
            DPadre Obj = new DPadre();
            Obj.TextBuscar = textbuscar;
            Obj.TextBuscar1 = textbuscar1;
            return Obj.BuscarNombre(Obj);
        }
    }
}
