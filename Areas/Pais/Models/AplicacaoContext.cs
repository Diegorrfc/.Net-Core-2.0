using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aulaDotNetCore.Areas.Pais.Models
{
    public class AplicacaoContext : DbContext    
    {
        public AplicacaoContext(DbContextOptions<AplicacaoContext> options): base (options)
            { }
        public DbSet<Pais> Paises { get; set; }
    }
}
