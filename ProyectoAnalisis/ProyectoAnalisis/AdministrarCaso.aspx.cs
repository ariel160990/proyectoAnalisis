using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            }
            else
            {
                caso();
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
    }
}