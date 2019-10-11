using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "administrator" && passwordTextBox.Text == "password")
            {
                MainForm mainmenu = new MainForm();
                mainmenu.Show();
                this.Hide();
            }
        }
    }
}
