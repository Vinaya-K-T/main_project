<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="upd_complaint.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        			<section class="vbox">
				<section class="scrollable padder">
					<ul class="breadcrumb no-border no-radius b-b b-light pull-in">
						<li>
							<a href="index.html"><i class="fa fa-home"></i> Home</a>
						</li>
						<li>
							<a href="#">UI kit</a>
						</li>
						<li>
							<a href="#">Form</a>
						</li>
						<li class="active">Validation</li>
					</ul>
					<div class="m-b-md">
						<h3 class="m-b-none">Complaint</h3>
					</div>
					<div class="row">
						<div class="col-sm-12">
						
								<section class="panel panel-default">
									<%--<header class="panel-heading">
										<span class="h4">Register</span>
									</header>--%>
									<div class="panel-body">
										<p class="text-muted">Please fill the information to continue</p>
										<div class="form-group">
											<table class="table table-bordered">
                
                <tr>
                    <th>Location:</th>
                    <td>
                        <asp:TextBox ID="txtlocn" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtlocn"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Submission Date:</th>
                    <td>
                        <asp:TextBox ID="txtsdt" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtsdt"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Description:</th>
                    <td>
                        <asp:TextBox ID="txtdes" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtdes"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Upload Image:</th>
                    <td>
                        <asp:FileUpload ID="img" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="img"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                     <th>Status</th>
                     <td>
                        <asp:DropDownList ID="sts" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                            <asp:ListItem Text="In Progress" Value="In Progress"></asp:ListItem>
                            <asp:ListItem Text="Resolved" Value="Resolved"></asp:ListItem>
                        </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="sts"></asp:RequiredFieldValidator>
                    </td>
             </tr>
             <tr>
        <%--<th>pid</th>
        <td>
            <asp:TextBox ID="id" runat="server"  class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="id"></asp:RequiredFieldValidator>
        </td>--%>
         </tr>
            </table>
                                            </div>
                                        </div>
                                    </section>
                        
										<div class="checkbox">
											<label><input checked data-required="true" name="check" type="checkbox"> I agree to the <a class="text-info" href="#">Terms of Service</a></label>
										</div>
									</div>
									<footer class="panel-footer text-center bg-light lter">
                                        <asp:Button runat="server" Text="Submit" OnClick="Button1_Click"  CssClass="btn btn-success"/>
									</footer>
						</div></section>
                        </section>
</asp:Content>
