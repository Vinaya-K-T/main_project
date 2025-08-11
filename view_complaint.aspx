
<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="view_complaint.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 

   <%-- <section id="content">
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
							<li class="active">Datatable</li>
						</ul>
						<div class="m-b-md">
							<h3 class="m-b-none">Datatable</h3>
						</div>
						<section class="panel panel-default">
							<header class="panel-heading">
								DataTables <i class="fa fa-info-sign text-muted" data-placement="bottom" data-title="ajax to load the data." data-toggle="tooltip"></i>
							</header>
							<div class="table-responsive">
 <asp:GridView ID="GridView1" runat="server" class="table table-striped m-b-none" data-ride="datatables" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
     <Columns>
         <asp:ButtonField CommandName="del" Text="delete">
         <ControlStyle ForeColor="Red" />
         <FooterStyle ForeColor="#CC0000" />
         </asp:ButtonField>
         <asp:ButtonField CommandName="upd" Text="update">
         <ControlStyle ForeColor="#009933" />
         <FooterStyle ForeColor="#009933" />
         </asp:ButtonField>
     </Columns>
    </asp:GridView>
								<asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" CssClass="btn btn-success" />
								
							</div>
						</section>
					</section>
				</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
			</section>--%>
   

	  <section id="content">
					<section class="vbox">


						<div class="col-sm-6 col-md-3 padder-v b-r b-light">
							<span class="fa-stack fa-2x pull-left m-r-sm"> 
								<i class="fa fa-circle fa-stack-2x text-info"></i> 
								<i class="fa fa-male fa-stack-1x text-white"></i> 

							</span> <a class="clear" href="#"> 
								<span class="h3 block m-t-xs"><strong><asp:Label ID="lblc" runat="server" Text="Label"></asp:Label></strong></span> 
								<small class="text-muted text-uc">Completed Complaints</small> </a> 

						</div> 

						<div class="col-sm-6 col-md-3 padder-v b-r b-light">
				<span class="fa-stack fa-2x pull-left m-r-sm"> 
					<i class="fa fa-circle fa-stack-2x text-info"></i> 
					<i class="fa fa-male fa-stack-1x text-white"></i> 

				</span> <a class="clear" href="#"> 
					<span class="h3 block m-t-xs"><strong><asp:Label ID="lblnc" runat="server" Text="Label"></asp:Label></strong></span> 
					<small class="text-muted text-uc">Not Completed Complaints</small> </a> 

</div> 

						<section class="scrollable padder">
							<div class="m-b-md">
								<h3 class="m-b-none">COMPLAINT</h3>
							</div>
						
							<section class="panel panel-default">
								<header class="panel-heading">
									Responsive Table
								</header>
								
			<div class="table-responsive">
		
	<asp:Repeater ID="rptPathholes" runat="server">
    <HeaderTemplate>
       <table class="table table-striped b-t b-light">
		   <th>add contractor</th>
            <th># </th>
<th>Location</th>
<th>Details</th>
<th>Date</th>
<th>Image</th>
    </HeaderTemplate>
    <ItemTemplate>
			<%--<asp:GridView ID="GridView1" runat="server" class="table table-striped b-t b-light" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:ButtonField CommandName="ass" Text="Assign to condractors" >
                    <ControlStyle ForeColor="#0033CC" />
                    </asp:ButtonField>
                </Columns>
                </asp:GridView>   --%>                                                 
              <tr>
				  <td><a href="add_contracts.aspx?a=<%# Eval("code") %>">add contractor</a></td>

				<td><%# Eval("#") %></td>
				<td><%# Eval("Location") %></td>
				<td><%# Eval("Description") %></td>
				<td><%# Eval("Date") %></td>
				<td><img src="../path_hole/<%# Eval("Image") %>" width="100px" class="img-rounded" /></td>

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
