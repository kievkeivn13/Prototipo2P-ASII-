using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaContolador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        //Empleado

        public void llamarInsertEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado){

            sn.funInsertarEmpleado(id,dpi,nombre,apellido,direccion,telefono,estado);
            }

        public void llamarModifEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funModifEmpleado(id, dpi, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarElimEmpleado(string id)
        {

            sn.funElimEmpleado(id);
        }
        public DataTable llenarEmpleado(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarEmpleado(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Usuario
        public OdbcDataReader llenarcbxEmpleado()
        {
            string sql = "SELECT nombre_empleado FROM segundoparcial.empleado;";
            return sn.llenarcbxEmpleado(sql);
        }
        public string consultaIdEmpleado(string nombre)
        {
            string id = sn.consultaIdEmpleado(nombre);
            return id;
        }
        public void llamarInsertUsurio(string id, string idempleado, string nombre, string contraseña, string estado)
        {

            sn.funInsertarUsuario(id, idempleado, nombre, contraseña, estado);
        }

        public void llamarModifUsuario(string id, string idempleado, string nombre, string coanrtraseña, string estado)
        {

            sn.funModifUsuario(id, idempleado, nombre, coanrtraseña, estado);
        }

        public void llamarElimUsurio(string id)
        {

            sn.funElimEmpleado(id);
        }

        //SIU
        //LLenar data grid

        public DataTable llenarTabla(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarTabla(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Alumno

        public void llamarInsertarAlumno(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {

            sn.funInsertAlumno(carnet, nombre, direccion, telefono, correo, estado);
        }

        public void llamarModificarAlumno(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {
            

            sn.funModificarAlumno(carnet, nombre, direccion, telefono, correo, estado);
        }

        public void llamarEliminarAlumno(string carnet)
        {

            sn.funEliminarAlumno(carnet);
        }

        //Maestros

        public void llamarInsertarMaestro(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {

            sn.funInsertMaestro(carnet, nombre, direccion, telefono, correo, estado);
        }

        public void llamarModificarMaestro(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {


            sn.funModificarMaestro(carnet, nombre, direccion, telefono, correo, estado);
        }

        public void llamarEliminarMaestro(string carnet)
        {

            sn.funEliminarMestro(carnet);
        }
    }
}

