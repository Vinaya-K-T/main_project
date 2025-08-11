<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="add_reason.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
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
						<%--<div class="m-b-md">
							<h3 class="m-b-none">Validation</h3>
						</div>--%>
						<div class="row">
							<div class="col-sm-12">
							
									<section class="panel panel-default">
										<header class="panel-heading">
											<span class="h4">Reason</span>
										</header>
										<div class="panel-body">
											<%--<p class="text-muted">Please fill the information to continue</p>--%>
											<table class="table table-bordered">
												<tr>
													<th>Reason</th>
													<td>
														<asp:TextBox ID="txtrn" runat="server" class="form-control"></asp:TextBox>
														<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtrn"></asp:RequiredFieldValidator>
													</td>
												</tr>
											</table>
											<%--<div class="checkbox">
												<label><input checked data-required="true" name="check" type="checkbox"> I agree to the <a class="text-info" href="#">Terms of Service</a></label>
											</div>--%>
										</div>
										<footer class="panel-footer text-centre bg-light lter">
											<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-success"/>
										</footer>
									</section>
							</div>
						</div>
					</section>
				</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
			</section>
</asp:Content>
    