﻿using ApplicationCore.EF;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class CartDetailService : ICartDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CartDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateCartdetailAsync(cartdetailModels obj)
        {
            var cartdetail = _mapper.Map<cartdetailModels, Cartdetail>(obj);
            await _unitOfWork.CartDetail.AddAsync(cartdetail);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCartdetailAsync(string id)
        {
            var cartdetail = await _unitOfWork.CartDetail.GetByAsync(id);
            if (cartdetail == null) return;

            await _unitOfWork.CartDetail.RemoveAsync(cartdetail);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<cartdetailModels> GetByIdAsync(string id)
        {
            var cartdetail = await _unitOfWork.CartDetail.GetByAsync(id);
            return _mapper.Map<Cartdetail, cartdetailModels>(cartdetail);
        }

        public async Task<PaginationModels<cartdetailModels>> GetCartdetailAsync([FromQuery] SearchString search,int current = 1)
        {
            var cartdetal = await _unitOfWork.CartDetail.GetAllAsync();
            var cartdetails = _mapper.Map<IEnumerable<Cartdetail>, IEnumerable<cartdetailModels>>(cartdetal);

            PaginationModels<cartdetailModels> _cartdetail = new PaginationModels<cartdetailModels>();
            int total = cartdetails.Count();
            _cartdetail.array = cartdetails.Skip((current - 1) * _cartdetail.PageSize).Take<cartdetailModels>(_cartdetail.PageSize);
            _cartdetail.totalPage = (int)Math.Ceiling(total / (double)_cartdetail.PageSize);
            _cartdetail.count = _cartdetail.array.Count();
            _cartdetail.current = current;
            return _cartdetail;
        }

        public async Task UpdateCartdetailAsync(cartdetailModels obj)
        {
            var cartdetail = await _unitOfWork.CartDetail.GetByAsync(obj.Idcartdetail);
            if (cartdetail == null) return;

            _mapper.Map<cartdetailModels, Cartdetail>(obj, cartdetail);

            await _unitOfWork.CompleteAsync();
        }
    }
}
