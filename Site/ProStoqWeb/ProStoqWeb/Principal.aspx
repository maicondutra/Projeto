<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ProStoqWeb.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.Net Custom Authentication Forms Based Security</title>
    <link href="css/structure.css" rel="stylesheet" />
    <script type="text/javascript">
        function pageValid(e) {
            var obj = document.getElementById('txtUserName');
            if (obj.value == '') {
                alert('Please enter username.');
                obj.focus();
                window.event ? event.returnValue = false : e.preventDefault();
                return;
            }
            obj = document.getElementById('txtPassword');
            if (obj.value == '') {
                alert('Please enter password.');
                obj.focus();
                window.event ? event.returnValue = false : e.preventDefault();
                return;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" class="box login" defaultbutton="btnGo">
        <div class="boxBody">
            <div class="login_area">

                <div>
                    <label>Username</label>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="username" MaxLength="20"></asp:TextBox>
                </div>
                <div>
                    <label>Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="password" TextMode="Password" MaxLength="15"></asp:TextBox>
                </div>
                <div class="go_botton" id="dvBtn">
                    <asp:Button ID="btnGo" Text="Login" class="btnLogin" onmousedown="mousedwnevt();" onmouseup="mouseupevt();" runat="server" OnClientClick="pageValid(event);" OnClick="btnLogin_Click" />
                </div>

            </div>

        </div>
    </form>
</body>
</html>
