using Microsoft.AspNetCore.Identity;

namespace satinalma.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;    
        public string ConfirmCode { get; set;} = string.Empty;

    }
}
