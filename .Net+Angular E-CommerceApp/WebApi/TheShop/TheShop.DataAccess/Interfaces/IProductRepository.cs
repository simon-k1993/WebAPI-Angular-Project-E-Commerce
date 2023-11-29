using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Domain.Models;

namespace TheShop.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();

        Task<IReadOnlyList<ProductBrand>> GetProductBrandAsync();

        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
