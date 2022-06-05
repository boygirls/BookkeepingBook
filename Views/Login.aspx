<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookkeepingBook.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>记账本——登录</title>
    <link rel="stylesheet" type="text/css" href="../Content/login.css" />
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script>
        $(function () {
            //1.给登录按钮绑定单击事件
            $("#btn_sub").click(function () {
                //2.发送ajax请求，提交表单数据
                $.post("http://localhost:8237/api/user", $("#loginForm").serialize(), function (data) {
                    //data : {flag:false,errorMsg:''}
                    if (data.IsSuccess == true ) {
                        //登录成功
                        console.log(data);
                        location.href = "http://localhost:8237?";
                    } else {
                        //登录失败
                        console.log(data);
                        $("#errorMsg").html(data.errorMsg);
                    }
                });
            });
        });
    </script>
</head>
<body>

    <div class="login-box">
        <div class="title">
            <img src="../images/login_logo.png" alt="" style="width: 40px; height: 40px" />
            <span>欢迎登录记账本账户</span>
        </div>
        <div class="login_inner">

            <!--登录错误提示消息-->
            <div id="errorMsg" class="alert alert-danger"></div>
            <form id="loginForm" method="post" accept-charset="utf-8">
                <input name="username" type="text" placeholder="请输入账号" autocomplete="off" />
                <input name="password" type="text" placeholder="请输入密码" autocomplete="off" />
                <div class="verify">
                    <input name="check" type="text" placeholder="请输入验证码" autocomplete="off" />
                    <span>
                        <img src="/Views/CheckCode.aspx" alt="验证码" style="width: 100px; height: 40px" onclick="changeCheckCode(this)" />
                    </span>
                    <script type="text/javascript">
                        //图片点击事件
                        function changeCheckCode(img) {
                            img.src = "checkCode?" + new Date().getTime();
                        }
                    </script>
                </div>
                <div class="submit_btn">
                    <button id="btn_sub" type="button">登录</button>
                    <div class="auto_login">
                        <input type="checkbox" name="" class="checkbox" />
                        <span>自动登录</span>
                    </div>
                </div>
            </form>
            <div class="reg">没有账户？<a href="javascript:;">立即注册</a></div>
        </div>
    </div>

</body>
</html>
