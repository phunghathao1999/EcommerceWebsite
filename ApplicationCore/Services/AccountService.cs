using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace ApplicationCore.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<IdentityResult> CreateAccountAsync(accountModels obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> GetAccountAsync(accountModels obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAccountAsync(accountModels obj)
        {
            throw new System.NotImplementedException();
        }
    }
}