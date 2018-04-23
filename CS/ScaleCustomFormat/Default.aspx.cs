using System;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;

namespace ScaleCustomFormat {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
        }


        protected void ASPxDashboard1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e)
        {
            Access97ConnectionParameters parameters = new Access97ConnectionParameters();
            parameters.FileName = Server.MapPath("~/App_Data/nwind.mdb");
            e.ConnectionParameters = parameters;
        }
    }
}