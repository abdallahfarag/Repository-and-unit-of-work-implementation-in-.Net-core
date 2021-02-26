using SQLAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLAccess.IUnitOfWork
{
   public  interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IProductCategoryRepository Categories { get; }
        IProductImages ProductImages { get; }
        int Complete();
    }
}
