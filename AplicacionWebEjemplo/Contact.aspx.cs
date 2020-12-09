using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : Page
{
    GestionarEmpleados Gestion = new GestionarEmpleados();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnnuevo_Click(object sender, EventArgs e)
    {
        txtnombre.Text = "";
        txtdireccion.Text = "";
        txttelefono.Text = "";
    }
    protected void btnguardar_Click(object sender, EventArgs e)
    {
        Contacto pContacto = new Contacto(); pContacto.nombre = txtnombre.Text.Trim(); pContacto.direccion = txtdireccion.Text.Trim(); pContacto.telefono = txttelefono.Text.Trim(); int resultado = Empleados.Agregar(pContacto);
    }


    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        Contacto pContacto = new Contacto();
        pContacto.nombre = txtnombre.Text.Trim();
        pContacto.direccion = txtdireccion.Text.Trim();
        pContacto.telefono = txttelefono.Text.Trim();
    }
    protected void btneliminar_Click(object sender, EventArgs e)
    {
        Contacto pContacto = new Contacto();
        pContacto.nombre = txtnombre.Text.Trim();
    }
}
