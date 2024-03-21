using ProjectPRN211.DAL;
using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN211
{
    public partial class frmChangePassword : Form
    {
        public User OwnUser { get; set; }
        bool isValidPass { set; get; }
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string curPass = txtCurPass.Text;
            if (!curPass.Equals(OwnUser.Password))
            {
                MessageBox.Show("Password is incorrect!");
                return;
            }
            string newPass = txtNewPass.Text;
            string confirmNewPass = txtConfirmPass.Text;
            if (!newPass.Equals(confirmNewPass)) 
            {
                MessageBox.Show("Password is diffrence!");
                return;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text) || string.IsNullOrEmpty(txtConfirmPass.Text) || string.IsNullOrEmpty(txtCurPass.Text)) 
            {
                MessageBox.Show("The field is must fill out!");
                return;
            }
            if (isValidPass)
            {
                MessageBox.Show("Change Password Successfully!", "Change Password");
                OwnUser.Password = newPass;
                UserDAO.UpdateUser(OwnUser);
            }
            else
            {
                MessageBox.Show("Password is invalid!");
                return;
            }
        }

        private void txtNewPass_TextChange(object sender, EventArgs e)
        {
            string newPass = txtNewPass.Text;
            int count = 0;
            if (newPass.Length > 6)
            {
                panel1.Visible = true;
                count++;
            }
            else
            {
                panel1.Visible = false;
            }
            var hasUpperCase = new Regex(@"[A-Z]+");
            var hasLowerCase = new Regex(@"[a-z]+");
            var hasNumber = new Regex(@"[0-9]+");
            if (hasUpperCase.IsMatch(newPass))
            {
                panel2.Visible = true;
                count++;
            }
            else
            {
                panel2.Visible = false;
            }
            if (hasLowerCase.IsMatch(newPass))
            {
                panel3.Visible = true;
                count++;
            }
            else
            {
                panel3.Visible = false;
            }
            if (hasNumber.IsMatch(newPass))
            {
                panel4.Visible = true;
                count++;
            }
            else
            {
                panel4.Visible = false;
            }
            if (count == 4)
            { 
                isValidPass = true;
            }
            else { isValidPass = false; }
        }
    }
}
