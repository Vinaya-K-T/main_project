<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Site1.Master" AutoEventWireup="true" CodeBehind="view_contracts.aspx.cs" Inherits="pothole_detection_system.Admins.WebForm20" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <section id="content">
		<section class="vbox">
			<section class="scrollable padder">
				<div class="m-b-md">
					<h3 class="m-b-none">Datatable</h3>
				</div>
				<section class="panel panel-default">
					<header class="panel-heading">
						DataTables <i class="fa fa-info-sign text-muted" data-placement="bottom" data-title="ajax to load the data." data-toggle="tooltip"></i>
					</header>
					<div class="table-responsive">
							<asp:GridView ID="GridView1" runat="server" class="table table-striped b-t b-light" data-ride="datatables" OnRowCommand="GridView1_RowCommand">
                                <Columns>
                                    <asp:ButtonField CommandName="del" Text="delete">
                                    <ControlStyle ForeColor="Red" />
                                    </asp:ButtonField>
                                    <asp:ButtonField CommandName="upd"  Text="update">
                                    <ControlStyle ForeColor="#009933" />
                                    </asp:ButtonField>
                                    <asp:ButtonField CommandName="ch"  Text="choose">
                                    <ControlStyle ForeColor="Blue" />
                                    </asp:ButtonField>
                                </Columns>
                            </asp:GridView>

					</div>
				</section>
			</section>
		</section><a class="hide nav-off-screen-block" data-target="#nav,html" data-toggle="class:nav-off-screen, open" href="#"></a>
	</section>
</asp:Content>
