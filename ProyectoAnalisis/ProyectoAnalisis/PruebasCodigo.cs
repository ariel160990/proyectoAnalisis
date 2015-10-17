using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace ProyectoAnalisis
{
    public class PruebasCodigo
    {
        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        public Boolean banderita = false;
        //consultar caso prueba unitaria
        public void ConsultarCaso(int valor)
        {
            try
            {

                connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand instruccion = connection.CreateCommand();
                instruccion.CommandText = "select  * from solicitud where Id_solicitud ='" + valor + "';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                if (!Reader.Read())
                {
                    MessageBox.Show("No se mostrara la consulta!", "Error de solicitud");
                    banderita = false;
                }
                else
                {
                    banderita = true;
                    MessageBox.Show("Se mostrara la consulta!");
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