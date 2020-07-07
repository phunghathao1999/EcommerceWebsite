using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICartService
    {
        Task<PaginationModels<cartModels>> GetCartAsync([FromQuery] SearchString search, int current = 1);
        Task<cartModels> GetByIdAsync(string id);
        Task CreateCartAsync(cartModels obj);
        Task UpdateCartAsync(cartModels obj);
        Task DeleteCartAsync(string id);
    }
}
