<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ogrenciWebForm.aspx.cs" Inherits="WebApplication1.ogrenciWebForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type"content="text/html; charset = utf-8"/>
<title></title>
</head>
<body>
<form id="form1" runat="server">
<asp:Repeater ID="rptogrenci" runat="server">
<HeaderTemplate>
<table border="1">
<tr style="background-color:darkgreen;color:black">
<td>ogr_no</td>
<td>ad</td>
<td>soyad</td>
<td>bölüm</td>
<td>adres</td>
<td>cinsiyet</td>
<td>resim</td>
</tr>
</HeaderTemplate>
<ItemTemplate>
<tr style = "background-color:gainsboro" >
<td><%#Eval("ogr_no")%>"</td>
<td><%#Eval("ad")%>"</td>
<td><%#Eval("soyad")%>"</td>
<td><%#Eval("bölüm")%>"</td>
<td><%#Eval("adres")%>"</td>
<td><%#Eval("cinsiyet")%>"</td>
<td><%#Eval("resim")%>"</td>
</tr>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>
</form>
</body>
</html>
