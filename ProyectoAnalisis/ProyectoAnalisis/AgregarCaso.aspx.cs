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
    public partial class AgregarCaso : System.Web.UI.Page
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
                String fecha = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
                instruccion.CommandText = "insert into caso(Descripcion,Fecha_Ingreso,Usuario_Usuario,Estado_Id_Estado,Tipo_Caso_Id_Tipo)  values('" + TextBox2.Text + "','" + fecha + "','" + Label4.Text + "'," + 1 + "," + 1 + ");";
                instruccion.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Documento Registrado Correctamente!", "Registro Completado");
                TextBox2.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Un dato esta erroneo", "Inserción incorrecta");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text=="")
            {
                MessageBox.Show("Llene todos los campos para continuar!","Error de llenado");
            }
            else
            {
                conectarBase();
            }
            
        }
    }
}