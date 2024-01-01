<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel.Master" AutoEventWireup="true" CodeBehind="hodadmin.aspx.cs" Inherits="Internship.hodadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-left: 101px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div style="border-style: solid; border-width: medium">

  <div style="text-align: center; background-color: #FEFDC0; border: 10px solid #ddd; padding: 10px;">
    <p>
        <br />
        &nbsp;
    </p>
    <div style="border: 1px solid #ddd; padding: 10px;">
        <p>
            &nbsp;&nbsp;&nbsp; User id :&nbsp;
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp; Name of HOD :&nbsp;
            <asp:TextBox ID="txtnohod" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp; Email id :&nbsp;
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp; Mobile No :&nbsp;
            <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp; password :&nbsp;
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp; &nbsp;Department :&nbsp;
            <asp:DropDownList ID="dddept" runat="server">
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>IT</asp:ListItem>
                <asp:ListItem>CIVIL</asp:ListItem>
                <asp:ListItem>ETC</asp:ListItem>
                <asp:ListItem>MECH</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Show" OnClick="Button2_Click" />
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </div>
</div>



       <br />
       <br />



    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style2" Width="392px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:TemplateField HeaderText="Sno">
                <ItemTemplate>
                             <%#Container.DataItemIndex+1 %>  
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text ='<%# Eval("uerid") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NAME">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text ='<%# Eval("name") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EMAIL">
                 <ItemTemplate>
                     <asp:TextBox ID="TextBox2" runat="server" Text ='<%# Eval("email") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PASSWORD">
                 <ItemTemplate>
                     <asp:TextBox ID="TextBox3" runat="server" Text ='<%# Eval("password") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DEPARTMENT">
                 <ItemTemplate> 
                     <asp:DropDownList ID="dddept" runat="server" Text ='<%# Eval("department") %>'>
                         <asp:ListItem>CSE</asp:ListItem>
        <asp:ListItem>IT</asp:ListItem>
        <asp:ListItem>CIVIL</asp:ListItem>
        <asp:ListItem>ETC</asp:ListItem>
        <asp:ListItem>MECH</asp:ListItem>
                     </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="BUTTON">
                 <ItemTemplate>
                     <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />      <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
   </div>
</asp:Content>
