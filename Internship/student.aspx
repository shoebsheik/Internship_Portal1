<%@ Page Title="" Language="C#" MasterPageFile="~/hodpanel.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="Internship.student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            margin-left: 145px;
        }
    .auto-style4 {
        width: 140px;
        height: 42px;
        margin-left: 225px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="border-style: solid; border-width: medium">
     <div style="color: #FF0000; font-size: 22px; text-align: center">
         <br />
         Student Ragistertion
         <br />
         <br />
     </div>
 
        <div style="background-color: #FEFDC0; border: 5px solid #ddd; width: 50%; margin: auto; padding: 20px 20px 10%; box-sizing: border-box; text-align: center;">
                   <br />
       <br />
&nbsp;&nbsp; Student ID :
       <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
       <br />
       <br />
&nbsp;&nbsp; Name :
       <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
       <br />
       <br />
&nbsp;&nbsp; Branch :
        <asp:TextBox ID="txtbranch" runat="server"></asp:TextBox>
       <br />
&nbsp;&nbsp;
       <br />
&nbsp;&nbsp; Section :
        <asp:DropDownList ID="ddsection" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>D</asp:ListItem>
        </asp:DropDownList>
       <br />
       <br />
&nbsp;&nbsp; Mobile No :&nbsp;
       <asp:TextBox ID="txtmob" runat="server"></asp:TextBox>
       <br />
&nbsp;<br />
&nbsp;&nbsp; Session :
       <asp:TextBox ID="txtsession" runat="server" Enabled="False">2022-23</asp:TextBox>
       <br />
       <br />
&nbsp; Password :
       <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
       <br />
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Button2" runat="server" Text="Show" OnClick="Button2_Click" style="height: 26px" />
     
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;
     
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style4" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:TemplateField HeaderText="Student ID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server"  Text ='<%# Eval("studentid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text ='<%# Eval("name") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Branch">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text ='<%# Eval("branch") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Section">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text ='<%# Eval("section") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Mobile">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text ='<%# Eval("mobile") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Opertion ">
                    <ItemTemplate>
                        <asp:Button ID="Button3" runat="server" Text="Update"  OnClick="Button3_Click"/>
                        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
                       
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
     
   </div>

</asp:Content>
