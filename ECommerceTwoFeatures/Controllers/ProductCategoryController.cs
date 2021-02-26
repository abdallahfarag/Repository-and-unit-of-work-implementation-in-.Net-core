using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceBusiness.BOs;
using Entity.Entities;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using SQLAccess.IUnitOfWork;

namespace ECommerceTwoFeatures.Controllers
{
    public class ProductCategoryController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IEnumerable<AllCategoriesResult>> Categories()
        {
            IEnumerable<AllCategoriesResult> allCategoriesResults = await new ProductCategoryBO(_unitOfWork).ProductCategories();
            return allCategoriesResults;
        }

        [HttpPost]
        public void AddCategory(AddProductCategoryViewModel category)
        {
            new ProductCategoryBO(_unitOfWork).AddProductCategory(category);
        }
    }
}
