using Microsoft.AspNetCore.Identity;
using Core.Interfaces;

namespace Infrastructure.Identity
{
    public class UserManagerService : IUserManagerService
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserManagerService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // Implement methods to interact with user accounts,
        // e.g., CreateUserAsync, DeleteUserAsync, etc.
    }
}