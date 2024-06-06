<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="WebAdo.AddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Customer</title>

    <style>
         .form-container {
            display: flex;
            flex-direction: column;
            align-items: center;
        }
         .form-container div {
            margin-bottom: 10px;
        }

        .form-container label {
            width: 150px;
            text-align: right;
            margin-right: 10px;
        }

        .form-container input, .form-container select {
            max-width: 300px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />

        </div>
        <br />
         <div class="form-container">
            <div>
                <asp:Label ID="customerID" runat="server" Text="CustomerID: "></asp:Label> <br />
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="companyName" runat="server" Text="Company Name: "></asp:Label> <br />
                <asp:TextBox ID="txtCompName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="contactName" runat="server" Text="Contact Name: "></asp:Label> <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="contactTitle" runat="server" Text="Contact Title: "></asp:Label> <br />
                <asp:TextBox ID="txtConTitle" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="address" runat="server" Text="Address: "></asp:Label> <br />
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="city" runat="server" Text="City: "></asp:Label> <br />
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            </div>
            <div >
                <asp:Label ID="postCode" runat="server" Text="Postal code: "></asp:Label> <br />
                <asp:TextBox ID="txtPostal" runat="server"></asp:TextBox>
            </div>
            <div >
                <asp:Label ID="country" runat="server" Text="Country: "></asp:Label> <br />
                <asp:DropDownList ID="listCountry" runat="server"></asp:DropDownList>
            </div>
            <div >
                <asp:Label ID="phone" runat="server" Text="Phone: "></asp:Label> <br />
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </div>
             <div>
             <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
             </div>
        </div>

    </form>
</body>
</html>
