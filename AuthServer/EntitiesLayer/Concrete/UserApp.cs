using Microsoft.AspNetCore.Identity;

namespace EntitiesLayer.Concrete
{
    public class UserApp:IdentityUser
    {
        public string City { get; set; }
    }
}
