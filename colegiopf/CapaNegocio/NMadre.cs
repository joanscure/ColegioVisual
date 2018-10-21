using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NMadre
    {
        public static string Insertar(string nombre_pa, string apellido_pa, string dni_pa, string email_pa, string ocuacion_pa, string esta_civil_pa, string celular_pa, string grado_estudio_pa, string centro_trabajo_pa, string domi_actual_pa, string fecha_defu, DateTime fecha_naci, string lugar_naci, string vive, string vive_con_estu)
        {
            DMadre Obj = new DMadre();
            Obj.Nombre_ma = nombre_pa;
            Obj.Apellido_materno_ma = apellido_pa;
            Obj.Dni_ma = dni_pa;
            Obj.Email_ma = email_pa;
            Obj.Ocuacion_ma = ocuacion_pa;
            Obj.Esta_civil_ma = esta_civil_pa;
            Obj.Celular_ma = celular_pa;
            Obj.Grado_estudio_ma = grado_estudio_pa;
            Obj.Centro_trabajo_ma = centro_trabajo_pa;
            Obj.Domi_actual_ma = domi_actual_pa;
            Obj.Fecha_defu = fecha_defu;
            Obj.Fecha_naci = fecha_naci;
            Obj.Lugar_naci = lugar_naci;
            Obj.Vive = vive;
            Obj.Vive_con_estu = vive_con_estu;

            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_madre, string nombre_ma, string apellido_ma, string dni_ma, string email_ma, string ocuacion_ma, string esta_civil_ma, string celular_ma, string grado_estudio_ma, string centro_trabajo_ma, string domi_actual_ma, string fecha_defu, DateTime fecha_naci, string lugar_naci, string vive, string vive_con_estu)
        {
            DMadre Obj = new DMadre();
            Obj.Id_madre = id_madre;
            Obj.Nombre_ma = nombre_ma;
            Obj.Apellido_materno_ma = apellido_ma;
            Obj.Dni_ma = dni_ma;
            Obj.Email_ma = email_ma;
            Obj.Ocuacion_ma = ocuacion_ma;
            Obj.Esta_civil_ma = esta_civil_ma;
            Obj.Celular_ma = celular_ma;
            Obj.Grado_estudio_ma = grado_estudio_ma;
            Obj.Centro_trabajo_ma = centro_trabajo_ma;
            Obj.Domi_actual_ma = domi_actual_ma;
            Obj.Fecha_defu = fecha_defu;
            Obj.Fecha_naci = fecha_naci;
            Obj.Lugar_naci = lugar_naci;
            Obj.Vive = vive;
            Obj.Vive_con_estu = vive_con_estu;

            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_madre)
        {
            DMadre Obj = new DMadre();
            Obj.Id_madre = id_madre;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DMadre().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar, string textbuscar1)
        {
            DMadre Obj = new DMadre();
            Obj.TextBuscar = textbuscar;
            Obj.TextBuscar1 = textbuscar1;
            return Obj.BuscarNombre(Obj);
        }

    }
}
