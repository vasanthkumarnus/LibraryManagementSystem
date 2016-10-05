using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA43Team05B.Model;
using SA43Team05B.Controller;

//Written By Nyeint Nyeint Khin

namespace SA43Team05B.View
{
    public partial class LoginForm : Form
    {
      
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Text = null;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_name = txtUserName.Text.ToString();
            string password = txtPassword.Text.ToString();

            Login login = new Login();
            bool result = login.checkLogin(user_name, password);

            if (result)
            {
                MessageBox.Show("Login Success.");
            }
            else
            {
                MessageBox.Show("Login Failed.");
            }
        }
    }
}
