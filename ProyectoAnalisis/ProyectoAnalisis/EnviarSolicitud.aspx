<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="EnviarSolicitud.aspx.cs" Inherits="ProyectoAnalisis.EnviarSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Pagina de envio de solicitud nueva"></asp:Label>
    </p>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Tipo de Solicitud"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Descripcion"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Height="67px" TextMode="MultiLine" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Abogado"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="DPI (Cliente Actual): "></asp:Label>
    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="18pt" Text="2236666880401"></asp:Label>
    &nbsp;<br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="Ingresar" Font-Names="Comic Sans MS" Font-Size="18pt" />
    <br />
    <br />
</asp:Content>
