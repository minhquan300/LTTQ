using Microsoft.Data.SqlClient;
using QuanLyNhaHang.Data;
using QuanLyNhaHang.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhaHang
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string password = "NhaHang@2026";

            string passwordHash =
                QuanLyNhaHang.Service.PasswordHelper.HashPassword(password);

            Clipboard.SetText(passwordHash);
            MessageBox.Show("Đã sao chép mật khẩu băm vào Clipboard!");

            System.Windows.Forms.Application.Run(new FormLogin());

        }
    }
}