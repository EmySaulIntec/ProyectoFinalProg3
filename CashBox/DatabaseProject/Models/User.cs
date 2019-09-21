using DatabaseProject.Models;

namespace DatabaseProject.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsCasher { get; set; }
        public bool IsEnabled { get; set; } = true;
        public string Email { get; set; }

        public override string ToString()
        {
            return UserName;
        }
    }
}