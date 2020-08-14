using Entidades;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_envios.Administracion
{
    public partial class Agregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var itemNames = System.Enum.GetNames(typeof(EEstadoPedido));
            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemNames[i], i.ToString());
                EstadoPedido.Items.Add(item);
            }
        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)
        {
            fechaEntrega.Text = Calendario.SelectedDate.ToShortDateString();
        }
    }
}