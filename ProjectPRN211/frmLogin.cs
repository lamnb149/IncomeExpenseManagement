using Microsoft.Extensions.Configuration;
using ProjectPRN211.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPRN211.Models;

namespace ProjectPRN211
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool IsLogin(string username, string password)
        {
            List<User> users = UserDAO.GetAllUsers();
            User user = users.FirstOrDefault(x => x.Username == username && x.Password == password);
            return (user != null ? true : false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isLogin = IsLogin(username, password);
            User user = UserDAO.GetAllUsers().FirstOrDefault(x => x.Username == username);
            if (user != null)
            {
                int role = user.Role;
                if (isLogin)
                {
                    MessageBox.Show("Login Successfully!", "Login", MessageBoxButtons.OK);
                    frmMain frmMain = new frmMain()
                    {
                        Username = username,
                        Role = role
                    };
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Password or Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong Password or Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            if (frmRegister.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("HELLO");
            }
        }
    }
}
