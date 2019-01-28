<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ThreetierArc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 158%;
            height: 259px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 217px;
        }
        .auto-style4 {
            height: 23px;
            text-align: center;
        }
        .auto-style5 {
            width: 217px;
            text-align: left;
        }
    </style>
</head>
<body style="height: 140px; width: 195px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="3">3 Tier Example</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">Name :</td>
                    <td class="auto-style3" id="txtname">
                        
                        
                        <asp:TextBox ID="TxtName1" runat="server" OnTextChanged="TxtName1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">City :</td>
                    <td class="auto-style3" id="txtcity">
                        <asp:TextBox ID="TxtCity1" runat="server" OnTextChanged="TxtCity1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">Email :</td>
                    <td class="auto-style3" id="txtemail">
                        <asp:TextBox ID="TxtEmail1" runat="server" OnTextChanged="TxtEmail1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 28px" Text="save1" Width="90px" Height="28px" />
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="210px">
        </asp:GridView>
    </form>
</body>
</html>
