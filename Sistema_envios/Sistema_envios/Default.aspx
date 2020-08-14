<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sistema_envios._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <ul class="nav nav-pills nav-justified " id="pills-tab" role="tablist">
        <li class="nav-item" role="presentation">
            <a class="nav-link active" id="pills-encargado-tab" data-toggle="pill" href="#pills-encargado" role="tab" aria-controls="pills-encargado" aria-selected="true">Encargado</a>
        </li>
        <li class="nav-item" role="presentation">
            <a class="nav-link" id="pills-enviado-tab" data-toggle="pill" href="#pills-enviado" role="tab" aria-controls="pills-enviado" aria-selected="false">Enviado</a>
        </li>
        <li class="nav-item" role="presentation">
            <a class="nav-link" id="pills-entregado-tab" data-toggle="pill" href="#pills-entregado  " role="tab" aria-controls="pills-entregado" aria-selected="false">Entregado</a>
        </li>
    </ul>
    <div class="tab-content" id="pills-tabContent">
        <div class="tab-pane fade show active" id="pills-encargado" role="tabpanel" aria-labelledby="pills-encargado-tab">
            <div class="table-responsive table-hover">
                <asp:ListView ID="listViewPedidos" runat="server">
                    <LayoutTemplate>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th scope="col">Id</th>
                                    <th scope="col">Proveedor</th>
                                    <th scope="col">Fecha entrega</th>
                                    <th scope="col">Monto pagado</th>
                                    <th scope="col">Monto total</th>
                                    <th scope="col">Estado pedido</th>
                                    <th scope="col"></th>
                                    <th scope="col">Acciones</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </tbody>
                        </table>
                    </LayoutTemplate>

                    <ItemTemplate>
                        <tr>
                            <th scope="row"><%# Eval("Id")%></th>
                            <td><%# Eval("Proveedor")%></td>
                            <td><%# Eval("FechaEntrega")%></td>
                            <td><%# Eval("MontoPagado")%></td>
                            <td><%# Eval("MontoTotal")%></td>
                            <td><%# Eval("EstadoPedido")%></td>
                            <loggedintemplate>
                         <td >
                            
                            <a class="btn btn-secondary" href="Administracion/CambiarEstado.aspx?id=<%# Eval("Id") %>&estado=<%# Eval("EstadoPedido")%>" role="button">Enviar</a>
                         </td>
                        <td >
                            <a class="btn btn-secondary" href="Default.aspx?id=<%# Eval("Id") %>" role="button">Eliminar</a>
                            <%--<asp:HyperLink id="aExample" runat="server" NavigateUrl="~/Eliminar.aspx?id=<%# Eval("Id") %>" pRUEBA/>--%>
                         </td> 
                            <td >
                            <a class="btn btn-secondary" href="Administracion/Editar.aspx?id=<%# Eval("Id") %>" role="button">Editar</a>
                            <%--<asp:HyperLink id="aExample" runat="server" NavigateUrl="~/Eliminar.aspx?id=<%# Eval("Id") %>" pRUEBA/>--%>
                         </td>                               
                     </loggedintemplate>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
        <div class="tab-pane fade" id="pills-enviado" role="tabpanel" aria-labelledby="pills-enviado-tab">B</div>
        <div class="tab-pane fade" id="pills-entregado" role="tabpanel" aria-labelledby="pills-entregado-tab">C</div>
    </div>
    <div class="text-right">
        <a class="btn btn-secondary" runat="server" href="Administracion/Agregar.aspx" role="button">Agrega pedido</a>
    </div>


</asp:Content>
