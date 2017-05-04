using Microsoft.AspNet.Identity.EntityFramework;

namespace Jo2me.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
