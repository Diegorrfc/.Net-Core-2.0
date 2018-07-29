
using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Controllers
{
    [Route("[controller]/[action]")]
    public class ProdutoController : Controller
    {
        public IActionResult Index (int? id, string ordem)
        {
            if(!id.HasValue){
                id=23;
            }
            if(string.IsNullOrEmpty(ordem)){
                ordem="vazio";
            }
            var https = HttpContext.Request.IsHttps;
            var caminho =HttpContext.Request.Path;
            var status = HttpContext.Response.StatusCode;
            return Content(string.Format("pagina = {0} & ordem = {1}",id,ordem));
        }
        public IActionResult Detalhe()
        {
            return RedirectToAction("Index","Home",new {nome = "Diego"});
        }
        public IActionResult Edit(int codigo){

            return Content("ID: "+codigo.ToString());
        }
        public IActionResult DataLancamento(int ano, int mes){

            return Content(ano +"  "+mes);
        }
    }
}