using System.Collections.Generic;
using aulaDotNetCore.Models;
using aulaDotNetCore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Controllers
{
    [Route("[controller]/[action]")]
    public class ClientesController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(Cliente cliente) {

            if(cliente?.Nome==null ||cliente?.Email==null || cliente?.ClienteId==0){
                ViewBag.Erro="Chorou";
                return View();
            }else{
                return View("ExibirDados", cliente);
            }          

        } 
        public IActionResult Detalhe(){            
           
            Cliente cliente = new Cliente{
                ClienteId =100,
                Nome="Diego",
                Email="diego.rrfc@gmail.com"
            };

            var produto = new List<Produto>{
                    new Produto{ProdutoNome="Diego",ProdutoId=1},
                    new Produto{ProdutoNome="carolo",ProdutoId=3},

            };
            ViewModelCLientePedindo ItemPedido = new ViewModelCLientePedindo{
                cliente=cliente,
                produtoNome=produto
            };
            return View(ItemPedido);
        }
    }
}