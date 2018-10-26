using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Config
/// </summary>
public class Config
{
    public Config() { }

    public static string GetConnectionString()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        return connectionString;
    }
}