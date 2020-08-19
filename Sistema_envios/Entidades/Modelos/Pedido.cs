using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Proveedor { get; set; }
        [Required]
        public DateTime FechaEntrega {
            get;
            set;
        }
        [Required]
        public decimal MontoPagado { get; set; }
        [Required]
        public decimal MontoTotal { get; set; }
        [Required]
        public EEstadoPedido EstadoPedido { get; set; }
    }
}
