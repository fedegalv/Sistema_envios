using Entidades;
using Microsoft.Ajax.Utilities;
using Pedidos.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_envios.Administracion
{
    public partial class Eliminar : System.Web.UI.Page
    {
        private PedidosNegocio pedidosAdministrador;
        public Eliminar()
        {
            pedidosAdministrador = new PedidosNegocio();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                string idQuery = Request.QueryString["id"];
                if (!idQuery.IsNullOrWhiteSpace())
                {
                    int id = Convert.ToInt32(idQuery);
                    if (id > 0)
                    {
                        Pedido pedidoAEliminar = pedidosAdministrador.ObtenerPedido(id);
                        proveedor.Text = pedidoAEliminar.Proveedor;
                        estadoPedido.Text = pedidoAEliminar.EstadoPedido.ToString();
                        fechaEntrega.Text = pedidoAEliminar.FechaEntrega.ToShortDateString();
                        montoPagado.Text = pedidoAEliminar.MontoPagado.ToString();
                        montoTotal.Text = pedidoAEliminar.MontoTotal.ToString();
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string idQuery = Request.QueryString["id"];
            if (!string.IsNullOrWhiteSpace(idQuery))
            {
                int id = Convert.ToInt32(idQuery);
                if (id > 0)
                {
                    pedidosAdministrador.EliminarPedido(pedidosAdministrador.ObtenerPedido(id));
                }
            }
            Response.Redirect("~/Default.aspx");
            Response.End();
        }
    }
}