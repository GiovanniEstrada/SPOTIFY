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
    public partial class MenuAdmin : Form
    {

        string vlUser;
        string vlName;
        string vlType;
        string vlID;

        public MenuAdmin(string user, string name, string type, string id)
        {
            InitializeComponent();
            this.vlUser = user;
            this.vlName = name;
            this.vlType = type;
            this.vlID = id;

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionUsuarios user = new GestionUsuarios(this.vlUser, this.vlName, this.vlType, this.vlID);
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionarArtista artista = new GestionarArtista();
            artista.Show();
        }
    }
}
