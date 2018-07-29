using aulaDotNetCore.InterfaceModels;

namespace aulaDotNetCore.Models
{
    public class Estado : IEstado
    {
        public string NomeEstado { get ; set ; }
        public string SiglaEstago { get  ; set ; }
    }
}