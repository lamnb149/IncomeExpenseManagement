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
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string password = txtPassword.Text;
            string username = txtUsername.Text;
            int role = 1;
            List<User> users = UserDAO.GetAllUsers();
            User user = users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                MessageBox.Show("Add User Successfully!", "Add", MessageBoxButtons.OK);
                User userAdd = new User(
                        username,
                        firstName,
                        lastName,
                        password,
                        email,
                        DateTime.Now,
                        role
                    );
                UserDAO.AddUser(userAdd);
            }
            else
            {
                MessageBox.Show("Username is duplicated!");
            }
        }
    }
}
