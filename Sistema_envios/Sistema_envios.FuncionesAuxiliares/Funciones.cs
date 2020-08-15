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
        public static void CambiarEstadoPedido(Pedido pedido)
        {
            int estadoNum = (int)pedido.EstadoPedido;
            estadoNum++;
            pedido.EstadoPedido = (EEstadoPedido)estadoNum;
        }

    }
}
