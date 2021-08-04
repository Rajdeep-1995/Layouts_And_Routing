using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layouts.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [Route("products")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("products/details/{id:int?}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return Content("Please pass an Id");
            }
            var products = new[]
            {
                new{ProductId=1,ProductName="Iphone",Cost=20000},
                 new{ProductId=2,ProductName="IMack",Cost=40000},
                  new{ProductId=3,ProductName="TV",Cost=15000}
            };
            var productName = "";
            foreach (var item in products)
            {
                if (item.ProductId==id)
                {
                    productName = item.ProductName;
                }
            }
            return Content(productName);

        }
        [Route("products/details/{productName}")]
        public ActionResult GetProductId(string productName)
        {
           
            var products = new[]
            {
                new{ProductId=1,ProductName="Iphone",Cost=20000},
                 new{ProductId=2,ProductName="IMack",Cost=40000},
                  new{ProductId=3,ProductName="TV",Cost=15000}
            };
            if (productName == null)
            {
                return Content("Please pass a name of the product");
            }
            else
            {
                var productId = 0;
                foreach (var item in products)
                {
                    if (item.ProductName == productName)
                    {
                        productId = item.ProductId;
                    }
                }
                return Content(productId.ToString());
            }
        }
    }
}