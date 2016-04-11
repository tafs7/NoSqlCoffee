using NoSqlCoffee.Domain.Common;

namespace NoSqlCoffee.Domain.Models.Commerce
{
    public class User : Entity
    {
        public static readonly User Anonymous = new User(null);

        public string Username { get; }

        public User(string username)
        {
            Username = username ?? "anonymous";                          
        }
    }
}
