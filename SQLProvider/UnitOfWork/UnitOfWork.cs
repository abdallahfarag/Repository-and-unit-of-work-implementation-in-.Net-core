using SQLAccess.IRepositories;
using SQLAccess.IUnitOfWork;
using SQLProvider.ECommerceContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProvider.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _context;

        public IProductRepository Products { get; }
        public IProductCategoryRepository Categories { get; }
        public IProductImages ProductImages { get; }

        public UnitOfWork(ECommerceDbContext eCommerceDbContext,
           IProductRepository productsRepository,
           IProductCategoryRepository categoriesRepository, IProductImages productImages)
        {
            this._context = eCommerceDbContext;
            this.Products = productsRepository;
            this.Categories = categoriesRepository;
            this.ProductImages = productImages;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
