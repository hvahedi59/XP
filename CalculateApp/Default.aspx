<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculateApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox runat="server" ID="txtOperation"> </asp:TextBox>
    <asp:Button ID="btnCalculate" runat="server" Text="=" OnClick="btnCalculate_Click" />
    <asp:Button ID="btnClear" runat="server" Text="C" OnClick="btnClear_Click" />
    <br />
    <asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" />
    <asp:Button ID="btnSubstract" runat="server" Text="-" OnClick="btnSubstract_Click" />
    <asp:Button ID="btnMultiple" runat="server" Text="*" OnClick="btnMultiple_Click" />
    <asp:Button ID="btnDivision" runat="server" Text="/" OnClick="btnDivision_Click" /><br />
    <asp:Button ID="btnSaveMemory" runat="server" Text="M+" OnClick="btnSaveMemory_Click" />
    <asp:Button ID="btnClearMemory" runat="server" Text="M-" />
    <asp:Button ID="btnReadMemory" runat="server" Text="MR" />
</asp:Content>
