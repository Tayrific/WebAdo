<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAdo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Add new Customer" OnClick="btnAdd_Click" />  
            <asp:Button ID="btnUpdate" runat="server" Text="Update Customer" OnClick="btnUpdate_Click" /> 
            <asp:Button ID="btnDelete" runat="server" Text="Delete Customer" OnClick="btnDelete_Click" />
            <br /> <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /> <br/>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
