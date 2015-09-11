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
    public partial class EnviarSolicitud : System.Web.UI.Page
    {

        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void conectarBase()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "insert into solicitud(Tipo,Descripcion,No_Colegiado_Abogado,DPI,Estado_Solicitudl)  values('" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "','" + Label6.Text + "','" + "pendiente" + "');";
                instruccion.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Solicitud Registrada Correctamente, espere confirmación!", "Registro Completado");
                TextBox2.Text = "";
                TextBox1.Text = "";
                TextBox3.Text = "";
                token();
                valor = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Su solicitud no pudo ser procesada, prueba mas tarde!", "Error de solicitud");

            }
        }
        int valor = 0;
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text=="" && TextBox2.Text=="" && TextBox3.Text=="")
            {
                MessageBox.Show("Llene todos los campos para proceder!", "Error de solicitud");
            }
            else
            {
                conectarBase();
            }
        }

        private void token()
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "select  * from solicitud;";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                //MessageBox.Show("Anote el codigo proporcionado, con este podrá dar seguimiento a su solicitud: "+(Reader.FieldCount+1));
                while (Reader.Read())
                {
                    valor = valor+1;
                }
                MessageBox.Show("El token para seguimiento de su solicitud es: "+valor);
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