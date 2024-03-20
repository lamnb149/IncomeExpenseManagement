using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.DAL
{
    internal class BudgetDAO
    {
        public static List<Budget> GetAllBudgets()
        {
            string sql = "SELECT * FROM Budgets";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Budget> budgets = new List<Budget>();
            foreach (DataRow dr in dt.Rows)
            {
                budgets.Add(new Budget(
                        dr["Username"].ToString(),
                        Convert.ToInt32(dr["CategoryId"]),
                        Convert.ToDecimal(dr["Amount"]),
                        Convert.ToDateTime(dr["StartDate"]),
                        Convert.ToDateTime(dr["EndDate"])
                    ));
            }
            return budgets;
        }

        public static bool AddBudget(Budget budget)
        {
            string sql = "INSERT INTO Budgets (Username, CategoryId, Amount, StartDate, EndDate) " +
                         "VALUES (@Username, @CategoryId, @Amount, @StartDate, @EndDate)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = budget.Username },
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = budget.CategoryId },
            new SqlParameter("@Amount", SqlDbType.Decimal) { Value = budget.Amount },
            new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = budget.StartDate },
            new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = budget.EndDate }
            };

            return DAO.ChangeData(sql, parameters);
        }

        public static bool DeleteBudgetWithCategory(int categoryId, string username)
        {
            string sql = "DELETE FROM Budgets WHERE CategoryId = @CategoryId AND Username = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = categoryId },
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = username }
            };
            return DAO.ChangeData(sql, parameters);
        }

        public static bool DeleteBudget(string username)
        {
            string sql = "DELETE FROM Budgets WHERE Username = @Username";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = username }
            };
            return DAO.ChangeData(sql, parameters);
        }

        public static bool UpdateBudget(Budget budget)
        {
            string sql = "UPDATE Budgets SET Amount = @Amount, StartDate = @StartDate, EndDate = @EndDate " +
                         "WHERE CategoryId = @CategoryId AND Username = @Username";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Amount", SqlDbType.Decimal) { Value = budget.Amount },
            new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = budget.StartDate },
            new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = budget.EndDate },
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = budget.CategoryId },
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = budget.Username }
            };

            return DAO.ChangeData(sql, parameters);
        }
    }
}
