using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aulaDotNetCore.Areas.Produtos.Services;
using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var produtos = ProdutoServices.getProdutos();
            return View(produtos);
        }
    }
}