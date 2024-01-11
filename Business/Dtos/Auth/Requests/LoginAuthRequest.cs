using Core.Entities;

namespace Business.Dtos.Auth.Requests
{
    public class LoginAuthRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}