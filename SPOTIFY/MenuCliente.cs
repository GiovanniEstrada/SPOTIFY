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
    public partial class MenuCliente : Form
    {
        string vlUser;
        string vlName;
        string vlType;
        string vlID;

        public MenuCliente(string user, string name, string type, string id)
        {
            InitializeComponent();
            this.vlUser = user;
            this.vlName = name;
            this.vlType = type;
            this.vlID = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
