using Entity.Entities;
using Entity.Models;
using SQLAccess.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBusiness.BOs
{
    public class ProductCategoryBO
    {
        private IUnitOfWork _unitOfWork;

        public ProductCategoryBO(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<AllCategoriesResult>> ProductCategories()
        {
            var categories =  await _unitOfWork.Categories.GetAll();
            var allCategories = new List<AllCategoriesResult>();
            foreach (var item in categories)
            {
                if(item.ParentProductCategory == null)
                {
                    allCategories.Add(new AllCategoriesResult { Id = item.Id, Name = item.Name, ParentProductCategoryName = ""});
                }
                else
                {
                    allCategories.Add(new AllCategoriesResult { Id = item.Id, Name = item.Name, ParentProductCategoryName = item.ParentProductCategory.Name });
                }
            }
            return allCategories;
        }

        public void AddProductCategory(AddProductCategoryViewModel model)
        {
            ProductCategory category = new ProductCategory { Name = model.Name, ParentCategoryId = model.ParentCategoryId };
            _unitOfWork.Categories.Add(category);
            _unitOfWork.Complete();
        }
    }
}
