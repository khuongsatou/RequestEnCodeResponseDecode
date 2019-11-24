<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuiPost.aspx.cs" Inherits="RequestReponse.GuiPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" action="NhanPost.aspx" method="post" runat="server">
        <div>
             <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            <asp:Button ID="btnGui" runat="server" Text="Gửi" />

        </div>
    </form>
</body>
</html>
