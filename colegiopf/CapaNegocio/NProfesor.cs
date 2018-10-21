using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NProfesor
    {
        public static string Insertar(string nombre,string apellido,string dni, string celular, string email,DateTime fecha_naci,string edad,int id_año)
        {
            DProfesor Obj = new DProfesor();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellido;
            Obj.Dni = dni;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Fecha_naci = fecha_naci;
            Obj.Edad = edad;
            Obj.Id_año = id_año;
            return Obj.Insertar(Obj);

        }
        public static string Editar(int id_profesor, string nombre, string apellido, string dni, string celular, string email, DateTime fecha_naci, string edad, int id_año)
        {
            DProfesor Obj = new DProfesor();
            Obj.Id_profesor = id_profesor;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellido;
            Obj.Dni = dni;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Fecha_naci = fecha_naci;
            Obj.Edad = edad;
            Obj.Id_año = id_año;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_profesor)
        {
            DProfesor Obj = new DProfesor();
            Obj.Id_profesor = id_profesor;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DProfesor().Mostrar();
        }
        public static DataTable buscarnombre(string textbuscar1, string textbuscar3)
        {
            DProfesor Obj = new DProfesor();
            Obj.TextBuscar1 = textbuscar1;
            Obj.TextBuscar3 = textbuscar3;
            return Obj.BuscarNombre(Obj);
        }
    }
}
