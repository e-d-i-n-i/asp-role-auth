using Microsoft.AspNetCore.Identity;

namespace Role_Based_Authorization.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }

        public string ? ProfilePictures { get; set; }
    }
}
