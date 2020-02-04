<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleCalc.aspx.cs" Inherits="SimpleCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:TextBox ID="tbOp1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbOp1" Display="Dynamic" ErrorMessage="Введите первое число" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tbOp1" Display="Dynamic" ErrorMessage="Введите число" Type="Double" ForeColor="Red" Operator="DataTypeCheck">*</asp:CompareValidator>
                    <asp:Label ID="Label1" runat="server" Text="+"></asp:Label>
                    <asp:TextBox ID="tbOp2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbOp2" Display="Dynamic" ErrorMessage="Введите второе число" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="tbOp2" Display="Dynamic" ErrorMessage="Введите число" Type="Double" ForeColor="Red" Operator="DataTypeCheck">*</asp:CompareValidator>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    
                    <asp:Button ID="btnSum" runat="server" Text="=" OnClick="btnSum_Click" />
                    <asp:Label ID="lbResult" runat="server" Text="Результат"></asp:Label>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>
           
            
        </div>
    </form>
</body>
</html>
