using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// ...
namespace SPOTIFY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";
            string vlUserLogin = UserLogin.Text;
            string vlPwdLogin = PwdLogin.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Consulta para verificar si el usuario y la contraseña coinciden
                string consulta = "SELECT * FROM USUARIO WHERE USERNAME = @nombreUsuario AND PWD = @contraseña";

                using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", vlUserLogin);
                    cmd.Parameters.AddWithValue("@contraseña", vlPwdLogin);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Nombre de usuario válido encontrado en la base de datos
                            string UserResponse = Convert.ToString(reader["USERNAME"]);
                            string NameResponse = Convert.ToString(reader["NAME"]);
                            string TypeUserResponse = Convert.ToString(reader["TIPO_USER"]);
                            string IdUser = Convert.ToString(reader["ID"]);
                            MessageBox.Show($"Bienvenido! {UserResponse}");

                            // Se valida si el usuario es admin o cliente
                            if (TypeUserResponse == "ADMIN") {
                                MenuAdmin MenuAdmin = new MenuAdmin(UserResponse, NameResponse, TypeUserResponse, IdUser);
                            }
                            else
                            { }

                        }
                        else
                        {
                            // Inicio de sesión fallido
                            MessageBox.Show("Usuario o contraseña invalida, vuelve a intentar");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
            this.Hide();
        }

        private void UserLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}