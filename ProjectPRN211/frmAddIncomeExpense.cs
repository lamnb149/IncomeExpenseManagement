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
    public partial class frmAddIncomeExpense : Form
    {
        public bool IsUpdate { set; get; }
        public bool IsIncome { set; get; }
        public Transaction Transaction { set; get; }
        public User UserLogin { set; get; }
        public frmAddIncomeExpense()
        {
            InitializeComponent();
        }

        private void frmAddIncomeExpense_Load(object sender, EventArgs e)
        {
            List<Category> categories = CategoryDAO.GetAllCategorys();
            List<Category> incomeCategory = categories.Where(x => x.Type == 0).ToList();
            List<Category> expenseCategory = categories.Where(x => x.Type == 1).ToList();
            if (IsIncome)
            {
                cboCategory.DataSource = incomeCategory;
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "CategoryId";
            }
            else
            {
                cboCategory.DataSource = expenseCategory;
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "CategoryId";
            }
            if (IsUpdate)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            txtAmount.Text = Transaction.Amount.ToString();
            txtDescription.Text = Transaction.Description.ToString();
            dtpCreatedTime.Value = Transaction.CreatedDate;
            List<Category> categories = CategoryDAO.GetAllCategorys();
            Category category = categories.FirstOrDefault(x => x.CategoryId == Transaction.CategoryId);
            int count = 0;
            foreach (var item in cboCategory.Items)
            {
                string categoryName = cboCategory.GetItemText(item);
                if (categoryName.Equals(category.Name))
                {
                    break;
                }
                count++;
            }
            cboCategory.SelectedIndex = count;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string amount = txtAmount.Text;
            if (IsUpdate)
            {
                try
                {
                    decimal amountConvert = Convert.ToDecimal(amount);
                    string description = txtDescription.Text;
                    var nameCategory = cboCategory.GetItemText(cboCategory.SelectedItem);
                    Category category = CategoryDAO.GetAllCategorys().FirstOrDefault(x => x.Name.Equals(nameCategory));
                    List<Transaction> transactions = TransactionDAO.GetAllTransactions();
                    Transaction transaction = transactions.FirstOrDefault(x => x.TransactionId == Transaction.TransactionId);
                    if (transaction != null) 
                    {
                        transaction.UpdatedDate = DateTime.Now;
                        transaction.Description = description;
                        transaction.Amount = amountConvert;
                        transaction.CategoryId = category.CategoryId;
                        MessageBox.Show("Update Income Successfully!", "Update");
                        TransactionDAO.UpdateTransaction(transaction);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter amount valid! {ex.Message}", "Notification");
                }
            }
            else
            {
                try
                {
                    decimal amountConvert = Convert.ToDecimal(amount);
                    string description = txtDescription.Text;
                    var nameCategory = cboCategory.GetItemText(cboCategory.SelectedItem);
                    Category category = CategoryDAO.GetAllCategorys().FirstOrDefault(x => x.Name.Equals(nameCategory));
                    List<Transaction> transactions = TransactionDAO.GetAllTransactions();
                    int id = transactions[transactions.Count() - 1].TransactionId;
                    Transaction transaction = new Transaction(
                            ++id,
                            UserLogin.Username,
                            category.CategoryId,
                            amountConvert,
                            dtpCreatedTime.Value,
                            null,
                            null,
                            description,
                            IsIncome == true ? 0 : 1
                        );
                    MessageBox.Show("Add Income Successfully!", "Add");
                    TransactionDAO.AddTransaction(transaction);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter amount valid! {ex.Message}", "Notification");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
