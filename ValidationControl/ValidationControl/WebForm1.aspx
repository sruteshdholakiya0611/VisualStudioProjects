<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Page</title>
    <style>
        *{
            font-family: Consolas;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div>  
        <asp:Label ID="Label1" runat="server" Style="top: 239px; left: 75px; position: absolute;  
            height: 22px; width: 128px" Text="Enter Age:"></asp:Label>  
           
        <asp:Label ID="Label2" runat="server" Style="top: 94px; left: 78px; position: absolute;  
            height: 22px; width: 128px" Text="Enter Name:"></asp:Label>  
     </div>  
     <asp:TextBox ID="TextBox1" runat="server" Style="top: 95px; left: 250px; position: absolute;  
        height: 22px; width: 128px"></asp:TextBox>  
     <p>  
        <asp:TextBox ID="TextBox4" runat="server" Style="top: 195px; left: 249px; position: absolute;  
            height: 22px; width: 127px"></asp:TextBox>  
     </p>  
     <p>  
        <asp:Label ID="Label3" runat="server" Style="top: 148px; left: 76px; position: absolute;  
            height: 22px; width: 128px" Text="Enter Password:"></asp:Label>  
     </p>  
     <p>  
        <asp:TextBox ID="TextBox3" runat="server" Style="top: 146px; left: 249px; position: absolute;  
            height: 22px; width: 127px" TextMode="Password"></asp:TextBox>  
     </p>  
     <p>  
        <asp:Label ID="Label4" runat="server" Style="top: 197px; left: 75px; position: absolute;  
            height: 22px; width: 128px" Text="Confirm Password:"></asp:Label>  
     </p>  
    <asp:TextBox ID="TextBox2" runat="server" Style="top: 236px; left: 250px; position: absolute;  
        height: 22px; width: 127px" TextMode="Password"></asp:TextBox>  
    <asp:CompareValidator ID="CompareValidator1" runat="server" Style="top: 197px; left: 522px;  
        position: absolute; height: 22px; width: 17px" ErrorMessage="CompareValidator"  
        ControlToCompare="TextBox2" ControlToValidate="TextBox3">*</asp:CompareValidator>  
    <p>  
        <asp:Button ID="Button1" runat="server" Style="top: 300px; left: 248px; position: absolute;  
            height: 40px; width: 100px; background-color: cornflowerblue; color: white; border:none; border-radius:5px; font-size: 1rem" Text="Login" />  
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Style="top: 196px;  
            left: 393px; position: absolute; height: 22px; width: 22px; color: red" ErrorMessage="Confirm Password mandatory & should match password"  
            ControlToValidate="TextBox3">*</asp:RequiredFieldValidator>  
        <asp:RangeValidator ID="RangeValidator1" runat="server" Style="top: 235px; left: 388px;  
            position: absolute; height: 22px; width: 156px; bottom: 288px; color: red" ErrorMessage="age between 18-100"  
            ControlToValidate="TextBox4" MaximumValue="100" MinimumValue="18" Type="Integer">*</asp:RangeValidator>  
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Style="top: 92px;  
            left: 393px; position: absolute; height: 22px; width: 156px; color: red" ErrorMessage="Name is required"  
            ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>  
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Style="top: 146px;  
            left: 391px; position: absolute; height: 22px; width: 156px; color: red" ErrorMessage="Password mandatory"  
            ControlToValidate="TextBox2">*</asp:RequiredFieldValidator>  
    </p>  
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="top: 390px;  
        left: 44px; position: absolute; height: 38px; width: 625px" />
    </form>
</body>
</html>
