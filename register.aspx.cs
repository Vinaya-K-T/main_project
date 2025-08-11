using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_potholedete.operation;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;
using DAL_potholedete.entities;
using BLL_potholedete.operation;
using System.Net.Mail;
using System.Net;

namespace pothole_detection_system.login_public
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        op_register op=new op_register();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string pname = txtfn.Text;
            string phno = txtpno.Text;
            string uname = pname.Substring(0, 3) + phno.Substring(6, 3);

            et_register r = new et_register();
            r.name = txtfn.Text;
            r.phone = txtpno.Text;
            r.email = txtem.Text;
            r.password = txtpswd.Text;
            r.uname = uname;

            op.registration_insert(r);
            et_login el = new et_login();
            el.uname = uname;
            el.password = txtpswd.Text;
            el.role = "user";
            op_login opl = new op_login();
            opl.login_insert(el);

            //Mailing


            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("cloudservicemail@gmail.com");
            msg.To.Add(txtem.Text);
            msg.Subject = "Path hole Project Account Creation Mail";
            msg.Body = "You are successfully completed registration proccess.your login details are <br/>";
            msg.Body += "<h3>Username : " + uname + "<br/> Password :" + txtpswd.Text + "</h3>";



            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntwd = new NetworkCredential();
            ntwd.UserName = "cloudservicemail@gmail.com";
            ntwd.Password = "ffhaydgnffvbjplk";
            smt.UseDefaultCredentials = false;
            smt.Credentials = ntwd;
            smt.Port = 587;
            smt.EnableSsl = true;
            smt.Send(msg);

            Response.Write("<script>alert('inserted successfully');</script>");

        }
    }
}