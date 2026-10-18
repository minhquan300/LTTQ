using Microsoft.Data.SqlClient;

namespace QuanLyNhaHang.Data
{
    public class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                @"Server=MSI\SQLEXPRESS;Database=QuanLyNhaHang;Integrated Security=True;TrustServerCertificate=True;";

            return new SqlConnection(connectionString);
        }
    }
}