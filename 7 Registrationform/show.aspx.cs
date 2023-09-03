using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
      //  Image1.ImageUrl = Request.QueryString["img"];
        TextBox1.Text = Request.QueryString["fn"];
        TextBox2.Text = Request.QueryString["padd"];
        TextBox3.Text = Request.QueryString["ctr"];
        TextBox4.Text = Request.QueryString["sta"];
        TextBox5.Text = Request.QueryString["ct"];
        TextBox6.Text = Request.QueryString["gd"];
        TextBox7.Text = Request.QueryString["hb"];

       Label12.Text= Request.QueryString["ug"];
       Label15.Text = Request.QueryString["pg"];
       Label10.Text = Request.QueryString["twp"];
       Label13.Text = Request.QueryString["ugp"];
       Label16.Text = Request.QueryString["pgp"];
       Image1.ImageUrl = Request.QueryString["fi"];
       Image2.ImageUrl = Request.QueryString["fi2"];
       HyperLink1.NavigateUrl = Request.QueryString["fp"];
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
