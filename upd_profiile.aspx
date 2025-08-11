<%@ Page Title="" Language="C#" MasterPageFile="~/userr/Site1.Master" AutoEventWireup="true" CodeBehind="upd_profiile.aspx.cs" Inherits="pothole_detection_system.userr.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <style>
        html, body, form {
            height: 100%;
            margin: 0;
            padding: 0;
        }

       /* body {
            background: linear-gradient(135deg, #c471f5, #fa71cd);
        }*/

        .profile-card {
            max-width: 450px;
            width: 100%;
            background: white;
            border-radius: 1rem;
            box-shadow: 0 8px 25px rgba(0, 0, 0, 0.15);
            overflow: hidden;
        }

        .profile-header {
            background: linear-gradient(135deg, #6a11cb 0%, #2575fc 100%);
            color: white;
            padding: 2rem 1rem;
        }

        .profile-header i {
            font-size: 3rem;
        }

        .form-floating label i {
            margin-right: 0.5rem;
        }

        .btn-custom {
            background-color: #6a11cb;
            border: none;
            color: white;
            transition: background 0.3s ease;
        }

        .btn-custom:hover {
            background-color: #5011a1;
        }

        .btn-outline-custom {
            border: 1px solid #6a11cb;
            color: #6a11cb;
        }

        .btn-outline-custom:hover {
            background-color: #6a11cb;
            color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div style="min-height: 100vh; display: flex; justify-content: center; align-items: center;">
        <div class="profile-card">
            <!-- Header -->
            <div class="profile-header text-center">
                <i class="fa fa-user-circle mb-3"></i>
                <h4 class="fw-bold mb-1">📝 Account Details</h4>
                <p class="mb-0 small opacity-75">Update your details below</p>
            </div>

            <!-- Card Body -->
            <div class="card-body px-4 py-4">
                <h6 class="text-primary fw-bold mb-4 text-center"></h6>

                <div class="form-floating mb-3">
                      <label for="txtfn"><i class="fa fa-user text-primary"></i> First Name</label>
                    <asp:TextBox ID="txtfn" runat="server" CssClass="form-control shadow-sm" placeholder="First Name" />
                  
                </div>

                <div class="form-floating mb-3">
                       <label for="txtpno"><i class="fa fa-phone text-primary"></i> Phone</label>
                    <asp:TextBox ID="txtpno" runat="server" CssClass="form-control shadow-sm" placeholder="Phone" />
                 
                </div>

                <div class="form-floating mb-3">
                     <label for="txtem"><i class="fa fa-envelope text-primary"></i> Email</label>
                    <asp:TextBox ID="txtem" runat="server" CssClass="form-control shadow-sm" placeholder="Email" />
                   
                </div>

                <div class="form-floating mb-4">
                     <label for="txtpswd"><i class="fa fa-lock text-primary"></i> Password</label>
                    <asp:TextBox ID="txtpswd" runat="server" TextMode="Password" CssClass="form-control shadow-sm" placeholder="Password" />
                   
                </div>

                <div class="d-flex justify-content-between gap-2 text-center">
                    <asp:Button ID="Button1" runat="server" Text="Update" CssClass="btn btn-custom w-50" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn btn-outline-custom w-50" OnClick="Button2_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
