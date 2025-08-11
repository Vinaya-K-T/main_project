<%@ Page Title="" Language="C#" MasterPageFile="~/login_public/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pothole_detection_system.login_public.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        .form-section {
            background-color: #ffffff;
            padding: 40px;
            border-radius: 12px;
            box-shadow: 0 4px 20px rgba(0,0,0,0.1);
            max-width: 600px;
            margin: auto;
        }

        .btn-section a {
            display: inline-block;
            padding: 10px 20px;
            margin: 0 5px 20px;
            font-weight: 500;
            border-radius: 6px;
            text-decoration: none;
        }

        .btn-1.active-bg {
            background-color: #007bff;
            color: #fff;
        }

        .btn-2 {
            background-color: #f0f0f0;
            color: #333;
        }

        .form-section h1 {
            font-size: 2rem;
            margin-bottom: 10px;
        }

        .form-section h3 {
            font-size: 1.2rem;
            color: #777;
        }

        .social-list a {
            margin: 0 5px;
            font-size: 18px;
            color: #555;
        }

        .social-list a:hover {
            color: #007bff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%-- <div class="page_loader"></div>--%>
<!-- Login 7 start -->
<%--<div class="login-7">
    <div>
        <div id="particles-js"></div>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="form-info">
                        <div class="form-section align-self-center">
                            <div class="btn-section clearfix">
                                <a href="login.aspx" class="link-btn active btn-1 active-bg default-bg">Login</a>
                                <a href="register.aspx" class="link-btn btn-2">Register</a>
                            </div>
                            <div class="logo">
                                <a href="login-7.html">
                                    <img src="assets/img/logos/logo-2.png" alt="logo">
                                </a>
                            </div>
                            <h1>Welcome!</h1>
                            <div class="typing">
                                <h3>Sign Into Your Account</h3>
                            </div>
                            <div class="clearfix"></div>
                           
                                <div class="form-group">
                                <table class="table">
                                <tr>
                                    <td><label class="control-label">User name</label></td>
                                    <td><asp:TextBox ID="txtun" runat="server" class="form-control"></asp:TextBox></td>
                                </tr>
                                  <tr>
                                     <td><label class="control-label">Password</label></td>
                                     <td> <asp:TextBox ID="txtpwd" TextMode="Password" runat="server" class="form-control"></asp:TextBox> </td>
                                 </tr>
                                   </table>
                                <div class="checkbox form-group clearfix">
                                    <div class="form-check float-start mb-0">
                                        <input class="form-check-input" type="checkbox" id="rememberme">
                                        <label class="form-check-label" for="rememberme">
                                            Remember me
                                        </label>
                                    </div>
                                    <a href="forgot-password-7.html" class="float-end forgot-password">Forgot your password?</a>
                                </div>
                                <div class="form-group clearfix">
                                    <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" class="btn btn-primary btn-lg btn-theme" />
                                </div>
                     
                            <p>Help & Support</p>
                            <div class="social-list">
                                <a href="#">
                                    <i class="fa fa-facebook"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-twitter"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-google"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-linkedin"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-pinterest"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-youtube"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div></div>--%>


     <div class="login-7 py-5">
         <div id="particles-js" style="position: fixed; width: 100%; height: 100%; z-index: -1;"></div>
        <div class="container">
            <div class="form-section">
                <div class="text-center mb-4">
                    <div class="btn-section">
                        <a href="login.aspx" class="link-btn active btn-1 active-bg">Login</a>
                        <a href="register.aspx" class="link-btn btn-2">Register</a>
                    </div>
                    <div class="logo mb-3">
                        <img src="assets/img/logos/logo-2.png" alt="logo" style="max-height: 50px;">
                    </div>
                    <h1>Welcome!</h1>
                    <h3>Sign Into Your Account</h3>
                </div>

                <table class="table border-0">
                    <tr>
                        <td><label for="txtun" class="control-label">User Name</label></td>
                        <td><asp:TextBox ID="txtun" runat="server" CssClass="form-control" /></td>
                    </tr>
                    <tr>
                        <td><label for="txtpwd" class="control-label">Password</label></td>
                        <td><asp:TextBox ID="txtpwd" runat="server" TextMode="Password" CssClass="form-control" /></td>
                    </tr>
                </table>

                <div class="d-flex justify-content-between align-items-center mb-3">
                    <div class="form-check">
                        <input class="form-check-input" type="checkbox" id="rememberme" />
                        <label class="form-check-label" for="rememberme">Remember me</label>
                    </div>
                    <a href="register.aspx" class="forgot-password">Forgot your password?</a>
                </div>

                <div class="text-center mb-4">
                    <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg btn-block w-100" />
                </div>

                <p class="text-center">Help & Support</p>
                <div class="text-center social-list">
                    <a href="#"><i class="fa fa-facebook"></i></a>
                    <a href="#"><i class="fa fa-twitter"></i></a>
                    <a href="#"><i class="fa fa-google"></i></a>
                    <a href="#"><i class="fa fa-linkedin"></i></a>
                    <a href="#"><i class="fa fa-pinterest"></i></a>
                    <a href="#"><i class="fa fa-youtube"></i></a>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
