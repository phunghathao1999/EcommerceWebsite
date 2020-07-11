using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.EF;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateUserAsync(userinformationModels obj)
        {
            var result = _mapper.Map<userinformationModels, Userinformation>(obj);
            await _unitOfWork.User.AddAsync(result);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteUserAsync(string id)
        {
            var result = await _unitOfWork.User.GetByAsync(id);

            if (result == null) return;

            await _unitOfWork.User.RemoveAsync(result);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<userinformationModels>> GetUserAsync()
        {
            var result = await _unitOfWork.User.GetAllAsync();
            return _mapper.Map<IEnumerable<Userinformation>, IEnumerable<userinformationModels>>(result);
        }

        public async  Task<userinformationModels> GetUserByIdAsync(string id)
        {
            var result = await _unitOfWork.User.GetByAsync(id);
            return _mapper.Map<Userinformation, userinformationModels>(result);
        }

        public async Task UpdateUsertAsync(userinformationModels obj)
        {
            var result = await _unitOfWork.User.GetByAsync(obj.IdUser);
            if (result == null) return;

            _mapper.Map<userinformationModels, Userinformation>(obj, result);
            await _unitOfWork.CompleteAsync();
        }
    }
}