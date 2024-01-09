using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualLibrary.Infrastructure.Identity
{
    public class IdentitySeeder
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentitySeeder(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedAsync()
        {
            await EnsureRolesAsync();
            await EnsureDefaultAdminUserAsync();
        }

        private async Task EnsureRolesAsync()
        {
            if (!await _roleManager.RoleExistsAsync("Administrator"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Administrator"));
            }

            if (!await _roleManager.RoleExistsAsync("Librarian"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Librarian"));
            }
        }

        private async Task EnsureDefaultAdminUserAsync()
        {
            var adminUser = await _userManager.FindByEmailAsync("admin@example.com");
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@example.com",
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(adminUser, "AdminPass123!");
                await _userManager.AddToRoleAsync(adminUser, "Administrator");
            }
        }
    }
}