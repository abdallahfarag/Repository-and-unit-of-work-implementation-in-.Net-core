using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using SQLAccess.IRepositories;
using SQLProvider.ECommerceContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLProvider.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ECommerceDbContext _context;
        public ProductCategoryRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(ProductCategory productCategory)
        {
            await _context.ProductCategories.AddAsync(productCategory);
            return 1;
        }

        public async Task<ProductCategory> Get(int id)
        {
            return await _context.ProductCategories.FindAsync(id);
        }

        public async Task<IEnumerable<ProductCategory>> GetAll()
        {
            return await _context.ProductCategories.ToListAsync();
        }
    }
}
