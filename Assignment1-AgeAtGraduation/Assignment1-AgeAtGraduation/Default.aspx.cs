using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentDate.Text = DateTime.Now.ToString();
    }

    protected void Calculate_Age_Button_Click(object sender, EventArgs e)
    {
        int gy, gm, gd, bYear, bMonth, bDay;
        Int32.TryParse(gradYear.Text, out gy);
        Int32.TryParse(gradMonth.Text, out gm);
        Int32.TryParse(gradDay.Text, out gd);
        Int32.TryParse(birthYear.Text, out bYear);
        Int32.TryParse(birthMonth.Text, out bMonth);
        Int32.TryParse(birthDay.Text, out bDay);

        int currentMonth = DateTime.Today.Month;
        int currentYear = DateTime.Today.Year;
        int currentDay = DateTime.Today.Day;

        currentMonth = currentMonth - bMonth;
        currentYear = currentYear - bYear;
        currentDay = currentDay - bDay;

        DateTime yourBirthday = new DateTime(bYear, bMonth, bDay);
        DateTime yourGrad = new DateTime(gy, gm, gd);

        TimeSpan ts = yourGrad - yourBirthday;

        int tYear = (int)ts.TotalDays / 365;

        int tDays = (int)ts.TotalDays % 365;

        string age = (gy - bYear).ToString();

        AgeLabel.Text = "You will be " + age + " years old when you graduate, (inaccurate).";

        TotalDaysLabel.Text = "You will be " + ts.TotalDays + " total days old when you graduate.";

        TotalDaysAndYears.Text = "You will be " + tYear + " years and " + tDays + " days old when you graduate.";
    }
}