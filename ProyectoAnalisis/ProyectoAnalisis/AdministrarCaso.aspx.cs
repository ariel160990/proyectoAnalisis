using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoAnalisis
{
    public partial class AdministrarCaso : System.Web.UI.Page
    {
        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Clear();
                bindtoddl();

                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
                FileUpload1.Visible = false;
                Label17.Visible = false;
                DropDownList2.Visible = false;
                Label18.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;
                ListBox1.Visible = false;

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.Equals("Seleccione..."))
            {
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Label16.Visible = false;
                Label17.Visible = false;
                FileUpload1.Visible = false;
                Label17.Visible = false;
                DropDownList2.Visible = false;
                Label18.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;
                ListBox1.Visible = false;
            }
            else
            {
                caso();
                CargarMultimedia();
            }
            
        }

        private void bindtoddl()
        {
            connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
            connection.ConnectionString = connectionString;
            connection.Open();
            MySqlCommand instruccion = connection.CreateCommand();
            instruccion.CommandText = "SELECT Id_Caso FROM caso WHERE Abogado = '" + Label3.Text + "';";
            MySqlDataReader Reader = instruccion.ExecuteReader();
            if (!Reader.HasRows)
            {
                MessageBox.Show("No existen casos para este abogado","No hay casos :(");
            }
            else
            {
                DropDownList1.Items.Add("Seleccione...");
                while(Reader.Read()){
                    DropDownList1.Items.Add(Reader["Id_Caso"].ToString());
                    DropDownList1.DataBind();
                }

            }
            connection.Close();

        }


        //metodo que traera la consulta
        private void caso()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "select  * from caso where Id_Caso ='" + DropDownList1.SelectedValue + "';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                if (!Reader.Read())
                {
                    MessageBox.Show("No existe esa solicitud, verifique su numero y pruebe nuevamente!", "Error de solicitud");
                }
                else
                {
                    Label5.Visible = true;
                    Label6.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label9.Visible = true;
                    Label10.Visible = true;
                    Label11.Visible = true;
                    Label12.Visible = true;
                    Label13.Visible = true;
                    Label14.Visible = true;
                    Label15.Visible = true;
                    Label16.Visible = true;
                    Label17.Visible = true;
                    FileUpload1.Visible = true;
                    Label17.Visible = true;
                    DropDownList2.Visible = true;
                    Label18.Visible = true;
                    Button1.Visible = true;
                    Button2.Visible = true;
                    ListBox1.Visible = true;

                    Label6.Text=Reader["Id_Caso"].ToString();
                    Label8.Text = Reader["Fecha_Ingreso"].ToString();
                    Label10.Text = Reader["Estado_Id_Estado"].ToString();
                    Label12.Text = Reader["Tipo_Caso_Id_Tipo"].ToString();
                    Label14.Text = Reader["Abogado"].ToString();
                    Label16.Text = Reader["Descripcion"].ToString();
                   
                }
                connection.Close();
                //MessageBox.Show("Solicitud Registrada Correctamente, espere confirmación!", "Registro Completado");
            }
            catch (Exception)
            {
                MessageBox.Show("Su solicitud no pudo ser procesada, prueba mas tarde!", "Error de solicitud");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //String path = @"C:/Users/Francisco/Desktop/PBD2FASE2/[Analisis1]Proyecto1-Compartido/images/zapatos/";

            String path2 = Server.MapPath("~/Multimedia/");
            //MessageBox.Show(path2);
            if (FileUpload1.HasFile)
            {
                String fileName = FileUpload1.FileName;
                //path += fileName;
                path2 += Label6.Text + fileName;
                FileUpload1.SaveAs(path2);
                ListBox1.Items.Add(fileName);
                MessageBox.Show("Se subió correctamente el archivo " + fileName + " al servidor");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                //String ruta = Server.MapPath("~/Multimedia/" + Label6.Text + ListBox1.Items[i]);
                //Process.Start(ruta);
                String ruta = Label6.Text + ListBox1.Items[i];
                GuardarImagenes(ruta);
            }
            MessageBox.Show("Se guardo la multimedia correctamente");
            ListBox1.Items.Clear();
            CargarMultimedia();
        }

        public void GuardarImagenes(String ruta) {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "insert into Multimedia(Ruta,Caso_Id_Caso) values('" + ruta+"',"+Label6.Text + ");";
                //instruccion.CommandText = "insert into caso(Descripcion,Fecha_Ingreso,Usuario_Usuario,Estado_Id_Estado,Tipo_Caso_Id_Tipo)  values('" + TextBox2.Text + "','" + fecha + "','" + Label4.Text + "'," + 1 + "," + 1 + ");";
                instruccion.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Las imagenes no se han guardado en la base de datos!", "Inserción incorrecta");

            }
        }

        public void CargarMultimedia() {
            connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
            connection.ConnectionString = connectionString;
            connection.Open();
            MySqlCommand instruccion = connection.CreateCommand();
            instruccion.CommandText = "SELECT Ruta FROM Multimedia WHERE Caso_Id_Caso = '" + Label6.Text + "';";
            MySqlDataReader Reader = instruccion.ExecuteReader();
            if (!Reader.HasRows)
            {
                MessageBox.Show("No existen documentos para este caso", "No hay documentos :(");
            }
            else
            {
                DropDownList2.Items.Add("Seleccione...");
                while (Reader.Read())
                {
                    DropDownList2.Items.Add(Reader["Ruta"].ToString());
                    DropDownList2.DataBind();
                }

            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedValue.Equals("Seleccione..."))
            {

            }else{
                String ruta = Server.MapPath("~/Multimedia/" + DropDownList2.SelectedValue);
                Process.Start(ruta);
            }

        }
    }
}