<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="Ereditarieta.Input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Raggio: "></asp:Label>
            <asp:TextBox ID="Raggio" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Altezza: "></asp:Label>
            <asp:TextBox ID="Altezza" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Lato: "></asp:Label>
            <asp:TextBox ID="Lato" runat="server"></asp:TextBox>
            <asp:Label ID="Visualliza1" runat="server"></asp:Label>
            <asp:Label ID="Visualliza2" runat="server"></asp:Label>
            <asp:Button ID="Cerchio" runat="server" OnClick="Cerchio_Click" Text="Cerchio"/>
            <asp:Button ID="Rettangolo" runat="server" OnClick="Rettangolo_Click" Text="Rettangolo"/>
            <asp:Button ID="Quadrato" runat="server" OnClick="Quadrato_Click" Text="Quadrato"/>
            <asp:Button ID="Triangolo" runat="server" OnClick="Triangolo_Click" Text="Triangolo"/>
        </div>
    </form>
</body>
</html>
