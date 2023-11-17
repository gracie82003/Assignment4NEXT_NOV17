<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="instructorpage.aspx.cs" Inherits="Assignment4NEXT.Instructors.instructorpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="InstructorID">
        <Columns>
            <asp:BoundField DataField="InstructorID" HeaderText="InstructorID" ReadOnly="True" SortExpression="InstructorID" />
            <asp:BoundField DataField="InstructorFirstName" HeaderText="InstructorFirstName" SortExpression="InstructorFirstName" />
            <asp:BoundField DataField="InstructorLastName" HeaderText="InstructorLastName" SortExpression="InstructorLastName" />
            <asp:BoundField DataField="InstructorPhoneNumber" HeaderText="InstructorPhoneNumber" SortExpression="InstructorPhoneNumber" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KarateSchoolConnectionString1 %>" SelectCommand="SELECT * FROM [Instructor]"></asp:SqlDataSource>
</p>
<p>
    aghdfAJDFajdfAJDFajdfAJDFajdf</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
