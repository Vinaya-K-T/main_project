<%@ Page Title="" Language="C#" MasterPageFile="~/userr/Site1.Master" AutoEventWireup="true" CodeBehind="view_profiile.aspx.cs" Inherits="pothole_detection_system.userr.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style>
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
            background-color: #f4f6f9;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        form {
            height: 100%;
        }

        #content-wrapper {
            min-height: 100%;
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 40px 20px;
        }

        .card {
            border-radius: 1rem;
            background: #fff;
            box-shadow: 0 8px 24px rgba(0, 0, 0, 0.1);
        }

        .card-header-gradient {
            background: linear-gradient(135deg, #7b2ff7, #f107a3);
            color: white;
            padding: 40px 20px;
            text-align: center;
        }

        .card-header-gradient i {
            font-size: 3rem;
            margin-bottom: 10px;
        }

        .info-item {
            display: flex;
            align-items: center;
            margin-bottom: 1.5rem;
        }

        .info-item i {
            font-size: 1.2rem;
            margin-right: 10px;
            color: #7b2ff7;
        }

        .info-item span.label {
            font-weight: 500;
            color: #555;
            width: 70px;
        }

        .info-item .form-control {
            border: none;
            background: transparent;
            font-weight: 600;
            padding-left: 0;
            color: #333;
        }

        .info-item .form-control[readonly] {
            background-color: transparent;
        }

        .btn-gradient {
            background: linear-gradient(135deg, #7b2ff7, #f107a3);
            border: none;
            color: white;
            transition: background 0.3s ease;
        }

        .btn-gradient:hover {
            background: linear-gradient(135deg, #6a11cb, #c90076);
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="content-wrapper">
        <div class="card shadow-lg border-0 overflow-hidden" style="max-width: 450px; width: 100%;">
            <!-- Header -->
            <div class="card-header-gradient">
                <i class="fa fa-user-circle"></i>
                <h4 class="mt-2 mb-0 fw-semibold">Your Profile</h4>
            </div>

            <!-- Body -->
            <div class="card-body p-4">
                <div class="info-item">
                    <i class="fa fa-user"></i>
                    <span class="label">Name:</span>
                    <asp:TextBox ID="txtfn" runat="server" CssClass="form-control" ReadOnly="true" />
                </div>

                <div class="info-item">
                    <i class="fa fa-phone"></i>
                    <span class="label">Phone:</span>
                    <asp:TextBox ID="txtpno" runat="server" CssClass="form-control" ReadOnly="true" />
                </div>

                <div class="info-item">
                    <i class="fa fa-envelope"></i>
                    <span class="label">Email:</span>
                    <asp:TextBox ID="txtem" runat="server" CssClass="form-control" ReadOnly="true" />
                </div>

                <!-- Button -->
                <div class="text-center mt-4">
                    <asp:Button ID="Button1" runat="server" Text="Edit Profile" OnClick="Button1_Click"
                        CssClass="btn btn-gradient rounded-pill px-4 py-2 fw-semibold" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
