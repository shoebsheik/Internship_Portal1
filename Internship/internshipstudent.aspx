<%@ Page Title="" Language="C#" MasterPageFile="~/studentpanel.Master" AutoEventWireup="true" CodeBehind="internshipstudent.aspx.cs" Inherits="Internship.internshipstudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style6 {
            margin-left: 39px;
        }
        .auto-style9 {
        width: 917px;
    }
        .auto-style10 {
            margin-left: 34px;
        }
        .auto-style11 {
            margin-left: 62px;
        }
        .auto-style12 {
            margin-left: 54px;
        }
        .auto-style13 {
            margin-left: 42px;
        }
        .auto-style14 {
            margin-left: 32px;
        }
        .auto-style15 {
            margin-left: 27px;
        }
        .auto-style16 {
            margin-left: 57px;
        }
        .auto-style17 {
            width: 84%;
            height: 240px;
            margin-bottom: 0px;
        }
        .auto-style18 {
            width: 684px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div style="border-style: solid; border-width: medium">

       &nbsp;&nbsp;

       <br />
&nbsp;<table class="auto-style2">
           <tr>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
               <td class="auto-style9">&nbsp;</td>
               <td>Welcome :
                   <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                   <br />
               </td>
           </tr>
       </table>

        
<div >
    <table class="auto-style17" style="background-color: #FEFDC0; border: 5px solid #ddd; margin: auto; padding: 20px 20px 10%; box-sizing: border-box; text-align: center; font-size: 17px;" class="auto-style5">
           <tr>
               <td class="auto-style18">&nbsp;
                   <br />
                   Student ID :
                   <asp:TextBox ID="txtid" runat="server" CssClass="auto-style10" Width="184px"></asp:TextBox>
                   &nbsp;&nbsp;<br />
                   <br />
&nbsp;Name&nbsp; :
                   <asp:TextBox ID="txtname" runat="server" CssClass="auto-style11"></asp:TextBox>
                   &nbsp;&nbsp;<br />
                   <br />
&nbsp;Branch :
                   <asp:TextBox ID="txtbranch" runat="server" CssClass="auto-style12"></asp:TextBox>
                   &nbsp;&nbsp;&nbsp;
                   <br />
                   <br />
                   Section :
                   <asp:TextBox ID="txtsection" runat="server" CssClass="auto-style13"></asp:TextBox>
                   &nbsp;&nbsp;<br />
                   <br />
&nbsp;Company :
                   <asp:TextBox ID="txtcompany" runat="server" CssClass="auto-style14"></asp:TextBox>
                   &nbsp;<br />
                   <br />
                   &nbsp; City :
                   <asp:TextBox ID="txtcity" runat="server" CssClass="auto-style15"></asp:TextBox>
                   &nbsp; &nbsp;<br />
                   <br />
&nbsp;Internship Type :<asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style16">
                       <asp:ListItem>2 week</asp:ListItem>
                       <asp:ListItem>3 - month</asp:ListItem>
                       <asp:ListItem>6 - Month</asp:ListItem>
                   </asp:DropDownList>
                   &nbsp;&nbsp;
                   <br />
                   <br />
                   Status :&nbsp;
                   <asp:Label ID="llstatus" runat="server" Text="Label"></asp:Label>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                   <br />
                   <asp:Button ID="btnsubmit" runat="server" CssClass="auto-style6" Text="Submit" Width="120px" OnClick="Button1_Click" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
               </td>
           </tr>
           </table>
</div>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
&nbsp;<br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       &nbsp;&nbsp;
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />

   </div>
</asp:Content>

