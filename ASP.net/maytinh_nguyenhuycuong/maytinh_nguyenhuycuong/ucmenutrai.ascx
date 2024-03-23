<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucmenutrai.ascx.cs" Inherits="maytinh_nguyenhuycuong.ucmenutrai" %>
<asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# ~/maytheoloai/Eval("mamay") %>' Text='<%# Eval("tenmay") %>'></asp:HyperLink>
    </ItemTemplate>
</asp:DataList>

