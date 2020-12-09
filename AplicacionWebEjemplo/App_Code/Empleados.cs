using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
/// <summary>
/// Summary description for Empleados
/// </summary>
public class Empleados
{
	public static int Agregar (Contacto pContacto)

	{
        int retorno = 0;
        MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO contactos (nombre,direccion,telefono) VALUES ('{juan}','{jose victor jimenez}','{9321099878}')",
       pContacto.nombre, pContacto.direccion, pContacto.telefono), GestionarEmpleados.ObtenerConexion());
       retorno = comando.ExecuteNonQuery();
       return retorno;
       
        
	}
    public static int Actualizar(Contacto pContacto)
    {
        int retorno = 0; 
        MySqlConnection conexion = GestionarEmpleados.ObtenerConexion(); MySqlCommand comando = new MySqlCommand(string.Format("UPDATE contactos SET nombre='{0}',direcion='{1}', telefono='{2}'",
       pContacto.nombre, pContacto.direccion, pContacto.telefono), conexion); 
        retorno = comando.ExecuteNonQuery(); conexion.Close(); return retorno;


    }
    public static int Eliminar(int pId) 
{ 
        int retorno = 0; MySqlConnection conexion = GestionarEmpleados.ObtenerConexion(); 
        MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM contactos WHERE nombre={0}"), conexion); 
        retorno = comando.ExecuteNonQuery(); conexion.Close(); return retorno; }
}
