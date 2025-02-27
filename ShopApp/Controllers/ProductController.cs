 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopApp.Models;
using Entities.Models;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;
using Entities.RequestParameters;

namespace ShopApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }




        // GET: Product
        public async Task<IActionResult> Index(ProductRequestParameters p)
        {
            var products = _manager.ProductService.GetAllProductsWithDetails(p);
            var pagination = new Pagination()
            {
                CurrentPage = p.PageNumber,
                ItemsPerPage = p.PageSize,
                TotalItems = _manager.ProductService.GetAllProducts(false).Count()
            };
            return View(new ProductListViewModel()
            {
                Products = products,
                Pagination = pagination
            });
        }

        // GET: Product/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _manager.Product.GetAllProducts(false) == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _manager.Product.GetAllProducts(false)
        //        .FirstOrDefaultAsync(m => m.ProductId == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(product);
        //}
        public async Task<IActionResult> Details([FromRoute(Name="id")]int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }


    }
}
