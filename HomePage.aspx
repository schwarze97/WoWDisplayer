<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WoWDisplayer.HomePage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 aria-multiline="True">World of Warcraft</h1>
        <h1 aria-multiline="True">Character Profile Displayer</h1>
        <p class="lead">
            &nbsp;</p>
        <p class="lead"></p>
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="#FF9900" BorderStyle="Solid" BorderWidth="10px" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="308px" style="text-align: justify; margin-left: 201px" Width="478px">
            &nbsp;&nbsp;&nbsp;&nbsp;<ul>
                <li>
                    <address>
                        Region:<asp:DropDownList ID="RegionDropDown" runat="server" OnSelectedIndexChanged="RegionDropDown_SelectedIndexChanged" Width="180px" AutoPostBack="True">
                            <asp:ListItem>Please Select</asp:ListItem>
                        </asp:DropDownList>
                    </address>
                </li>
                <li>
                    <address>
                        Realm Slug:<asp:DropDownList ID="RealmDropDown" runat="server" OnSelectedIndexChanged="RealmDropDown_SelectedIndexChanged" Width="180px" AppendDataBoundItems="True" AutoPostBack="True">
                            <asp:ListItem>Please Select</asp:ListItem>
                        </asp:DropDownList>
                    </address>
                </li>
                <li>
                    <address>
                        Locale:<asp:TextBox ID="LocaleTextBox" runat="server" ForeColor="Black" OnTextChanged="LocaleTextBox_TextChanged"></asp:TextBox>
                    </address>
                </li>
                <li>
                    <address>
                        Character Name:<asp:TextBox ID="CharacterNameTextBox" runat="server" ForeColor="Black" OnTextChanged="CharacterNameTextBox_TextChanged"></asp:TextBox>
                    </address>
                </li>
                <li>
                    <address>
                        Namespace:<asp:TextBox ID="NamespaceTextBox" runat="server" ForeColor="Black" OnTextChanged="NamespaceTextBox_TextChanged"></asp:TextBox>
                    </address>
                </li>
            </ul>
        </asp:Panel>
        <p class="lead">&nbsp;</p>
		<p class="lead">Click on the button below to obtain information about a World of Warcraft character.</p>
		<p class="lead">&nbsp;</p>
        <p>
			<asp:Button ID="GetInformationButton" runat="server" Height="52px" OnClick="GetInformationButton_Click" Text="Get Information" Width="195px" />
		</p>
		<p>&nbsp;</p>
		<p>ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="IDTextBox" runat="server" OnTextChanged="IDTextBox_TextChanged"></asp:TextBox>
&nbsp;</p>
		<p>Name:&nbsp;&nbsp;
			<asp:TextBox ID="NameTextBox" runat="server" OnTextChanged="IDTextBox_TextChanged"></asp:TextBox>
		</p>
		<p>Level:&nbsp;&nbsp;&nbsp;
			<asp:TextBox ID="LevelTextBox" runat="server" OnTextChanged="LevelTextBox_TextChanged"></asp:TextBox>
		</p>
		<p>&nbsp;</p>
		<p>&nbsp;</p>
    </div>

    </asp:Content>
