<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adder.aspx.cs" Inherits="SessionDemo.Adder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:TextBox runat="server" ID="TxtNumber"></asp:TextBox>    
        <asp:Button Text="Add" runat="server" ID="BtnAdd" OnClick="BtnAddClick"/>
        <asp:Button Text="Show Result" runat="server" ID="BtnShowResult" OnClick="BtnShowResultClick" />
        <asp:Label Text="" ID="LblResult" runat="server" />
        <asp:Button Text="Reset Session" runat="server" OnClick="BtnResetSessionClick" />
        <br />
        <div>User count : <%=Application["UserCount"] %></div>
    </div>
    </form>
</body>
</html>
