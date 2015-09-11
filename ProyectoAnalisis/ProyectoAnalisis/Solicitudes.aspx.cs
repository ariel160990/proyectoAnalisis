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
                    TextBox1.Text = Reader["Id_solicitud"].ToString();
                    TextBox2.Text = Reader["Tipo"].ToString();
                    TextBox3.Text = Reader["Descripcion"].ToString();
                    //MessageBox.Show(aam);

                }
                connection.Close();
                //MessageBox.Show("Solicitud Registrada Correctamente, espere confirmación!", "Registro Completado");
            }
            catch (Exception)
            {
                MessageBox.Show("Su solicitud no pudo ser procesada, prueba mas tarde!", "Error de solicitud");

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.Items.Count>0)
            {

            }
            else
            {
                conectarBase();
            }
            
        }
        private void conectarBase()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "select  * from solicitud where No_Colegiado_Abogado ='" + Label3.Text + "' and Estado_Solicitudl="+"'pendiente';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                if (!Reader.Read())
                {
                    Label7.Text = "No hay solicitudes nuevas!";
                }
                else
                {
                    while (Reader.Read())
                    {


                        //Console.Write(Reader["Id_solicitud"].ToString());
                        //MessageBox.Show(Reader["Id_solicitud"].ToString());
                        //String aam = Reader["Id_solicitud"].ToString() + " " + Reader["Descripcion"].ToString();
                        this.DropDownList1.Items.Add(Reader["Id_solicitud"].ToString());

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
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void aceptar()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                //update 
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "update solicitud set Estado_Solicitudl='aceptada' where Id_solicitud='"+TextBox1.Text+ "';";
                instruccion.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha aceptado la solicitud correctamente!", "Solicitud Aceptada");
                TextBox2.Text = "";
                TextBox1.Text = "";
                TextBox3.Text = "";
                DropDownList1.Items.Clear();
                conectarBase();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio algún problema, intente mas tarde!", "Error de solicitud");

            }
        }
        private void rechazar()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                //update 
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "update solicitud set Estado_Solicitudl='rechazada' where Id_solicitud='" + TextBox1.Text + "';";
                instruccion.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha rechazado la solicitud correctamente!", "Solicitud Rechazada");
                TextBox2.Text = "";
                TextBox1.Text = "";
                TextBox3.Text = "";
                DropDownList1.Items.Clear();
                conectarBase();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio algún problema, intente mas tarde!", "Error de solicitud");

            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            rechazar();
        }
    }
}