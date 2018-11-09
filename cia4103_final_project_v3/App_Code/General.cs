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

    //The website uses only 1 cookie that contains many values. It will store values such as email.
    //It takes HttpRequest as an input because it needs to read the cookie from the user.
    //It takes HttpResponse as an input because the server needs to the cookie from the server side.
    public static void CreateCookie(HttpRequest Request, HttpResponse Response)
    {
        //If the cookie does not exist, then it will be created.
        if (Request.Cookies["volunteerCookie"] == null)
        {
            HttpCookie volunteerCookie = new HttpCookie("volunteerCookie");
            volunteerCookie.Expires = DateTime.Now.AddDays(365); //It will expire in a year.
            Response.Cookies.Add(volunteerCookie);
        }
    }

    //Takes Request and Response as input in-order to interact with cookies.
    //Example of key and value are following:
    //Key: Email, Value: myemail@gmail.com
    public static void InsertToCookie(HttpRequest Request, HttpResponse Response, string key, string value)
    {
        //If the cookie exists
        if (Request.Cookies["volunteerCookie"] != null)
        {
            HttpCookie volunteerCookie = new HttpCookie("volunteerCookie");
            volunteerCookie.Values[key] = value; //Insert key and value based on the input parameters.
            Response.Cookies.Add(volunteerCookie);
        }
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
 