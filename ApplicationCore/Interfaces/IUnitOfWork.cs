using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        ILaptopRepository Laptop { get; }
        ICartRepository Cart { get; }
        ICartDetailRepository CartDetail { get; }
        IPromotionRepository Promotion { get; }
        IAccountRepository Account { get; }
        IUserRepository User {get;}
        Task<int> CompleteAsync();
    }
}
