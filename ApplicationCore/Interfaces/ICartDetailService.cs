using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ICartDetailService
    {
        Task<PaginationModels<cartdetailModels>> GetCartdetailAsync([FromQuery] SearchString search, int current = 1);
        Task<cartdetailModels> GetByIdAsync(string id);
        Task CreateCartdetailAsync(cartdetailModels obj);
        Task UpdateCartdetailAsync(cartdetailModels obj);
        Task DeleteCartdetailAsync(string id);
    }
}
