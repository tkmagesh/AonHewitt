<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Greeting.aspx.vb" Inherits="GreetingApp.Greeting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%
        Dim vFirstName, vLastName, userFullName
        If (Request.Form("btnSubmit") = "Greet") Then
            
            Response.Write(Request.Form("hiddenData") & "<br/>")
            vFirstName = Request.Form("firstName")
            vLastName = Request.Form("lastName")
            If (vFirstName = "") Then
                Response.Write("Firstname cannot be empty")
            End If
            If (vLastName = "") Then
                Response.Write("LastName cannot be empty")
            End If
            userFullName = vFirstName & " " & vLastName

            Response.Write("Hi " & userFullName)
            If (Hour(Now) > 18) Then
                Response.Write(" ,Good Evening")
            Else
                Response.Write(" ,Good Morning")
            End If
        End If
	%>
	<form action="Greeting.aspx" method="post">
	<div>
		<span>First name</span>
		<input type="text" name="firstName" id="" value="<%=vFirstName%>">
		
	</div>
	<div>
		<span>Last name</span>
		<input type="text" name="lastName" id=""  value="<%=vLastName%>">
	</div>
	
	<input type="submit" name="btnSubmit" value="Greet">
	</form>
	
</body>
</html>
