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
    internal class SavingGoalDAO
    {
        public static List<SavingGoal> GetAllSavingGoals()
        {
            string sql = "SELECT * FROM SavingGoals";
            DataTable dt = DAO.GetDataBySql(sql);
            List<SavingGoal> savingGoals = new List<SavingGoal>();
            foreach (DataRow dr in dt.Rows)
            {
                savingGoals.Add(new SavingGoal(
                        Convert.ToInt32(dr["GoalId"]),
                        dr["Username"].ToString(),
                        dr["Name"].ToString(),
                        Convert.ToDecimal(dr["TargetAmount"]),
                        Convert.ToDecimal(dr["CurrentAmount"]),
                        Convert.ToDateTime(dr["StartDate"]),
                        Convert.ToDateTime(dr["EndDate"])
                    ));
            }
            return savingGoals;
        }

        public static bool AddSavingGoal(SavingGoal savingGoal)
        {
            string sql = "INSERT INTO SavingGoals (Username, Name, TargetAmount, CurrentAmount, StartDate, EndDate) " +
                         "VALUES (@Username, @Name, @TargetAmount, @CurrentAmount, @StartDate, @EndDate)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = savingGoal.Username },
            new SqlParameter("@Name", SqlDbType.NVarChar) { Value = savingGoal.Name },
            new SqlParameter("@TargetAmount", SqlDbType.Decimal) { Value = savingGoal.TargetAmount },
            new SqlParameter("@CurrentAmount", SqlDbType.Decimal) { Value = savingGoal.CurrentAmount },
            new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = savingGoal.StartDate },
            new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = savingGoal.EndDate }
            };

            return DAO.ChangeData(sql, parameters);
        }

        public static bool DeleteSavingGoal(int goalId)
        {
            string sql = "DELETE FROM SavingGoals WHERE GoalId = @GoalId";
            SqlParameter parameter = new SqlParameter("@GoalId", SqlDbType.Int);
            parameter.Value = goalId;
            return DAO.ChangeData(sql, parameter);
        }

        public static bool UpdateSavingGoal(SavingGoal savingGoal)
        {
            string sql = "UPDATE SavingGoals SET Username = @Username, Name = @Name, TargetAmount = @TargetAmount, " +
                         "CurrentAmount = @CurrentAmount, StartDate = @StartDate, EndDate = @EndDate " +
                         "WHERE GoalId = @GoalId";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = savingGoal.Username },
            new SqlParameter("@Name", SqlDbType.NVarChar) { Value = savingGoal.Name },
            new SqlParameter("@TargetAmount", SqlDbType.Decimal) { Value = savingGoal.TargetAmount },
            new SqlParameter("@CurrentAmount", SqlDbType.Decimal) { Value = savingGoal.CurrentAmount },
            new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = savingGoal.StartDate },
            new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = savingGoal.EndDate },
            new SqlParameter("@GoalId", SqlDbType.Int) { Value = savingGoal.GoalId }
            };

            return DAO.ChangeData(sql, parameters);
        }
    }
}
