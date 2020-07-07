using ApplicationCore.EF;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class LaptopService : ILaptopService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LaptopService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateLaptopAsync(laptopModels obj)
        {
            var product = _mapper.Map<laptopModels, Laptop>(obj);
            await _unitOfWork.Laptop.AddAsync(product);
        }

        public async Task DeleteLaptopAsync(string id)
        {
            var product = await _unitOfWork.Laptop.GetByAsync(id);

            if (product == null) return;

            await _unitOfWork.Laptop.RemoveAsync(product);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<laptopModels> GetByIdAsync(string id)
        {
            var product = await _unitOfWork.Laptop.GetByAsync(id);
            return _mapper.Map<Laptop, laptopModels>(product);
        }

        public async Task<PaginationModels<laptopModels>> GetLaptopAsync(SearchString search, int current = 1)
        {
            var movies = await _unitOfWork.Laptop.GetAllAsync();
            var product = _mapper.Map<IEnumerable<Laptop>, IEnumerable<laptopModels>>(movies);
            
            if (search.Name != "")
            {
                product = product.Where(a =>
                    a.Nameproduct.ToLower().Contains(search.Name.ToLower()));
            }
            if(search.Manufacturer != "")
            {
                // int tmp = Int32.Parse(search.Manufacturer);
                product = product.Where(a =>
                    a.Idmanufacturer.ToString().Contains(search.Manufacturer.ToLower()));
            }

            PaginationModels<laptopModels> _product = new PaginationModels<laptopModels>();
            int total = product.Count();
            _product.array = product.Skip((current - 1) * _product.PageSize).Take<laptopModels>(_product.PageSize);
            _product.totalPage = (int)Math.Ceiling(total / (double)_product.PageSize);
            _product.count = _product.array.Count();
            _product.current = current;
            return _product;
        }

        public async Task<IEnumerable<laptopModels>> GetLaptopAsync()
        {
            var products = await _unitOfWork.Laptop.GetAllAsync();
            return _mapper.Map<IEnumerable<Laptop>, IEnumerable<laptopModels>>(products);
        }

        public async Task UpdateLaptopAsync(laptopModels obj)
        {
            var product = await _unitOfWork.Laptop.GetByAsync(obj.Idproduct);
            if (product == null) return;

            _mapper.Map<laptopModels, Laptop>(obj, product);

            await _unitOfWork.CompleteAsync();
        }
    }
}
