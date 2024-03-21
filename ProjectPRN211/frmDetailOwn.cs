using ProjectPRN211.DAL;
using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN211
{
    public partial class frmDetailOwn : Form
    {
        public User UserOwn { set; get; }
        public frmDetailOwn()
        {
            InitializeComponent();
        }

        private void frmDetailOwn_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = UserOwn.FirstName;
            txtLastName.Text = UserOwn.LastName;
            txtUsername.Text = UserOwn.Username;
            txtEmail.Text = UserOwn.Email;
            txtPassword.Text = UserOwn.Password;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword() 
            {
                OwnUser = UserOwn
            };
            if (frmChangePassword.ShowDialog() == DialogResult.OK)
            {
                txtFirstName.Text = UserOwn.FirstName;
                txtLastName.Text = UserOwn.LastName;
                txtUsername.Text = UserOwn.Username;
                txtEmail.Text = UserOwn.Email;
                txtPassword.Text = UserOwn.Password;
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("The field is not empty!", "Update Profile");
                return;
            }
            User user = new User(
                    username,
                    firstName,
                    lastName,
                    password,
                    email,
                    UserOwn.CreatedDate,
                    UserOwn.Role
                );
            MessageBox.Show("Update Profile Successfully!", "Update Profile");
            UserDAO.UpdateUser(user);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
