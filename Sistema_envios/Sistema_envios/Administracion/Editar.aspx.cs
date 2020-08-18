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
    public partial class Editar : System.Web.UI.Page
    {
        private PedidosNegocio pedidosAdministrador;
        private bool hayCambios;
        public Editar()
        {
            pedidosAdministrador = new PedidosNegocio();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                hayCambios = false;
                var itemNames = System.Enum.GetNames(typeof(EEstadoPedido));
                for (int i = 0; i <= itemNames.Length - 1; i++)
                {
                    ListItem item = new ListItem(itemNames[i], i.ToString());
                    estadoPedido.Items.Add(item);
                }

                string idQuery = Request.QueryString["id"];
                if (!idQuery.IsNullOrWhiteSpace())
                {
                    int id = Convert.ToInt32(idQuery);
                    if (id > 0)
                    {
                        Pedido pediaAEditar = pedidosAdministrador.ObtenerPedido(id);
                        proveedor.Text = pediaAEditar.Proveedor;
                        int estadoNum = (int)pediaAEditar.EstadoPedido;
                        estadoPedido.SelectedValue = estadoNum.ToString();
                        fechaEntrega.Text = pediaAEditar.FechaEntrega.ToShortDateString();
                        montoPagado.Text = pediaAEditar.MontoPagado.ToString();
                        montoTotal.Text = pediaAEditar.MontoTotal.ToString();
                    }
                }
            }
        }

        public void Text_Changed(Object sender, EventArgs e)
        {
            TextBox t = (TextBox)(sender);
            hayCambios = true;

        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            fechaEntrega.Text = calendario.SelectedDate.ToShortDateString();
            calendarHidden.Value = "calendarTrue";
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string idQuery = Request.QueryString["id"];
            if (!string.IsNullOrWhiteSpace(idQuery) && (hayCambios || calendarHidden.Value == "calendarTrue"))
            {
                int id = Convert.ToInt32(idQuery);
                if (id > 0)
                {
                    Pedido pedidoEditado = pedidosAdministrador.ObtenerPedido(id);
                    pedidoEditado.Proveedor = proveedor.Text;
                    pedidoEditado.FechaEntrega = DateTime.Parse(fechaEntrega.Text).Date;
                    pedidoEditado.MontoPagado = float.Parse(montoPagado.Text);
                    pedidoEditado.MontoTotal = float.Parse(montoTotal.Text);
                    pedidoEditado.EstadoPedido = (EEstadoPedido)Enum.Parse(typeof(EEstadoPedido), estadoPedido.Text);
                    pedidosAdministrador.ActualizarPedido(pedidoEditado);

                }
            }
            Response.Redirect("~/Default.aspx");
            Response.End();
        }
    }
}