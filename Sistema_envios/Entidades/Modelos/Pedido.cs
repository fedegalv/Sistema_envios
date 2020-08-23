using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        [Required]
        [Key]
        public int IdPedido { get; set; }
        [Required]
        public string Proveedor { get; set; }
        [Required]
        public DateTime FechaEntrega {  get; set; }
        [Required]
        public decimal MontoPagado { get; set; }
        [Required]
        public decimal MontoTotal { get; set; }

        [Required]
        public EEstadoPedido EstadoPedido { get; set; }
    }
}
