using Microsoft.EntityFrameworkCore;
using SQLAccess.IRepositories;
using SQLProvider.ECommerceContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProvider.Repositories
{
    public class ProductImages : IProductImages
    {
        private readonly ECommerceDbContext _context;
        public ProductImages(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Entity.Entities.ProductImages> GetProductDefaultImage(int productId)
        {
            return await _context.ProductImages.FirstOrDefaultAsync(i => i.ProductId == productId);

        }
    }
}
