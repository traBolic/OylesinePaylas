<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="KullaniciFormuWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width:50%;" align="center">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" AssociatedControlID="TextBox1" Text="Sporcunun Adı"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" AssociatedControlID="TextBox2" Text="Derecesi"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="Görüntüle" OnClick="Button1_Click" />
                    
                </td>
                <td align="center">
                    &nbsp;</td>
            </tr>
        </table><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
