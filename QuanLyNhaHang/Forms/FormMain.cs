
using System.Drawing.Drawing2D;
using QuanLyNhaHang.Models;
namespace QuanLyNhaHang
{
    public partial class FormMain : Form
    {
        private User? currentUser;

        public FormMain()
        {
            InitializeComponent();
            CapNhatDongHo();
            BoGocButton(btnTable, 10);
            BoGocButton(btnOrder, 10);
            BoGocButton(btnKitchen, 10);
            BoGocButton(btnStatistics, 10);
            BoGocButton(btnUserManagement, 10);
            BoGocButton(btnDashboard, 10);
            BoGocPanel(pnlClock, 12);
            BoGocPanel(pnlAccountInfo, 12);
            CaiDatMauMenu();
        }
        internal FormMain(User user) : this()
        {
            currentUser = user;

            lblEmployeeName.Text = "Xin chào! " + user.FullName;

            // Hiển thị thông tin tài khoản ở cuối menu
            lblAccountName.Text = user.FullName;

            switch (user.RoleID)
            {
                case 1:
                    lblAccountRole.Text = "Quản lý";
                    break;

                case 2:
                    lblAccountRole.Text = "Thu ngân";
                    break;

                case 3:
                    lblAccountRole.Text = "Nhân viên phục vụ";
                    break;

                case 4:
                    lblAccountRole.Text = "Đầu bếp";
                    break;

                default:
                    lblAccountRole.Text = "Không xác định";
                    break;
            }

            lblAccountStatus.Text = "Đang hoạt động";

            PhanQuyen(user);
            SapXepMenu();
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormDashboard());
        }

