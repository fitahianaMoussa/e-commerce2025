

using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context)
    {
        if (!context.Products.Any())
        {
            var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/Seeds/Products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            if (products != null) context.Products.AddRange(products);
            
            await context.SaveChangesAsync();
        }
    }
}