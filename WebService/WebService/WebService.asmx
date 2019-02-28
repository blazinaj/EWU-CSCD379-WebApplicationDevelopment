<%@ WebService Language="C#" CodeBehind="~/App_Code/WebService.cs" Class="WebService" %>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://ziptasticapi.com")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DataTable ConnectToSQL()
    {
        string connectionString = "Data Source=SQL7002.site4now.net;Initial Catalog=DB_A444B6_webservice;User Id=DB_A444B6_webservice_admin;Password=webservice123;";
        SqlConnection cn = new SqlConnection(connectionString);
        SqlCommand cmd = cn.CreateCommand();
        SqlDataReader reader;
        cmd.CommandText = "select * from ZIP_Codes";
        cn.Open();
        reader = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Load(reader);
        cn.Close();
        return dt;
    }

    [WebMethod]
    public string DisplayResult()
    {
        DataTable zips = ConnectToSQL();
        string res = "";
        foreach (DataRow dr in zips.Rows)
        {
            foreach (var item in dr.ItemArray)
            {
                res += item;
            }
        }
        return res;


    }

}
