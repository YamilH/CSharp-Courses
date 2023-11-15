<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ejemplo_web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    <style>
        .oculto{
            display: none;
        }
    </style>--%>

    <h1>Mock up</h1>
    <h4>Grilla de Defecto</h4>

    <div class="row">
        <div class="col">
            <asp:GridView runat="server" ID="dgvAutos" DataKeyNames="Id" OnSelectedIndexChanged="dgvAutos_SelectedIndexChanged" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>
                   <%-- <asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto" />--%>
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo"/>
                    <asp:BoundField HeaderText="Color" DataField="Color"/>
                    <asp:BoundField HeaderText="Usado" DataField="Usado"/>
                    <asp:BoundField HeaderText="Importado" DataField="Importado"/>
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado"/>
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado"/>

                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />

                </Columns>
            </asp:GridView>
            <a href="AutoForm.aspx">Agregar</a>
        </div>
    </div>


</asp:Content>
