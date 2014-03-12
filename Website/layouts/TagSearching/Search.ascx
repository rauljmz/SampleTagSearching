<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="Website.layouts.TagSearching.Search" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<div>
    <asp:Label runat="server" Text="Search:" AssociatedControlID="ddSearch" />
    <asp:DropDownList runat="server" ID="ddSearch" ItemType="SampleTagSearching.ContentType.Tag" DataTextField="Name" DataValueField="ItemID" SelectMethod="ddSearch_GetData"></asp:DropDownList>
    <asp:Button runat="server" ID="btnSearch" Text="Search" OnClick="btnSearch_Click" />
</div>


<asp:Repeater runat="server" ItemType="SampleTagSearching.ContentType.SampleContent"  ID="rptSearchResults">
    <HeaderTemplate>
        <h1>search results</h1>
    </HeaderTemplate>
    <ItemTemplate>
        <strong><%#:Item.Title %></strong><br />
        <%#:Item.Text %>
        <br />
        <br />
    </ItemTemplate>
</asp:Repeater>
  <asp:Literal runat="server" ID="litTotal" />