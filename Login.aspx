<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WoWDisplayer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

ul,
ol {
  margin-top: 0;
  margin-bottom: 10px;
}
* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}
  *,
  *:before,
  *:after {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
  }
  address {
  margin-bottom: 20px;
  font-style: normal;
  line-height: 1.42857143;
    margin-left: 40px;
}
input,
select,
textarea {
    max-width: 280px;
}


input,
button,
select,
textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}
button,
select {
  text-transform: none;
}
button,
input,
optgroup,
select,
textarea {
  color: #000000;
  margin: 0;
}
input {
  line-height: normal;
}
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;<asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="#FF9900" BorderStyle="Solid" BorderWidth="10px" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="308px" style="text-align: justify; margin-left: 201px" Width="478px">
            &nbsp;&nbsp;&nbsp;&nbsp;<p>
                    &nbsp;Token:&nbsp;
                    <asp:TextBox ID="TokenTextBox" runat="server" ForeColor="Black" OnTextChanged="TokenTextBox_TextChanged"></asp:TextBox>
                </p>
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p class="auto-style1">
                    <asp:Button ID="ConfirmTokenButton" runat="server" OnClick="ConfirmTokenButton_Click" Text="Confirm Token" />
                </p>
        </asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
