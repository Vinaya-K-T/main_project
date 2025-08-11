<%@ Page Title="" Language="C#" MasterPageFile="~/login_public/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="pothole_detection_system.login_public.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <style>
        .form-section {
            background: #fff;
            padding: 40px;
            border-radius: 12px;
            box-shadow: 0 4px 25px rgba(0, 0, 0, 0.1);
            max-width: 650px;
            margin: 60px auto;
            position: relative;
            z-index: 1;
        }
        .btn-section a {
            margin-right: 10px;
            padding: 10px 20px;
            border-radius: 6px;
            text-decoration: none;
            font-weight: 600;
        }
        .btn-1.active-bg {
            background-color: #007bff;
            color: white;
        }
        .btn-2 {
            background-color: #f1f1f1;
            color: #333;
        }
        .social-list a {
            margin: 0 8px;
            color: #555;
            font-size: 18px;
        }
        .social-list a:hover {
            color: #007bff;
        }
        #particles-js {
            position: fixed;
            top: 0; left: 0;
            width: 100%;
            height: 100%;
            z-index: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <%--  <!-- Login 7 start -->
<div class="login-7">
    <div >
        <div id="particles-js"></div>
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="form-info">
                        <div class="form-section align-self-center">
                            <div class="btn-section clearfix">
                                <a href="login.aspx" class="link-btn active btn-1 default-bg">Login</a>
                                <a href="register.aspx" class="link-btn btn-2 active-bg">Register</a>
                            </div>
                            <div class="logo">
                                <a href="login-7.html">
                                    <img src="assets/img/logos/logo-2.png" alt="logo">
                                </a>
                            </div>
                            <h1>Welcome!</h1>
                            <div class="typing">
                                <h3>Create An Account</h3>
                            </div>
                            <div class="clearfix"></div>
                            <form action="#" method="GET">
                                 <table class="table">
     <tr>
         <th><label for="txtfn">Name</label></th>
         <td>
             <asp:TextBox ID="txtfn" runat="server" class="form-control" placeholder="Enter Your Name"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtfn"></asp:RequiredFieldValidator>
         </td>
     </tr>
     <tr>
         <th><label for="txtpno">Phone</label></th>
         <td>
             <asp:TextBox ID="txtpno" runat="server" class="form-control" placeholder="9123456780"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtpno"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtpno" ValidationExpression="^(0|\+91)?[789]\d{9}$"></asp:RegularExpressionValidator>
         </td>
     </tr>
     <tr>
         <th><label for="txtem">Email</label></th>
         <td>
             <asp:TextBox ID="txtem" runat="server" class="form-control" placeholder="test@example.com"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtem"></asp:RequiredFieldValidator>
         </td>
     </tr>
     <tr>
         <th><label for="txtpswd">Password</label></th>
         <td>
             <asp:TextBox ID="txtpswd" runat="server" class="form-control" placeholder="Type a password" TextMode="Password"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtpswd"></asp:RequiredFieldValidator>
         </td>
     </tr>
     <tr>
         <th><label for="txtcpsd"> Confirm Password</label></th>
         <td>
             <asp:TextBox ID="txtcpsd" runat="server" class="form-control" placeholder="confirm password" TextMode="Password" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtcpsd"></asp:RequiredFieldValidator>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password doesnot match" ControlToValidate="txtpswd" ControlToCompare="txtcpsd"></asp:CompareValidator>
         </td>
     </tr>
    
 </table>
                                <div class="form-group checkbox clearfix">
                                    <div class="clearfix float-start">
                                        <div class="form-check mb-0">
                                            <input class="form-check-input" type="checkbox" id="rememberme">
                                            <label class="form-check-label" for="rememberme">
                                                I agree to the terms of service
                                            </label>
                                        </div>
                                    </div>
                                </div class="form-group clearfix">
                                    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" class="btn btn-primary btn-lg btn-theme"/>
                                </div>
                            </form>
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
</div>--%>


    <div id="particles-js"></div>

    <div class="login-7">
        <div class="container">
            <div class="form-section">
                <div class="text-center mb-4">
                    <div class="btn-section">
                        <a href="login.aspx" class="btn-1">Login</a>
                        <a href="register.aspx" class="btn-2 active-bg">Register</a>
                    </div>
                    <div class="logo mb-3">
                        <img src="assets/img/logos/logo-2.png" alt="logo" style="max-height: 50px;">
                    </div>
                    <h1>Welcome!</h1>
                    <h3>Create an Account</h3>
                </div>

                <table class="table compact-table">
                    <tr>
                        <th><label for="txtfn">Name</label></th>
                        <td>
                            <asp:TextBox ID="txtfn" runat="server" CssClass="form-control" placeholder="Enter Your Name" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtfn" ErrorMessage="*" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <th><label for="txtpno">Phone</label></th>
                        <td>
                            <asp:TextBox ID="txtpno" runat="server" CssClass="form-control" placeholder="9123456780" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpno" ErrorMessage="*" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtpno" ErrorMessage="Invalid Phone" ValidationExpression="^(0|\+91)?[789]\d{9}$" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <th><label for="txtem">Email</label></th>
                        <td>
                            <asp:TextBox ID="txtem" runat="server" CssClass="form-control" placeholder="test@example.com" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtem" ErrorMessage="*" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <th><label for="txtpswd">Password</label></th>
                        <td>
                            <asp:TextBox ID="txtpswd" runat="server" CssClass="form-control" TextMode="Password" placeholder="Type a password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtpswd" ErrorMessage="*" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <th><label for="txtcpsd">Confirm Password</label></th>
                        <td>
                            <asp:TextBox ID="txtcpsd" runat="server" CssClass="form-control" TextMode="Password" placeholder="Confirm password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcpsd" ErrorMessage="*" ForeColor="Red" />
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtpswd" ControlToCompare="txtcpsd" ErrorMessage="Passwords do not match" ForeColor="Red" />
                        </td>
                    </tr>
                </table>

                <div class="form-check my-3">
                    <input class="form-check-input" type="checkbox" id="termsCheck" required />
                    <label class="form-check-label">
                        I agree to the terms of service
                    </label>
                </div>

                <div class="text-center mb-3">
                    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg w-100" />
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
