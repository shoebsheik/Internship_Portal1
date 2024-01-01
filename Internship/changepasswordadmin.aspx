<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel.Master" AutoEventWireup="true" CodeBehind="changepasswordadmin.aspx.cs" Inherits="Internship.changepasswordadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="border-style: solid; border-width: medium">

   <div style="background-color: #FEFDC0; border: 5px solid #ddd; width: 50%; margin: auto; padding: 20px 20px 10%; box-sizing: border-box;">
    <p><br /></p>
    <p style="text-align: center">
        &nbsp; User id :
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
    </p>
    <p style="text-align: center">
        &nbsp; Old Password :
        <asp:TextBox ID="txtoldpass" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p style="text-align: center">
        &nbsp; New Password :
        <asp:TextBox ID="txtnewpass" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p style="text-align: center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" ForeColor="Red" Text="update" OnClick="Button1_Click" />
        &nbsp;
    </p>
</div>




    </div>
</asp:Content>