        private void BoGocButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;
            int w = btn.Width;
            int h = btn.Height;

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(w - d, 0, d, d, 270, 90);
            path.AddArc(w - d, h - d, d, d, 0, 90);
            path.AddArc(0, h - d, d, d, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
            path.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormTable());
        }
        private void OpenFormInPanel(Form form)
        {
            // Kiểm tra tài khoản đăng nhập
            if (currentUser == null)
            {
                form.Dispose();
                MessageBox.Show("Chưa có thông tin tài khoản đăng nhập!");
                return;
            }

            // Xác định chức năng tương ứng với Form
            string chucNang = "";
            if (form is QuanLyNhaHang.Forms.FormDashboard)
            {
                chucNang = "Dashboard";
            }

            if (form is QuanLyNhaHang.Forms.FormTable)
                chucNang = "Table";
            else if (form is QuanLyNhaHang.Forms.FormOrder)
                chucNang = "Order";
            else if (form is QuanLyNhaHang.Forms.FormKitchen)
                chucNang = "Kitchen";
            else if (form is QuanLyNhaHang.Forms.FormStatistics)
                chucNang = "Statistics";
            else if (form is QuanLyNhaHang.Forms.FormUserManagement)
                chucNang = "UserManagement";
            else if (form is QuanLyNhaHang.Forms.FormDashboard)
                chucNang = "Dashboard";

            // Kiểm tra quyền trước khi mở
            if (!CoQuyen(currentUser.RoleID, chucNang))
            {
                form.Dispose();
                MessageBox.Show(
                    "Bạn không có quyền sử dụng chức năng này!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Đóng Form đang hiển thị
            while (pnlContent.Controls.Count > 0)
            {
                Control oldControl = pnlContent.Controls[0];
                pnlContent.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            // Hiển thị Form mới
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(form);
            form.Show();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormOrder());
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormKitchen());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormStatistics());
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormUserManagement());
        }
        private void PhanQuyen(User user)
        {
            int roleID = user.RoleID;

            // Quản lý: sử dụng tất cả chức năng
            if (roleID == 1)
            {
                btnTable.Visible = true;
                btnOrder.Visible = true;
                btnKitchen.Visible = true;
                btnStatistics.Visible = true;
                btnUserManagement.Visible = true;
            }
            // Thu ngân
            else if (roleID == 2)
            {
                btnTable.Visible = false;
                btnOrder.Visible = true;
                btnKitchen.Visible = false;
                btnStatistics.Visible = false;
                btnUserManagement.Visible = false;
            }
            // Nhân viên phục vụ
            else if (roleID == 3)
            {
                btnTable.Visible = true;
                btnOrder.Visible = true;
                btnKitchen.Visible = false;
                btnStatistics.Visible = false;
                btnUserManagement.Visible = false;
            }
            // Đầu bếp
            else if (roleID == 4)
            {
                btnTable.Visible = false;
                btnOrder.Visible = false;
                btnKitchen.Visible = true;
                btnStatistics.Visible = false;
                btnUserManagement.Visible = false;
            }
            // Vai trò không hợp lệ
            else
            {
                btnTable.Visible = false;
                btnOrder.Visible = false;
                btnKitchen.Visible = false;
                btnStatistics.Visible = false;
                btnUserManagement.Visible = false;
            }
        }
        private bool CoQuyen(int roleID, string chucNang)
        {
            // Tất cả tài khoản hợp lệ đều được xem Dashboard
            if (chucNang == "Dashboard")
                return true;
            if (chucNang == "Dashboard")
                return roleID >= 1 && roleID <= 4;

            if (roleID == 1)
                return true;

            if (roleID == 2)
                return chucNang == "Order";

            if (roleID == 3)
                return chucNang == "Table" || chucNang == "Order";

            if (roleID == 4)
                return chucNang == "Kitchen";

            return false;
        }

        private void SapXepMenu()
        {
            if (currentUser == null)
                return;

            int viTriY = 36;
            int khoangCach = 70;

            Button[] danhSachNut =
            {
        btnDashboard,
        btnTable,
        btnOrder,
        btnKitchen,
        btnStatistics,
        btnUserManagement
    };

            PictureBox[] danhSachIcon =
            {
        picHome,
        picTable,
        picOrder,
        picKitchen,
        picStatistics,
        picEmployee
    };

            string[] danhSachChucNang =
            {
        "Dashboard",
        "Table",
        "Order",
        "Kitchen",
        "Statistics",
        "UserManagement"
    };

            for (int i = 0; i < danhSachNut.Length; i++)
            {
                Button nut = danhSachNut[i];
                PictureBox icon = danhSachIcon[i];

                if (CoQuyen(currentUser.RoleID, danhSachChucNang[i]))
                {
                    // Hiển thị nút và icon
                    nut.Visible = true;
                    icon.Visible = true;

                    // Giữ nguyên khoảng cách tương đối giữa icon và nút
                    int doLechY = icon.Top - nut.Top;

                    // Di chuyển nút đến vị trí mới
                    nut.Location = new Point(10, viTriY);

                    // Di chuyển icon theo nút
                    icon.Location = new Point(icon.Left, viTriY + doLechY);

                    // Vị trí của nút tiếp theo
                    viTriY += khoangCach;
                }
                else
                {
                    // Không có quyền thì ẩn cả nút và icon
                    nut.Visible = false;
                    icon.Visible = false;
                }
            }
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new QuanLyNhaHang.Forms.FormDashboard());
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            CapNhatDongHo();
        }

        private void CapNhatDongHo()
        {
            DateTime hienTai = DateTime.Now;

            lblClockTime.Text = hienTai.ToString("HH:mm:ss");

            lblClockDate.Text = hienTai.ToString(
                "dddd, dd/MM/yyyy",
                new System.Globalization.CultureInfo("vi-VN")
            );
        }
        private void BoGocPanel(Panel panel, int banKinh)
        {
            GraphicsPath path = new GraphicsPath();

            int d = banKinh * 2;

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(panel.Width - d, 0, d, d, 270, 90);
            path.AddArc(panel.Width - d, panel.Height - d, d, d, 0, 90);
            path.AddArc(0, panel.Height - d, d, d, 90, 90);

            path.CloseFigure();

            Region oldRegion = panel.Region;
            panel.Region = new Region(path);

            oldRegion?.Dispose();
            path.Dispose();
        }

        private void picTable_Click(object sender, EventArgs e)
        {

        }

        private void picEmployee_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void CaiDatMauMenu()
        {
            Button[] danhSachNut =
            {
        btnDashboard,
        btnTable,
        btnOrder,
        btnKitchen,
        btnStatistics,
        btnUserManagement
    };

            PictureBox[] danhSachIcon =
            {
        picHome,
        picTable,
        picOrder,
        picKitchen,
        picStatistics,
        picEmployee
    };

            for (int i = 0; i < danhSachNut.Length; i++)
            {
                Button nut = danhSachNut[i];
                PictureBox icon = danhSachIcon[i];

                // Màu nền ban đầu của icon
                icon.BackColor = nut.BackColor;

                // Khi chuột vào nút
                nut.MouseEnter += (s, e) =>
                {
                    icon.BackColor = nut.FlatAppearance.MouseOverBackColor;
                };

                // Khi chuột rời nút
                nut.MouseLeave += (s, e) =>
                {
                    icon.BackColor = nut.BackColor;
                };

                // Khi chuột vào icon
                icon.MouseEnter += (s, e) =>
                {
                    icon.BackColor = nut.FlatAppearance.MouseOverBackColor;
                };

                // Khi chuột rời icon
                icon.MouseLeave += (s, e) =>
                {
                    icon.BackColor = nut.BackColor;
                };
            }
        }

    }

}
