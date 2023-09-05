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

namespace SPOTIFY
{
    public partial class GestionarArtista : Form
    {
        public GestionarArtista()
        {
            InitializeComponent();
            CargarArtistas();
        }

        public void CargarArtistas()
        {
            comboBox1.Items.Clear();
            comboBox1.SelectedValue = "";
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT NOMBRE FROM ARTISTA";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["NOMBRE"].ToString());
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";
            string vlNameA = nombreArtista.Text;
            string vlNacionA = NacionalidadA.Text;

            if (string.IsNullOrWhiteSpace(vlNameA) || string.IsNullOrWhiteSpace(vlNacionA))
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Se realiza la insercion de la nueva cuenta
                    string consulta = "INSERT INTO ARTISTA (NOMBRE, NACIONALIDAD, AÑO_INICIO, IMG) VALUES (@NAME, @NACIONALIDAD, @AÑO, @IMG)";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@NAME", vlNameA);
                        cmd.Parameters.AddWithValue("@NACIONALIDAD", vlNacionA);
                        cmd.Parameters.AddWithValue("@AÑO", " ");
                        cmd.Parameters.AddWithValue("@IMG", " ");

                        // Ejecuta la consulta de inserción
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Artista creado!!");
                            CargarArtistas();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, vuelve a intentar");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";

            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string command = "DELETE FROM ARTISTA WHERE NOMBRE = @NAME";

                using (MySqlCommand cmd = new MySqlCommand(command, connection))
                {
                    if(comboBox1.Items.Count.ToString() == "0")
                    {
                        MessageBox.Show("No existen artistas creados");
                    }
                    else
                    {
                        string vtName = comboBox1.SelectedItem.ToString();
                        cmd.Parameters.AddWithValue("@NAME", vtName);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Se ha eliminado el artista correctamente");
                            CargarArtistas();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el artista especificado");
                        }
                    }
                    
                }
            }
        }
    }
}
