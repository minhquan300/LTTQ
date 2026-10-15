using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using QuanLyNhaHang.Models;
namespace QuanLyNhaHang.Data
{
    internal class UserRepository
    {
        public User? GetByUsername(string username)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT EmployeeID, Username,
                               PasswordHash, FullName, Phone,
                               RoleID, IsActive
                               FROM Employees
                               WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User();

                            user.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                            user.Username = reader["Username"].ToString() ?? "";
                            user.PasswordHash = reader["PasswordHash"].ToString() ?? "";
                            user.FullName = reader["FullName"].ToString() ?? "";

                            user.Phone = reader["Phone"] == DBNull.Value
                                ? ""
                                : reader["Phone"].ToString() ?? "";

                            user.RoleID = Convert.ToInt32(reader["RoleID"]);
                            user.IsActive = Convert.ToBoolean(reader["IsActive"]);

                            return user;
                        }
                    }
                }
            }

            return null;
        }
    }
}