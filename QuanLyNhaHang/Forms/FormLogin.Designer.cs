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
            pnlLeft = new Panel();
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
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(25, 59, 103);
            pnlLeft.Controls.Add(lblRestaurant);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(320, 460);
            pnlLeft.TabIndex = 0;
            // 
            // lblRestaurant
            // 
            lblRestaurant.AutoSize = true;
            lblRestaurant.BackColor = Color.Transparent;
            lblRestaurant.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblRestaurant.ForeColor = SystemColors.ButtonHighlight;
            lblRestaurant.Location = new Point(35, 141);
            lblRestaurant.Name = "lblRestaurant";
            lblRestaurant.Size = new Size(250, 41);
            lblRestaurant.TabIndex = 0;
            lblRestaurant.Text = "NHÀ HÀNG ABC";
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
            pnlLeft.PerformLayout();
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
    }
}