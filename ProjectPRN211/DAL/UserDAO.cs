using Microsoft.VisualBasic.Devices;
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
    internal class UserDAO
    {
        public static List<User> GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            DataTable dt = DAO.GetDataBySql(sql);
            List<User> users = new List<User>();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(new User(
                        dr["Username"].ToString(),
                        dr["FirstName"].ToString(),
                        dr["LastName"].ToString(),
                        dr["Password"].ToString(),
                        dr["Email"].ToString(),
                        Convert.ToDateTime(dr["CreatedDate"].ToString()),
                        Convert.ToInt32(dr["Role"])
                    ));
            }
            return users;
        }

        public static bool DeleteUser(string username)
        {
            string sql = "DELETE FROM Users WHERE Username = @Username";
            SqlParameter parameter = new SqlParameter("@Username", DbType.String);
            parameter.Value = username;
            return DAO.ChangeData(sql, parameter);
        }

        public static bool UpdateUser(User user)
        {
            string sql = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, " +
                         "Password = @Password, Email = @Email, CreatedDate = @CreatedDate, Role = @Role " +
                         "WHERE Username = @Username";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = user.FirstName },
            new SqlParameter("@LastName", SqlDbType.VarChar) { Value = user.LastName },
            new SqlParameter("@Password", SqlDbType.VarChar) { Value = user.Password },
            new SqlParameter("@Email", SqlDbType.VarChar) { Value = user.Email },
            new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = user.CreatedDate },
            new SqlParameter("@Role", SqlDbType.Int) { Value = user.Role },
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = user.Username }
            };
            return DAO.ChangeData(sql, parameters);
        }

        public static bool AddUser(User user)
        {
            string sql = "INSERT INTO Users (Username, FirstName, LastName, Password, Email, CreatedDate, Role) " +
                         "VALUES (@Username, @FirstName, @LastName, @Password, @Email, @CreatedDate, @Role)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Username", SqlDbType.VarChar) { Value = user.Username },
            new SqlParameter("@FirstName", SqlDbType.VarChar) { Value = user.FirstName },
            new SqlParameter("@LastName", SqlDbType.VarChar) { Value = user.LastName },
            new SqlParameter("@Password", SqlDbType.VarChar) { Value = user.Password },
            new SqlParameter("@Email", SqlDbType.VarChar) { Value = user.Email },
            new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = user.CreatedDate },
            new SqlParameter("@Role", SqlDbType.Int) { Value = user.Role }
            };

            return DAO.ChangeData(sql, parameters);
        }
    }
}
