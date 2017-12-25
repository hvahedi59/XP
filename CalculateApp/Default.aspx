<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculateApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    
    <asp:TextBox runat="server" ID="txtOperation"> </asp:TextBox>
    <br />
     <asp:Button ID="btnSin"  Width ="40" runat="server" Text="Sin" OnClick="btnSin_Click"  />
    <asp:Button ID="btnCalculate" Width ="40" runat="server" Text="=" OnClick="btnCalculate_Click" />
    <asp:Button ID="btnClear" Width ="40" runat="server" Text="C" OnClick="btnClear_Click" />
    <br />
    <asp:Button ID="btnPlus" Width ="40" runat="server" Text="+" OnClick="btnPlus_Click" />
    <asp:Button ID="btnSubstract" Width ="40" runat="server" Text="-" OnClick="btnSubstract_Click" />
    <asp:Button ID="btnMultiple" Width ="40" runat="server" Text="*" OnClick="btnMultiple_Click" />
    <asp:Button ID="btnDivision" Width ="40" runat="server" Text="/" OnClick="btnDivision_Click" /><br />
    <asp:Button ID="btnSaveMemory" Width ="40" runat="server" Text="M+" OnClick="btnSaveMemory_Click" />
    <asp:Button ID="btnClearMemory" Width ="40" runat="server" Text="M-" />
    <asp:Button ID="btnReadMemory" Width ="40" runat="server" Text="MR" /><br />
   
   
    <asp:Button ID="btn7" Width ="40" runat="server" Text="7" OnClick="btn7_Click" />
    <asp:Button ID="btn8" Width ="40" runat="server" Text="8" OnClick="btn8_Click" />
    <asp:Button ID="btn9" Width ="40" runat="server" Text="9" OnClick="btn9_Click" />
    <br />
     <asp:Button ID="btn4" Width ="40" runat="server" Text="4" OnClick="btn4_Click" />
    <asp:Button ID="btn5"  Width ="40" runat="server" Text="5" OnClick="btn5_Click" />
    <asp:Button ID="btn6" Width ="40"  runat="server" Text="6" OnClick="btn6_Click" />
    <br />
     <asp:Button ID="btn1" Width ="40"  runat="server" Text="1" OnClick="btn1_Click" />
    <asp:Button ID="btn2" Width ="40"  runat="server" Text="2" OnClick="btn2_Click" />
    <asp:Button ID="btn3" Width ="40"  runat="server" Text="3" OnClick="btn3_Click" />
    <br />

    <asp:Button ID="btn0" Width ="40"  runat="server" Text="0" OnClick="btn0_Click" />
     <asp:Button ID="btnDot"  Width ="40" runat="server" Text="." OnClick="btnDot_Click" />
    <br />
   


</asp:Content>
