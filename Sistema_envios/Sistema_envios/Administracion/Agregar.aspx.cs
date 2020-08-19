using Entidades;
using Pedidos.Negocio;
using System;
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
                // Carga a el dropdownList estadoPedido los items en el enum EEstadoPedido
                var itemNames = System.Enum.GetNames(typeof(EEstadoPedido));
                for (int i = 0; i <= itemNames.Length - 1; i++)
                {
                    ListItem item = new ListItem(itemNames[i], i.ToString());
                    estadoPedido.Items.Add(item);
                }
            }

        }
        /// <summary>
        /// Cambia la propiedad Text de fechaEntrega segun la seleccion en Calendario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            fechaEntrega.Text = calendario.SelectedDate.ToShortDateString();
        }
        /// <summary>
        /// Agrega un nuevi pedido a la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Pedido nuevoPedido = new Pedido
            {
                Proveedor = proveedor.Text,
                FechaEntrega = calendario.SelectedDate.Date,
                MontoPagado = decimal.Parse(montoPagado.Text),
                MontoTotal = decimal.Parse(montoTotal.Text),
                EstadoPedido = (EEstadoPedido)Enum.Parse(typeof(EEstadoPedido), estadoPedido.Text)
            };

            pedidosAdministrador.AgregarPedido(nuevoPedido);
            Response.Redirect("~/Default.aspx");
        }
    }
}