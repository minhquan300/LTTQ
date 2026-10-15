using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyNhaHang.Service;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Kiểm tra người dùng đã nhập đủ thông tin chưa
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            try
            {
                // Gọi lớp xử lý đăng nhập
                AuthService authService = new AuthService();

                User? user = authService.Login(username, password);

                // Kiểm tra kết quả
                if (user == null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, hoặc tài khoản đã bị khóa!");
                    return;
                }

                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");

                // Tạm thời chưa mở FormMain
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi đăng nhập: " + ex.Message);
            }
        }


        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
