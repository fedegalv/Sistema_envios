using Entidades;
using Pedidos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_envios
{
    public partial class _Default : Page
    {
        private List<Pedido> listaPedidos = new List<Pedido>();
        private PedidosNegocio pedidosNegocio = new PedidosNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            listaPedidos = pedidosNegocio.ListarPedidos().ToList();
            listViewPedidos.DataSource = listaPedidos;
            listViewPedidos.DataBind();
        }
    }
}