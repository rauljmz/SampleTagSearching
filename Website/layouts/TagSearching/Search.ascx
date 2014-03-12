<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="Website.layouts.TagSearching.Search" %>
<%@ Register TagPrefix="sc" Namespace="Sitecore.Web.UI.WebControls" Assembly="Sitecore.Kernel" %>
<style>
    .left
    {
        float: left;
        width:450px;
    }
    .right
    {
         float:left;
    }
    .clear
    {
        clear:both;
    }
    .selected
    {
        font-weight:bold;
    }
</style>

<div>
    <asp:Label runat="server" Text="Search:" AssociatedControlID="ddSearch" />
    <asp:DropDownList runat="server" ID="ddSearch" ItemType="SampleTagSearching.ContentType.Tag" DataTextField="Name" DataValueField="ItemID" SelectMethod="ddSearch_GetData"></asp:DropDownList>
    <asp:Button runat="server" ID="btnSearch" Text="Search" OnClick="btnSearch_Click" />
</div>


<div class="left">
    <asp:Repeater runat="server" ItemType="SampleTagSearching.ContentType.SampleContent" ID="rptSearchResults">
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
</div>

<div class="right">
    <asp:Repeater runat="server" ID="rptFacets" ItemType="SampleTagSearching.ContentType.Facet">
        <HeaderTemplate>
            <h1>Facets</h1>
        </HeaderTemplate>
        <ItemTemplate>           
                <asp:LinkButton runat="server" Text=" <%#:Item.Value%>" OnClick="lkFacet_Click" ID="lkFacet" CssClass="<%#Item.Enabled %>" />
                (<%#:Item.Count %>)                   
            <br />
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="clear">
    <asp:Literal runat="server" ID="litTotal" />
</div>
