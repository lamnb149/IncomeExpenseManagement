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
    internal class TransactionDAO
    {
        public static List<Transaction> GetAllTransactions()
        {
            string sql = "SELECT * FROM Transactions";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Transaction> transactions = new List<Transaction>();
            foreach (DataRow dr in dt.Rows)
            {
                transactions.Add(new Transaction(
                    Convert.ToInt32(dr["TransactionId"]),
                    dr["Username"].ToString(),
                    Convert.ToInt32(dr["CategoryId"]),
                    Convert.ToDecimal(dr["Amount"]),
                    Convert.ToDateTime(dr["CreatedDate"]),
                    dr["UpdatedDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["UpdatedDate"]),
                    dr["DeletedDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["DeletedDate"]),
                    dr["Description"].ToString(),
                    Convert.ToInt32(dr["Type"])
                    ));
            }
            return transactions;
        }

        public static bool AddTransaction(Transaction transaction)
        {
            string sql = "INSERT INTO Transactions (Username, CategoryId, Amount, CreatedDate, UpdatedDate, DeletedDate, Description, Type) " +
                         "VALUES (@Username, @CategoryId, @Amount, @CreatedDate, @UpdatedDate, @DeletedDate, @Description, @Type)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = transaction.Username },
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = transaction.CategoryId },
            new SqlParameter("@Amount", SqlDbType.Decimal) { Value = transaction.Amount },
            new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = transaction.CreatedDate },
            new SqlParameter("@UpdatedDate", SqlDbType.DateTime) { Value = (object)transaction.UpdatedDate ?? DBNull.Value },
            new SqlParameter("@DeletedDate", SqlDbType.DateTime) { Value = (object)transaction.DeletedDate ?? DBNull.Value },
            new SqlParameter("@Description", SqlDbType.NText) { Value = transaction.Description },
            new SqlParameter("@Type", SqlDbType.Int) { Value = transaction.Type }
            };

            return DAO.ChangeData(sql, parameters);
        }

        public static bool DeleteTransaction(int transactionId)
        {
            string sql = "DELETE FROM Transactions WHERE TransactionId = @TransactionId";
            SqlParameter parameter = new SqlParameter("@TransactionId", SqlDbType.Int) { Value = transactionId };
            return DAO.ChangeData(sql, parameter);
        }

        public static bool UpdateTransaction(Transaction transaction)
        {
            string sql = "UPDATE Transactions SET Username = @Username, CategoryId = @CategoryId, Amount = @Amount, " +
                         "CreatedDate = @CreatedDate, UpdatedDate = @UpdatedDate, DeletedDate = @DeletedDate, Description = @Description, Type = @Type " +
                         "WHERE TransactionId = @TransactionId";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = transaction.Username },
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = transaction.CategoryId },
            new SqlParameter("@Amount", SqlDbType.Decimal) { Value = transaction.Amount },
            new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = transaction.CreatedDate },
            new SqlParameter("@UpdatedDate", SqlDbType.DateTime) { Value = (object)transaction.UpdatedDate ?? DBNull.Value },
            new SqlParameter("@DeletedDate", SqlDbType.DateTime) { Value = (object)transaction.DeletedDate ?? DBNull.Value },
            new SqlParameter("@Description", SqlDbType.NText) { Value = transaction.Description },
            new SqlParameter("@Type", SqlDbType.Int) { Value = transaction.Type },
            new SqlParameter("@TransactionId", SqlDbType.Int) { Value = transaction.TransactionId }
            };

            return DAO.ChangeData(sql, parameters);
        }
    }
}
