using SCharpEgitimKampi301_501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCharpEgitimKampi301_501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllPRoductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(int id);
        Task GetByProductIdAsync(int id);
    }
}
