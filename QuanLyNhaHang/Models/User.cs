using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaHang.Models
{
    internal class User
    {
        public int EmployeeID { get; set; }

        public string Username { get; set; } = "";

        public string PasswordHash { get; set; } = "";

        public string FullName { get; set; } = "";

        public string Phone { get; set; } = "";

        public int RoleID { get; set; }

        public bool IsActive { get; set; }
    }
}
