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
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dataSet = GetDataSet();

            StudentGridView.DataSource = dataSet.Tables["Student"];
            StudentGridView.DataBind();

            DepartmentGridView.DataSource = dataSet.Tables["Department"];
            DepartmentGridView.DataBind();
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
        public DataTable GetStudentTable()
        {
            dt = new DataTable("Student");

            dc = new DataColumn("Id", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("Name", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("DeptId", typeof(int));
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Name"] = "Ajith";
            dr["DeptId"] = 1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Id"] = 2;
            dr["Name"] = "Ajo";
            dr["DeptId"] = 2;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Id"] = 3;
            dr["Name"] = "Aji";
            dr["DeptId"] = 3;
            dt.Rows.Add(dr);

            return dt;
        }
        public DataSet GetDataSet()
        {
            DataTable student = GetStudentTable();
            DataTable department = GetDepartMentTable();
            ds = new DataSet();
            ds.Tables.Add(student);
            ds.Tables.Add(department);

            DataColumn col_primary_key = ds.Tables["Department"].Columns["Id"];
            DataColumn col_foreign_key = ds.Tables["Student"].Columns["DeptId"];
            DataRelation relation = new DataRelation("student_dept_relation",col_foreign_key,col_primary_key);
            ds.Relations.Add(relation);

            return ds;
        }
    }
}