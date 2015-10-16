<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ControlarCasos.aspx.cs" Inherits="ProyectoAnalisis.ControlarCasos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Bienvenido"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="juanito"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="12345678" Visible="False"></asp:Label>
        </p>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="Id_Caso">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Id_Caso" HeaderText="Id_Caso" InsertVisible="False" ReadOnly="True" SortExpression="Id_Caso" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                <asp:BoundField DataField="Fecha_Ingreso" HeaderText="Fecha_Ingreso" SortExpression="Fecha_Ingreso" />
                <asp:BoundField DataField="Usuario_Usuario" HeaderText="Usuario_Usuario" SortExpression="Usuario_Usuario" />
                <asp:BoundField DataField="Estado_Id_Estado" HeaderText="Estado_Id_Estado" SortExpression="Estado_Id_Estado" />
                <asp:BoundField DataField="Tipo_Caso_Id_Tipo" HeaderText="Tipo_Caso_Id_Tipo" SortExpression="Tipo_Caso_Id_Tipo" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:analisis1ConnectionString %>" DeleteCommand="DELETE FROM [caso] WHERE [Id_Caso] = ?" InsertCommand="INSERT INTO [caso] ([Id_Caso], [Descripcion], [Fecha_Ingreso], [Usuario_Usuario], [Estado_Id_Estado], [Tipo_Caso_Id_Tipo], [Abogado]) VALUES (?, ?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:analisis1ConnectionString.ProviderName %>" SelectCommand="SELECT Id_Caso, Descripcion, Fecha_Ingreso, Usuario_Usuario, Estado_Id_Estado, Tipo_Caso_Id_Tipo FROM caso WHERE (Abogado = @Param1)" UpdateCommand="UPDATE [caso] SET [Descripcion] = ?, [Fecha_Ingreso] = ?, [Usuario_Usuario] = ?, [Estado_Id_Estado] = ?, [Tipo_Caso_Id_Tipo] = ?, [Abogado] = ? WHERE [Id_Caso] = ?" OnSelecting="SqlDataSource1_Selecting">
            <DeleteParameters>
                <asp:Parameter Name="Id_Caso" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id_Caso" Type="Int32" />
                <asp:Parameter Name="Descripcion" Type="String" />
                <asp:Parameter Name="Fecha_Ingreso" Type="DateTime" />
                <asp:Parameter Name="Usuario_Usuario" Type="String" />
                <asp:Parameter Name="Estado_Id_Estado" Type="String" />
                <asp:Parameter Name="Tipo_Caso_Id_Tipo" Type="String" />
                <asp:Parameter Name="Abogado" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Descripcion" Type="String" />
                <asp:Parameter Name="Fecha_Ingreso" Type="DateTime" />
                <asp:Parameter Name="Usuario_Usuario" Type="String" />
                <asp:Parameter Name="Estado_Id_Estado" Type="String" />
                <asp:Parameter Name="Tipo_Caso_Id_Tipo" Type="String" />
                <asp:Parameter Name="Abogado" Type="String" />
                <asp:Parameter Name="Id_Caso" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
    </div>
    <p>
        &nbsp;</p>
    <br />
    <br />
</asp:Content>
