using ApplicationCore.EF;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository :  Repository<Userinformation>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        protected new ApplicationDbContext Context => base.Context as ApplicationDbContext;
    }
}