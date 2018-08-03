using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aulaDotNetCore.Areas.Aluno.Models;
using Microsoft.AspNetCore.Mvc;

namespace aulaDotNetCore.Areas.Aluno.Controllers
{
    public class HomeController : Controller
    {
        [Area("Aluno")]
        public IActionResult Index()
        {
            AlunoBLL _aluno = new AlunoBLL();
            List<Models.Aluno> alunos = _aluno.GetAlunos().ToList();

            return View("Lista",alunos);
        }
    }
}