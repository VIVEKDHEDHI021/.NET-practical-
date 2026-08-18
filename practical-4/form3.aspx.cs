using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_4
{
    public partial class form3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode =
                UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            string department = RadioButtonList1.SelectedValue;
            string gender = RadioButtonList2.SelectedValue;

            string skills = "";

            if (CheckBox1.Checked)
            {
                skills += "C# ";
            }

            if (CheckBox2.Checked)
            {
                skills += "Python ";
            }

            if (CheckBox3.Checked)
            {
                skills += "AI ";
            }

            string terms = "Accepted";

            Label11.Text =

                "<h2>Submitted Details</h2>" +
                "<table border='1' cellpadding='8' cellspacing='0'>" +

                "<tr>" +
                "<th>Field</th>" +
                "<th>Details</th>" +
                "</tr>" +

                "<tr>" +
                "<td>Full Name</td>" +
                "<td>" + TextBox1.Text + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Email Id</td>" +
                "<td>" + TextBox2.Text + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Contact No.</td>" +
                "<td>" + TextBox3.Text + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>College</td>" +
                "<td>" + TextBox4.Text + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Department</td>" +
                "<td>" + RadioButtonList1.SelectedValue + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Event</td>" +
                "<td>" + DropDownList1.SelectedValue + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Gender</td>" +
                "<td>" + RadioButtonList2.SelectedValue + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Skills</td>" +
                "<td>" + skills + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Address</td>" +
                "<td>" + TextBox5.Text + "</td>" +
                "</tr>" +

                "<tr>" +
                "<td>Terms</td>" +
                "<td>" + terms + "</td>" +
                "</tr>" +

                "</table>";
        }
    }
}