﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="ProyectoAnalisis.Solicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Bienvenido"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="juanito"></asp:Label>
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="12345678" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Nuevas Solicitudes"></asp:Label>
    </p>
    <asp:DropDownList ID="DropDownList1" runat="server" CausesValidation="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar"/>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="ID"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="48px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Tipo"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Descripcion"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="TextBox3" runat="server" Height="94px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Aceptar" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Rechazar" />
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
</asp:Content>
