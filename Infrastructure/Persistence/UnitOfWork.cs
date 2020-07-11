using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repositories;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Laptop = new LaptopRepository(context);
            Cart = new CartRepository(context);
            CartDetail = new CartDetailRepository(context);
            Promotion = new PromotionRepository(context);
            User = new UserRepository(context);
        }
        public ILaptopRepository Laptop { get; }
        public ICartRepository Cart { get; }
        public ICartDetailRepository CartDetail { get; }
        public IPromotionRepository Promotion { get; }
        public IUserRepository User { get; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
