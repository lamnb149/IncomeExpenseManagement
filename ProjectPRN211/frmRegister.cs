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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPass = txtConfirmPass.Text;
            string email = txtEmail.Text;
            Dictionary<string, string> userRegistration = new Dictionary<string, string>
            {
                {"FirstName", txtFirstName.Text},
                {"LastName", txtLastName.Text},
                {"Username", txtUsername.Text},
                {"Password", txtPassword.Text},
                {"ConfirmPass", txtConfirmPass.Text},
                {"Email", txtEmail.Text}
            };
            string jsonString = System.Text.Json.JsonSerializer.Serialize(userRegistration);

            List<User> users = UserDAO.GetAllUsers();
            User user = users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                if (!password.Equals(confirmPass))
                {
                    Dictionary<string, string> userFromJson = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                    ClearText();
                    txtFirstName.Text = userFromJson["FirstName"];
                    txtLastName.Text = userFromJson["LastName"];
                    txtUsername.Text = userFromJson["Username"];
                    txtEmail.Text = userFromJson["Email"];
                    MessageBox.Show("Password is different!", "Register", MessageBoxButtons.OK);
                }
                else
                {
                    
                    if (string.IsNullOrEmpty(txtFirstName.Text) ||
                        string.IsNullOrEmpty(txtLastName.Text) ||
                        string.IsNullOrEmpty(txtEmail.Text) ||
                        string.IsNullOrEmpty(txtPassword.Text) ||
                        string.IsNullOrEmpty(txtConfirmPass.Text))
                        {
                            MessageBox.Show("All fields must be filled out!", "Register", MessageBoxButtons.OK);
                            return;
                        }
                    User regisUser = new User(
                            username,
                            firstName,
                            lastName,
                            password,
                            email,
                            DateTime.Now,
                            1
                        );
                    MessageBox.Show("Register successfully!");
                    UserDAO.AddUser(regisUser);
                }
            }
            else
            {
                Dictionary<string, string> userFromJson = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                ClearText();
                txtFirstName.Text = userFromJson["FirstName"];
                txtLastName.Text = userFromJson["LastName"];
                txtUsername.Text = userFromJson["Username"];
                txtEmail.Text = userFromJson["Email"];
                MessageBox.Show("Username is duplicated!", "Register", MessageBoxButtons.OK);
            }
        }

        private void ClearText()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPass.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
