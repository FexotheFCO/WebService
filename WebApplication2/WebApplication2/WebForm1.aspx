<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            width: 167px;
        }
        #Text1 {
            width: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Plata :
            <asp:Label ID="LblPlata" runat="server" Text="xxxx"></asp:Label>
        </div>
    <p>
&nbsp;<asp:Label ID="LblProducto1" runat="server" Text="LblProducto1"></asp:Label>
        &nbsp;<asp:Label ID="LblPrecio1" runat="server" Text="xxxx"></asp:Label>
        <asp:Label ID="LblCantidad1" runat="server" Text="xxxx"></asp:Label>
        <asp:Button ID="BtnCompra1" runat="server" OnClick="BtnCompra1_Click" Text="Button" />
        </p>
        <p>
        <asp:Label ID="LblProducto2" runat="server" Text="LblProducto2"></asp:Label>
            <asp:Label ID="LblPrecio2" runat="server" Text="xxxx"></asp:Label>
            <asp:Label ID="LblCantidad2" runat="server" Text="xxxx"></asp:Label>
        <asp:Button ID="BtnCompra2" runat="server" OnClick="BtnCompra2_Click" Text="Button" />
        </p>
        <p>
        <asp:Label ID="LblProducto3" runat="server" Text="LblProducto3"></asp:Label>
            <asp:Label ID="LblPrecio3" runat="server" Text="xxxx"></asp:Label>
            <asp:Label ID="LblCantidad3" runat="server" Text="xxxx"></asp:Label>
        <asp:Button ID="BtnCompra3" runat="server" OnClick="BtnCompra3_Click" Text="Button" />
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
    </body>
</html>