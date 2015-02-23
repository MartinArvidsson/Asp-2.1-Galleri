<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Galleriet_2._1.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="~/Model/Style.css" />
    <script src="Model/Script.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <%--Din bild laddades / laddades inte upp ska synas här.--%>
        <asp:PlaceHolder ID="MessagePlaceholder" Visible="false" runat="server">
            <div id="SuccessBox">
                <label>Din bild laddades upp!</label>
                    <div id="SuccessButton">
                        <label>X</label>
                    </div>
            </div>
        </asp:PlaceHolder>
        <div>
        <%-- Bilden(Den stora) --%>
        <asp:Image ID="MainPicture" runat="server" /> <br />
        
        <%-- Tumnaglar --%>
        <asp:Repeater ID="Thumbnailrepeater" runat="server" SelectMethod="Thumbnailrepeater_GetData" ItemType="System.String">
            
            <%--Templatet på vad som ska rendeas ut varje gång som en bild läggs till --%>
            <ItemTemplate>
                <asp:HyperLink ID="ThumnailHyperlink" 
                    runat="server" 
                    ImageURL='<%# "~/Galleri/Gallerithumbnails/" + Item %>' 
                    NavigateURL='<%#"?name=" + Item %>'
                    CssClass="thumb">
                </asp:HyperLink>  
            </ItemTemplate>

        </asp:Repeater><br />
        <%-- ladda upp bild --%>
        <asp:Button ID="SendButton" runat="server" Text="Ladda upp!" OnClick="SendButton_Click" />
        <asp:FileUpload ID="FileUploader" runat="server" />
        <label>Ladda upp en bild! Tillåtna format: jpeg, gif och png</label><br />

        <%-- Validatorer --%>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator" 
            runat="server" ErrorMessage="Måste välja en fil (Glöm inte giltigt format!)" 
            Display="Dynamic" 
            ControlToValidate="FileUploader">
        </asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator
            ID="RegExValidator" 
            runat="server" 
            ErrorMessage="Måste vara Jpeg , Gif eller png" 
            ControlToValidate="FileUploader" 
            Display="Dynamic" 
            ValidationExpression="^.*\.(gif|jpg|png|GIF|JPG|PNG)$">
        </asp:RegularExpressionValidator>
    </div>
    </form>
</body>
</html>
