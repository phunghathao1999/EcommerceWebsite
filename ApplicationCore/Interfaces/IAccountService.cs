using System.Threading.Tasks;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;

namespace ApplicationCore.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateAccountAsync(accountModels obj);
        Task<IdentityResult> GetAccountAsync(accountModels obj);
        Task<IdentityResult> UpdateAccountAsync(accountModels obj);
    }
}