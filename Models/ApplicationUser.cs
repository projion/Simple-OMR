using Microsoft.AspNetCore.Identity;

namespace Simple_OMR.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
    }
}
