using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Organizer
/// </summary>
public class Organizer
{
    //Attributes
    public int OrganizerID { get; set; }
    public int OrganizationID { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public char Gender { get; set; }
    public string MobileNumber { get; set; }
    public bool IsAdmin { get; set; }

    //Methods
    public static bool Authenticate(string Email, string Password)
    {
        //Open Database connection
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = Config.GetConnectionString();
        conn.Open();

        //Prepare SQL Command with parameter
        string sql = "SELECT Email, Password FROM Organizers WHERE Email = @Email AND Password = @Password";
        SqlCommand cmd = new SqlCommand(sql, conn);

        //Set the parameter value to Email and Password that is sent to the method
        cmd.Parameters.AddWithValue("Email", Email);
        cmd.Parameters.AddWithValue("Password", Password);

        //Checks if a matching email and password were found within the DB.
        SqlDataReader reader = cmd.ExecuteReader();
        bool isAccountFound;
        if (reader.Read())
        {
            isAccountFound = true;
        }
        else
        {
            isAccountFound = false;
        }

        //Closes connection and returns the true/false value.
        conn.Close();
        return isAccountFound;
    }

    //Constructor
    public Organizer() { }
}