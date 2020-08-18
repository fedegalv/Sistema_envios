<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Sistema_envios.Administracion.Eliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>¿Está seguro que desea eliminar el pedido?</h4>
        <hr />
        <div class="form-row">
            <%-- PROVEEDOR --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="proveedor" CssClass="col-md-2 control-label">Proveedor</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="proveedor" CssClass="form-control" ReadOnly="True" />
                </div>
            </div>
            <%-- ESTADO PEDIDO --%>
            <div class="form-group col-md-6">
                <asp:Label runat="server" AssociatedControlID="estadoPedido" CssClass="col-md-4 control-label">Estado pedido: </asp:Label>
                <div class="col-md-5">
                    <asp:TextBox ID="estadoPedido" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
        </div>


        <div class="form-row">
            <%-- FECHA ENTREGA --%>
            <div class="form-group col-md-4">
                <asp:Label runat="server" AssociatedControlID="fechaEntrega" CssClass="col-md control-label">Fecha de entrega:</asp:Label>
                <div class="col-md-4">
                    <asp:TextBox runat="server" ID="fechaEntrega" CssClass="form-control" TextMode="DateTime" ReadOnly="True" />
                </div>
            </div>
            <%-- MONTO PAGADO --%>
            <div class="form-group col-md-4">
                <asp:Label runat="server" AssociatedControlID="montoPagado" CssClass="col-md control-label">Monto pagado:</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="montoPagado" CssClass="form-control" TextMode="Number" ReadOnly="True" />

                </div>
            </div>
            <%-- MONTO TOTAL --%>
            <div class="form-group col-md-4">
                <asp:Label runat="server" AssociatedControlID="montoTotal" CssClass="col-md control-label">Monto total:</asp:Label>
                <div class="col-md-5">
                    <asp:TextBox runat="server" ID="montoTotal" CssClass="form-control" TextMode="Number" ReadOnly="True" />

                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-5">
                <asp:Button runat="server" ID="btnEliminar" Text="Eliminar pedido" CssClass="btn btn-primary" OnClick="btnEliminar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
