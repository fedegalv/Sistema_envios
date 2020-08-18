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
        /// <summary>
        /// Obtiene IEnumerable de Pedido
        /// </summary>
        /// <returns>IEnumerable de Pedidos</returns>
        public IEnumerable<Pedido> ListarPedidos()
        {
            return tareasDataBase.ObtenerTodos();
        }
        /// <summary>
        /// Obtiene Pedido a partir de una ID
        /// </summary>
        /// <param name="id">Id del Pedido a buscar</param>
        /// <returns></returns>
        public Pedido ObtenerPedido(int id)
        {
            return tareasDataBase.ObtenerPedido(id);
        }
        /// <summary>
        /// Agrega Pedido a BD
        /// </summary>
        /// <param name="pedido">Pedido a agregar</param>
        public void AgregarPedido(Pedido pedido)
        {
            tareasDataBase.Agregar(pedido);
        }
        /// <summary>
        /// Actualiza Pedido en BD
        /// </summary>
        /// <param name="pedido">Pedido a actualizar</param>
        public void ActualizarPedido(Pedido pedido)
        {
            tareasDataBase.Actualizar(pedido);
        }
        /// <summary>
        /// Elimina Pedido en BD
        /// </summary>
        /// <param name="pedido">Pedido a eliminar</param>
        public void EliminarPedido(Pedido pedido)
        {
            tareasDataBase.Eliminar(pedido);
        }
        /// <summary>
        /// Obtiene IEnumerable de Pedido, filtrado por un filtro de estado
        /// </summary>
        /// <param name="estadoFiltro">EEstadoPedido: Encargado, Enviado, Entregado</param>
        /// <returns></returns>
        public IEnumerable<Pedido> ListaPedidosFiltrada(EEstadoPedido estadoFiltro)
        {
            return tareasDataBase.ObtenerTodosFiltrado(estadoFiltro);
        }
    }
}
