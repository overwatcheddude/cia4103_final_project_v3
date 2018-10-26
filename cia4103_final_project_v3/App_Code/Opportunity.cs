using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Opportunity
/// </summary>
public class Opportunity
{
    //Attributes
    public int OpportunityID { get; set; }
    public int OrganizerID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string Emirate { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public static DataTable GetAll()
    {
        // Open Database Connection
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = Config.GetConnectionString();
        conn.Open();

        // Prepare SQL Command
        string query = "SELECT * FROM Opportunities";
        SqlCommand cmd = new SqlCommand(query, conn);

        // Create Data Adapter
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        // Initiate DataTable result with Data Adapter
        DataTable result = new DataTable();
        da.Fill(result);

        // Close connection and release Data Adapter
        conn.Close();
        da.Dispose();

        return result;
    }

    //Constructor
    public Opportunity() { }
}