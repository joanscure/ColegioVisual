using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NAlumno
    {

        public static string Insertar(string nombres, string apellido, string dni, DateTime fecha_naci, string sexo,string edad, int id_padre, int id_madre, int id_año, string codigo, string lugar_naci, string domi_actual, string direccion, string n_partida, string religion, string len_materna, string n_hermanos, string lugar_ocupa, string cole_procedencia, string discapacidad, string parto)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.Nombres = nombres;
            Obj.Apellidos = apellido;
            Obj.Dni = dni;
            Obj.Fecha_naci = fecha_naci;
            Obj.Sexo = sexo;
            Obj.Edad = edad;
            Obj.Id_padre = id_padre;
            Obj.Id_madre = id_madre;
            Obj.Id_año = id_año;
            Obj.Codigo = codigo;
            Obj.Lugar_naci = lugar_naci;
            Obj.Domi_actual = domi_actual;
            Obj.Direccion = direccion;
            Obj.N_partida = n_partida;
            Obj.Religion = religion;
            Obj.Len_materna = len_materna;
            Obj.N_hermanos = n_hermanos;
            Obj.Lugar_ocupa = lugar_ocupa;
            Obj.Cole_procedencia = cole_procedencia;
            Obj.Discapacidad = discapacidad;
            Obj.Parto = parto;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int id_alumno, string nombres, string apellido, string dni, DateTime fecha_naci, string sexo,string edad, int id_padre, int id_madre, int id_año, string codigo, string lugar_naci, string domi_actual, string direccion, string n_partida, string religion, string len_materna, string n_hermanos, string lugar_ocupa, string cole_procedencia, string discapacidad, string parto)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.Id_alumno = id_alumno;
            Obj.Nombres = nombres;
            Obj.Apellidos = apellido;
            Obj.Dni = dni;
            Obj.Fecha_naci = fecha_naci;
            Obj.Sexo = sexo;
            Obj.Edad = edad;
            Obj.Id_padre = id_padre;
            Obj.Id_madre = id_madre;
            Obj.Id_año = id_año;
            Obj.Codigo = codigo;
            Obj.Lugar_naci = lugar_naci;
            Obj.Domi_actual = domi_actual;
            Obj.Direccion = direccion;
            Obj.N_partida = n_partida;
            Obj.Religion = religion;
            Obj.Len_materna = len_materna;
            Obj.N_hermanos = n_hermanos;
            Obj.Lugar_ocupa = lugar_ocupa;
            Obj.Cole_procedencia = cole_procedencia;
            Obj.Discapacidad = discapacidad;
            Obj.Parto = parto;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int id_alumno)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.Id_alumno = id_alumno;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DAlumnos().Mostrar();
        }

        public static DataTable buscarnombre(string textbuscar, string textbuscar1)
        {
            DAlumnos Obj = new DAlumnos();
            Obj.TextBuscar = textbuscar;
            Obj.TextBuscar1 = textbuscar1;
            return Obj.BuscarNombre(Obj);
        }
       
    }
}
