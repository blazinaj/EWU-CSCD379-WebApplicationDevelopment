using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            SqlDataReader drInvoices = null;
            SqlDataReader drCustomers = null;

            Table invoiceTable = null;
            TableRow row = null;
            TableCell cell = null;

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = WebConfigurationManager.ConnectionStrings["DB_A444B6_blazinaj"].ConnectionString;

                command = new SqlCommand("SELECT * FROM Invoice WHERE Status = 'Open' ORDER BY CustNumber, InvoiceNumber", connection);

                connection.Open();

                drInvoices = command.ExecuteReader();

                invoiceTable = new Table();

                invoiceTable.CellPadding = 10;

                TableHeaderRow header = new TableHeaderRow();
                TableHeaderCell hinvoiceNum = new TableHeaderCell();
                TableHeaderCell hcustNumber = new TableHeaderCell();
                TableHeaderCell horderDate = new TableHeaderCell();
                TableHeaderCell hshipDate = new TableHeaderCell();
                TableHeaderCell hstatus = new TableHeaderCell();
                TableHeaderCell hperson = new TableHeaderCell();

                hinvoiceNum.Text = "Invoice Number";
                header.Cells.Add(hinvoiceNum);

                hcustNumber.Text = "Customer Number";
                header.Cells.Add(hcustNumber);

                horderDate.Text = "Order Date";
                header.Cells.Add(horderDate);

                hshipDate.Text = "Ship Date";
                header.Cells.Add(hshipDate);

                hstatus.Text = "Status";
                header.Cells.Add(hstatus);

                hperson.Text = "Contact";
                header.Cells.Add(hperson);

                invoiceTable.Rows.Add(header);



                //Invoices
                while (drInvoices.Read() == true)
                {
                    row = new TableRow();
                    cell = new TableCell();
                    cell.Text = drInvoices["InvoiceNumber"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string custNumber = drInvoices["CustNumber"].ToString();
                    cell.Text = custNumber;
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string orderDate = drInvoices["OrderDate"].ToString();
                    cell.Text = orderDate;
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string shipDate = drInvoices["ShipDate"].ToString();
                    cell.Text = shipDate;
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string status = drInvoices["Status"].ToString();
                    cell.Text = status;
                    row.Cells.Add(cell);

                    command = new SqlCommand("SELECT * FROM Customer WHERE CustNumber = " + custNumber, connection);
                    drCustomers = command.ExecuteReader();
                    if (drCustomers.Read() == true)
                    {
                        cell = new TableCell();
                        cell.Text = drCustomers["Contact"].ToString();
                        row.Cells.Add(cell);
                    }

                    invoiceTable.Rows.Add(row);
                }
                Page.Controls.Add(invoiceTable);
            }
            catch (Exception error)
            {
                this.lblStatus.Text = error.Message + "Jacob";
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        {
            SqlConnection connection = null;
            SqlCommand command = null;

            SqlDataReader drInvoices = null;
            SqlDataReader drCustomers = null;

            Table invoiceTable = null;
            TableRow row = null;
            TableCell cell = null;

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = WebConfigurationManager.ConnectionStrings["DB_A444B6_blazinaj"].ConnectionString;

                command = new SqlCommand("SELECT * FROM Invoice WHERE Status = 'Open' ORDER BY CustNumber, InvoiceNumber", connection);

                connection.Open();

                drInvoices = command.ExecuteReader();

                invoiceTable = new Table();

                invoiceTable.CellPadding = 10;

                TableHeaderRow header = new TableHeaderRow();
                TableHeaderCell hinvoiceNum = new TableHeaderCell();
                TableHeaderCell hcustNumber = new TableHeaderCell();
                TableHeaderCell horderDate = new TableHeaderCell();
                TableHeaderCell hshipDate = new TableHeaderCell();
                TableHeaderCell hstatus = new TableHeaderCell();
                TableHeaderCell hperson = new TableHeaderCell();

                hinvoiceNum.Text = "Invoice Number";
                header.Cells.Add(hinvoiceNum);

                hcustNumber.Text = "Customer Number";
                header.Cells.Add(hcustNumber);

                horderDate.Text = "Order Date";
                header.Cells.Add(horderDate);

                hshipDate.Text = "Ship Date";
                header.Cells.Add(hshipDate);

                hstatus.Text = "Status";
                header.Cells.Add(hstatus);

                hperson.Text = "Contact";
                header.Cells.Add(hperson);

                invoiceTable.Rows.Add(header);



                //Invoices
                while (drInvoices.Read() == true)
                {
                    row = new TableRow();
                    cell = new TableCell();
                    cell.Text = drInvoices["InvoiceNumber"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string custNumber = drInvoices["CustNumber"].ToString();
                    cell.Text = custNumber;
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string orderDate = drInvoices["OrderDate"].ToString();
                    cell.Text = orderDate;
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string shipDate = drInvoices["ShipDate"].ToString();
                    cell.Text = shipDate;
                    row.Cells.Add(cell);

                    cell = new TableCell();

                    string status = drInvoices["Status"].ToString();
                    cell.Text = status;
                    row.Cells.Add(cell);

                    command = new SqlCommand("SELECT * FROM Customer WHERE CustNumber = " + custNumber, connection);
                    drCustomers = command.ExecuteReader();
                    if (drCustomers.Read() == true)
                    {
                        cell = new TableCell();
                        cell.Text = drCustomers["Contact"].ToString();
                        row.Cells.Add(cell);
                    }

                    invoiceTable.Rows.Add(row);
                }
                Page.Controls.Add(invoiceTable);
            }
            catch (Exception error)
            {
                this.lblStatus.Text = error.Message + "Jacob";
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


    }
}