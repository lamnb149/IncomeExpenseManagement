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
    public partial class frmShowIncomeExpense : Form
    {
        public User UserLogin { set; get; }
        public frmShowIncomeExpense()
        {
            InitializeComponent();
            
        }

        private void frmShowIncomeExpense_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadComboBox();
            cboCategoryIncome.SelectedIndex = 0;
            cboCategoryExpense.SelectedIndex = 0;
            cboMonth.SelectedIndex = 0;
            txtTotalIncome.Enabled = false;
            txtTotalExpense.Enabled = false;
            txtBalance.Enabled = false;
        }

        private void CalcTotal()
        {
            List<Transaction> transactions = TransactionDAO.GetAllTransactions();
            decimal income = 0;
            decimal expense = 0;
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Type == 0)
                {
                    income += transaction.Amount;
                }
                else
                {
                    expense += transaction.Amount;
                }
            }
            txtTotalIncome.Text = income.ToString();
            txtTotalExpense.Text = expense.ToString();
            txtBalance.Text = (income - expense).ToString();
        }

        private void LoadDgv()
        {
            List<Transaction> transactions = TransactionDAO.GetAllTransactions();
            var incomes = transactions.Where(x => x.Type == 0 && x.Username.Equals(UserLogin.Username))
                .Select(x => new {
                    x.TransactionId,
                    x.Amount,
                    x.CreatedDate,
                    x.Description
                }).ToList();
            var expenses = transactions.Where(x => x.Type == 1 && x.Username.Equals(UserLogin.Username))
                .Select(x => new {
                    x.TransactionId,
                    x.Amount,
                    x.CreatedDate,
                    x.Description
                }).ToList();
            dgvIncome.DataSource = incomes;
            dgvExpense.DataSource = expenses;
            CalcTotal();
        }

        private void LoadComboBox()
        {
            List<Category> categories = CategoryDAO.GetAllCategorys();

            var allCategoryIncome = new Category(0, "All Category", "All", 0);
            var allCategoryExpense = new Category(-1, "All Category", "All", 1);

            categories.Insert(0, allCategoryIncome);
            categories.Insert(0, allCategoryExpense);

            cboCategoryIncome.DataSource = categories.Where(x => x.Type == 0).ToList();
            cboCategoryIncome.DisplayMember = "Name";
            cboCategoryExpense.ValueMember = "CategoryId";

            cboCategoryExpense.DataSource = categories.Where(x => x.Type == 1).ToList();
            cboCategoryExpense.DisplayMember = "Name";
            cboCategoryExpense.ValueMember = "CategoryId";
        }

        private void cboCategoryIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterIndexIncome = cboCategoryIncome.GetItemText(cboCategoryIncome.SelectedItem);
            var all = cboCategoryIncome.SelectedIndex;
            if (all == 0) 
            {
                LoadDgv();
            }
            else
            {
                Category category = CategoryDAO.GetAllCategorys().FirstOrDefault(x => x.Name.Equals(filterIndexIncome));

                List<Transaction> filterTransactionIncome = TransactionDAO.GetAllTransactions().
                    Where(x => x.Type == 0 && x.CategoryId == category.CategoryId && x.Username.Equals(UserLogin.Username)).ToList();
                var incomes = filterTransactionIncome.Where(x => x.Type == 0 && x.Username.Equals(UserLogin.Username))
                .Select(x => new {
                    x.TransactionId,
                    x.Amount,
                    x.CreatedDate,
                    x.Description
                }).ToList();
                dgvIncome.DataSource = incomes;
            }
        }

        private void cboCategoryExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterIndexExpenses = cboCategoryExpense.GetItemText(cboCategoryExpense.SelectedItem);
            var all = cboCategoryExpense.SelectedIndex;
            if (all == 0)
            {
                LoadDgv();
            }
            else
            {
                Category category = CategoryDAO.GetAllCategorys().FirstOrDefault(x => x.Name.Equals(filterIndexExpenses));

                List<Transaction> filterTransactionExpense = TransactionDAO.GetAllTransactions().
                    Where(x => x.Type == 1 && x.CategoryId == category.CategoryId && x.Username.Equals(UserLogin.Username)).ToList();
                var expense = filterTransactionExpense.Where(x => x.Type == 1 && x.Username.Equals(UserLogin.Username))
                .Select(x => new {
                    x.TransactionId,
                    x.Amount,
                    x.CreatedDate,
                    x.Description
                }).ToList();
                dgvExpense.DataSource = expense;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadDgv();
            cboCategoryIncome.SelectedIndex = 0;
            cboCategoryExpense.SelectedIndex = 0;
            cboMonth.SelectedIndex = 0;
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Transaction> transactions = TransactionDAO.GetAllTransactions();
            List<Transaction> filterIncome = transactions.
                Where(x => x.Type == 0 && x.Username.Equals(UserLogin.Username)).ToList();
            List<Transaction> filterExpense = transactions.
                Where(x => x.Type == 1 && x.Username.Equals(UserLogin.Username)).ToList();
            int month = cboMonth.SelectedIndex;
            if (month == 0)
            {
                LoadDgv();
            }
            else
            {
                List<Transaction> filterMonthIncome = filterIncome.Where(x => x.CreatedDate.Month == month).ToList();
                List<Transaction> filterMonthExpense = filterExpense.Where(x => x.CreatedDate.Month == month).ToList();
                var incomes = filterMonthIncome.Where(x => x.Type == 0 && x.Username.Equals(UserLogin.Username))
                .Select(x => new {
                    x.TransactionId,
                    x.Amount,
                    x.CreatedDate,
                    x.Description
                }).ToList();
                var expenses = filterMonthExpense.Where(x => x.Type == 1 && x.Username.Equals(UserLogin.Username))
                    .Select(x => new {
                        x.TransactionId,
                        x.Amount,
                        x.CreatedDate,
                        x.Description
                    }).ToList();
                dgvIncome.DataSource = incomes;
                dgvExpense.DataSource = expenses;
            }
        }

        private void dgvIncome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dgvIncome.Rows[e.RowIndex].Cells["TransactionId"].Value);
                List<Transaction> transactions = TransactionDAO.GetAllTransactions();
                Transaction transaction = transactions.FirstOrDefault(x => x.TransactionId == id);

                frmAddIncomeExpense frmAddIncomeExpense = new frmAddIncomeExpense()
                {
                    IsUpdate = true,
                    IsIncome = true,
                    UserLogin = UserLogin,
                    Transaction = transaction
                };
                if (frmAddIncomeExpense.ShowDialog() == DialogResult.OK)
                {
                    LoadDgv();
                }
            }
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            frmAddIncomeExpense frmAddIncomeExpense = new frmAddIncomeExpense()
            {
                IsUpdate = false,
                IsIncome = true,
                UserLogin = UserLogin,
                Transaction = null
            };
            if (frmAddIncomeExpense.ShowDialog() == DialogResult.OK)
            {
                LoadDgv();
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            frmAddIncomeExpense frmAddIncomeExpense = new frmAddIncomeExpense()
            {
                IsUpdate = false,
                IsIncome = false,
                UserLogin = UserLogin,
                Transaction = null
            };
            if (frmAddIncomeExpense.ShowDialog() == DialogResult.OK)
            {
                LoadDgv();
            }
        }

        private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dgvExpense.Rows[e.RowIndex].Cells["TransactionId"].Value);
                List<Transaction> transactions = TransactionDAO.GetAllTransactions();
                Transaction transaction = transactions.FirstOrDefault(x => x.TransactionId == id);

                frmAddIncomeExpense frmAddIncomeExpense = new frmAddIncomeExpense()
                {
                    IsUpdate = true,
                    IsIncome = false,
                    UserLogin = UserLogin,
                    Transaction = transaction
                };
                if (frmAddIncomeExpense.ShowDialog() == DialogResult.OK)
                {
                    LoadDgv();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvIncome.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int transactionId = Convert.ToInt32(dgvIncome.CurrentRow.Cells[0].Value);
                    MessageBox.Show($"{transactionId}");
                    TransactionDAO.DeleteTransaction(transactionId);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Transaction");
            }
            LoadDgv();
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int transactionId = Convert.ToInt32(dgvExpense.CurrentRow.Cells[0].Value);
                    MessageBox.Show($"{transactionId}");
                    TransactionDAO.DeleteTransaction(transactionId);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Transaction");
            }
            LoadDgv();
        }
    }
}
