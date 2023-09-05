using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SPOTIFY
{
    public partial class GestionUsuarios : Form
    {

        string vlUser;
        string vlName;
        string vlType;
        string vlID;

        

        public GestionUsuarios(string user, string name, string type, string id)
        {
            InitializeComponent();

            this.vlUser = user;
            this.vlName = name;
            this.vlType = type;
            this.vlID = id;

            this.fnListadoAlumnos();
        }

        public void fnListadoAlumnos()
        {
            usersList.Items.Clear();
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                string consultaClientes = "SELECT USERNAME FROM USUARIO WHERE TIPO_USER = 'CLI'";
                using (MySqlCommand comando = new MySqlCommand(consultaClientes, conexion))
                {
                    conexion.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega cada valor del resultado a ComboBox
                            usersList.Items.Add(reader["USERNAME"].ToString());
                        }
                    }
                }
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vlUserReg = "";
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";
            if (usersList.Items.Count.ToString() == "0")
            {
                MessageBox.Show($"No existen usuarios creados");
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Se realiza la insercion de la nueva cuenta
                    string consulta = "DELETE FROM USUARIO WHERE USERNAME = @USER";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@USER", vlUserReg);


                        // Ejecuta la consulta de inserción
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Usuario eliminado satisfactoriamente");
                            this.fnListadoAlumnos();
                        }
                        else
                        {
                            MessageBox.Show("Algo salio mal, vuelve a intentarlo");
                        }
                    }
                }
            }
            
            
        }
    }
}
