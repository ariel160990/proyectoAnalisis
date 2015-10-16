<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AdministrarCaso.aspx.cs" Inherits="ProyectoAnalisis.AdministrarCaso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Bienvenido"></asp:Label>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="juanito"></asp:Label>
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="12345678" Visible="False"></asp:Label>
    </p>
    <asp:Label ID="Label4" runat="server" Text="Seleccione el caso: "></asp:Label>
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ToolTip="Seleccione el caso que desee">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Numero de Caso"></asp:Label>
&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Fecha que ingreso"></asp:Label>
&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Tipo de caso"></asp:Label>
&nbsp;&nbsp;
    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label13" runat="server" Text="No Colegiado Abogado"></asp:Label>
&nbsp;&nbsp;
    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label15" runat="server" Text="Descripcion"></asp:Label>
    <br />
    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label17" runat="server" Text="Multimedia"></asp:Label>
    <br />
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
</asp:Content>
