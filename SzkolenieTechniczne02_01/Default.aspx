<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SzkolenieTechniczne02_01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zajęcia pierwsze</title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <div >
            <asp:Label ID="lblName" runat="server" ></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Label ID="lblAge" runat="server" ></asp:Label>
            <asp:DropDownList ID="ddlAge" runat="server"></asp:DropDownList>
            <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click"/>

            <div >
                <asp:Panel ID="panelInfo" Visible="False" runat="server">
                    <asp:Label ID="lblInfo" runat="server" ></asp:Label>
                    <asp:TextBox ID="txtInfo" TextMode="MultiLine" Rows="4" runat="server"></asp:TextBox>
                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" />
                </asp:Panel>
            </div>
        </div>
    </div>
</form>
</body>
</html>