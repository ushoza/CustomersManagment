<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImportCountries.aspx.cs" Inherits="ImportCountries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="FilterButton" runat="server" Text="Filter countries" OnClick="FilterButton_Click" />
        </div>
        <div class="importResult">
            <asp:Label ID="ImportResultLabel" runat="server" Text="" EnableViewState="false"></asp:Label>
        </div>
        <div>
            <asp:GridView ID="CountriesGridView" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="XmlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="PhoneNoFormat" HeaderText="PhoneNoFormat" SortExpression="PhoneNoFormat" />
                    <asp:BoundField DataField="DialingCountryCode" HeaderText="DialingCountryCode" SortExpression="DialingCountryCode" />
                    <asp:BoundField DataField="InternationalDialingCode" HeaderText="InternationalDialingCode" SortExpression="InternationalDialingCode" />
                    <asp:BoundField DataField="InternetTLD" HeaderText="InternetTLD" SortExpression="InternetTLD" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Countries.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
