using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
/// Summary description for GestionarEmpleados
/// </summary>

public class GestionarEmpleados
{
    private MySqlConnection conectar;
    private MySqlCommand comando;
    private MySqlDataAdapter mysqlda;
    private DataSet ds;
    public static MySqlConnection ObtenerConexion()
    {
        MySqlConnection conectar = new MySqlConnection("Server=localhost;DataBase=empleados;Port=3306;Uid=root;Pwd=;");
        conectar.Open();
        return conectar;
    }
    public DataSet ConsultaContactos()
    {
        ds = new DataSet();
        mysqlda = new MySqlDataAdapter("SELECT * FROM contactos", ObtenerConexion());
        mysqlda.Fill(ds);
        return ds;


    }
}
