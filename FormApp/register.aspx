<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="FormApp.register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <style>
        table { width: 100%; }
        td { padding: 10px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div>
   <h1 align="center">Registration Form</h1>
         
   <asp:Label ID="fname" runat="server" Text="Full Name:"></asp:Label>
       
   <asp:TextBox ID="txtfname" runat="server" MaxLength="100"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfname" ErrorMessage="Full Name is required." ForeColor="Red" ></asp:RequiredFieldValidator>
   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"ControlToValidate="txtfname"  ErrorMessage="Full Name must be alphanumeric."ValidationExpression="^[a-zA-Z0-9 ]*$"></asp:RegularExpressionValidator>  
    


</div>
</form>

</body>
   
  </html>