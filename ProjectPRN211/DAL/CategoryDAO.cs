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
    internal class CategoryDAO
    {
        public static List<Category> GetAllCategorys()
        {
            string sql = "SELECT * FROM Categories";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Category> categories = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                categories.Add(new Category(
                        Convert.ToInt32(dr["CategoryId"]),
                        dr["Name"].ToString(),
                        dr["Description"].ToString(),
                        Convert.ToInt32(dr["Type"])
                    ));
            }
            return categories;
        }

        public static bool AddCategory(Category category)
        {
            string sql = "INSERT INTO Categories (Name, Description, Type) " +
                         "VALUES (@Name, @Description, @Type)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Name", SqlDbType.NVarChar) { Value = category.Name },
            new SqlParameter("@Description", SqlDbType.NText) { Value = category.Description ?? (object)DBNull.Value },
            new SqlParameter("@Type", SqlDbType.Int) { Value = category.Type }
            };

            return DAO.ChangeData(sql, parameters);
        }

        public static bool DeleteCategory(int categoryId)
        {
            string sql = "DELETE FROM Categories WHERE CategoryId = @CategoryId";
            SqlParameter parameter = new SqlParameter("@CategoryId", SqlDbType.Int) { Value = categoryId };
            return DAO.ChangeData(sql, parameter);
        }

        public static bool UpdateCategory(Category category)
        {
            string sql = "UPDATE Categories SET Name = @Name, Description = @Description, Type = @Type " +
                         "WHERE CategoryId = @CategoryId";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Name", SqlDbType.NVarChar) { Value = category.Name },
            new SqlParameter("@Description", SqlDbType.NText) { Value = category.Description ?? (object)DBNull.Value }, // Assuming Description can be null
            new SqlParameter("@Type", SqlDbType.Int) { Value = category.Type },
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = category.CategoryId }
            };

            return DAO.ChangeData(sql, parameters);
        }
    }
}
