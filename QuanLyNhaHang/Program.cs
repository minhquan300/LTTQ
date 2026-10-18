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

            

            System.Windows.Forms.Application.Run(new FormLogin());

        }
    }
}