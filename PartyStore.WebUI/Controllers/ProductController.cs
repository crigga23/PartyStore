using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyStore.Domain.Abstract;

namespace PartyStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(_productRepository.Products);
        }

    }
}
