using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion cn = new Conexion();

        //Empleado
        public void funInsertarEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            string cadena = "INSERT INTO Empleado VALUES ('" + id + "','" + dpi + "','" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifEmpleado(string id, string dpi, string nombre, string apellido, string direccion, string telefono, string estado)
        {
            string cadena = "UPDATE Empleado SET dpi_empleado= '" + dpi + "', nombre_empleado= '" + nombre + "', apellido_empleado='" + apellido + "', direccion_empleado= '" + direccion + "', telefono_empleado= '" + telefono + "', estado_empleado= '" + estado + "' WHERE id_empleado= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimEmpleado(string id)
        {
            string cadena = "DELETE FROM Empleado WHERE id_empleado= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarEmpleado(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        //Usuarios
        public OdbcDataReader llenarcbxEmpleado(string sql)
        {
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string consultaIdEmpleado(string nombre)
        {
            string id = "";
            string Query = "select * from Empleado where nombre_empleado='" + nombre + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {
                id = busqueda["id_empleado"].ToString();
            }
            return id;
        }

        public void funInsertarUsuario(string id, string idempleado, string nombre, string caontraseña, string estado)
        {

            string cadena = "INSERT INTO usuario VALUES ('" + id + "','" + idempleado + "','" + nombre + "','" + caontraseña  + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModifUsuario(string id, string idempleado, string nombre, string contraseña, string estado)
        {
            string cadena = "UPDATE usuario SET id_empleado= '" + idempleado + "', nombre_usuario= '" + nombre + "', contraseña_usuario='" + contraseña + "', estado_usuario= '" + estado + "' WHERE id_empleado= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funElimUsuario(string id)
        {
            string cadena = "DELETE FROM usuario WHERE id_usuario= '" + id + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
        public OdbcDataAdapter llenarUsuario(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }


        //SIU

        //Llenar tabla 
        public OdbcDataAdapter llenarTabla(string tabla1)// metodo  que obtinene el contenido de una tabla
        {

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla1 + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Alumno
        public void funInsertAlumno(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {

            string cadena = "INSERT INTO alumnos VALUES ('" + carnet + "','" + nombre + "','" + direccion + "','" + telefono + "','" + correo + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModificarAlumno(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {
            string cadena = "UPDATE alumnos SET nombre_alumno= '" + nombre + "', direccion_alumno= '" + direccion + "', telefono_alumno='" + telefono + "', email_alumno= '" + correo  + "', estatus_alumno= '" + estado + "' WHERE carnet_alumno= '" + carnet + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funEliminarAlumno(string carnet)
        {
            string cadena = "DELETE FROM alumnos WHERE carnet_alumno= '" + carnet + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        //Maestro
        public void funInsertMaestro(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {

            string cadena = "INSERT INTO maestros VALUES ('" + carnet + "','" + nombre + "','" + direccion + "','" + telefono + "','" + correo + "','" + estado + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }

        public void funModificarMaestro(string carnet, string nombre, string direccion, string telefono, string correo, string estado)
        {
            string cadena = "UPDATE maestros SET nombre_maestro= '" + nombre + "', direccion_maestro= '" + direccion + "', telefono_maetro='" + telefono + "', email_maestro= '" + correo + "', estatus_maestro= '" + estado + "' WHERE codigo_maestro= '" + carnet + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        public void funEliminarMestro(string carnet)
        {
            string cadena = "DELETE FROM maestros WHERE codigo_maestro= '" + carnet + "';";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }
    }
}
