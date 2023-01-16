<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="aspDotNetDatabase.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LogIN</title>
    <style>
        *{
            font-family:Consolas;
        }
        body{
            position:relative;
            display:block;
        }
        .form{
            position:relative;
            display:block;
            width:26%;
            padding:1rem 1.8rem;
            margin: 5% auto;
            border:1px solid cornflowerblue;
            border-radius:0.4rem;
        }
        .form h1{
            text-align: left;
            color: dodgerblue;
            padding: 0.5rem;
            font-size: 2rem;
            font-weight:normal;
        }
        .form_input-group{
            position:relative;
            display:flex;
            flex-direction:column;
            padding:0.5rem;
        }
        .form-input{
            position:relative;
            display:block;
            width:100%;
        }
        .form-input #label1,
        .form-input #label2{
            display: flex;
            margin: 0.7rem 0.15rem;
            font-size:1rem;
            font-weight: normal;
        }
        .form-input #field1, 
        .form-input #field2{
            width: 90%;
            margin: 0px 0px 0px 0.2rem;
            padding: 1rem;
            display: block;
            font-size:1.0rem;
            border-radius: 0.4rem;
            border: 1px solid cornflowerblue;
            outline: none;
        }
        .form-btn{
            position:relative;
            display:flex;
            align-items:center;
            justify-content:center;
            width:100%;
        }
        .form-btn #submit{
            width: 50%;
            height:2.5rem;
            float:right;
            margin-top:1rem;
            margin-left:auto;
            padding: 0.5rem 1rem;
            color: white;
            background-color: cornflowerblue;
            cursor: pointer;
            font-size: 1rem;
            border: none;
            border-radius: 0.5rem;
        }
        .display-toggle-btn {
            position: absolute;
            top: 3rem;
            right: 0.25rem;
            height: 2.5rem;
            width: 2.5rem;
            border: none;
            border-radius: 0.4rem;
            padding: 0.15rem;
            visibility:hidden;
            z-index: 100;
        }

        .display-toggle-btn ion-icon {
            cursor: pointer;
            font-size: 1.2rem;
            padding: 0.5rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form">
            <h1>LogIN</h1>
            <div class="form_input-group">
                <div class="form-input">
                    <asp:Label ID="label1" runat='server' Text="| E-mail ID or USername : "></asp:Label>
                    <asp:TextBox ID="field1" runat="server"></asp:TextBox>
                </div>
                <div class="form-input">
                    <asp:Label ID="label2" runat='server' Text="| Password : "></asp:Label>
                    <asp:TextBox ID="field2" TextMode="Password" runat="server"></asp:TextBox>
                    <button type="button" class="display-toggle-btn" id="toggle-password">
                       <ion-icon name="eye-off-outline" id="show-hide"></ion-icon>
                    </button>
                </div>
            </div>
            <div class="form-btn">
                <asp:Button ID="submit" runat="server" Text="LogIN" OnClick="submit_Click"/>
            </div>
        </div>
    </form>
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
    <script>
        document.querySelector("#field2").addEventListener("input", function () {
            document.getElementById('toggle-password').style.visibility = "visible";
        });
        document.querySelector("#field2").addEventListener("focusin", function () {
            document.getElementById('toggle-password').style.color = "cornflowerblue";
        });
        document.querySelector("#field2").addEventListener("focusout", function () {
            document.getElementById('toggle-password').style.color = "#80868B";
        });
        document.querySelector("#toggle-password").addEventListener("click", function () {
            const input = document.querySelector("#field2"),
                showHide = document.querySelector("#show-hide");
            if (input.type === "password") {
                input.type = "text";
                showHide.name = "eye-outline";
            } else {
                input.type = "password";
                showHide.name = "eye-off-outline";
            }
        });
    </script>
</body>
</html>
