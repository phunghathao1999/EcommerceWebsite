using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.EF;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence.Repositories
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly  UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserIdentityService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        
        public async Task<SignInResult> LoginAsync(string userName, string password, bool isPersistant, bool lockoutOnFailure)
        {
            var result = await _signInManager.PasswordSignInAsync(userName, password, isPersistant, lockoutOnFailure);
            return result;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityUser> GetUserAsync(string userName)
        {
            return await _userManager.FindByNameAsync(userName);
        }

        public async Task<IdentityResult> CreateUserAsync(IdentityUser user, string password)
        {
            var result = await _userManager.CreateAsync(user,password);
            return result;
        }

        public async Task<IdentityResult> UpdateUserAsync(IdentityUser user, string password)
        {
            var result = await _userManager.UpdateAsync(user);
            return result;
        }

        public async Task<IdentityResult> UpdatePwdAsync(IdentityUser user, string password)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, password);
            return result;
        }

        public async Task<IdentityResult> AddRoleToUserAsync(IdentityUser user, string role)
        {
            var result = await _userManager.AddToRoleAsync(user,role);
            return result;
        }

        public async Task<IEnumerable<string>> GetRoleToUserAsync(IdentityUser user)
        {
            var result = await _userManager.GetRolesAsync(user);
            return result;
        }

        public async Task<IdentityResult> CreateRoleAsync(string role)
        {
            var identityRole = new IdentityRole(role);
            var result = await _roleManager.CreateAsync(identityRole);
            return result;
        }
    }
}