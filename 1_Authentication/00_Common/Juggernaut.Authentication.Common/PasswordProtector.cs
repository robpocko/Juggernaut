namespace Juggernaut.Authentication.Common
{
    public class PasswordProtector
    {
        //  Private default constructor; class is not intended to be instantiated
        private PasswordProtector() { }

        public static string PasswordToHash(string rawPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(rawPassword, 8);
        }

        public static bool VerifyPassword(string rawPassword, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(rawPassword, hash);
        }
    }
}
