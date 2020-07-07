using ApplicationCore.EF;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class CartDetailRepository : Repository<Cartdetail>, ICartDetailRepository
    {
        public CartDetailRepository(ApplicationDbContext context) : base(context)
        {

        }

        protected new ApplicationDbContext Context => base.Context as ApplicationDbContext;
    }
}
