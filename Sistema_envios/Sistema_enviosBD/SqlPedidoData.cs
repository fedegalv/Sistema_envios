using Entidades;
using Entidades.Servicios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_enviosBD
{
    public class SqlPedidoData : IPedidoData
    {
        private EntidadesDbContext entidadesDb;
        public SqlPedidoData()
        {
            entidadesDb = new EntidadesDbContext();

        }
        /// <summary>
        /// Actualiza el pedido en DB con el pedido dado por el usuario, se usa optimistic concurrency 
        /// </summary>
        /// <param name="pedido"></param>
        public void Actualizar(Pedido pedido)
        {
            var entrada = entidadesDb.Entry(pedido);
            entrada.State = EntityState.Modified;
            entidadesDb.SaveChanges();
        }
        /// <summary>
        /// Agrega pedidos a base de datos
        /// </summary>
        /// <param name="pedido"></param>
        public void Agregar(Pedido pedido)
        {
            entidadesDb.Pedidos.Add(pedido);
            entidadesDb.SaveChanges();
        }
        /// <summary>
        /// Elimina el pedido en DB, se usa optimistic concurrency 
        /// </summary>
        /// <param name="pedido"></param>
        public void Eliminar(Pedido pedido)
        {
            var entrada = entidadesDb.Entry(pedido);
            entrada.State = EntityState.Deleted;
            entidadesDb.SaveChanges();
        }
        /// <summary>
        /// Obtiene pedido a a partir de una ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pedido ObtenerPedido(int id)
        {
            return entidadesDb.Pedidos.FirstOrDefault(p => p.IdPedido == id);
        }
        /// <summary>
        /// Obtiene IEnumerable con todos los pedidos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pedido> ObtenerTodos()
        {
            return entidadesDb.Pedidos;
        }
        /// <summary>
        /// Obtiene un IEnumerable de Pedido, filtrado por el estado enviado como parametro.
        /// </summary>
        /// <param name="estadoFiltro">Estado para usar como filtro</param>
        /// <returns>IEnumerable de Pedido filtrado</returns>
        public IEnumerable<Pedido> ObtenerTodosFiltrado(EEstadoPedido estadoFiltro)
        {
            return entidadesDb.Pedidos.Where(p => p.EstadoPedido == estadoFiltro);
        }
    }
}
