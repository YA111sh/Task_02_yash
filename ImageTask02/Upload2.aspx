<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload2.aspx.cs" Inherits="ImageTask02.Upload2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Img" runat="server" Text="ImageUpload"></asp:Label>

                </td>
               

            </tr>
            <tr>
                <td>
                     <asp:FileUpload ID="UploadImage" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btn" runat="server" Text="Submit" OnClick="Btn_Click" />

                </td>
            </tr>
        </table>

        
    </form>
</body>
</html>
