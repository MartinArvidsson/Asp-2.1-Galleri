<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Galleriet_2._1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server"></asp:Repeater>
        <asp:FileUpload ID="FileUploader" runat="server" />
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator" 
            runat="server" ErrorMessage="RequiredFieldValidator" 
            Display="Dynamic" 
            ControlToValidate="FileUploader">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="RegExValidator" 
            runat="server" 
            ErrorMessage="RegularExpressionValidator" 
            ControlToValidate="FileUploader" 
            Display="Dynamic">
        </asp:RegularExpressionValidator>

        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink><asp:Image ID="Image1" runat="server" />
    </div>
    </form>
</body>
</html>
