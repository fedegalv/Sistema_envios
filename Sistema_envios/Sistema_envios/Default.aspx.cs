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
            listaPedidos = pedidosNegocio.ListaPedidosFiltrada(EEstadoPedido.Encargado).ToList();
            listViewPedidosEncargados.DataSource = listaPedidos;
            listViewPedidosEncargados.DataBind();

            listaPedidos = pedidosNegocio.ListaPedidosFiltrada(EEstadoPedido.Enviado).ToList();
            listViePedidosEnviados.DataSource = listaPedidos;
            listViePedidosEnviados.DataBind();

            listaPedidos = pedidosNegocio.ListaPedidosFiltrada(EEstadoPedido.Entregado).ToList();
            listViewPedidosEntregados.DataSource = listaPedidos;
            listViewPedidosEntregados.DataBind();

            //listViewPedidos.DataSource = listaPedidosEncargados;
            //listViewPedidosEnviados.DataBind();
        }
        //protected void EnviarBtnHandler(Object sender, EventArgs e)
        //{
        //    Response.Redirect("Default.aspx");
        //}
    }
}