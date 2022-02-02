using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS484_Lab3
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStudentName.Text = Session["StudentName"].ToString();
            lblStudentEmail.Text = Session["StudentEmail"].ToString();
        }
    }
}