<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    MvcXaml
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><img src="<%: Url.Action("MirroredText", new {text = "Welcome to MvcXaml!"}) %>" /></h2>
    <p>
        To learn more about MvcXaml visit <a href="http://mvcxaml.codeplex.com" title="MvcXaml Project">http://MvcXaml.codeplex.com</a>.
    </p>
    
    <table>
        <tr>
            <td valign="top">
                <img src="<%: Url.Action("Test1ImageA") %>" />
                <br /><br />
                <img src="<%: Url.Action("Test1ImageB") %>" />        
                <br /><br />
                <img src="<%: Url.Action("BarGraph") %>" />
            </td>
            <td valign="top">
                <img src="<%: Url.Action("Person", new { id = 0 }) %>" />
                <br />
                <img src="<%: Url.RouteUrl(new { controller = "Home", action = "Person", id = 1}) %>" />
            </td>
        </tr>
    </table>
    
</asp:Content>
