﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain;
using SportsStore.Domain.Concrete;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        EFDbContext context = new EFDbContext();
        public int PageSize = 2;

        public ProductController(IProductsRepository productsRepository)
        {
            this.repository = productsRepository;
        }
        
        
        // GET: Product
        public ActionResult List(int page = 1)
        {
            //List<Product> x = context.Products.ToList();
            //var res = repository.Products.OrderBy(p => p.ProductID).Skip((page - 1)*PageSize).Take(PageSize);
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products.OrderBy(p => p.ProductID).Skip((page - 1)*PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = repository.Products.Count()
                    }
            };
            return View(model);
        }
    }
        
    }
