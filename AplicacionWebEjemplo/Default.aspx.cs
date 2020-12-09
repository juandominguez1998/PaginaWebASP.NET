using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : Page
{
    GestionarEmpleados Gestion = new GestionarEmpleados();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGenerar_Click(object sender, EventArgs e)
    {
        try
        {
            GridViewTabla.DataSource = Gestion.ConsultaContactos().Tables[0];
            GridViewTabla.DataBind();
        }
        catch (Exception msj)
        {
            Page.ClientScript.RegisterStartupScript(
                Page.GetType(),
                "Advertencia",
                "<script language='javascript'> alert('" + msj + "'</script>");
        }
    }
}