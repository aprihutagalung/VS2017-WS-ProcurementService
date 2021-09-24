using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ProcurementWS
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ProcurementWS : System.Web.Services.WebService
{

    public ProcurementWS()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public DataTable GetAllCategories()
    {
        using (SqlConnection conn = new SqlConnection(Constants.ProcurementSystemConn))
        {

            DataTable data = new DataTable { TableName = "TableCategories" };
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SPGetCategories";
                cmd.CommandTimeout = Constants.SQLCmdTimeout;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter oAdapter = new SqlDataAdapter();
                oAdapter.SelectCommand = cmd;

                oAdapter.Fill(data);
                oAdapter.Dispose();



                //int index = 1;
                //foreach (DataRow dr in data.Rows)
                //{
                //   dataBody += @"<tr class='odd gradeX'>
                //                        <td>" + index+ "</td>" +
                //                        "<td>" + dr["ItemName"] + @"</td>" +
                //                        "<td>" + dr["MeasureName"] + @"</td>"+
                //                        "<td>" + dr["CategoryName"] + @"</td>" +
                //                        "<td>" + dr["IsActive"] + @"</td>" +
                //                        "<td>" + dr["ModifiedDate"] + @"</td> " +
                //                        "<td>" + dr["ModifiedBy"] + @"</td>" +
                //                        "<td>ACTION</td>" +
                //                "</tr>";

                //    index++;
                //}

            }
            catch (Exception ex)
            {
                //log.ErrorFormat("ERROR GetUserPermission(). Message : {0}", ex.Message);
                throw;
            }
            finally
            {

                conn.Close();
                conn.Dispose();

            }

            return data;
        }

    }


    [WebMethod]
    public DataTable GetAllUOMS()
    {
        using (SqlConnection conn = new SqlConnection(Constants.ProcurementSystemConn))
        {

            DataTable data = new DataTable { TableName = "TableUOMS" };
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SPGetUOMS";
                cmd.CommandTimeout = Constants.SQLCmdTimeout;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter oAdapter = new SqlDataAdapter();
                oAdapter.SelectCommand = cmd;

                oAdapter.Fill(data);
                oAdapter.Dispose();



                //int index = 1;
                //foreach (DataRow dr in data.Rows)
                //{
                //   dataBody += @"<tr class='odd gradeX'>
                //                        <td>" + index+ "</td>" +
                //                        "<td>" + dr["ItemName"] + @"</td>" +
                //                        "<td>" + dr["MeasureName"] + @"</td>"+
                //                        "<td>" + dr["CategoryName"] + @"</td>" +
                //                        "<td>" + dr["IsActive"] + @"</td>" +
                //                        "<td>" + dr["ModifiedDate"] + @"</td> " +
                //                        "<td>" + dr["ModifiedBy"] + @"</td>" +
                //                        "<td>ACTION</td>" +
                //                "</tr>";

                //    index++;
                //}

            }
            catch (Exception ex)
            {
                //log.ErrorFormat("ERROR GetUserPermission(). Message : {0}", ex.Message);
                throw;
            }
            finally
            {

                conn.Close();
                conn.Dispose();

            }

            return data;
        }

    }

    [WebMethod]
    public DataTable GetAllLineItems()
    {
        using (SqlConnection conn = new SqlConnection(Constants.ProcurementSystemConn))
        {
            //string dataBody="";
            DataTable data = new DataTable { TableName="TableLineItems"};
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SPGetLineItems";
                cmd.CommandTimeout = Constants.SQLCmdTimeout;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter oAdapter = new SqlDataAdapter();
                oAdapter.SelectCommand = cmd;

                oAdapter.Fill(data);
                oAdapter.Dispose();
                


                //int index = 1;
                //foreach (DataRow dr in data.Rows)
                //{
                //   dataBody += @"<tr class='odd gradeX'>
                //                        <td>" + index+ "</td>" +
                //                        "<td>" + dr["ItemName"] + @"</td>" +
                //                        "<td>" + dr["MeasureName"] + @"</td>"+
                //                        "<td>" + dr["CategoryName"] + @"</td>" +
                //                        "<td>" + dr["IsActive"] + @"</td>" +
                //                        "<td>" + dr["ModifiedDate"] + @"</td> " +
                //                        "<td>" + dr["ModifiedBy"] + @"</td>" +
                //                        "<td>ACTION</td>" +
                //                "</tr>";

                //    index++;
                //}

            }
            catch (Exception ex)
            {
                //log.ErrorFormat("ERROR GetUserPermission(). Message : {0}", ex.Message);
                throw;
            }
            finally
            {

                conn.Close();
                conn.Dispose();
               
            }
            return data;

        }

         
    }

}
