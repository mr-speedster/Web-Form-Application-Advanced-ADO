<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCreateTable.aspx.cs" Inherits="WebApplicationAdvancedADO.WebFormCreateTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="StudentGridView" runat="server"></asp:GridView>
            <asp:GridView ID="DepartmentGridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
