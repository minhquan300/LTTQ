using Microsoft.Data.SqlClient;

namespace QuanLyNhaHang.Data
{
    public class DashboardRepository
    {
        // Đếm tổng số bàn
        public int GetTotalTables()
        {
            string sql = "SELECT COUNT(*) FROM dbo.DiningTables";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar()!;
                }
            }
        }

        // Đếm đơn hàng được tạo hôm nay
        public int GetTodayOrders()
        {
            string sql = @"
                SELECT COUNT(*)
                FROM dbo.Orders
                WHERE OrderTime >= CAST(GETDATE() AS DATE)
                  AND OrderTime < DATEADD(DAY, 1, CAST(GETDATE() AS DATE))";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar()!;
                }
            }
        }

        // Đếm số món đang chế biến
        public int GetCookingOrders()
        {
            string sql = @"
                SELECT COUNT(*)
                FROM dbo.OrderDetails
                WHERE ItemStatus = N'Dang che bien'";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar()!;
                }
            }
        }

        // Đếm nhân viên đang hoạt động
        public int GetTotalEmployees()
        {
            string sql = @"
                SELECT COUNT(*)
                FROM dbo.Employees
                WHERE IsActive = 1";

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return (int)cmd.ExecuteScalar()!;
                }
            }
        }
    }
}