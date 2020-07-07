using ApplicationCore.EF;
using ApplicationCore.Interfaces;

namespace Infrastructure.Persistence.Repositories
{
    public class AccountRepository :  Repository<Userinformation>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context) : base(context)
        {

        }

        protected new ApplicationDbContext Context => base.Context as ApplicationDbContext;
    }
}