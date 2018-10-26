<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Opportunities.aspx.cs" Inherits="Opportunities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Opportunities</h1>
            <asp:Literal ID="ltlError" runat="server"></asp:Literal>
            <asp:Repeater ID="rptrOpportunities" runat="server">
                <ItemTemplate>
                    <table border="1" style="display: inline-block">
                        <tr>
                            <th colspan="2"><%#Eval("Name") %></th>
                        </tr>
                        <tr>
                            <td class="table-key">Emirate</td>
                            <td><%#Eval("Emirate") %></td>
                        </tr>
                        <tr>
                            <td class="table-key">Date</td>
                            <td><%# Convert.ToDateTime(Eval("StartDate")).ToString("d/M/yyyy") %> - <%# Convert.ToDateTime(Eval("EndDate")).ToString("d/M/yyyy") %></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>