using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        EFDbContext context = new EFDbContext();

        public ProductController(IProductsRepository productsRepository)
        {
            this.repository = productsRepository;
        }
        
        
        // GET: Product
        public ActionResult List()
        {
            //List<Product> x = context.Products.ToList();
            return View(repository.Products);
        }
    }
}