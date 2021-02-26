using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceBusiness.BOs;
using Entity.Entities;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SQLAccess.IUnitOfWork;

namespace ECommerceTwoFeatures.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var products =await new ProductBO(_unitOfWork).AllProducts();
            ViewBag.products = products;
            return View();
        }

        public async Task<IActionResult> AddProduct()
        {
            IEnumerable<AllCategoriesResult> allCategoriesResults = await new ProductCategoryBO(_unitOfWork).ProductCategories();
            ViewBag.prodCategories = new SelectList(allCategoriesResults, "Id", "Name", 1);
            return View(new Product());
        }

        [HttpPost]
        public IActionResult AddProduct(Product product, IFormFile[] photos)
        {
            var addProductViewModel = new AddProductViewModel() { Product = product, Photos = photos };
            new ProductBO(_unitOfWork).AddProduct(addProductViewModel);
            return RedirectToAction(nameof(Index));
        }


    }
}
