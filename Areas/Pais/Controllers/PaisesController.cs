using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aulaDotNetCore.Areas.Pais.Models;
using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Areas.Pais.Controllers
{
    [Area("Pais")]
    public class PaisesController : Controller
    {
        private readonly AplicacaoContext _Context;
        public PaisesController(AplicacaoContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            
            List<Models.Pais> listaPaises = new List<Models.Pais>();

            listaPaises = (from pais in _Context.Paises select pais).ToList();
            listaPaises.Insert(0, new Models.Pais { Id = 0, Nome = "Selecione" });
            ViewBag.ListaPaises = listaPaises;

            return View();
        }
    }
}