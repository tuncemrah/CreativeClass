<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DersWebForm.aspx.cs" Inherits="WebApplication1.DersWebForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type"content="text/html; charset = utf-8"/>
<title></title>
</head>
<body>
<form id="form1" runat="server">
<asp:Repeater ID="rptDers" runat="server">
<HeaderTemplate>
<table border="1">
<tr style="background-color:darkgreen;color:black">
<td>derskod</td>
<td>dersad</td>
</tr>
</HeaderTemplate>
<ItemTemplate>
<tr style = "background-color:gainsboro" >
<td><%#Eval("derskod")%>"</td>
<td><%#Eval("dersad")%>"</td>
</tr>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>
</form>
</body>
</html>
