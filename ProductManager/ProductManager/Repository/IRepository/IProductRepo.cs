using ProductManager.Entity;

namespace ProductManager.Repository.IRepository;

public interface IProductRepo : IRepository<Product,int>
{
    
}