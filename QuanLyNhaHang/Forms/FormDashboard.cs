
using System;
using System.Windows.Forms;
using QuanLyNhaHang.Data;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace QuanLyNhaHang.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            pnlTotalTables.BorderStyle = BorderStyle.None;
            pnlTodayOrders.BorderStyle = BorderStyle.None;
            pnlCookingOrders.BorderStyle = BorderStyle.None;
            pnlTotalEmployees.BorderStyle = BorderStyle.None;

            BoGocPanel(pnlTotalTables, 10);
            BoGocPanel(pnlTodayOrders, 10);
            BoGocPanel(pnlCookingOrders, 10);
            BoGocPanel(pnlTotalEmployees, 10);

            LoadDashboardData();
            LoadRecentOrders();
            LoadOrderStatus();
        }

        private void LoadRecentOrders()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string sql = @"
                SELECT TOP 10
                    OrderCode AS [Mã đơn hàng],
                    TableID AS [Mã bàn],
                    OrderTime AS [Thời gian],
                    OrderStatus AS [Trạng thái]
                FROM dbo.Orders
                ORDER BY OrderTime DESC, OrderID DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRecentOrders.DataSource = dt;

                    dgvRecentOrders.Columns["Thời gian"].DefaultCellStyle.Format =
                        "dd/MM/yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách đơn hàng: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Lấy dữ liệu từ SQL Server và hiển thị lên Dashboard
        private void LoadDashboardData()
        {
            try
            {
                DashboardRepository repository = new DashboardRepository();

                lblTotalTables.Text = repository.GetTotalTables().ToString();

                lblTodayOrders.Text = repository.GetTodayOrders().ToString();

                lblCookingOrders.Text = repository.GetCookingOrders().ToString();

                lblTotalEmployees.Text = repository.GetTotalEmployees().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu Dashboard!\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void lblCookingTitle_Click(object sender, EventArgs e)
        {

        }

        // Thống kê trạng thái tất cả đơn hàng trong CSDL
        private void LoadOrderStatus()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    COUNT(*) AS TongDonHang,

                    COUNT(CASE
                        WHEN OrderStatus = N'Dang xu ly' THEN 1
                    END) AS DangXuLy,

                    COUNT(CASE
                        WHEN OrderStatus = N'Da thanh toan' THEN 1
                    END) AS DaThanhToan,

                    COUNT(CASE
                        WHEN OrderStatus = N'Hoan thanh' THEN 1
                    END) AS HoanThanh,

                    COUNT(CASE
                        WHEN OrderStatus = N'Moi' THEN 1
                    END) AS DonMoi,

                    COUNT(CASE
                        WHEN OrderStatus = N'Da huy' THEN 1
                    END) AS DaHuy

                FROM dbo.Orders";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblProcessingCount.Text =
                                reader["DangXuLy"].ToString();

                            lblPaidCount.Text =
                                reader["DaThanhToan"].ToString();

                            lblTotalOrdersCount.Text =
                                reader["TongDonHang"].ToString();

                            lblCompletedCount.Text =
                                reader["HoanThanh"].ToString();

                            lblNewCount.Text =
                                reader["DonMoi"].ToString();

                            lblCancelledCount.Text =
                                reader["DaHuy"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thống kê đơn hàng: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void BoGocPanel(Panel panel, int radius)
        {
            if (panel.Width <= 0 || panel.Height <= 0)
                return;

            int w = panel.Width;
            int h = panel.Height;
            int d = radius * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(w - d - 1, 0, d, d, 270, 90);
                path.AddArc(w - d - 1, h - d - 1, d, d, 0, 90);
                path.AddArc(0, h - d - 1, d, d, 90, 90);
                path.CloseFigure();

                Region? oldRegion = panel.Region;
                panel.Region = new Region(path);
                oldRegion?.Dispose();
            }

            panel.Paint -= VeVienPanel;
            panel.Paint += VeVienPanel;
        }

        private void VeVienPanel(object? sender, PaintEventArgs e)
        {
            Panel? panel = sender as Panel;

            if (panel == null)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 10;
            int d = radius * 2;
            int w = panel.Width - 1;
            int h = panel.Height - 1;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(w - d, 0, d, d, 270, 90);
                path.AddArc(w - d, h - d, d, d, 0, 90);
                path.AddArc(0, h - d, d, d, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(Color.FromArgb(220, 230, 240), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
