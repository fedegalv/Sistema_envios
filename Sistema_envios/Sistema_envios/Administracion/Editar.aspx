<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Sistema_envios.Administracion.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Crear nuevo pedido</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        
        <div class="form-row">
            <%-- TEXTBOX PROVEEDOR --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="proveedor" CssClass="col-md-2 control-label">proveedor</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="proveedor" OnTextChanged="Text_Changed" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="proveedor"
                        CssClass="text-danger" ErrorMessage="El campo Proveedor es obligatorio." />
                </div>
            </div>
            <%-- TEXTBOX ESTADO PEDIDO --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="estadoPedido" OnTextChanged="Text_Changed" CssClass="col-md-4 control-label">Estado pedido: </asp:Label>
                <div class="col-md-5">
                    <asp:DropDownList ID="estadoPedido" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="estadoPedido"
                        CssClass="text-danger" ErrorMessage="El campo Estado pedido es obligatorio." />
                </div>
            </div>
        </div>

        <div class="form-row">

             <%-- CALENDARIO --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="calendario" CssClass="col-md-2 control-label">Calendario: </asp:Label>

                <asp:Calendar ID="calendario" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendario_SelectionChanged">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </div>
            <%-- TEXTBOX FECHA DE ENTREGA --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="fechaEntrega" CssClass="col-md-4 control-label">Fecha de entrega:</asp:Label>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="fechaEntrega" CssClass="form-control"  OnTextChanged="Text_Changed" TextMode="DateTime" ReadOnly="True" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="fechaEntrega"
                        CssClass="text-danger" ErrorMessage="El campo Calendario es obligatorio." />
                </div>
            </div>
        </div>

        <div class="form-row">
            <%-- MONTO PAGADO --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="montoPagado" CssClass="col-md-4 control-label">Monto pagado:</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="montoPagado" CssClass="form-control" OnTextChanged="Text_Changed" TextMode="Number" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="montoPagado"
                        CssClass="text-danger" ErrorMessage="El campo Monto pagado es obligatorio." />
                </div>
            </div>
            <%-- MONTO TOTAL --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="montoTotal" CssClass="col-md-4 control-label">Monto total:</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="montoTotal" CssClass="form-control" OnTextChanged="Text_Changed" TextMode="Number" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="montoTotal"
                        CssClass="text-danger" ErrorMessage="El campo Monto total es obligatorio." />
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-5">
                <asp:Button runat="server" ID="btnEditar" Text="Editar" CssClass="btn btn-primary" OnClick="btnEditar_Click" />
            </div>
        </div>
    </div>  
</asp:Content>
