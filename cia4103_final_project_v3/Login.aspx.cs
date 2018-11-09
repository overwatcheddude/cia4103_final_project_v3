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

    private void rememberEmail()
    {
        //If the user checked "Remember Email?" checkbox.
        if (cbRememberEmail.Checked)
        {
            //Reads the email from the textbox.
            string email = txtEmail.Text.ToString();

            //Calls a method to create a cookie (if it does not exist).
            General.CreateCookie(Request, Response);

            //Insert email value into email key (if the cookie exists).
            General.InsertToCookie(Request, Response, "email", email);
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Calls the remember email method to save the user's email in a cookie if the remember email checkbox was checked.
        rememberEmail();

        //Read email and password from textboxes.
        string email = txtEmail.Text;
        string password = txtPassword.Text;

        //If the user's account exists, then redirect him to a webpage and store his email as session, else display error message.
        if (Student.Authenticate(email, password))
        {
            Session["accType"] = "Student";
            Session["email"] = email;
            Response.Redirect("Opportunities.aspx");
        }
        if (Organizer.Authenticate(email, password))
        {
            Session["accType"] = "Organizer";
            Session["email"] = email;
            Response.Redirect("Opportunities.aspx");
        }
        else
        {
            displayMessage("Cannot find your account within DB.");
        }
    }
}