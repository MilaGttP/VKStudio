namespace VKStudio.Services
{
    public interface IAuthService
    {
        bool IsValidUser(string login, string password);
    }

    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool IsValidUser(string login, string password)
        {
            string expectedLogin = _configuration["UserSecrets:Login"];
            string expectedPassword = _configuration["UserSecrets:Password"];

            return login == expectedLogin && password == expectedPassword;
        }
    }
}
