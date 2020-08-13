using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Servicios
{
    public class EntidadesDbContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
