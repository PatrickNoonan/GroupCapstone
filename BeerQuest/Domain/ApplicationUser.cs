using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string RoleString { get; set; }
    }
    
}
