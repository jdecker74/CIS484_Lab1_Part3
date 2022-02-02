using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS484_Lab3
{
    public partial class StudentSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblPostBack.Text = "[[[Postback Occured]]]";
            }
            else
            {
                lblPostBack.Text = "First Time Loading Page";
            }
        }

        protected void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedStudent.Text = lstStudents.SelectedItem.ToString();
        }

        protected void btnViewStudentDetails_Click(object sender, EventArgs e)
        {
            Session["StudentName"] = lstStudents.SelectedItem.ToString();
            Session["StudentEmail"] = lstStudents.SelectedValue.ToString();
            Response.Redirect("StudentDetails.aspx");
                }
    }
}