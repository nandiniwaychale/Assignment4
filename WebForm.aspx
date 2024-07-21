<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Assignment4.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Rainbow Colors</title>
    <style>
        .horizontal-list {
            display: flex;
            justify-content: space-around;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <h2>Rainbow Colors</h2>
            <div class="horizontal-list">
                <asp:ListBox ID="lstColorsUppercase" runat="server" OnSelectedIndexChanged="lstColorsUppercase_SelectedIndexChanged"></asp:ListBox>
                <asp:ListBox ID="lstColorsLowercase" runat="server"></asp:ListBox>
            </div>
        </div>
    </form>
</body>
</html>
