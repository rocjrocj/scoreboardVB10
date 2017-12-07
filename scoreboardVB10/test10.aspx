<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test10.aspx.cs" Inherits="scoreboardVB10.test10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>VB Score</h1>
            <div id="scoreVB"></div>

        </div>
    </form>

    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/jquery.signalR-2.2.2.min.js"></script>
    
    <script type="text/javascript">

        $(function () {
            var con = $.hubConnection();
            var hub = con.createHubProxy('keepScore');
            hub.on('onScoreUp', function (i) {
                $('#scoreVB').text(i);
            });
            con.start(function () {
                hub.invoke();
            });
        })

    </script>

</body>
</html>
