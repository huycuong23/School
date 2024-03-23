<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_left.ascx.cs" Inherits="WebApplication3.WebUserControl1" %>
<asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~theoloaisach.aspx?maloai=" + Eval("Ma_dausach") %>' Text='<%# Eval("Ten_dausach") %>'></asp:HyperLink>
    </ItemTemplate>
</asp:DataList>
<asp:Label ID="lblthongbao" runat="server" Text="Label"></asp:Label>

