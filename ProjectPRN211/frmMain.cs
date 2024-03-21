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
    public partial class frmMain : Form
    {
        public string Username { get; set; }
        public int Role { set; get; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tslName.Text = Username;
            tslRole.Text = (Role == 0 ? "Admin" : "User");
            if (Role != 0)
            { 
                btnUserManagement.Visible = false;
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            frmMemberManagement.ShowDialog();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            List<User> users = UserDAO.GetAllUsers();
            User user = users.FirstOrDefault(x => x.Username == Username);
            frmDetailOwn frmDetailOwn = new frmDetailOwn() {
                UserOwn = user
            };
            frmDetailOwn.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            List<User> users = UserDAO.GetAllUsers();
            User user = users.FirstOrDefault(x => x.Username == Username);
            frmShowIncomeExpense frmShowIncomeExpense = new frmShowIncomeExpense()
            {
                UserLogin = user
            };
            frmShowIncomeExpense.ShowDialog();
        }
    }
}
