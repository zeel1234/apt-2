<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="XmlTransformation.MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/MyFirst.xml" TransformSource="~/MyXsl.xslt"></asp:Xml>
    </form>
</body>
</html>
