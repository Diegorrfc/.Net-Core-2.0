using System.Collections.Generic;
using aulaDotNetCore.Models;

namespace aulaDotNetCore.Services
{
    public class ListaEstadoServices
    {
        public List<Estado> GetEstados(){

            return new List<Estado>(){
                new Estado{NomeEstado="Pernambuco",SiglaEstago="PE"},
                new Estado{NomeEstado="Pernambuco1",SiglaEstago="PE1"},
                new Estado{NomeEstado="Pernambuco2",SiglaEstago="2"},

            };
        }
    }
}