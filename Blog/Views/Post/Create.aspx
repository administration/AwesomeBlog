﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="LeftContent" runat="server">

    <div class="post_add">
        <% using (Html.BeginForm("Create", "Post"))
           {%>
        <fieldset>
            <%= Html.Label("Tytul") %><br />
            <%= Html.TextBox("Tytul", "") %><br />

            <%= Html.Label("Tresc") %><br />
            <%= Html.TextBox("Tresc", "")%><br />

            <%= Html.Label("Status") %><br />
            <%= Html.CheckBox("Status", "")%><br />

            <%= Html.Label("Tagi") %><br />
            <%= Html.TextBox("Tagi", "")%><br />

            <%= Html.Label("Opis") %><br />
            <%= Html.TextBox("Opis", "")%><br />

            <input value="Dodaj" type="submit" />
        </fieldset>
        <% } %>
    </div>

</asp:Content>
