<%@ Page Title="" Language="C#" MasterPageFile="~/userr/Site1.Master" AutoEventWireup="true" CodeBehind="add_feedback.aspx.cs" Inherits="pothole_detection_system.userr.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style>
        html, body {
            height: 100%;
            margin: 0;
            font-family: 'Segoe UI', sans-serif;
            background: linear-gradient(135deg, #f0f4f8, #d9e2ec);
        }

        /* Full viewport height and flex centering */
        .center-container {
            height: 100vh; /* viewport height */
            display: flex;
            justify-content: center;
            align-items: center;
            padding: 1rem;
        }

        /* Glass effect form container */
        .glass-form {
            backdrop-filter: blur(15px);
            background: rgba(255, 255, 255, 0.85);
            border-radius: 1rem;
            box-shadow: 0 8px 32px rgba(0, 0, 0, 0.1);
            color: #222;
            padding: 2rem;
            max-width: 600px;
            width: 100%;
            border: 1px solid rgba(0, 0, 0, 0.05);
        }

        .glass-form h3 {
            margin-bottom: 1.5rem;
            text-align: center;
            color: #333;
        }

        .glass-form label {
            font-weight: 600;
            margin-bottom: 0.3rem;
            display: block;
            color: #555;
        }

        .glass-form .form-control {
            width: 100%;
            padding: 0.5rem 0.75rem;
            border: 1px solid #ccc;
            border-radius: 0.4rem;
            font-size: 1rem;
            transition: border-color 0.3s;
        }

        .glass-form .form-control:focus {
            border-color: #667eea;
            outline: none;
            box-shadow: 0 0 5px #667eea;
        }

        .glass-form .btn {
            background-color: #667eea;
            border: none;
            padding: 0.75rem 2rem;
            font-weight: 700;
            color: white;
            border-radius: 0.5rem;
            cursor: pointer;
            transition: background-color 0.3s ease;
            width: 100%;
            font-size: 1.1rem;
        }

        .glass-form .btn:hover {
            background-color: #5a6bd1;
        }

        .mb-3 {
            margin-bottom: 1.25rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="center-container">
        <div class="glass-form">
            <h3>💬 Feedback Form</h3>
            <div class="mb-3">
                <label for="txtem">Email</label>
                <asp:TextBox ID="txtem" runat="server" CssClass="form-control" placeholder="example@gmail.com" />
            </div>
            <div class="mb-3">
                <label for="txtmsg">Message</label>
                <asp:TextBox ID="txtmsg" runat="server" TextMode="MultiLine" Rows="4" CssClass="form-control" placeholder="Your message here..." />
            </div>
            <div class="mb-3">
                <label for="txtsub">Date</label>
                <asp:TextBox ID="txtsub" runat="server" TextMode="Date" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtui">UID</label>
                <asp:TextBox ID="txtui" runat="server" CssClass="form-control" placeholder="Your user ID" />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn" />
        </div>
    </section>
    </section></asp:Content>
