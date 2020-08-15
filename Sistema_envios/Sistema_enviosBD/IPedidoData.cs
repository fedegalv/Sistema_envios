using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_enviosBD
{
    public interface IPedidoData
    {
        IEnumerable<Pedido> ObtenerTodos();
        Pedido ObtenerPedido(int id);
        void Agregar(Pedido pedido);
        void Actualizar(Pedido pedido);
        void Eliminar(Pedido pedido);
    }
}
