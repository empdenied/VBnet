<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="RAlexander_Program_4._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rough Riders Rodeo -- Tickets</title>
    <style type="text/css">
        .labels
        {
            font-weight: bold;
        }
        .rightalign
        {
            position: absolute;
            right: 50%;
        }
        .newStyle1
        {
            
            float: right;
            position: absolute;
        }
        .newStyle2
        {
            float: right;
        }
        .relative
        {
            position: relative;
        }
        body
        {
            position: relative;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: relative; top: 0px; left: 0px; width: 100%;">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Image ID="imgHeader" runat="server" Height="156px" 
            ImageUrl="~/rodeologo.jpg" Width="658px" />
        <br />
        <div id="divLeft" style="position: absolute; left: 0px; width: 50%;">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Tickets" CssClass="labels"></asp:Label>
&nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddTickets" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CheckBox ID="cbAwards" runat="server" Text="Awards Ceremony?" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Font-Italic="True" 
                        Text="Note: Awards Ceremony access adds $10 per ticket"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Street Address" CssClass="labels"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbAddress" runat="server" Width="384px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="tbAddress" ErrorMessage="Please enter a value." 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="City/State/ZIP" CssClass="labels"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbCity" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tbState" runat="server" Width="38px"></asp:TextBox>
                    <asp:TextBox ID="tbZip" runat="server" Width="88px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Card Number" CssClass="labels"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbCardNumber" runat="server"></asp:TextBox>
                    <asp:DropDownList ID="ddCreditType" runat="server">
                        <asp:ListItem>American Express</asp:ListItem>
                        <asp:ListItem>Discover</asp:ListItem>
                        <asp:ListItem>Mastercard</asp:ListItem>
                        <asp:ListItem>Visa</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="tbCardNumber" ErrorMessage="Please enter a card number."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Expire Date (mm/yy)" 
                        CssClass="labels"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbExpire" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="tbExpire" ErrorMessage="Please enter a value." 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    
        </div>
        <div id="divRight" style="position: absolute; right: 0px; width: 50%">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" Visible="False">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Large" 
                            Text="Order Confirmation"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Number of Tickets"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTickets" runat="server" Text="Label" style=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Awards Ceremony"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblCeremony" runat="server" style="" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Billing Address"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" style="" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Amount Billed"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTotalBilled" runat="server" style="" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="lnkConfirm" runat="server" NavigateUrl="~/confirmation.aspx">Confirm Order</asp:HyperLink>
                    </td>
                    <td class="relative">
                        &nbsp;</td>
                </tr>
            </table>
<br />
<br />
<br />
<br />
        </ContentTemplate>
    </asp:UpdatePanel>
    
        </div>
        <br />
    
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
