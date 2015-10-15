<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ConsultaCaso.aspx.cs" Inherits="ProyectoAnalisis.ConsultaCaso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:Label ID="Label1" runat="server" Text="Ingresa tu numero de solicutud para ver el estado"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Buscar" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Resultados de la busqueda"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label" text-align="left"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Label" text-align="left"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Label" text-align="left"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Estado de la solicitud:"></asp:Label>
&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Rechazada"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Nota Importante:                        "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label10" runat="server" Text="Estado solicitud aceptada: el abogado ha creado el caso y aceptado tu solicitud"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label11" runat="server" Text="Estado solicitud rechazada: el abogado no quiere trabajar en tu caso."></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label12" runat="server" Text="Estado solicitud pendiente: el abogado no ha respondido tu solicitud o no la ha visto aún."></asp:Label>
&nbsp;&nbsp;
    <br />
</asp:Content>
