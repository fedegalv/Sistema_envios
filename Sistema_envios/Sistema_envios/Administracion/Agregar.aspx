<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="Sistema_envios.Administracion.Agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Crear nuevo pedido</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <%-- TEXTBOX PROVEEDOR --%>
        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="Proveedor" CssClass="col-md-2 control-label">Proveedor</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="Proveedor" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Proveedor"
                        CssClass="text-danger" ErrorMessage="El campo Proveedor es obligatorio." />
                </div>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="EstadoPedido" CssClass="col-md-2 control-label">Estado pedido: </asp:Label>
                <div class="col-md-5">
                    <asp:DropDownList ID="EstadoPedido" runat="server"></asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="EstadoPedido"
                        CssClass="text-danger" ErrorMessage="El campo Estado pedido es obligatorio." />
                </div>
            </div>
        </div>
        <%-- CALENDARIO --%>


        <div class="form-row">
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="Calendario" CssClass="col-md-2 control-label">Calendario: </asp:Label>

                <asp:Calendar ID="Calendario" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px" OnSelectionChanged="Calendario_SelectionChanged">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </div>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="fechaEntrega" CssClass="col-md-4 control-label">Fecha de entrega:</asp:Label>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="fechaEntrega" CssClass="form-control" TextMode="DateTime" ReadOnly="True" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="fechaEntrega"
                        CssClass="text-danger" ErrorMessage="El campo Calendario es obligatorio." />
                </div>
            </div>

        </div>

        <div class="form-row">
            <%-- MONTO PAGADO --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="MontoPagado" CssClass="col-md-4 control-label">Monto pagado:</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="MontoPagado" CssClass="form-control" TextMode="Number" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="MontoPagado"
                        CssClass="text-danger" ErrorMessage="El campo Monto pagado es obligatorio." />
                </div>
            </div>
            <%-- MONTO TOTAL --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="MontoTotal" CssClass="col-md-4 control-label">Monto total:</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="MontoTotal" CssClass="form-control" TextMode="Number" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="MontoTotal"
                        CssClass="text-danger" ErrorMessage="El campo Monto total es obligatorio." />
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-5">
                <asp:Button runat="server" Text="Registrarse" CssClass="btn btn-primary" Type="Submit" />
            </div>
        </div>
    </div>

</asp:Content>
