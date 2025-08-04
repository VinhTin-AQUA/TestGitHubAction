using TestGithubAction.Models;

namespace TestGithubAction.Services
{
    public class UserService
    {
        public static List<User> users { get; set; } = [];
        
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User? GetUserById(string id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }
    }
}