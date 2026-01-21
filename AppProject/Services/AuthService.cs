using AppProject.Models;

namespace AppProject.Services
{
    public class AuthService
    {
        public bool Login(string username, string password)
        {
            // Demo cứng để làm mẫu
            return username == "admin" && password == "123";
        }
    }
}