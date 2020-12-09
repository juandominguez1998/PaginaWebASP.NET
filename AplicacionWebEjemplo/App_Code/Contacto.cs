using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Contacto
/// </summary>
public class Contacto
{
	
   public string nombre {get;set; }
    public string direccion {get;set; }
    public string telefono {get;set; }
    public string Direccion {get;set; }
    public Contacto() { }
    public Contacto (string pNombre,string pDireccion,string pTelefono)
    {this.nombre = pNombre;this.direccion = pDireccion;this.telefono = pTelefono;}
}

