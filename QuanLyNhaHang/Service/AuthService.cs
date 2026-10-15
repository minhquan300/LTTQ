
using QuanLyNhaHang.Data;
using QuanLyNhaHang.Models;

namespace QuanLyNhaHang.Service
{
    internal class AuthService
    {
        private UserRepository userRepository = new UserRepository();

        public User? Login(string username, string password)
        {
            // Tìm tài khoản theo tên đăng nhập
            User? user = userRepository.GetByUsername(username);

            // Không tìm thấy tài khoản
            if (user == null)
            {
                return null;
            }

            // Tài khoản đã bị vô hiệu hóa
            if (user.IsActive == false)
            {
                return null;
            }

            // Kiểm tra mật khẩu
            bool isValid = PasswordHelper.VerifyPassword(
                password, user.PasswordHash
            );

            if (isValid == false)
            {
                return null;
            }

            // Đăng nhập thành công
            return user;
        }
    }
}
