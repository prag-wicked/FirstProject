<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BookLibrary.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
                 <asp:Label ID="Label1" runat="server" Text="Serach by Book Name"></asp:Label>
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                 <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                 <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
             </div>
              <div>             
                <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblAuthor" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblGenre" runat="server" Text=""></asp:Label>
                <asp:Image ID="imgBookCover" runat="server" />                       
              </div>
        </div>
    </form>     
</body>
</html>
