using System;
using ClassLibrary2;
using ClassLibrary3;

namespace ThreetierArc
{
    public partial class WebForm1 : System.Web.UI.Page

    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            IUserRequestProcessor bl = new UserRequestProcessor();

            UserPL pl=new UserPL();

            pl.Name = TxtName1.Text;
            pl.City = TxtCity1.Text;
            pl.Email = TxtEmail1.Text;

            bl.InsertUser(pl);

            GridView1.DataSource = bl.SelectUser();
            GridView1.DataBind();
        }

        protected void TxtCity1_TextChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = TxtCity1.Text;
            GridView1.DataBind();
        }

        protected void TxtName1_TextChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = TxtName1.Text;
            GridView1.DataBind();
        }

        protected void TxtEmail1_TextChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = TxtEmail1.Text;
            GridView1.DataBind();
        }
    }
}