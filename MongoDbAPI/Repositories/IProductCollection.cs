using MongoDbAPI.Models;

namespace MongoDbAPI.Repositories
{
    public interface IProductCollection
    {
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(string id);
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(string id);
        //Task<Product> GetProductByName(string name);
    }
}
