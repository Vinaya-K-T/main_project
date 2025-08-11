<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="view_detection.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm14" %>
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
						
							<asp:GridView ID="GridView1" runat="server" class="table table-striped m-b-none"></asp:GridView>	
					</div>
				</section>
			</section>
		</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
	</section>
</asp:Content>
