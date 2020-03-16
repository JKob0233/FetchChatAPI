using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPI
{
    public partial class Login : Form
    {
        public static string username = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameEntry.Text == null || usernameEntry.Text == "")
            {
                MessageBox.Show("Enter a username to login", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Enter a username to login");
            }
            else
            {
                username = usernameEntry.Text;
                MainPage main = new MainPage();
                main.Show();
            }
        }
    }
}
