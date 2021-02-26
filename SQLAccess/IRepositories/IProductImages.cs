using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLAccess.IRepositories
{
    public interface IProductImages
    {
        Task<ProductImages> GetProductDefaultImage(int productId);
    }
}
