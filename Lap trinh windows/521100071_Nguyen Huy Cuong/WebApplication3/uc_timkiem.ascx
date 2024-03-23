<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_timkiem.ascx.cs" Inherits="WebApplication3.uc_timkiem" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        margin-right: 0px;
    }
    .auto-style2 {
        width: 97px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">Tên sách</td>
        <td>
            <asp:TextBox ID="txttensach" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Tên tác giả</td>
        <td>
            <asp:TextBox ID="txttentacgia" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<asp:Button ID="btntim" runat="server" OnClick="btntim_Click" Text="Tìm kiếm" />

