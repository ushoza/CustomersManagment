<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ColorChooser.aspx.cs" Inherits="ColorChooser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="tbColor" runat="server"></asp:TextBox>
    <ajaxToolkit:ColorPickerExtender ID="tbColor_ColorPickerExtender" runat="server" TargetControlID="tbColor" SampleControlID="tbColor" />
    <asp:Button ID="btnColor" runat="server" Text="Choose" OnClick="btnColor_Click" />
</asp:Content>

