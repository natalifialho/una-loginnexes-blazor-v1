using LoginNexus.Moldels;
using LoginNexus.Moldels;

namespace LoginNexus.Services
{
    public class AuthService
    {
        private readonly List<user> _users = new()
    {
        new user { Email = "daniel@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Arnaldo" },
        new user { Email = "natali@nexus.edu", Password = "123", Role = "Student", Name = "natali" }
    };

        public user? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}