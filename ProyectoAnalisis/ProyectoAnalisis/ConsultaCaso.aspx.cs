using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoAnalisis
{
    public partial class ConsultaCaso : System.Web.UI.Page
    {
        MySqlConnection connection = new MySqlConnection();
        String connectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
            Label6.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label7.Visible = false;
            Label8.Visible = false;
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
                instruccion.CommandText = "select  * from solicitud where Id_solicitud ='" + TextBox1.Text + "';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                if (!Reader.Read())
                {
                    MessageBox.Show("No existe esa solicitud, verifique su numero y pruebe nuevamente!", "Error de solicitud");
                }
                else {
                    Label2.Visible = true;
                    Label6.Visible = true;
                    Label4.Visible = true;
                    Label5.Visible = true;
                    Label7.Visible = true;
                    Label8.Visible = true;
                    Label6.Text = "Id: " + Reader["Id_solicitud"].ToString();
                    Label7.Text = "Tipo: " + Reader["Tipo"];
                    Label8.Text = "Descripcion: " + Reader["Descripcion"];
                    Label4.Text=Reader["Estado_Solicitudl"].ToString();
                    if (Reader["Estado_Solicitudl"].ToString().Equals("pendiente"))
                    {
                        Label4.ForeColor = System.Drawing.Color.Orange;
                    }
                    else if (Reader["Estado_Solicitudl"].ToString().Equals("rechazada"))
                    {
                        Label4.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        Label4.ForeColor = System.Drawing.Color.Green;
                    }
                }
                connection.Close();
                //MessageBox.Show("Solicitud Registrada Correctamente, espere confirmación!", "Registro Completado");
            }
            catch (Exception)
            {
                MessageBox.Show("Su solicitud no pudo ser procesada, prueba mas tarde!", "Error de solicitud");

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            caso();
            TextBox1.Text = "";
        }
    }
}