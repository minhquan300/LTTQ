namespace QuanLyNhaHang.Forms
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblDashboardTitle = new Label();
            lblDashboardSubtitle = new Label();
            pnlTotalTables = new Panel();
            lblTotalTables = new Label();
            lblTotalTablesTitle = new Label();
            pnlCookingOrders = new Panel();
            lblCookingOrders = new Label();
            lblCookingOrdersTitle = new Label();
            pnlTodayOrders = new Panel();
            lblTodayOrders = new Label();
            lblTodayOrdersTitle = new Label();
            pnlTotalEmployees = new Panel();
            lblTotalEmployees = new Label();
            lblTotalEmployeesTitle = new Label();
            lblRecentOrdersTitle = new Label();
            dgvRecentOrders = new DataGridView();
            pnlOrderStatus = new Panel();
            lblCancelledCount = new Label();
            lblNewCount = new Label();
            lblCancelledTitle = new Label();
            lblNewTitle = new Label();
            lblCompletedCount = new Label();
            lblCompletedTitle = new Label();
            lblTotalOrdersCount = new Label();
            lblPaidCount = new Label();
            lblProcessingCount = new Label();
            lblTotalOrdersTitle = new Label();
            lblPaidTitle = new Label();
            lblProcessingTitle = new Label();
            lblOrderStatusTitle = new Label();
            pnlTotalTables.SuspendLayout();
            pnlCookingOrders.SuspendLayout();
            pnlTodayOrders.SuspendLayout();
            pnlTotalEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
            pnlOrderStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDashboardTitle.ForeColor = Color.FromArgb(25, 55, 95);
            lblDashboardTitle.Location = new Point(30, 25);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(374, 41);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "TỔNG QUAN NHÀ HÀNG";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblDashboardSubtitle.ForeColor = Color.DimGray;
            lblDashboardSubtitle.Location = new Point(32, 68);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(427, 23);
            lblDashboardSubtitle.TabIndex = 1;
            lblDashboardSubtitle.Text = "Theo dõi hoạt động và tình hình kinh doanh nhà hàng";
            // 
            // pnlTotalTables
            // 
            pnlTotalTables.BackColor = Color.FromArgb(228, 239, 251);
            pnlTotalTables.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalTables.Controls.Add(lblTotalTables);
            pnlTotalTables.Controls.Add(lblTotalTablesTitle);
            pnlTotalTables.Location = new Point(30, 120);
            pnlTotalTables.Name = "pnlTotalTables";
            pnlTotalTables.Size = new Size(220, 130);
            pnlTotalTables.TabIndex = 2;
            // 
            // lblTotalTables
            // 
            lblTotalTables.AutoSize = true;
            lblTotalTables.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTotalTables.ForeColor = Color.FromArgb(25, 55, 95);
            lblTotalTables.Location = new Point(15, 55);
            lblTotalTables.Name = "lblTotalTables";
            lblTotalTables.Size = new Size(43, 60);
            lblTotalTables.TabIndex = 1;
            lblTotalTables.Text = "_";
            // 
            // lblTotalTablesTitle
            // 
            lblTotalTablesTitle.AutoSize = true;
            lblTotalTablesTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTotalTablesTitle.ForeColor = Color.DimGray;
            lblTotalTablesTitle.Location = new Point(15, 15);
            lblTotalTablesTitle.Name = "lblTotalTablesTitle";
            lblTotalTablesTitle.Size = new Size(127, 23);
            lblTotalTablesTitle.TabIndex = 0;
            lblTotalTablesTitle.Text = "TỔNG SỐ BÀN";
            // 
            // pnlCookingOrders
            // 
            pnlCookingOrders.BackColor = Color.FromArgb(228, 239, 251);
            pnlCookingOrders.BorderStyle = BorderStyle.FixedSingle;
            pnlCookingOrders.Controls.Add(lblCookingOrders);
            pnlCookingOrders.Controls.Add(lblCookingOrdersTitle);
            pnlCookingOrders.Location = new Point(539, 120);
            pnlCookingOrders.Name = "pnlCookingOrders";
            pnlCookingOrders.Size = new Size(220, 130);
            pnlCookingOrders.TabIndex = 3;
            // 
            // lblCookingOrders
            // 
            lblCookingOrders.AutoSize = true;
            lblCookingOrders.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCookingOrders.ForeColor = Color.FromArgb(25, 55, 95);
            lblCookingOrders.Location = new Point(15, 55);
            lblCookingOrders.Name = "lblCookingOrders";
            lblCookingOrders.Size = new Size(43, 60);
            lblCookingOrders.TabIndex = 1;
            lblCookingOrders.Text = "_";
            // 
            // lblCookingOrdersTitle
            // 
            lblCookingOrdersTitle.AutoSize = true;
            lblCookingOrdersTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCookingOrdersTitle.ForeColor = Color.DimGray;
            lblCookingOrdersTitle.Location = new Point(15, 15);
            lblCookingOrdersTitle.Name = "lblCookingOrdersTitle";
            lblCookingOrdersTitle.Size = new Size(141, 23);
            lblCookingOrdersTitle.TabIndex = 0;
            lblCookingOrdersTitle.Text = "ĐANG CHẾ BIẾN";
            // 
            // pnlTodayOrders
            // 
            pnlTodayOrders.BackColor = Color.FromArgb(228, 239, 251);
            pnlTodayOrders.BorderStyle = BorderStyle.FixedSingle;
            pnlTodayOrders.Controls.Add(lblTodayOrders);
            pnlTodayOrders.Controls.Add(lblTodayOrdersTitle);
            pnlTodayOrders.Location = new Point(283, 120);
            pnlTodayOrders.Name = "pnlTodayOrders";
            pnlTodayOrders.Size = new Size(220, 130);
            pnlTodayOrders.TabIndex = 4;
            // 
            // lblTodayOrders
            // 
            lblTodayOrders.AutoSize = true;
            lblTodayOrders.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTodayOrders.ForeColor = Color.FromArgb(25, 55, 95);
            lblTodayOrders.Location = new Point(15, 55);
            lblTodayOrders.Name = "lblTodayOrders";
            lblTodayOrders.Size = new Size(43, 60);
            lblTodayOrders.TabIndex = 1;
            lblTodayOrders.Text = "_";
            // 
            // lblTodayOrdersTitle
            // 
            lblTodayOrdersTitle.AutoSize = true;
            lblTodayOrdersTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTodayOrdersTitle.ForeColor = Color.DimGray;
            lblTodayOrdersTitle.Location = new Point(15, 15);
            lblTodayOrdersTitle.Name = "lblTodayOrdersTitle";
            lblTodayOrdersTitle.Size = new Size(190, 23);
            lblTodayOrdersTitle.TabIndex = 0;
            lblTodayOrdersTitle.Text = "ĐƠN HÀNG HÔM NAY";
            // 
            // pnlTotalEmployees
            // 
            pnlTotalEmployees.BackColor = Color.FromArgb(228, 239, 251);
            pnlTotalEmployees.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalEmployees.Controls.Add(lblTotalEmployees);
            pnlTotalEmployees.Controls.Add(lblTotalEmployeesTitle);
            pnlTotalEmployees.Location = new Point(791, 120);
            pnlTotalEmployees.Name = "pnlTotalEmployees";
            pnlTotalEmployees.Size = new Size(220, 130);
            pnlTotalEmployees.TabIndex = 4;
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.AutoSize = true;
            lblTotalEmployees.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTotalEmployees.ForeColor = Color.FromArgb(25, 55, 95);
            lblTotalEmployees.Location = new Point(15, 55);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(43, 60);
            lblTotalEmployees.TabIndex = 1;
            lblTotalEmployees.Text = "_";
            // 
            // lblTotalEmployeesTitle
            // 
            lblTotalEmployeesTitle.AutoSize = true;
            lblTotalEmployeesTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTotalEmployeesTitle.ForeColor = Color.DimGray;
            lblTotalEmployeesTitle.Location = new Point(15, 15);
            lblTotalEmployeesTitle.Name = "lblTotalEmployeesTitle";
            lblTotalEmployeesTitle.Size = new Size(104, 23);
            lblTotalEmployeesTitle.TabIndex = 0;
            lblTotalEmployeesTitle.Text = "NHÂN VIÊN";
            // 
            // lblRecentOrdersTitle
            // 
            lblRecentOrdersTitle.AutoSize = true;
            lblRecentOrdersTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblRecentOrdersTitle.ForeColor = Color.FromArgb(25, 55, 95);
            lblRecentOrdersTitle.Location = new Point(30, 300);
            lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            lblRecentOrdersTitle.Size = new Size(307, 38);
            lblRecentOrdersTitle.TabIndex = 5;
            lblRecentOrdersTitle.Text = "ĐƠN HÀNG GẦN ĐÂY";
            // 
            // dgvRecentOrders
            // 
            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AllowUserToDeleteRows = false;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.BackgroundColor = Color.FromArgb(228, 239, 251);
            dgvRecentOrders.BorderStyle = BorderStyle.None;
            dgvRecentOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(29, 61, 104);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentOrders.ColumnHeadersHeight = 42;
            dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 50, 65);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(25, 55, 95);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentOrders.EnableHeadersVisualStyles = false;
            dgvRecentOrders.GridColor = Color.FromArgb(230, 235, 240);
            dgvRecentOrders.Location = new Point(30, 350);
            dgvRecentOrders.Name = "dgvRecentOrders";
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.RowHeadersVisible = false;
            dgvRecentOrders.RowHeadersWidth = 51;
            dgvRecentOrders.RowTemplate.Height = 36;
            dgvRecentOrders.ScrollBars = ScrollBars.Vertical;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.Size = new Size(729, 418);
            dgvRecentOrders.TabIndex = 6;
            // 
            // pnlOrderStatus
            // 
            pnlOrderStatus.BackColor = Color.FromArgb(228, 239, 251);
            pnlOrderStatus.Controls.Add(lblCancelledCount);
            pnlOrderStatus.Controls.Add(lblNewCount);
            pnlOrderStatus.Controls.Add(lblCancelledTitle);
            pnlOrderStatus.Controls.Add(lblNewTitle);
            pnlOrderStatus.Controls.Add(lblCompletedCount);
            pnlOrderStatus.Controls.Add(lblCompletedTitle);
            pnlOrderStatus.Controls.Add(lblTotalOrdersCount);
            pnlOrderStatus.Controls.Add(lblPaidCount);
            pnlOrderStatus.Controls.Add(lblProcessingCount);
            pnlOrderStatus.Controls.Add(lblTotalOrdersTitle);
            pnlOrderStatus.Controls.Add(lblPaidTitle);
            pnlOrderStatus.Controls.Add(lblProcessingTitle);
            pnlOrderStatus.Controls.Add(lblOrderStatusTitle);
            pnlOrderStatus.Location = new Point(791, 350);
            pnlOrderStatus.Name = "pnlOrderStatus";
            pnlOrderStatus.Size = new Size(279, 305);
            pnlOrderStatus.TabIndex = 7;
            // 
            // lblCancelledCount
            // 
            lblCancelledCount.AutoSize = true;
            lblCancelledCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCancelledCount.ForeColor = Color.FromArgb(220, 38, 38);
            lblCancelledCount.Location = new Point(195, 140);
            lblCancelledCount.Name = "lblCancelledCount";
            lblCancelledCount.Size = new Size(18, 20);
            lblCancelledCount.TabIndex = 12;
            lblCancelledCount.Text = "0";
            // 
            // lblNewCount
            // 
            lblNewCount.AutoSize = true;
            lblNewCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblNewCount.ForeColor = Color.FromArgb(2, 132, 199);
            lblNewCount.Location = new Point(195, 220);
            lblNewCount.Name = "lblNewCount";
            lblNewCount.Size = new Size(18, 20);
            lblNewCount.TabIndex = 11;
            lblNewCount.Text = "0";
            // 
            // lblCancelledTitle
            // 
            lblCancelledTitle.AutoSize = true;
            lblCancelledTitle.Location = new Point(27, 140);
            lblCancelledTitle.Name = "lblCancelledTitle";
            lblCancelledTitle.Size = new Size(55, 20);
            lblCancelledTitle.TabIndex = 10;
            lblCancelledTitle.Text = "Đã hủy";
            // 
            // lblNewTitle
            // 
            lblNewTitle.AutoSize = true;
            lblNewTitle.Location = new Point(27, 220);
            lblNewTitle.Name = "lblNewTitle";
            lblNewTitle.Size = new Size(35, 20);
            lblNewTitle.TabIndex = 9;
            lblNewTitle.Text = "Mới";
            // 
            // lblCompletedCount
            // 
            lblCompletedCount.AutoSize = true;
            lblCompletedCount.BackColor = Color.FromArgb(228, 239, 251);
            lblCompletedCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblCompletedCount.ForeColor = Color.FromArgb(37, 99, 235);
            lblCompletedCount.Location = new Point(195, 180);
            lblCompletedCount.Name = "lblCompletedCount";
            lblCompletedCount.Size = new Size(18, 20);
            lblCompletedCount.TabIndex = 8;
            lblCompletedCount.Text = "0";
            // 
            // lblCompletedTitle
            // 
            lblCompletedTitle.AutoSize = true;
            lblCompletedTitle.Location = new Point(27, 180);
            lblCompletedTitle.Name = "lblCompletedTitle";
            lblCompletedTitle.Size = new Size(86, 20);
            lblCompletedTitle.TabIndex = 7;
            lblCompletedTitle.Text = "Hoàn thành";
            // 
            // lblTotalOrdersCount
            // 
            lblTotalOrdersCount.AutoSize = true;
            lblTotalOrdersCount.BackColor = Color.FromArgb(228, 239, 251);
            lblTotalOrdersCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTotalOrdersCount.ForeColor = Color.FromArgb(25, 55, 95);
            lblTotalOrdersCount.Location = new Point(195, 260);
            lblTotalOrdersCount.Name = "lblTotalOrdersCount";
            lblTotalOrdersCount.Size = new Size(18, 20);
            lblTotalOrdersCount.TabIndex = 6;
            lblTotalOrdersCount.Text = "0";
            // 
            // lblPaidCount
            // 
            lblPaidCount.AutoSize = true;
            lblPaidCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPaidCount.ForeColor = Color.FromArgb(22, 163, 74);
            lblPaidCount.Location = new Point(195, 100);
            lblPaidCount.Name = "lblPaidCount";
            lblPaidCount.Size = new Size(18, 20);
            lblPaidCount.TabIndex = 5;
            lblPaidCount.Text = "0";
            // 
            // lblProcessingCount
            // 
            lblProcessingCount.AutoSize = true;
            lblProcessingCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblProcessingCount.ForeColor = Color.FromArgb(217, 119, 6);
            lblProcessingCount.Location = new Point(195, 60);
            lblProcessingCount.Name = "lblProcessingCount";
            lblProcessingCount.Size = new Size(18, 20);
            lblProcessingCount.TabIndex = 4;
            lblProcessingCount.Text = "0";
            // 
            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.AutoSize = true;
            lblTotalOrdersTitle.Location = new Point(27, 260);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(110, 20);
            lblTotalOrdersTitle.TabIndex = 3;
            lblTotalOrdersTitle.Text = "Tổng đơn hàng";
            // 
            // lblPaidTitle
            // 
            lblPaidTitle.AutoSize = true;
            lblPaidTitle.Location = new Point(27, 100);
            lblPaidTitle.Name = "lblPaidTitle";
            lblPaidTitle.Size = new Size(103, 20);
            lblPaidTitle.TabIndex = 2;
            lblPaidTitle.Text = "Đã thanh toán";
            // 
            // lblProcessingTitle
            // 
            lblProcessingTitle.AutoSize = true;
            lblProcessingTitle.Location = new Point(27, 60);
            lblProcessingTitle.Name = "lblProcessingTitle";
            lblProcessingTitle.Size = new Size(80, 20);
            lblProcessingTitle.TabIndex = 1;
            lblProcessingTitle.Text = "Đang xử lý";
            // 
            // lblOrderStatusTitle
            // 
            lblOrderStatusTitle.AutoSize = true;
            lblOrderStatusTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblOrderStatusTitle.ForeColor = Color.FromArgb(25, 55, 95);
            lblOrderStatusTitle.Location = new Point(15, 15);
            lblOrderStatusTitle.Name = "lblOrderStatusTitle";
            lblOrderStatusTitle.Size = new Size(252, 28);
            lblOrderStatusTitle.TabIndex = 0;
            lblOrderStatusTitle.Text = "TRẠNG THÁI ĐƠN HÀNG";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(243, 246, 250);
            ClientSize = new Size(1387, 709);
            Controls.Add(pnlOrderStatus);
            Controls.Add(dgvRecentOrders);
            Controls.Add(lblRecentOrdersTitle);
            Controls.Add(pnlTotalEmployees);
            Controls.Add(pnlCookingOrders);
            Controls.Add(pnlTodayOrders);
            Controls.Add(pnlTotalTables);
            Controls.Add(lblDashboardSubtitle);
            Controls.Add(lblDashboardTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            pnlTotalTables.ResumeLayout(false);
            pnlTotalTables.PerformLayout();
            pnlCookingOrders.ResumeLayout(false);
            pnlCookingOrders.PerformLayout();
            pnlTodayOrders.ResumeLayout(false);
            pnlTodayOrders.PerformLayout();
            pnlTotalEmployees.ResumeLayout(false);
            pnlTotalEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
            pnlOrderStatus.ResumeLayout(false);
            pnlOrderStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboardTitle;
        private Label lblDashboardSubtitle;
        private Panel pnlTotalTables;
        private Label lblTotalTablesTitle;
        private Label lblTotalTables;
        private Panel pnlCookingOrders;
        private Label lblCookingOrders;
        private Label lblCookingOrdersTitle;
        private Panel pnlTodayOrders;
        private Label lblTodayOrders;
        private Label lblTodayOrdersTitle;
        private Panel pnlTotalEmployees;
        private Label lblTotalEmployees;
        private Label lblTotalEmployeesTitle;
        private Label lblRecentOrdersTitle;
        private DataGridView dgvRecentOrders;
        private Panel pnlOrderStatus;
        private Label lblTotalOrdersCount;
        private Label lblPaidCount;
        private Label lblProcessingCount;
        private Label lblTotalOrdersTitle;
        private Label lblPaidTitle;
        private Label lblProcessingTitle;
        private Label lblOrderStatusTitle;
        private Label lblCompletedCount;
        private Label lblCompletedTitle;
        private Label lblCancelledCount;
        private Label lblNewCount;
        private Label lblCancelledTitle;
        private Label lblNewTitle;
    }
}