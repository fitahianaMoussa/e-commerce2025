using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Repositories;

public class ProductRepository: IProductRepository
{
    public Task<Product?> GetProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<Product>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public bool ProductExists(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}