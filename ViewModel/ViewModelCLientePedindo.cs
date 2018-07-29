using System.Collections.Generic;
using aulaDotNetCore.Models;

namespace aulaDotNetCore.ViewModel
{
    public class ViewModelCLientePedindo
    {
        public Cliente cliente {get;set;}
        public List<Produto> produtoNome {get;set;}
    }
}