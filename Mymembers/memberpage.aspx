<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="memberpage.aspx.cs" Inherits="Assignment4NEXT.Mymembers.memberpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Hello
        <asp:LoginName ID="LoginName1" runat="server" />
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="InstructorFirstName" HeaderText="InstructorFirstName" SortExpression="InstructorFirstName" />
                <asp:BoundField DataField="InstructorLastName" HeaderText="InstructorLastName" SortExpression="InstructorLastName" />
                <asp:BoundField DataField="SectionName" HeaderText="SectionName" SortExpression="SectionName" />
                <asp:BoundField DataField="SectionFee" HeaderText="SectionFee" SortExpression="SectionFee" />
                <asp:BoundField DataField="SectionStartDate" HeaderText="SectionStartDate" SortExpression="SectionStartDate" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KarateSchoolConnectionString1 %>" SelectCommand="SELECT Instructor.InstructorFirstName, Instructor.InstructorLastName, Section.SectionName, Section.SectionFee, Section.SectionStartDate FROM Instructor CROSS JOIN Section"></asp:SqlDataSource>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        HANNAH</p>
</asp:Content>
