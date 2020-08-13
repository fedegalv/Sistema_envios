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
            entidadesDb= new EntidadesDbContext();

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

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPedido(int id)
        {
            return entidadesDb.Pedidos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pedido> ObtenerTodos()
        {
            return entidadesDb.Pedidos;
        }
    }
}
