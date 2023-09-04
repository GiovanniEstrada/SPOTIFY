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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=prueba;Uid=root;";
            string vlNameReg = NameRegister.Text;
            string vlUserReg = UserRegister.Text;
            string vlPwdReg = PwdRegister.Text;
            string vlPwdReg2 = Pwd2Register.Text;

            if(vlPwdReg.Equals(vlPwdReg2))

            {
                MessageBox.Show("Contraseñas no coinciden, vuelva a intentar");
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para verificar si el usuario y la contraseña coinciden
                    string consulta = "INSERT INTO USUARIO (NAME, USERNAME, PWD, TIPO_USER) VALUES (@NAME, @USER, @PWD, @TIPO)";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@NAME", vlNameReg);
                        cmd.Parameters.AddWithValue("@USER", vlUserReg);
                        cmd.Parameters.AddWithValue("@PWD", vlPwdReg);
                        cmd.Parameters.AddWithValue("@TIPO", "CLI");

                        // Ejecuta la consulta de inserción
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Usuario creado, proceda a inicar sesion");
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña invalida, vuelve a intentar");
                        }
                    }
                }
            }

            

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
