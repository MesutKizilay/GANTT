using DevExpress.Web;
using DevExpress.Web.ASPxGantt;
using DevExpress.Web.Data;
using DevExpress.Web.Design;
using DevExpress.Web.FormLayout.Internal.RuntimeHelpers;
using DevExpress.Web.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXWebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Init()
        {
            Gantt.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}