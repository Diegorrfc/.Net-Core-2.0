using System.Collections.Generic;

namespace aulaDotNetCore.Services
{
    public class ProdutosServices
    {
        public List<string> getProtudos(){
            return new List<string>(){"Produto1","Produto2","Produto3"};
        }
    }
}