using aulaDotNetCore.Areas.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaDotNetCore.Areas.Produtos.Services
{
    public static class ProdutoServices
    {
        public static List<Produto> getProdutos()
        {
            return new List<Produto>()
            {
                new Produto { NomeProduto = "Produto1", IdProduto = "3" }
            };
                
        }
    }
}
