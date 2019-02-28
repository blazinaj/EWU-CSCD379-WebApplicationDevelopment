using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPagePost : System.Web.UI.Page
{
    private Table tbl;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            lblInfo.Text = "You came from a page titled " +
                PreviousPage.Title + "<br />";

            _Default prevPage = (_Default)PreviousPage;


            lblInfo.Text += "Some text from the previous page: " + prevPage.Fullname() + "<br />";

            List<Order> orders = prevPage.getorders();
            tbl = new Table();
            tbl.BorderStyle = BorderStyle.Dotted;
            tbl.EnableViewState = true;

            foreach (Order ord in orders)
            {
                if (ord.State.Equals("WA"))
                {

                    TableRow row = new TableRow();
                    row.BorderStyle = BorderStyle.Solid;

                    row.Cells.Add(addCell(ord.Name));
                    row.Cells.Add(addCell(ord.Street));
                    row.Cells.Add(addCell(ord.City));
                    row.Cells.Add(addCell(ord.State));
                    row.Cells.Add(addCell(ord.Zip));
                    row.Cells.Add(addCell(ord.OrderNumber.ToString()));
                    row.Cells.Add(addCell(ord.SKU));
                    row.Cells.Add(addCell(ord.Description));
                    row.Cells.Add(addCell(ord.Quantity.ToString()));
                    row.Cells.Add(addCell(ord.Price.ToString()));

                    tbl.Rows.Add(row);
                }
            }
            Panel2.Controls.Add(tbl);

            Image img = prevPage.getImage();
            Panel2.Controls.Add(img);

            //  Get the entire Table object that page 1 had...
            Table test = prevPage.getTable();
            Panel1.Controls.Add(test);
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
}