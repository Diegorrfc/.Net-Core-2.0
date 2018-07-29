using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Components
{
    public class ListaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string sequencia){
            var res = await Task.FromResult(sequencia.Split(new char[]{','}));
            return View("Lista",res);
        }
    }
}