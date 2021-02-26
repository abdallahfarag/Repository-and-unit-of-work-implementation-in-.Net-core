using Entity.Entities;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using SQLAccess.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceBusiness.BOs
{
    public class ProductBO
    {
        private IUnitOfWork _unitOfWork;

        public ProductBO(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<AllProductsResult>> AllProducts()
        {
            var products = await _unitOfWork.Products.GetAll();
            var allProducts = new List<AllProductsResult>();
            foreach (var item in products)
            {
                ProductCategory productCategory = await _unitOfWork.Categories.Get(item.ProductCategoryId);
                ProductImages productDefaultImage = await _unitOfWork.ProductImages.GetProductDefaultImage(item.Id);
                allProducts.Add(new AllProductsResult {Id=item.Id, Name=item.Name, Description=item.Description,CategoryName=productCategory.Name, DefaultImage= productDefaultImage.Name });
            }
            return allProducts;
        }

        public void AddProduct(AddProductViewModel model)
        {
            //model.Product.ProductImages = new IEnumerable<ProductImages>();
            foreach (IFormFile photo in model.Photos)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photo.FileName);
                var stream = new FileStream(path, FileMode.Create);
                photo.CopyToAsync(stream);
                model.Product.ProductImages.Add(new ProductImages { Name = photo.FileName});
            }
            _unitOfWork.Products.Add(model.Product);
            _unitOfWork.Complete();
        }

    }
    }

