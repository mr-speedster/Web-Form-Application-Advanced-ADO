using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationAdvancedADO
{
    public partial class WebFormCreateTable : System.Web.UI.Page
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public DataTable GetDepartMentTable()
        {
            dt = new DataTable("Department");

            dc = new DataColumn("Id",typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc= new DataColumn("Name",typeof(string));
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Name"] = "CSE";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Id"] = 2;
            dr["Name"] = "Mech";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Id"] = 3;
            dr["Name"] = "CE";
            dt.Rows.Add(dr);

            return dt;
        }
    }
}