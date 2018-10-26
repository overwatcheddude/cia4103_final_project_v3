using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void displayMessage(string msg)
    {
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + msg + "')", true);
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Read email and password from textboxes.
        string email = txtEmail.Text;
        string password = txtPassword.Text;

        //If the user's account exists, then redirect him to a webpage and store his email as session, else display error message.
        if (Student.Authenticate(email, password) || Organizer.Authenticate(email, password))
        {
            Session["email"] = email;
            Response.Redirect("Opportunities.aspx");
        }
        else
        {
            displayMessage("Cannot find your account within DB.");
        }
    }
}