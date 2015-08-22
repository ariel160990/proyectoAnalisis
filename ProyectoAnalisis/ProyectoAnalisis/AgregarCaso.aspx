<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AgregarCaso.aspx.cs" Inherits="ProyectoAnalisis.AgregarCaso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Pagina de Ingreso de un nuevo caso"></asp:Label>
    </p>
&nbsp;<div style="text-align: center; height: 299px;">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Descripcion"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Height="67px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Usuario (el de la sesion):"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Enabled="False" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="powerpancho"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Enabled="False" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Estado: Iniciado (por defecto)"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Ingresar" Font-Names="Comic Sans MS" Font-Size="18pt" />
        <br />
        <br />
        <br />
    <br />
    <br />
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
