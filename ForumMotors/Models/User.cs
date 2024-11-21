using Microsoft.AspNetCore.Identity;

namespace ForumMotors.Models
{
    public class User : IdentityUser
    {
        public string? FristName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
