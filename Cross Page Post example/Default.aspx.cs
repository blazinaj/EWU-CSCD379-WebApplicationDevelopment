/*
  This is an example of:
   - A two-page application that shares data from page-to-page using ViewState
   - Creating/using a custom C# class in a web app
   - Reading from a database once only, creating custom objects from the DB and storing
       the objects in an ArrayList<Order>.
   - Persisting the array list to the ViewState in page 1
   - Retreiving the array list for page 2 from a re-constructed page 1
*/
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private List<Order> theOrders;
    private Table tbl;


    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        OleDbDataReader dr;

        if (IsPostBack == false)
        {
            Label1.Text = "hello";
            TextBox1.Text = "Some text";
            try
            {
                this.theOrders = new List<Order>();
                //  Get database objects...
                //  Connect to database and open...
                String cnString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                cn = new OleDbConnection();

                cn.ConnectionString = cnString;

                // Create the SQL command...
                cmd = new OleDbCommand("SELECT * FROM Orders ORDER BY CusNum", cn);

                cn.Open();

                // Execute the SQL statement and get the dataset...
                dr = cmd.ExecuteReader();
                
                // Iterate over the dataset, create orders and add to collection...
                while (dr.Read())
                {
                    Order ord = new Order(int.Parse(dr["CusNum"].ToString()),
                                   dr["CusName"].ToString(),
                                   dr["Street"].ToString(),
                                   dr["City"].ToString(),
                                   dr["State"].ToString(),
                                   dr["Zip"].ToString(),
                                   int.Parse(dr["OrdNum"].ToString()),
                                   int.Parse(dr["LineNum"].ToString()),
                                   dr["SKU"].ToString(),
                                   dr["ItemDesc"].ToString(),
                                   int.Parse(dr["OrdQty"].ToString()),
                                   double.Parse(dr["UnitPrice"].ToString()),
                                   double.Parse(dr["UnitWeight"].ToString()));
                    theOrders.Add(ord);
                }

                dr.Close();
                cn.Close();
            }
            catch (Exception err)
            {
                lblStatus.Text = err.Message;
                return;
            }

        }  //  End !IsPostBack

        try
        {
            //  Restore the orders array from the viewstate...
            if (theOrders == null)
            {
                theOrders = (List<Order>)ViewState["theOrders"];
            }

            tbl = new Table();
            tbl.BorderStyle = BorderStyle.None;

            foreach (Order ord in theOrders)
            {
                TableRow row = new TableRow();
                row.BorderStyle = BorderStyle.Solid;

                row.Cells.Add(addCell(ord.Name));
                row.Cells.Add(addCell(ord.OrderNumber.ToString()));
                row.Cells.Add(addCell(ord.Description));
                row.Cells.Add(addCell(ord.Quantity.ToString()));
                row.Cells.Add(addCell(ord.Price.ToString()));

                tbl.Rows.Add(row);
            }
            Page.Controls.Add(tbl);
        }

        catch (Exception err)
        {
            lblStatus.Text = err.Message;
        }
    }

    private TableCell addCell(String pText)
    {
        TableCell cell = new TableCell();
        cell.BorderStyle = BorderStyle.Solid;
        cell.BorderWidth = 1;
        cell.Text = pText;

        return cell;
    }

    public List<Order> getorders()
    {
        return theOrders;
    }

    public Image getImage()
    {
        return this.Image1;
    }

    public Table getTable()
    {
        return this.tbl;
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        try
        {
            // Serialize the orders array to the viewstate...
            ViewState["theOrders"] = theOrders;
        }
        catch (Exception err)
        {
            lblStatus.Text = err.Message;
        }
    }

    public string Fullname()
    {
        return " -- This is coming from a code-behind method in the first page - Default.aspx.";
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("CrossPagePost.aspx");
        Server.Transfer("CrossPagePost.aspx", true);
        
    }

}