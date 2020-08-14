using Entidades;
using Microsoft.AspNet.Identity.EntityFramework;
using Pedidos.Negocio;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_envios.Administracion
{
    public partial class Agregar : System.Web.UI.Page
    {
        private PedidosNegocio pedidosAdministrador;
        public Agregar()
        {
            pedidosAdministrador = new PedidosNegocio();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var itemNames = System.Enum.GetNames(typeof(EEstadoPedido));
                for (int i = 0; i <= itemNames.Length - 1; i++)
                {
                    ListItem item = new ListItem(itemNames[i], i.ToString());
                    estadoPedido.Items.Add(item);
                }
            }

        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            fechaEntrega.Text = calendario.SelectedDate.ToShortDateString();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Pedido nuevoPedido = new Pedido
            {
                Proveedor = proveedor.Text,
                FechaEntrega = calendario.SelectedDate,
                MontoPagado = float.Parse(montoPagado.Text),
                MontoTotal = float.Parse(montoTotal.Text),
                EstadoPedido = (EEstadoPedido)Enum.Parse(typeof(EEstadoPedido), estadoPedido.Text)
            };

            pedidosAdministrador.AgregarPedido(nuevoPedido);
            Response.Redirect("~/Default.aspx");
        }
    }
}