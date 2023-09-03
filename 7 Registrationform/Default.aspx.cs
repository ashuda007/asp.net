using System;
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

public partial class _Default : System.Web.UI.Page
{
    string m;
    string c;
  
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

        if (CheckBox1.Checked)
        {
            TextBox3.Text = TextBox2.Text;
        }
        else
        {
            TextBox3.Text="";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
          if (RadioButton1.Checked)
        {
             m=RadioButton1.Text;
        }
        else if (RadioButton2.Checked)
        {
            m= RadioButton2.Text;
        }

         
          if (CheckBox2.Checked)
          {
              c = CheckBox2.Text;
          }
          if (CheckBox3.Checked)
          {

              c= c+ " , " + CheckBox3.Text;
          }
          if (CheckBox4.Checked)
          {

              c = c + " , " + CheckBox4.Text;
          }

        Response.Redirect("Uploaddetail.aspx?fn=" + TextBox1.Text + "&padd=" + TextBox2.Text + "&ctr=" + DropDownList1.SelectedItem + "&sta=" + DropDownList2.Text + "&ct=" + DropDownList3.SelectedItem + "&gd=" + m +"&hb="+c );
    }
  
}
