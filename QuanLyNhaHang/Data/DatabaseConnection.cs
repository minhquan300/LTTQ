using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.Data.SqlClient;

namespace QuanLyNhaHang.Data
{
    internal class DatabaseConnection
    {
        private static string connectionString =
            @"Server=MSI\SQLEXPRESS;Database=QuanLyNhaHang;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
