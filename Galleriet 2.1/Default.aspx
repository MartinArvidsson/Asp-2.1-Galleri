<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Galleriet_2._1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- Bilden --%>
        <asp:Image ID="MainPicture" runat="server" />
        
        <%-- Tumnaglar --%>
        <asp:Repeater ID="Thumbnailrepeater" runat="server" SelectMethod="Thumbnailrepeater_GetData" ItemType="System.string">
            
            <%--Templatet på vad som ska rendeas ut varje gång som en bild läggs till! --%>
            <ItemTemplate>
                <asp:HyperLink ID="ThumnailHyperlink" 
                    runat="server" 
                    ImageURL='<%#"~/Galleri/Gallerithumb/"+ Item %>>' 
                    NavigateURL='<%#"?name=" + Item %>'>
                </asp:HyperLink>  
            </ItemTemplate>

        </asp:Repeater><br />
        <%-- ladda upp bild --%>
        <asp:Button ID="SendButton" runat="server" Text="Ladda upp!" OnClick="SendButton_Click" />
        <asp:FileUpload ID="FileUploader" runat="server" />

        <%-- Validatorer --%>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator" 
            runat="server" ErrorMessage="Måste välja en fil >:(" 
            Display="Dynamic" 
            ControlToValidate="FileUploader">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="RegExValidator" 
            runat="server" 
            ErrorMessage="Måste vara Jpeg , Gif eller png" 
            ControlToValidate="FileUploader" 
            Display="Dynamic">
        </asp:RegularExpressionValidator>
    </div>
    </form>
</body>
</html>
