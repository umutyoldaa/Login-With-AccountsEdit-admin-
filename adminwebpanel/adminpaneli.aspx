<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminpaneli.aspx.cs" Inherits="adminwebpanel.adminpaneli" %>

<!DOCTYPE html>
<html>
<head>
    <title>ADMIN PANEL</title>

    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-grid.css" rel="stylesheet" />
    <style>
        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            background-color: #333;
        }

        li {
            float: left;
        }

            li a {
                display: block;
                color: white;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
            }

                li a:hover {
                    background-color: #111;
                }

        table, td, th {
            border: 1px solid black;
        }

        table {
            border-collapse: collapse;
            width: 100%;
        }

        th {
            height: 70px;
        }

        btn {
            border: 1px solid black;
        }

            btn btn-danger {
                color: red;
            }

            btn btn-succes {
                color: lightgreen;
            }
    </style>
</head>
<body>

    <form id="form1" runat="server">

        <ul>
            <li><a class="active" href="adminpaneli.aspx">Home</a></li>
            <li><a href="#">User</a></li>
            <li><a href="#">Edit</a></li>
            <li><a href="giris.aspx">Signout</a></li>
        </ul>
        <div style="margin-top: 15px">
            <table style="border: 1px solid black">
                <tr>

                    <th>ID</th>
                    <td>USERNAME</td>
                    <td>PASSWORD</td>
                    <td>DELETE</td>
                    <td>EDIT</td>

                </tr>

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("ID") %></th>
                            <td><%#Eval("KULLANICI") %></td>
                            <td><%#Eval("SIFRE") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"ADMINSIL.aspx?ID="+Eval("ID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"ADMINGUNCELLE.aspx?ID="+Eval("ID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Edit</asp:HyperLink></td>

                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                     <tr>

            </table>
        </div>


    </form>

</body>
</html>



