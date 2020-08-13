using Entidades;
using Sistema_enviosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Negocio
{
    public class PedidosNegocio
    {
        private SqlPedidoData tareasDataBase = new SqlPedidoData();

        public IEnumerable<Pedido> ListarPedidos()
        {
            return tareasDataBase.ObtenerTodos();
        }

        public Pedido ObtenerPedido(int id)
        {
            return tareasDataBase.ObtenerPedido(id);
        }

        public void AgregarPedido(Pedido pedido)
        {
            tareasDataBase.Agregar(pedido);
        }
        public void ActualizarPedido(Pedido pedido)
        {
            tareasDataBase.Actualizar(pedido);
        }
        public void EliminarPedido(int id)
        {
            tareasDataBase.Eliminar(id);
        }
    }
}
