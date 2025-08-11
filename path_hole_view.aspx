<%@ Page Title="" Language="C#" MasterPageFile="~/userr/Site1.Master" AutoEventWireup="true" CodeBehind="path_hole_view.aspx.cs" Inherits="pothole_detection_system.userr.WebForm11" %>
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
									<a href="#">Table</a>
								</li>
								<li class="active">Static table</li>
							</ul>
							<div class="m-b-md">
								<h3 class="m-b-none">Static Table</h3>
							</div>
						
							<section class="panel panel-default">
								<header class="panel-heading">
									Responsive Table
								</header>
								
										<div class="table-responsive">

								<asp:Repeater ID="rptPathholes" runat="server">
    <HeaderTemplate>
       <table class="table table-striped b-t b-light">
            <th># </th>
<th>Location</th>
<th>Details</th>
<th>Date</th>
<th>Image</th>
<th>Status</th>
    </HeaderTemplate>
    <ItemTemplate>
      

		<tr>
				<td><%# Eval("#") %></td>
				<td><%# Eval("Location") %></td>
				<td><%# Eval("Description") %></td>
				<td><%# Eval("Date") %></td>
				<td><img src="../path_hole/<%# Eval("Image") %>" width="100px" class="img-rounded" /></td>
				<td>
					<%# Eval("Status").ToString() == "0" ? "<span class='label label-warning'>Under Review</span>" : "<span class='label label-success'>Resolved</span>" %>
				</td>
</tr>
		
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>







						
									<%--<table class="table table-striped b-t b-light">
										<thead>
											<tr>
												
												<th># </th>
												<th>Location</th>
												<th>Details</th>
												<th>Date</th>
												<th>Image</th>
												<th>Status</th>
											</tr>
										</thead>
										<tbody>
											<tr>
												<td>1</td>
												<td>Nattika</td>
												<td>Path hole on near footpath</td>
												<td>Jul 25, 2013</td>
												<td><img src="../path_hole/nat.jpg" width="100px" class="img-rounded" /></td>
												<td>
													<a class="active" data-toggle="class" href="#"><i class="fa fa-check text-success text-active"></i><i class="fa fa-times text-danger text"></i></a>
												</td>
											</tr>
											
										</tbody>
									</table>--%>
								</div>
								<footer class="panel-footer">
									<div class="row">
										<div class="col-sm-4 hidden-xs">
											<select class="input-sm form-control input-s-sm inline v-middle">
												<option value="0">
													Bulk action
												</option>
												<option value="1">
													Delete selected
												</option>
												<option value="2">
													Bulk edit
												</option>
												<option value="3">
													Export
												</option>
											</select> <button class="btn btn-sm btn-default">Apply</button>
										</div>
										<div class="col-sm-4 text-center">
											<small class="text-muted inline m-t-sm m-b-sm">showing 20-30 of 50 items</small>
										</div>
										<div class="col-sm-4 text-right text-center-xs">
											<ul class="pagination pagination-sm m-t-none m-b-none">
												<li>
													<a href="#"><i class="fa fa-chevron-left"></i></a>
												</li>
												<li>
													<a href="#">1</a>
												</li>
												<li>
													<a href="#">2</a>
												</li>
												<li>
													<a href="#">3</a>
												</li>
												<li>
													<a href="#">4</a>
												</li>
												<li>
													<a href="#">5</a>
												</li>
												<li>
													<a href="#"><i class="fa fa-chevron-right"></i></a>
												</li>
											</ul>
										</div>
									</div>
								</footer>
							</section>
						</section>
					</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
				</section>

</asp:Content>
