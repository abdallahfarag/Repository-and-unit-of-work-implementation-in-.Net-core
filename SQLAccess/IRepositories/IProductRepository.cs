using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLAccess.IRepositories
{
    public interface IProductRepository
    {
        Task<int> Add(Product product);
        Task<Product> Get(int id);
        Task<IEnumerable<Product>> GetAll();
    }
}
