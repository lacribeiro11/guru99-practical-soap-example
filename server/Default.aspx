﻿<%@ Page Language="C#" Inherits="server.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
            <br />
            <a href="service.asmx">Service</a>
	</form>
</body>
</html>
