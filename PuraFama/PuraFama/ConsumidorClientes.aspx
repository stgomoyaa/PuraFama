<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumidorClientes.aspx.cs" Inherits="PuraFama.ConsumidorClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Consumidor Clientes</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>

    <h1 class="titulo">Consumidor Clientes</h1>

    <hr />

    <div id="wrapper">
        <nav class="navegacion-principal contenedor">
            <form id="form1" runat="server">
                <div style="height: 2417px; font-family: Dubai;">

                    <div>
                        <asp:GridView ID="grd_leerCliente" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="341px" Width="392px" Align="center">
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SortedAscendingCellStyle BackColor="#EDF6F6" />
                            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                            <SortedDescendingCellStyle BackColor="#D6DFDF" />
                            <SortedDescendingHeaderStyle BackColor="#002876" />
                        </asp:GridView>
                    </div>


                    <br />

                    <hr class="dividir" />

                    <br />

                    <div class="datos">
                        <strong>
                            <asp:Label ID="Label5" runat="server" Text="1) Crear Cliente"></asp:Label></strong>
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Rut cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_rutCliente" runat="server" OnTextChanged="txt_rutCliente_TextChanged" Width="156px" align="right"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Nombre cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_nombreCliente" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Telefono cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_telefonoCliente" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Gastos cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_gastosCliente" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btn_CrearCliente" runat="server" OnClick="btn_CrearCliente_Click" Text="Crear Cliente" Width="132px" />

                    </div>

                    <br />

                    <hr class="dividir" />

                    <br />

                    <div class="datos">
                        <strong>
                            <asp:Label ID="Label6" runat="server" Text="2) Leer cliente por rut"></asp:Label></strong>
                        <br />
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Rut Cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_rutClienteFiltrar" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btn_leerCliente" runat="server" OnClick="btn_leerCliente_Click" Text="Leer Cliente por rut" Width="132px"/>
                    </div>

                    <br />

                    <hr class="dividir" />

                    <br />

                    <div class="datos">
                        <strong>
                            <asp:Label ID="Label8" runat="server" Text="3) Actualizar cliente con rut"></asp:Label></strong>
                        <br />
                        <br />
                        <asp:Label ID="Label9" runat="server" Text="Rut del cliente que quieres actualizar"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_rutClienteActualizar" runat="server" OnTextChanged="txt_rutClienteActualizar_TextChanged" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label10" runat="server" Text="Nombre cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_nombreClienteActualizar" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label11" runat="server" Text="Telefono cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_telefonoClienteActualizar" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label12" runat="server" Text="Gastos cliente"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_gastosClienteActualizar" runat="server" Width="156px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btn_actualizarCliente" runat="server" OnClick="btn_actualizarCliente_Click" Text="Actualizar Cliente" Width="156px" />
                    </div>

                    <br />

                    <hr class="dividir" />

                    <br />

                    <div class="datos">

                        <strong>
                            <asp:Label ID="Label13" runat="server" Text="4) Eliminar cliente con rut"></asp:Label>
                        </strong>
                        <br />
                        <br />
                        <asp:Label ID="Label14" runat="server" Text="Rut del cliente que quieres eliminar"></asp:Label>
                        <br />
                        <asp:TextBox ID="txt_rutClienteEliminar" runat="server" OnTextChanged="txt_rutClienteEliminar_TextChanged" Width="132px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btn_eliminarCliente" runat="server" OnClick="btn_eliminarCliente_Click" Text="Eliminar Cliente" Width="156px" />

                    </div>

                    <br />

                    <hr class="dividir" />

                    <br />

                </div>

            </form>
    </div>
</body>
</html>
