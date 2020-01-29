﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Countries.aspx.cs" Inherits="Countries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" DataSourceID="EntityDataSource1">
                        <Columns>
                            <asp:CommandField ShowEditButton="True" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=CustomerManagementEntities" DefaultContainerName="CustomerManagementEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Countries" EntityTypeFilter="Country">
            </asp:EntityDataSource>

        </div>
    </form>
</body>
</html>