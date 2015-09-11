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
    public partial class Solicitudes : System.Web.UI.Page
    {
        MySqlConnection connection = new MySqlConnection();
        String connectionString;


        private void caso() {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "select  * from solicitud where Id_solicitud ='" + DropDownList1.SelectedItem + "';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                while (Reader.Read())
                {


                    //Console.Write(Reader["Id_solicitud"].ToString());
                    //MessageBox.Show(Reader["Id_solicitud"].ToString());
                    String aam = Reader["Id_solicitud"].ToString() + Reader["Descripcion"].ToString();
                    MessageBox.Show(aam);

                }
                connection.Close();
                MessageBox.Show("Solicitud Registrada Correctamente, espere confirmación!", "Registro Completado");
            }
            catch (Exception)
            {
                MessageBox.Show("Su solicitud no pudo ser procesada, prueba mas tarde!", "Error de solicitud");

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            conectarBase();
        }
        private void conectarBase()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "select  * from solicitud where No_Colegiado_Abogado ='"+Label3.Text+"';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                while (Reader.Read())
                {

                    
                    //Console.Write(Reader["Id_solicitud"].ToString());
                    //MessageBox.Show(Reader["Id_solicitud"].ToString());
                    //String aam = Reader["Id_solicitud"].ToString() + " " + Reader["Descripcion"].ToString();
                    this.DropDownList1.Items.Add(Reader["Id_solicitud"].ToString());

                }
                connection.Close();
                MessageBox.Show("Solicitud Registrada Correctamente, espere confirmación!", "Registro Completado");
            }
            catch (Exception)
            {
                MessageBox.Show("Su solicitud no pudo ser procesada, prueba mas tarde!", "Error de solicitud");

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            caso();
        }
    }
}