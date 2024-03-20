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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectPRN211
{
    public partial class frmMemberManagement : Form
    {
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            cboRole.SelectedIndex = 2;
            LoadDgvMember(UserDAO.GetAllUsers());
        }

        private void LoadDgvMember(List<User> users)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = users;

                txtEmail.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtUsername.DataBindings.Clear();

                txtEmail.DataBindings.Add("Text", source, "Email");
                txtFirstName.DataBindings.Add("Text", source, "FirstName");
                txtLastName.DataBindings.Add("Text", source, "LastName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtUsername.DataBindings.Add("Text", source, "Username");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;

                if (users.Count == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                { 
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ClearText()
        {
            txtEmail.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keySearch = txtSearch.Text;
            List<User> searchedUsers = UserDAO.GetAllUsers().Where(x => x.Username.Contains(keySearch)).ToList();
            LoadDgvMember(searchedUsers);
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int role = cboRole.SelectedIndex;
            List<User> filterRole;
            if (role == 2)
            {
                filterRole = UserDAO.GetAllUsers();
            }
            else
            {
                filterRole = UserDAO.GetAllUsers().Where(x => x.Role == role).ToList();
            }
            LoadDgvMember(filterRole);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail();
            if (frmMemberDetail.ShowDialog() == DialogResult.OK) 
            {
                LoadDgvMember(UserDAO.GetAllUsers());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to DELETE?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string username = txtUsername.Text;
                List<Budget> budgets = BudgetDAO.GetAllBudgets();
                List<SavingGoal> savingGoals = SavingGoalDAO.GetAllSavingGoals();
                List<Transaction> transactions = TransactionDAO.GetAllTransactions();
                BudgetDAO.DeleteBudget(username);
                SavingGoalDAO.DeleteSavingGoal(username);
                List<Transaction> searchedTransaction = transactions.Where(x => x.Username == username).ToList();
                if (searchedTransaction.Count > 0)
                {
                    foreach (var trans in searchedTransaction)
                    {
                        TransactionDAO.DeleteTransaction(trans.TransactionId);
                    }
                }
                UserDAO.DeleteUser(username);
                LoadDgvMember(UserDAO.GetAllUsers());
            }
            else
            {
                LoadDgvMember(UserDAO.GetAllUsers());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string password = txtPassword.Text;
            int role = 1;
            User updatedUser = UserDAO.GetAllUsers().FirstOrDefault(x => x.Username == txtUsername.Text);
            if (updatedUser != null) 
            {
                MessageBox.Show("Update Successfully!", "Update", MessageBoxButtons.OK);
                UserDAO.UpdateUser(updatedUser);
            }
        }
    }
}
