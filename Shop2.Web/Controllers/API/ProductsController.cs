using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop2.Web.Data;

namespace Shop2.Web.Controllers.API
{
    public class ProductsController : Controller
    {
        [Route("api/[Controller]")]

        public ProductsController(IProductsRepository)
    }
}
