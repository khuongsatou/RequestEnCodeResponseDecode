<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gui.aspx.cs" Inherits="RequestReponse.Gui" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNhap" runat="server"></asp:TextBox>
            <asp:Button ID="btnGui" runat="server" Text="Gửi" OnClick="BtnGui_Click" />

        </div>
    </form>
</body>
</html>
