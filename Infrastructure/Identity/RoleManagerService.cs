using Microsoft.AspNetCore.Identity;
using VirtualLibrary.Infrastructure.Identity;
using System.Threading.Tasks;

namespace VirtualLibrary.Infrastructure.Services
{
    public class RoleManagerService
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleManagerService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task CreateRolesAsync()
        {
            string[] roleNames = { "Administrator", "Librarian" };
            foreach (var roleName in roleNames)
            {
                var roleExist = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}