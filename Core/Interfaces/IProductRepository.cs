using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
        Task<Product?> GetProductByIdAsync(int id);
        Task<IReadOnlyCollection<Product>> GetProductsAsync(string? brand,string? type,string? sort);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        bool ProductExists(int id);
        Task<bool> SaveChangesAsync();
        Task<IReadOnlyList<string>> GetBrandAsync();
        Task<IReadOnlyList<string>> GetTypesAsync();
}