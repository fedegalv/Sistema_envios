using Entidades;
using Pedidos.Negocio;
using Sistema_envios.FuncionesAuxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_envios.Administracion
{

    public partial class CambiarEstado : System.Web.UI.Page
    {
        private PedidosNegocio pedidosAdministrador;
        public CambiarEstado()
        {
            pedidosAdministrador = new PedidosNegocio();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string idQuery = Request.QueryString["id"];
            string estadoQuery = Request.QueryString["estado"];

            if (!string.IsNullOrWhiteSpace(idQuery) || !string.IsNullOrWhiteSpace(estadoQuery))
            {
                int id = Convert.ToInt32(idQuery);
                if (id > 0)
                {
                    if (estadoQuery == "EnCurso" || estadoQuery == "Enviado")
                    {
                        Pedido pedidoActualizado = pedidosAdministrador.ObtenerPedido(id);
                        Funciones.CambiarEstadoPedido(pedidoActualizado);
                        pedidosAdministrador.ActualizarPedido(pedidoActualizado);
                    }
                }
            }
            Response.Redirect("~/Default.aspx");
            Response.End();
        }
    }

}