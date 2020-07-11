using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.EF;
using Microsoft.AspNetCore.Identity;

namespace ApplicationCore.Interfaces
{
    public interface IUserIdentityService
    {
        Task<SignInResult> LoginAsync(string userName, string password, bool isPersistant, bool lockoutOnFailure);
        Task LogoutAsync();
        Task<IdentityUser> GetUserAsync(string userName);
        Task<IdentityResult> CreateUserAsync(IdentityUser user, string password);
        Task<IdentityResult> UpdateUserAsync(IdentityUser user, string password);
        Task<IdentityResult> UpdatePwdAsync(IdentityUser user, string password);
        Task<IdentityResult> AddRoleToUserAsync(IdentityUser user, string role);
        Task<IEnumerable<string>> GetRoleToUserAsync(IdentityUser user);
        Task<IdentityResult> CreateRoleAsync(string role);
    }
}