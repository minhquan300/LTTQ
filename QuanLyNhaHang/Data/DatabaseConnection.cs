
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class DatabaseConnection
    {
        private static readonly string _connectionString =
            @"Server=MSI\SQLEXPRESS;Database=QuanLyNhaHang;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public static async Task<bool> TestConnectionAsync()
        {
            try
            {
                using var conn = GetConnection();
                await conn.OpenAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
