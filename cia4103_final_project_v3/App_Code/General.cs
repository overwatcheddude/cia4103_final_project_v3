using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class General
{
    public General()
    {
        //Constructor
    }

    //Useful for debugging
    //Example: Log("Email value is" + email);
    public static void Log(string msg)
    {
        System.Diagnostics.Debug.WriteLine(msg);
    }

    /*Check if the user is logged in or not.
     * The first parameter requires a session object, such as Session["email"].
     * The second parameter requires an HttpResponse because it will allow the method to redirect the user to the Login page.
     * Example: IsAuthenticated(Session["email"], Response);
    */
    public static void IsAuthenticated(Object Session, HttpResponse Response)
    {
        //If session is empty, then redirect user to login page. Else, do nothing.
        if (Session == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            return;
        }
    }
}
 