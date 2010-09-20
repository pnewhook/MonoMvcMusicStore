<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<MvcMusicStore.ViewModels.StoreIndexViewModel>" %>
<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="server">
	<title>Store</title>
</asp:Content>
<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2>Store Home</h2>
	
	<p>Browsing <%= Model.NumberOfGenres %> genres:</p>
	
	<ul> 
		<% foreach (string genreName in Model.Genres) { %> 
		<li> 
			<%= genreName %> 
		</li> 
		<% } %> 
	</ul> 
		
</asp:Content>
