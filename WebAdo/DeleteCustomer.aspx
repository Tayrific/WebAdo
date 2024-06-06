<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCustomer.aspx.cs" Inherits="WebAdo.DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" /><br /><br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Enter customer ID you would like to delete: "></asp:Label><asp:TextBox ID="txtInputID" runat="server"></asp:TextBox>
            </div>     
            <div>
                <asp:Label ID="lblID" runat="server" Text="Customer ID: "></asp:Label><asp:Label ID="lblCustID" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lblCompName" runat="server" Text="Company Name: : "></asp:Label><asp:Label ID="lblCustCompName" runat="server" Text=""></asp:Label><br />
                <asp:Label ID="lblContactName" runat="server" Text="Contact Name: "></asp:Label><asp:Label ID="lblCustContactName" runat="server" Text=""></asp:Label><br />
                <asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="btnDel_Click" />
            </div>
        </div>
    </form>
</body>
</html>
