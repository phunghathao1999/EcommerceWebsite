using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Identity;

namespace ApplicationCore.Interfaces
{
    public interface IUserService
    {
        Task CreateUserAsync(userinformationModels obj);
        Task<IEnumerable<userinformationModels>> GetUserAsync();
        Task<userinformationModels> GetUserByIdAsync(string id);
        Task UpdateUsertAsync(userinformationModels obj);
        Task DeleteUserAsync(string id);
    }
}