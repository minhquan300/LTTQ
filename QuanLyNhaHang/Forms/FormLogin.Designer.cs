namespace QuanLyNhaHang.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnlLeft = new Panel();
            picFeatureEmployee = new PictureBox();
            picFeatureKitchen = new PictureBox();
            picFeatureTable = new PictureBox();
            lblFeatureEmployee = new Label();
            lblFeatureKitchen = new Label();
            lblFeatureTable = new Label();
            pnlDivider = new Panel();
            lblSubtitle = new Label();
            picRestaurantLogo = new PictureBox();
            lblRestaurant = new Label();
            pnlLogin = new Panel();
            lblMessage = new Label();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblTitle = new Label();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFeatureEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFeatureKitchen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFeatureTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurantLogo).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(25, 59, 103);
            pnlLeft.Controls.Add(picFeatureEmployee);
            pnlLeft.Controls.Add(picFeatureKitchen);
            pnlLeft.Controls.Add(picFeatureTable);
            pnlLeft.Controls.Add(lblFeatureEmployee);
            pnlLeft.Controls.Add(lblFeatureKitchen);
            pnlLeft.Controls.Add(lblFeatureTable);
            pnlLeft.Controls.Add(pnlDivider);
            pnlLeft.Controls.Add(lblSubtitle);
            pnlLeft.Controls.Add(picRestaurantLogo);
            pnlLeft.Controls.Add(lblRestaurant);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(320, 460);
            pnlLeft.TabIndex = 0;
            // 
            // picFeatureEmployee
            // 
            picFeatureEmployee.BackColor = Color.Transparent;
            picFeatureEmployee.Image = (Image)resources.GetObject("picFeatureEmployee.Image");
            picFeatureEmployee.Location = new Point(35, 350);
            picFeatureEmployee.Name = "picFeatureEmployee";
            picFeatureEmployee.Size = new Size(26, 26);
            picFeatureEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            picFeatureEmployee.TabIndex = 9;
            picFeatureEmployee.TabStop = false;
            // 
            // picFeatureKitchen
            // 
            picFeatureKitchen.BackColor = Color.Transparent;
            picFeatureKitchen.Image = Properties.Resources.qlnhabep;
            picFeatureKitchen.Location = new Point(35, 310);
            picFeatureKitchen.Name = "picFeatureKitchen";
            picFeatureKitchen.Size = new Size(24, 24);
            picFeatureKitchen.SizeMode = PictureBoxSizeMode.Zoom;
            picFeatureKitchen.TabIndex = 8;
            picFeatureKitchen.TabStop = false;
            // 
            // picFeatureTable
            // 
            picFeatureTable.BackColor = Color.Transparent;
            picFeatureTable.Image = (Image)resources.GetObject("picFeatureTable.Image");
            picFeatureTable.Location = new Point(35, 270);
            picFeatureTable.Name = "picFeatureTable";
            picFeatureTable.Size = new Size(24, 24);
            picFeatureTable.SizeMode = PictureBoxSizeMode.Zoom;
            picFeatureTable.TabIndex = 7;
            picFeatureTable.TabStop = false;
            // 
            // lblFeatureEmployee
            // 
            lblFeatureEmployee.BackColor = Color.Transparent;
            lblFeatureEmployee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblFeatureEmployee.ForeColor = Color.White;
            lblFeatureEmployee.Location = new Point(75, 350);
            lblFeatureEmployee.Name = "lblFeatureEmployee";
            lblFeatureEmployee.Size = new Size(220, 30);
            lblFeatureEmployee.TabIndex = 6;
            lblFeatureEmployee.Text = "Quản lý nhân viên";
            lblFeatureEmployee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFeatureKitchen
            // 
            lblFeatureKitchen.BackColor = Color.Transparent;
            lblFeatureKitchen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblFeatureKitchen.ForeColor = Color.White;
            lblFeatureKitchen.Location = new Point(75, 310);
            lblFeatureKitchen.Name = "lblFeatureKitchen";
            lblFeatureKitchen.Size = new Size(270, 30);
            lblFeatureKitchen.TabIndex = 5;
            lblFeatureKitchen.Text = "Quản lý hoạt động nhà bếp";
            lblFeatureKitchen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFeatureTable
            // 
            lblFeatureTable.BackColor = Color.Transparent;
            lblFeatureTable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblFeatureTable.ForeColor = Color.White;
            lblFeatureTable.Location = new Point(75, 270);
            lblFeatureTable.Name = "lblFeatureTable";
            lblFeatureTable.Size = new Size(270, 30);
            lblFeatureTable.TabIndex = 4;
            lblFeatureTable.Text = "Quản lý bàn và đơn hàng";
            lblFeatureTable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.SteelBlue;
            pnlDivider.Location = new Point(65, 250);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(190, 2);
            pnlDivider.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(10, 200);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(300, 30);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "HỆ THỐNG QUẢN LÝ NỘI BỘ";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picRestaurantLogo
            // 
            picRestaurantLogo.BackColor = Color.Transparent;
            picRestaurantLogo.Image = (Image)resources.GetObject("picRestaurantLogo.Image");
            picRestaurantLogo.Location = new Point(120, 50);
            picRestaurantLogo.Name = "picRestaurantLogo";
            picRestaurantLogo.Size = new Size(80, 80);
            picRestaurantLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picRestaurantLogo.TabIndex = 1;
            picRestaurantLogo.TabStop = false;
            // 
            // lblRestaurant
            // 
            lblRestaurant.BackColor = Color.Transparent;
            lblRestaurant.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblRestaurant.ForeColor = SystemColors.ButtonHighlight;
            lblRestaurant.Location = new Point(10, 135);
            lblRestaurant.Name = "lblRestaurant";
            lblRestaurant.Size = new Size(300, 70);
            lblRestaurant.TabIndex = 0;
            lblRestaurant.Text = "QUẢN LÝ NHÀ HÀNG";
            lblRestaurant.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblMessage);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(chkShowPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Location = new Point(320, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(480, 460);
            pnlLogin.TabIndex = 1;
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.FromArgb(220, 38, 38);
            lblMessage.Location = new Point(59, 305);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(360, 24);
            lblMessage.TabIndex = 7;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            lblMessage.Click += lblMessage_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(25, 59, 103);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(91, 333);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(306, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.ForeColor = Color.FromArgb(75, 85, 99);
            chkShowPassword.Location = new Point(91, 278);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(127, 24);
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(91, 230);
            txtPassword.MaxLength = 100;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(306, 31);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(91, 141);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(306, 31);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.ForeColor = Color.FromArgb(55, 65, 81);
            lblPassword.Location = new Point(91, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblUsername.ForeColor = Color.FromArgb(55, 65, 81);
            lblUsername.Location = new Point(91, 107);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(128, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.FromArgb(25, 59, 103);
            lblTitle.Location = new Point(139, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng nhập hệ thống";
            lblTitle.Click += lblTitle_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 413);
            Controls.Add(pnlLogin);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Quản lý nhà hàng";
            Load += FormLogin_Load;
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFeatureEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFeatureKitchen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFeatureTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRestaurantLogo).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlLogin;

        private Label lblRestaurant;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;

        private TextBox txtUsername;
        private TextBox txtPassword;

        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Label lblMessage;
        private PictureBox picRestaurantLogo;
        private Label lblSubtitle;
        private Label lblFeatureEmployee;
        private Label lblFeatureKitchen;
        private Label lblFeatureTable;
        private Panel pnlDivider;
        private PictureBox picFeatureEmployee;
        private PictureBox picFeatureKitchen;
        private PictureBox picFeatureTable;
    }
}