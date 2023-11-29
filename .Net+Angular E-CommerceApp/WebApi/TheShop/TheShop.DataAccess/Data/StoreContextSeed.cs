using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TheShop.Domain.Models;

namespace TheShop.DataAccess.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.ProductBrands.Any())
            {
                var brandsData = File.ReadAllText("C:\\Users\\Simon\\Desktop\\.Net+Angular E-CommerceApp\\WebApi\\TheShop\\TheShop.DataAccess\\Data\\SeedData\\brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                context.ProductBrands.AddRange(brands);
            }

            if (!context.ProductTypes.Any())
            {
                var typesData = File.ReadAllText("C:\\Users\\Simon\\Desktop\\.Net+Angular E-CommerceApp\\WebApi\\TheShop\\TheShop.DataAccess\\Data\\SeedData\\types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                context.ProductTypes.AddRange(types);
            }
            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();

            if (!context.Products.Any())
            {
                var productsData = File.ReadAllText("C:\\Users\\Simon\\Desktop\\.Net+Angular E-CommerceApp\\WebApi\\TheShop\\TheShop.DataAccess\\Data\\SeedData\\products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                context.Products.AddRange(products);
            }

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
