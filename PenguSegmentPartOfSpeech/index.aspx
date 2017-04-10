<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PenguSegmentPartOfSpeech.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtContent" Style="width: 100%" TextMode="MultiLine" Rows="20" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnSplit" runat="server" Text="分詞" OnClick="btnSplit_Click" />
        <br />
        <p>
            <asp:Literal ID="ltlResult" runat="server"></asp:Literal>
        </p>
    </form>
</body>
</html>
