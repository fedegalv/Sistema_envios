using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_envios.FuncionesAuxiliares
{
    public class Funciones
    {
        /// <summary>
        /// Cambia el estado de un Pedido
        /// </summary>
        /// <param name="pedido"></param>
        public static void CambiarEstadoPedido(Pedido pedido)
        {
            int estadoNum = (int)pedido.EstadoPedido;
            estadoNum++;
            pedido.EstadoPedido = (EEstadoPedido)estadoNum;
        }

    }
}
