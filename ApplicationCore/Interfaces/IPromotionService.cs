using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IPromotionService
    {
        Task<PaginationModels<promotionModels>> GetPromotionAsync([FromQuery] SearchString search, int current = 1);
        Task<promotionModels> GetByIdAsync(string id);
        Task CreatePromotionAsync(promotionModels obj);
        Task UpdatePromotionAsync(promotionModels obj);
        Task DeletePromotionAsync(string id);
    }
}
