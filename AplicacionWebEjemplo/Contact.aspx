<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="jumbotron" align="center">
          <h3>MODULO DE EMPLEADOS</h3>
             <br />
             <table class=" table-bordered table-dark "style="background-color: #808080;" >
                 <tr>
                     <td>
                          nombre <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombre" ErrorMessage="INGRESAR UN NOMBRE"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td>
                         direccion <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdireccion" ErrorMessage="DEBE DE INGRESAR UNA DIRECCION"></asp:RequiredFieldValidator>
                   
                     </td>
                 </tr>
                 <tr>
                     <td>
                         telefono <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txttelefono" ErrorMessage="DEBE DE INGRESAR UN NUMERO DE TELEFONO"></asp:RequiredFieldValidator>
                   
                     </td>
                 </tr>
                 <tr>
                     <td>
                          <asp:Button ID="btnnuevo" runat="server" Text="NUEVO" class="btn btn-outline-warning" OnClick="btnnuevo_Click" />
                          <asp:Button ID="btnguardar" runat="server" Text="GUARDAR" class="btn btn-outline-warning" OnClick="btnguardar_Click" />
                          <asp:Button ID="btnactualizar" runat="server" Text="ACTUALIZAR" class="btn btn-outline-warning" OnClick="btnactualizar_Click" />
                         <asp:Button ID="btneliminar" runat="server" Text="ELIMINAR" class="btn btn-outline-warning" OnClick="btneliminar_Click" />
                     </td>
                 </tr>
             </table>
        </div>
</asp:Content>
