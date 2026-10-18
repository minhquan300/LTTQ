namespace QuanLyNhaHang
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            btnLogout = new Button();
            lblEmployeeName = new Label();
            lblSystemTitle = new Label();
            pnlMenu = new Panel();
            picHome = new PictureBox();
            picEmployee = new PictureBox();
            picStatistics = new PictureBox();
            picKitchen = new PictureBox();
            picOrder = new PictureBox();
            picTable = new PictureBox();
            pnlClock = new Panel();
            picTime = new PictureBox();
            lblClockDate = new Label();
            lblClockTime = new Label();
            lblClockTitle = new Label();
            pnlAccountInfo = new Panel();
            picAccount = new PictureBox();
            lblAccountStatus = new Label();
            lblAccountRole = new Label();
            lblAccountName = new Label();
            lblAccountTitle = new Label();
            btnDashboard = new Button();
            btnOrder = new Button();
            btnKitchen = new Button();
            btnStatistics = new Button();
            btnUserManagement = new Button();
            btnTable = new Button();
            pnlContent = new Panel();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTable).BeginInit();
            pnlClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTime).BeginInit();
            pnlAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAccount).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 59, 103);
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblEmployeeName);
            pnlHeader.Controls.Add(lblSystemTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1382, 65);
            pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logoNhaHang;
            picLogo.Location = new Point(12, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(60, 60);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(196, 61, 72);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1260, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 38);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.BackColor = Color.Transparent;
            lblEmployeeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Location = new Point(1023, 25);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(84, 23);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Xin chào!";
            // 
            // lblSystemTitle
            // 
            lblSystemTitle.AutoSize = true;
            lblSystemTitle.BackColor = Color.Transparent;
            lblSystemTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblSystemTitle.ForeColor = Color.White;
            lblSystemTitle.Location = new Point(77, 17);
            lblSystemTitle.Name = "lblSystemTitle";
            lblSystemTitle.Size = new Size(452, 38);
            lblSystemTitle.TabIndex = 0;
            lblSystemTitle.Text = "HỆ THỐNG QUẢN LÝ NHÀ HÀNG";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(35, 71, 111);
            pnlMenu.Controls.Add(picHome);
            pnlMenu.Controls.Add(picEmployee);
            pnlMenu.Controls.Add(picStatistics);
            pnlMenu.Controls.Add(picKitchen);
            pnlMenu.Controls.Add(picOrder);
            pnlMenu.Controls.Add(picTable);
            pnlMenu.Controls.Add(pnlClock);
            pnlMenu.Controls.Add(pnlAccountInfo);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(btnOrder);
            pnlMenu.Controls.Add(btnKitchen);
            pnlMenu.Controls.Add(btnStatistics);
            pnlMenu.Controls.Add(btnUserManagement);
            pnlMenu.Controls.Add(btnTable);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 65);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(280, 788);
            pnlMenu.TabIndex = 1;
            // 
            // picHome
            // 
            picHome.BackColor = Color.Transparent;
            picHome.Image = (Image)resources.GetObject("picHome.Image");
            picHome.Location = new Point(12, 386);
            picHome.Name = "picHome";
            picHome.Size = new Size(59, 49);
            picHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHome.TabIndex = 13;
            picHome.TabStop = false;
            // 
            // picEmployee
            // 
            picEmployee.BackColor = Color.Transparent;
            picEmployee.Image = (Image)resources.GetObject("picEmployee.Image");
            picEmployee.Location = new Point(12, 316);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(59, 49);
            picEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployee.TabIndex = 12;
            picEmployee.TabStop = false;
            picEmployee.Click += picEmployee_Click;
            // 
            // picStatistics
            // 
            picStatistics.BackColor = Color.Transparent;
            picStatistics.Image = (Image)resources.GetObject("picStatistics.Image");
            picStatistics.Location = new Point(10, 246);
            picStatistics.Name = "picStatistics";
            picStatistics.Size = new Size(61, 49);
            picStatistics.SizeMode = PictureBoxSizeMode.Zoom;
            picStatistics.TabIndex = 11;
            picStatistics.TabStop = false;
            // 
            // picKitchen
            // 
            picKitchen.BackColor = Color.Transparent;
            picKitchen.Image = (Image)resources.GetObject("picKitchen.Image");
            picKitchen.Location = new Point(10, 176);
            picKitchen.Name = "picKitchen";
            picKitchen.Size = new Size(61, 49);
            picKitchen.SizeMode = PictureBoxSizeMode.Zoom;
            picKitchen.TabIndex = 10;
            picKitchen.TabStop = false;
            // 
            // picOrder
            // 
            picOrder.BackColor = Color.Transparent;
            picOrder.Image = (Image)resources.GetObject("picOrder.Image");
            picOrder.Location = new Point(13, 106);
            picOrder.Name = "picOrder";
            picOrder.Size = new Size(59, 49);
            picOrder.SizeMode = PictureBoxSizeMode.Zoom;
            picOrder.TabIndex = 9;
            picOrder.TabStop = false;
            // 
            // picTable
            // 
            picTable.BackColor = Color.FromArgb(45, 90, 140);
            picTable.Image = (Image)resources.GetObject("picTable.Image");
            picTable.Location = new Point(12, 36);
            picTable.Name = "picTable";
            picTable.Size = new Size(59, 49);
            picTable.SizeMode = PictureBoxSizeMode.Zoom;
            picTable.TabIndex = 4;
            picTable.TabStop = false;
            picTable.Click += picTable_Click;
            // 
            // pnlClock
            // 
            pnlClock.BackColor = Color.FromArgb(45, 90, 140);
            pnlClock.Controls.Add(picTime);
            pnlClock.Controls.Add(lblClockDate);
            pnlClock.Controls.Add(lblClockTime);
            pnlClock.Controls.Add(lblClockTitle);
            pnlClock.Location = new Point(10, 475);
            pnlClock.Name = "pnlClock";
            pnlClock.Size = new Size(260, 115);
            pnlClock.TabIndex = 8;
            // 
            // picTime
            // 
            picTime.BackColor = Color.Transparent;
            picTime.Image = (Image)resources.GetObject("picTime.Image");
            picTime.Location = new Point(198, 11);
            picTime.Name = "picTime";
            picTime.Size = new Size(59, 49);
            picTime.SizeMode = PictureBoxSizeMode.Zoom;
            picTime.TabIndex = 14;
            picTime.TabStop = false;
            // 
            // lblClockDate
            // 
            lblClockDate.AutoSize = true;
            lblClockDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblClockDate.ForeColor = Color.White;
            lblClockDate.Location = new Point(21, 82);
            lblClockDate.Name = "lblClockDate";
            lblClockDate.Size = new Size(129, 17);
            lblClockDate.TabIndex = 2;
            lblClockDate.Text = "Ngày / Tháng / Năm";
            // 
            // lblClockTime
            // 
            lblClockTime.AutoSize = true;
            lblClockTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblClockTime.ForeColor = Color.White;
            lblClockTime.Location = new Point(21, 48);
            lblClockTime.Name = "lblClockTime";
            lblClockTime.Size = new Size(72, 23);
            lblClockTime.TabIndex = 1;
            lblClockTime.Text = "00:00:00";
            // 
            // lblClockTitle
            // 
            lblClockTitle.AutoSize = true;
            lblClockTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblClockTitle.ForeColor = Color.White;
            lblClockTitle.Location = new Point(16, 11);
            lblClockTitle.Name = "lblClockTitle";
            lblClockTitle.Size = new Size(96, 23);
            lblClockTitle.TabIndex = 0;
            lblClockTitle.Text = "THỜI GIAN";
            // 
            // pnlAccountInfo
            // 
            pnlAccountInfo.BackColor = Color.FromArgb(45, 90, 140);
            pnlAccountInfo.Controls.Add(picAccount);
            pnlAccountInfo.Controls.Add(lblAccountStatus);
            pnlAccountInfo.Controls.Add(lblAccountRole);
            pnlAccountInfo.Controls.Add(lblAccountName);
            pnlAccountInfo.Controls.Add(lblAccountTitle);
            pnlAccountInfo.Location = new Point(10, 623);
            pnlAccountInfo.Name = "pnlAccountInfo";
            pnlAccountInfo.Size = new Size(260, 130);
            pnlAccountInfo.TabIndex = 7;
            // 
            // picAccount
            // 
            picAccount.BackColor = Color.Transparent;
            picAccount.Image = (Image)resources.GetObject("picAccount.Image");
            picAccount.Location = new Point(198, 12);
            picAccount.Name = "picAccount";
            picAccount.Size = new Size(59, 49);
            picAccount.SizeMode = PictureBoxSizeMode.Zoom;
            picAccount.TabIndex = 15;
            picAccount.TabStop = false;
            // 
            // lblAccountStatus
            // 
            lblAccountStatus.AutoSize = true;
            lblAccountStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblAccountStatus.ForeColor = Color.LightGreen;
            lblAccountStatus.Location = new Point(26, 100);
            lblAccountStatus.Name = "lblAccountStatus";
            lblAccountStatus.Size = new Size(104, 17);
            lblAccountStatus.TabIndex = 3;
            lblAccountStatus.Text = "Đang hoạt động";
            // 
            // lblAccountRole
            // 
            lblAccountRole.AutoSize = true;
            lblAccountRole.ForeColor = Color.White;
            lblAccountRole.Location = new Point(26, 70);
            lblAccountRole.Name = "lblAccountRole";
            lblAccountRole.Size = new Size(59, 20);
            lblAccountRole.TabIndex = 2;
            lblAccountRole.Text = "Quản lý";
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.ForeColor = Color.White;
            lblAccountName.Location = new Point(26, 41);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(110, 20);
            lblAccountName.TabIndex = 1;
            lblAccountName.Text = "Nguyễn Văn An";
            // 
            // lblAccountTitle
            // 
            lblAccountTitle.AutoSize = true;
            lblAccountTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblAccountTitle.ForeColor = Color.White;
            lblAccountTitle.Location = new Point(26, 9);
            lblAccountTitle.Name = "lblAccountTitle";
            lblAccountTitle.Size = new Size(99, 23);
            lblAccountTitle.TabIndex = 0;
            lblAccountTitle.Text = "TÀI KHOẢN";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(45, 90, 140);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 90, 140);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 59, 103);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 386);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(260, 55);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Trang chủ";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(45, 90, 140);
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 90, 140);
            btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 59, 103);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(10, 106);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(15, 0, 0, 0);
            btnOrder.Size = new Size(260, 55);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Quản lý đơn hàng";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnKitchen
            // 
            btnKitchen.BackColor = Color.FromArgb(45, 90, 140);
            btnKitchen.Cursor = Cursors.Hand;
            btnKitchen.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnKitchen.FlatAppearance.BorderSize = 0;
            btnKitchen.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 90, 140);
            btnKitchen.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 59, 103);
            btnKitchen.FlatStyle = FlatStyle.Flat;
            btnKitchen.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnKitchen.ForeColor = Color.White;
            btnKitchen.Location = new Point(10, 176);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Padding = new Padding(15, 0, 0, 0);
            btnKitchen.Size = new Size(260, 55);
            btnKitchen.TabIndex = 4;
            btnKitchen.Text = "Nhà bếp";
            btnKitchen.UseVisualStyleBackColor = false;
            btnKitchen.Click += btnKitchen_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.FromArgb(45, 90, 140);
            btnStatistics.Cursor = Cursors.Hand;
            btnStatistics.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 90, 140);
            btnStatistics.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 59, 103);
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Location = new Point(10, 246);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Padding = new Padding(15, 0, 0, 0);
            btnStatistics.Size = new Size(260, 55);
            btnStatistics.TabIndex = 3;
            btnStatistics.Text = "Thống kê";
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(45, 90, 140);
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 90, 140);
            btnUserManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 59, 103);
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Location = new Point(10, 316);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Padding = new Padding(15, 0, 0, 0);
            btnUserManagement.Size = new Size(260, 55);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "Quản lý nhân viên";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnTable
            // 
            btnTable.BackColor = Color.FromArgb(45, 90, 140);
            btnTable.Cursor = Cursors.Hand;
            btnTable.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnTable.FlatAppearance.BorderSize = 0;
            btnTable.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 90, 140);
            btnTable.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 59, 103);
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTable.ForeColor = Color.White;
            btnTable.Location = new Point(10, 36);
            btnTable.Name = "btnTable";
            btnTable.Padding = new Padding(15, 0, 0, 0);
            btnTable.Size = new Size(260, 55);
            btnTable.TabIndex = 0;
            btnTable.Text = "Quản lý bàn";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(280, 65);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1102, 788);
            pnlContent.TabIndex = 2;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 853);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1350, 850);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà hàng";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)picKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTable).EndInit();
            pnlClock.ResumeLayout(false);
            pnlClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTime).EndInit();
            pnlAccountInfo.ResumeLayout(false);
            pnlAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlMenu;
        private Panel pnlContent;
        private Button btnKitchen;
        private Button btnOrder;
        private Button btnStatistics;
        private Button btnTable;
       
        private Button btnUserManagement;
        private Label lblEmployeeName;
        private Label lblSystemTitle;
        private Button btnLogout;
        private Button btnDashboard;
        private Panel pnlAccountInfo;
        private Label lblAccountStatus;
        private Label lblAccountRole;
        private Label lblAccountName;
        private Label lblAccountTitle;
        private Panel pnlClock;
        private Label lblClockDate;
        private Label lblClockTime;
        private Label lblClockTitle;
        private System.Windows.Forms.Timer timerClock;
        private PictureBox picLogo;
        private PictureBox picEmployee;
        private PictureBox picStatistics;
        private PictureBox picKitchen;
        private PictureBox picOrder;
        private PictureBox picTable;
        private PictureBox picHome;
        private PictureBox picTime;
        private PictureBox picAccount;
    }
}
