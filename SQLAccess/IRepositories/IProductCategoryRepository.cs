using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLAccess.IRepositories
{
    public interface IProductCategoryRepository
    {
        Task<int> Add(ProductCategory productCategory);
        Task<ProductCategory> Get(int id);
        Task<IEnumerable<ProductCategory>> GetAll();
    }
}
