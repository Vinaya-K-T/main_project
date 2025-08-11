<%@ Page Title="" Language="C#" MasterPageFile="~/contractor/Site1.Master" AutoEventWireup="true" CodeBehind="add_budget.aspx.cs" Inherits="pothole_detection_system.contractor.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<section class="vbox">
				<section class="scrollable padder">
					<section class="panel panel-default">
				<header class="panel-heading">
								<span class="h4">Budget</span>
				</header>
   										<div class="panel-body">
											<table class="table table-bordered">
												<tr>
													<th>Project Phase</th>
													<td>
														<asp:TextBox ID="txtpp" runat="server" class="form-control"></asp:TextBox>
													</td>
												</tr>
												<tr>
													<th>Complaint Name</th>
													<td>
														<asp:TextBox ID="txtcn" runat="server" class="form-control"></asp:TextBox>
														<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtcn"></asp:RequiredFieldValidator>
													</td>
												</tr>
												<tr>
													<th>Allocated Amount</th>
													<td>
														<asp:TextBox ID="txtam" runat="server" class="form-control"></asp:TextBox>
														<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtam"></asp:RequiredFieldValidator>
													</td>
												</tr>
												<tr>
													<th>Expense Type</th>
													<td>
														<asp:TextBox ID="txtet" runat="server" class="form-control"></asp:TextBox>
														<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtet"></asp:RequiredFieldValidator>
													</td>
												</tr>
												<tr>
													<th>Entry Date</th>
													<td>
														<asp:TextBox ID="txted" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
														<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txted"></asp:RequiredFieldValidator>
														<asp:RangeValidator ID="RangeValidator1" runat="server" Type="Date" ErrorMessage="not a valid date" ForeColor="Red" ControlToValidate="txted"></asp:RangeValidator>
													</td>
												</tr>
												<%--<tr>
													<th>Status</th>
													<td>
														<asp:DropDownList ID="st" runat="server">
                                                            <asp:ListItem>Active</asp:ListItem>
                                                            <asp:ListItem>Suspended</asp:ListItem>
                                                            <asp:ListItem>Blacklisted</asp:ListItem>
                                                        </asp:DropDownList>
													</td>
													<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="st"></asp:RequiredFieldValidator>
												</tr>--%>
												<tr>
													<th>cid</th>
														<td>
															<asp:TextBox ID="txtci" runat="server" class="form-control"></asp:TextBox>
														</td>
												</tr>
											</table>

											   <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Bold="true" />
<br />


										<footer class="panel-footer text-center bg-light lter">
											<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-primary" />
										</footer>
							</div>
					</section>
				</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
			</section>
</asp:Content>
