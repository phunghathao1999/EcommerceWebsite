using ApplicationCore.EF;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class LaptopRepository : Repository<Laptop>, ILaptopRepository
    {
        public LaptopRepository(ApplicationDbContext context) : base(context)
        {

        }

        protected new ApplicationDbContext Context => base.Context as ApplicationDbContext;
    }
}
