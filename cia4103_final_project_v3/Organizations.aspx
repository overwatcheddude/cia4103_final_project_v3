<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Organizations.aspx.cs" Inherits="Organizations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="dlOrganizations" runat="server">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td rowspan="5" class="auto-style2">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "images/" + Eval("Name") + ".png"%>' Height="120" Width="120" />
                            </td>
                            <td><strong>Name: </strong>
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("Name") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>Description:</strong><asp:Literal ID="Literal2" runat="server" Text='<%# Eval("Description") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>Address: </strong>
                                <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("Address") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>Contact Number: </strong>
                                <asp:Literal ID="Literal4" runat="server" Text='<%# Eval("ContactNumber") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>Email: </strong>
                                <asp:Literal ID="Literal5" runat="server" Text='<%# Eval("Email") %>'></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
