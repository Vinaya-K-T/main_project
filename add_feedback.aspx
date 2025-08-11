<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="add_feedback.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="vbox">
				<section class="scrollable padder">
					<%--<ul class="breadcrumb no-border no-radius b-b b-light pull-in">
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
					</ul>--%>
					<div class="m-b-md">
						<h3 class="m-b-none">Feedback</h3>
					</div>
					<div class="row">
						<div class="col-sm-12">
						
								<section class="panel panel-default">
									<%--<header class="panel-heading">
										<span class="h4">Feedback</span>
									</header>--%>
									<div class="panel-body">
										<p class="text-muted">Please fill the information to continue</p>
										<table class="table table-bordered">
											<tr>
												<th>Email</th>
												<td>
													<asp:TextBox ID="txteml" runat="server" class="form-control"></asp:TextBox>
													<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txteml"></asp:RequiredFieldValidator>
												</td>
											</tr>
											<tr>
												<th>Message</th>
												<td>
													<asp:TextBox ID="txtmsg" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
													<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtmsg"></asp:RequiredFieldValidator>
												</td>
											</tr>
											<tr>
												<th>Submission Date</th>
												<td>
													<asp:TextBox ID="txtsub" runat="server" class="form-control"></asp:TextBox>
													<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtsub"></asp:RequiredFieldValidator>
												</td>
											</tr>
											<%--<tr>
												<th>uid</th>
												<td>
													<asp:TextBox ID="ui" runat="server" class="form-control"></asp:TextBox>
													<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="ui"></asp:RequiredFieldValidator>
												</td>
											</tr>--%>
										</table>
										</div>
									</section>
							</div>
										<%--<div class="checkbox">
											<label><input checked data-required="true" name="check" type="checkbox"> I agree to the <a class="text-info" href="#">Terms of Service</a></label>
										</div>--%>
									</div>
									<footer class="panel-footer text-right bg-light lter">
										<asp:Button ID="Button1" runat="server" Text="Submit"  OnClick="Button1_Click"  CssClass="btn btn-success"/>
									</footer>
								</section></section>
</asp:Content>
