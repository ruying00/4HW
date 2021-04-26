<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownListShow.aspx.cs" Inherits="_4HW.DropdownListShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Area" runat="server" AutoPostBack="True"  Height="28px">
            </asp:DropDownList>
        </div>
        <asp:DropDownList ID="ddl_Place" runat="server"  >
        </asp:DropDownList>
    </form>
</body>
</html>
