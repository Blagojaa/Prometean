<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prometean.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" runat="server" Text="Log in:"></asp:Label>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Log in:" OnClick="Button1_Click" />
    <br /><br />
     <asp:Label ID="Label4" runat="server" Text="Gold cost:" Visible="false"></asp:Label>
 <br /><br />
 <asp:Label ID="Label5" runat="server" Text="MythunitsID " Visible="false"></asp:Label>
 <asp:TextBox ID="TextBox3" runat="server" Visible="false"></asp:TextBox>
 <br /><br />
 <asp:Label ID="Label6" runat="server" Text="Gold cost" Visible="false"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" Visible="false"></asp:TextBox>
 <br /><br />
 <asp:Button ID="Button2" runat="server" Text="Insert cost" Visible="false" OnClick="Button2_Click"/>
    <br /><br />
    <asp:GridView ID="GridView1" runat="server" CssClass="table"></asp:GridView>
</asp:Content>





