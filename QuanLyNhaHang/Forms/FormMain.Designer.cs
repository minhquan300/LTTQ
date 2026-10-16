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
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblEmployeeName = new Label();
            lblSystemTitle = new Label();
            pnlMenu = new Panel();
            btnOrder = new Button();
            btnKitchen = new Button();
            btnStatistics = new Button();
            btnUserManagement = new Button();
            btnTable = new Button();
            pnlContent = new Panel();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 59, 103);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblEmployeeName);
            pnlHeader.Controls.Add(lblSystemTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 65);
            pnlHeader.TabIndex = 0;
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
            btnLogout.Location = new Point(860, 17);
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
            lblEmployeeName.Location = new Point(623, 25);
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
            lblSystemTitle.Location = new Point(20, 17);
            lblSystemTitle.Name = "lblSystemTitle";
            lblSystemTitle.Size = new Size(452, 38);
            lblSystemTitle.TabIndex = 0;
            lblSystemTitle.Text = "HỆ THỐNG QUẢN LÝ NHÀ HÀNG";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(35, 71, 111);
            pnlMenu.Controls.Add(btnOrder);
            pnlMenu.Controls.Add(btnKitchen);
            pnlMenu.Controls.Add(btnStatistics);
            pnlMenu.Controls.Add(btnUserManagement);
            pnlMenu.Controls.Add(btnTable);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 65);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 538);
            pnlMenu.TabIndex = 1;
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
            btnOrder.Location = new Point(10, 80);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(15, 0, 0, 0);
            btnOrder.Size = new Size(200, 45);
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
            btnKitchen.Location = new Point(10, 135);
            btnKitchen.Name = "btnKitchen";
            btnKitchen.Padding = new Padding(15, 0, 0, 0);
            btnKitchen.Size = new Size(200, 45);
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
            btnStatistics.Location = new Point(10, 190);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Padding = new Padding(15, 0, 0, 0);
            btnStatistics.Size = new Size(200, 45);
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
            btnUserManagement.Location = new Point(10, 245);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Padding = new Padding(15, 0, 0, 0);
            btnUserManagement.Size = new Size(200, 45);
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
            btnTable.Location = new Point(10, 25);
            btnTable.Name = "btnTable";
            btnTable.Padding = new Padding(15, 0, 0, 0);
            btnTable.Size = new Size(200, 45);
            btnTable.TabIndex = 0;
            btnTable.Text = "Quản lý bàn";
            btnTable.UseVisualStyleBackColor = false;
            btnTable.Click += btnTable_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 65);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(762, 538);
            pnlContent.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 603);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1000, 650);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà hàng";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
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
    }
}
