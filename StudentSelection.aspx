<%@ Page Title="" Language="C#" MasterPageFile="~/InClassTemplate.Master" AutoEventWireup="true" CodeBehind="StudentSelection.aspx.cs" Inherits="CIS484_Lab3.StudentSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox ID="lstStudents" runat="server" OnSelectedIndexChanged ="lstStudents_SelectedIndexChanged" AutoPostBack ="true">
        <asp:ListItem Text ="Sarah Sarason" Value="sarason@dukes.jmu.edu"></asp:ListItem>
        <asp:ListItem Text ="Jessi James" Value="jjames@dukes.jmu.edu"></asp:ListItem>
    </asp:ListBox>
    <asp:TextBox ID="txtSelectedStudent" runat="server"></asp:TextBox>
    <asp:Label ID="lblPostBack" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btnViewStudentDetails" runat="server" Text="View Details" OnClick="btnViewStudentDetails_Click" />
</asp:Content>
