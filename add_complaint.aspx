<%@ Page Title="" Language="C#" MasterPageFile="~/userr/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="pothole_detection_system.userr.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style>
        html, body, form {
            height: 100%;
            margin: 0;
            padding: 0;
        }

        .full-center-wrapper {
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            background: linear-gradient(135deg, #f5f7fa, #c3cfe2);
        }

        .card {
            width: 100%;
            max-width: 600px;
        }
    </style></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="full-center-wrapper">
        <div class="card shadow-lg border-0 rounded-4">
            <div class="card-header bg-primary text-white text-center rounded-top-4">
                <h3 class="mb-0">Complaint Form</h3>
                <p class="mb-0 small">Please provide the required details</p>
            </div>
            <div class="card-body p-4 bg-white rounded-bottom-4">
                <table class="table table-borderless mb-0">
                    <tr>
                        <th class="w-25 align-middle">Location:</th>
                        <td>
                            <asp:TextBox ID="txtlocn" runat="server" CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Required" ForeColor="Red" ControlToValidate="txtlocn" Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <th class="align-middle">Submission Date:</th>
                        <td>
                            <asp:TextBox ID="txtsdt" runat="server" CssClass="form-control" TextMode="Date" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Required" ForeColor="Red" ControlToValidate="txtsdt" Display="Dynamic" />
                            <asp:RangeValidator ID="RangeValidator1" runat="server" Type="Date" ErrorMessage="* Invalid date" ForeColor="Red" ControlToValidate="txtsdt" Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <th class="align-middle">Description:</th>
                        <td>
                            <asp:TextBox ID="txtdes" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* Required" ForeColor="Red" ControlToValidate="txtdes" Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <th class="align-middle">Upload Image:</th>
                        <td>
                            <asp:FileUpload ID="img" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                    <%--<tr>
                        <th class="align-middle">Status:</th>
                        <td>
                            <asp:DropDownList ID="sts" runat="server" CssClass="form-select">
                                <asp:ListItem Text="Pending" Value="Pending" />
                                <asp:ListItem Text="In Progress" Value="In Progress" />
                                <asp:ListItem Text="Resolved" Value="Resolved" />
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="* Required" ForeColor="Red" ControlToValidate="sts" Display="Dynamic" />
                        </td>
                    </tr>--%>
                </table>
            </div>
            <div class="card-footer bg-light text-center">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-success px-4 py-2 shadow-sm" />
            </div>
        </div>
    </div></asp:Content>
