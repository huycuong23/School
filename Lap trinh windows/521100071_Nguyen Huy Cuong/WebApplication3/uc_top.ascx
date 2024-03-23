<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_top.ascx.cs" Inherits="WebApplication3.WebUserControl2" %>
<style type="text/css">
    .auto-style1 {
        text-align: center;
    }
</style>

<p class="auto-style1">
    <asp:HyperLink ID="HyperLink1" runat="server">Trang chủ</asp:HyperLink>
&nbsp;||
    <asp:HyperLink ID="HyperLink2" runat="server">Đăng kí</asp:HyperLink>
&nbsp;||
    <asp:HyperLink ID="HyperLink3" runat="server">Đăng nhập </asp:HyperLink>
&nbsp;||
    <asp:HyperLink ID="HyperLink4" runat="server">Liên hệ</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblchaomung" runat="server" Text="Chào Mừng bạn"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnthoat" runat="server" Text="Thoát" />
</p>

