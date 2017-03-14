<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" BorderColor="#0066FF" Font-Bold="True" ForeColor="#00CC00"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Botao" OnClick="Button1_Click" BorderStyle="Double" BorderColor="#0066FF" />
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Primeiro Nome: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Ultimo Nome: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Listar Via DB" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Inserir" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Update" OnClick="Button5_Click" />
        <asp:Button ID="Button6" runat="server" Text="Delete" OnClick="Button6_Click" />

        <br /><br />

        <asp:Button ID="Button7" runat="server" Text="Listar" OnClick="Button7_Click" />
        
        <br />
        
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
        
        <br /><br />

        <asp:Label ID="Label1" runat="server" Text="" BorderColor="#FF9900"></asp:Label>
    </div>
    </form>
</body>
</html>
