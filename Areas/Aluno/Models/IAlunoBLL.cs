using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaDotNetCore.Areas.Aluno.Models
{
    interface IAlunoBLL
    {
        List<Aluno> GetAlunos();
    }
}
