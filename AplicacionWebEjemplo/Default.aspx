<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" align="center">
        <asp:Image ID="imgImagen" runat="server" ImageUrl="~/Imagenes/contacto.png" AlternateText="Contactos" BorderStyle="Solid" ImageAlign="Middle" Width="150px" /><hr />
        <h2 style="font-weight:bold"> Lista de Empleados</h2>

        <asp:GridView style="text-align:center" class="lead" ID="GridViewTabla" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Clave Empleado" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre Empleado" />
                <asp:BoundField DataField="direccion" HeaderText="Domicilio" />
                <asp:BoundField DataField="telefono" HeaderText="Numero Telefono" />
                
            </Columns>
        </asp:GridView>
        <hr />
        <div>
            <asp:LinkButton 
                ID="btnGenerar" 
                runat="server"
                CssClass="btn btn-primary btn-lg" OnClick="btnGenerar_Click" >

                <span aria-hidden="true"
                    class="glyphycon glyphycon-list-alt">

                </span> Generar Lista
            </asp:LinkButton>
        </div>
    </div>
    
</asp:Content>
