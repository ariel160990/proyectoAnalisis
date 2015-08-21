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
    public partial class AsignarCaso : System.Web.UI.Page
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
                MessageBox.Show("Conexion Exitosa", ":)");
            }
            catch (Exception)
            {
                MessageBox.Show("El servidor de base de datos esta caido!", "Servidor No Disponible");

            }
        }
    }
}