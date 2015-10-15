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
                    Label8.Text=Reader["DPI"].ToString();
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
                instruccion.CommandText = "select  * from solicitud where No_Colegiado_Abogado =" + Label3.Text + " and Estado_Solicitudl="+"'pendiente';";
                MySqlDataReader Reader = instruccion.ExecuteReader();
                if (!Reader.HasRows)
                {
                    Label7.Text = "No hay solicitudes nuevas!";
                }
                else
                {
                    //Reader.Read();
                    while (Reader.Read())
                    {
                        DropDownList1.Items.Add(Reader["Id_solicitud"].ToString());
                        Console.Write(Reader["Id_solicitud"]);
                    }
                    /*List<int> list = new List<int>();
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        if (list.Contains(Convert.ToInt16(Reader["Id_solicitud"].ToString())))
                        {

                        }
                        else
                        {
                            Console.Write(Reader["Id_solicitud"].ToString());
                            list.Add(Convert.ToInt16(Reader["Id_solicitud"].ToString()));
                        }

                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        DropDownList1.Items.Add(list[i].ToString());
                    }*/
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
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {
                try
                {

                    connectionString = "server=127.0.0.1;uid=root;database=analisis1;port=3306;pwd=12345;";
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    //Inserción nuevo caso
                    MySqlCommand instruccionn = connection.CreateCommand();
                    String fecha = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss");
                    instruccionn.CommandText = "insert into caso(Id_Caso,Descripcion,Fecha_Ingreso,Usuario_Usuario,Estado_Id_Estado,Tipo_Caso_Id_Tipo) values(" + TextBox1.Text + ",'" + TextBox3.Text + "','" + fecha + "','" + Label8.Text + "'," + "'Iniciado','" + TextBox2.Text + "');";
                    //Se actualiza el registro de las solicitudes
                    MySqlCommand instruccion = connection.CreateCommand();
                    instruccion.CommandText = "update solicitud set Estado_Solicitudl='aceptada' where Id_solicitud='" + TextBox1.Text + "';";
                    instruccionn.ExecuteNonQuery();
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
            else
            {
                MessageBox.Show("No ha seleccionado ninguna solicitud, no se puede rechazar o aceptar nada!", "Solicitud vacía");
            }
            
        }
        private void rechazar()
        {
            if (TextBox1.Text!="" && TextBox2.Text!="" && TextBox3.Text!="")
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
            else
            {
                MessageBox.Show("No ha seleccionado ninguna solicitud, no se puede rechazar o aceptar nada!","Solicitud vacía");
            }
            
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            rechazar();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}