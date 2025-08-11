<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="upd_contracts.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="content">
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
				<h3 class="m-b-none">Contract</h3>
			</div>
			<div class="row">
				<div class="col-sm-12">
						<section class="panel panel-default">
							<%--<header class="panel-heading">
								<span class="h4">Register</span>
							</header>--%>
							<div class="panel-body">
								<%--<p class="text-muted">Please fill the information to continue</p>--%>
								<table class="table table-bordered">
									<tr>
										<th>Company Name:</th>
										<td>
											<asp:TextBox ID="txtcm" runat="server" class="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtcm"></asp:RequiredFieldValidator>
										</td>
										</tr>
									<tr>
										<th>Company Address:</th>
										<td>
											<asp:TextBox ID="txtcd" runat="server" class="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtcd"></asp:RequiredFieldValidator>
										</td>
									</tr>
									<tr>
										<th>Contact Person:</th>
										<td>
											<asp:TextBox ID="txtcr" runat="server" class="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtcr"></asp:RequiredFieldValidator>
										</td>
									</tr>
									<tr>
										<th>Phone:</th>
										<td>
											<asp:TextBox ID="txtpn" runat="server" class="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtpn"></asp:RequiredFieldValidator>
										</td>
									</tr>
									<tr>
										<th>District:</th>
										<td>
										   <asp:DropDownList ID="dt" runat="server">
												<asp:ListItem>Thrissur</asp:ListItem>
												<asp:ListItem>Palakkad</asp:ListItem>
												<asp:ListItem>Eranamkulam</asp:ListItem>
												<asp:ListItem>Alappuzha</asp:ListItem>
												<asp:ListItem>Kozhikkode</asp:ListItem>
											</asp:DropDownList>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="dt"></asp:RequiredFieldValidator>
										</td>
									</tr>
									<tr>
										<th>Annual Turnover:</th>
										<td>
											<asp:TextBox ID="txtan" runat="server" class="form-control"></asp:TextBox>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtan"></asp:RequiredFieldValidator>
										</td>
									</tr>
									<tr>
										<th>Status:</th>
										<td>
											<asp:DropDownList ID="ts" runat="server">
                                                         <asp:ListItem>Active</asp:ListItem>
                                                         <asp:ListItem>Suspended</asp:ListItem>
                                                         <asp:ListItem>blacklisted</asp:ListItem>
                                                     </asp:DropDownList>
											<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="ts"></asp:RequiredFieldValidator>
										</td>
									</tr>
								</table>
								<div class="checkbox">
									<label><input checked data-required="true" name="check" type="checkbox"> I agree to the <a class="text-info" href="#">Terms of Service</a></label>
								</div>
							</div>
							<footer class="panel-footer text-center bg-light lter">
								<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-primary" />
							</footer>
						</section>
				</div>
			</div>
		</section>
	</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
</section>
</asp:Content>
