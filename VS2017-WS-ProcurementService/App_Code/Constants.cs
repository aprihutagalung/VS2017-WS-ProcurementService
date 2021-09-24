using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Constants
/// </summary>
public class Constants
{
    public const int OrgID = 1;
    public static string[] AppID = new string[] { "APP00319" };

    public static string LKAppConn = ConfigurationManager.ConnectionStrings["LKAppConn"].ConnectionString;

    public static string ProcurementSystemConn = ConfigurationManager.ConnectionStrings["ProcurementSystemConn"].ConnectionString;
    public const string HomeUrl = "~/Login.aspx";
    public const string HomePageUrl = "~/Forms/Homepage.aspx";
    public const string AccessDeniedUrl = "~/Lookup/AccessDenied.ascx";

    public static int SQLCmdTimeout = 30;
    public const string SessionUser = "User";

    //MasterPageUrl
    public static string LineItemPageUrl = "~/Forms/Master/LineItem.aspx";

    public static string CategoryPageUrl = "~/Forms/Master/Category.aspx";
}