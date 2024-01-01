<%@ Page Title="" Language="C#" MasterPageFile="~/hodpanel.Master" AutoEventWireup="true" CodeBehind="incharge.aspx.cs" Inherits="Internship.incharge" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 100%;
    }
        .auto-style7 {
            margin-left: 194px;
        }
        .auto-style8 {
            width: 557px;
            height: 242px;
        margin-left: 0px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="border-style: solid; border-width: medium; text-align: center;">

     <div style="text-align: center; font-size: 19px; color: #FF0000">
         <br />
         Incharge Registration
     </div>
        <br />
        <br />

      <div style="background-color: #FEFDC0; border: 5px solid #ddd; width: 50%; margin: auto; padding: 20px 20px 10%; box-sizing: border-box; text-align: center;">
            <table class="auto-style8">
            <tr>
                <td style="text-align: center">Incharge Id :&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;<br />
                    <br />
&nbsp;Name : &nbsp;<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp; 
                    <br />
                    <br />
                    Branch : &nbsp;<asp:TextBox ID="txtbranch" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;<br />
                    <br />
&nbsp;Mobile : &nbsp;<asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                    <br />
                    <br />
&nbsp;Section Allotment : &nbsp;<asp:DropDownList ID="ddsection" runat="server">
                        <asp:ListItem>A</asp:ListItem>
                        <asp:ListItem>B</asp:ListItem>
                        <asp:ListItem>C</asp:ListItem>
                        <asp:ListItem>D</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
&nbsp; Password : 
                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    <br />
                    <br />
                </td>
            </tr>
            </table>
     
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Show" OnClick="Button2_Click" />
           </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style7">
            <Columns>
                <asp:TemplateField HeaderText="Sno">
                    <ItemTemplate>
                           <%#Container.DataItemIndex+1 %>                         
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text ='<%# Eval("inchargeid") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NAME">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text ='<%# Eval("name") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BRANCH">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text ='<%# Eval("branch") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="MOBILE">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text ='<%# Eval("mobile") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="SECTION">
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Text ='<%# Eval("section") %>'>
                        <asp:ListItem>A</asp:ListItem>
                        <asp:ListItem>B</asp:ListItem>
                        <asp:ListItem>C</asp:ListItem>
                        <asp:ListItem>D</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="OPERTION ">
                    <ItemTemplate>
                        <asp:Button ID="Button3" runat="server" Text="EDIT" OnClick="Button3_Click" />  <asp:Button ID="Button4" runat="server" Text="DELETE"  OnClick="Button4_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
