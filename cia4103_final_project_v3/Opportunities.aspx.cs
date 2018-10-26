using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Opportunities : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Check if user is authenticated, if so, then redirect him to login page.
        General.IsAuthenticated(Session["email"], Response);

        //Sets the welcome text, and display the user's email and account type (Student or Organizer).
        lblWelcome.Text = "Welcome " + Session["email"].ToString() + ", your account type is " + Session["accType"];

        DataTable opportunities = Opportunity.GetAll();

        ListOpportunities(opportunities);
    }

    private void ListOpportunities(DataTable opportunities)
    {
        if (opportunities.Rows.Count == 0)
        {
            ltlError.Text = "No opportunities available. Please wait until new opportunities are added by organizations.";
        }
        else
        {
            rptrOpportunities.DataSource = opportunities;
            rptrOpportunities.DataBind();
        }
    }
}