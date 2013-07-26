<!doctype html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Greeting App</title>
</head>
<body>
	<%
		dim vFirstName,vLastName 
		if (request.form("btnSubmit") = "Greet") then
			response.write(request.form("hiddenData")) & "<br/>"
			vFirstName = request.form("firstName")
			vLastName = request.form("lastName")
			if (vFirstName = "" ) then
				response.write("Firstname cannot be empty" )
			end if
				if (vLastName = "" ) then
				response.write("LastName cannot be empty" )
			end if
			userFullName = vFirstName & " " & vLastName

			response.write("Hi " & userFullName)
			if (hour(now) > 18) then
				response.write(" ,Good Evening")
			else
				response.write(" ,Good Morning")
			end if	
		end if
	%>
	<form action="GreetingApp.asp" method="post">
	<div>
		<span>First name</span>
		<input type="text" name="firstName" id="" value="<%=vFirstName%>">
		
	</div>
	<div>
		<span>Last name</span>
		<input type="text" name="lastName" id=""  value="<%=vLastName%>">
	</div>
	<input type="hidden" name="hiddenData" value="10000">
	<input type="submit" name="btnSubmit" value="Greet">
	</form>
	
</body>
</html>