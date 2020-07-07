using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ILaptopService
    {
        Task<PaginationModels<laptopModels>> GetLaptopAsync(SearchString search, int current = 1);
        Task<IEnumerable<laptopModels>> GetLaptopAsync();
        Task<laptopModels> GetByIdAsync(string id);
        Task CreateLaptopAsync(laptopModels obj);
        Task UpdateLaptopAsync(laptopModels obj);
        Task DeleteLaptopAsync(string id);
    }
}
