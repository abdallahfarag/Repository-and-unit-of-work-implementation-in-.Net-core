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
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceDbContext _context;
        public ProductRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Product product)
        {
            await _context.Products.AddAsync(product);
            return 1;
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.Include(x => x.ProductImages).ToListAsync();
        }
    }
}
