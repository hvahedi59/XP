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
    <asp:Button ID="btnReadMemory" runat="server" Text="MR" /><br />
    <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" />
    <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" />
    <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" />
    <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" />
    <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" />
    <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" />
    <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" />
    <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" />
    <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" />
    <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" />
     <asp:Button ID="btnDot" runat="server" Text="." OnClick="btnDot_Click" />
    <br />
    <asp:Button ID="btnSin" runat="server" Text="Sin" OnClick="btnSin_Click"  />


</asp:Content>
