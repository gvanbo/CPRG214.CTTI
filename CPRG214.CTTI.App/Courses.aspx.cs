using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214.CTTI.Data;

namespace CPRG214.CTTI.App
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new CTTIEntities();
            coursesDataGrid.DataSource = context.Courses.ToList();
            DataBind();
        }
    }
}