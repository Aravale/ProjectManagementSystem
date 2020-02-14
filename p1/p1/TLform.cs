using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class TLform : Form
    {
        int employeeid;
        int teamid;
        int taskid;
        int deptid;
        int projectid;
        string tskname;
        string tskdesc;
        string projectname;
        DateTime startdate;
        DateTime estdtime;
        DataTable teammembers;
        DataTable availmembers;
        Model m = new Model();
        public TLform(int eid)
        {
            employeeid = eid;
            DataTable DTpname = m.GetData("SELECT p.projectname from project p INNER JOIN employee e ON e.project_projectid=p.projectid WHERE" +
                                    $" empid={eid}");
            projectname = DTpname.Rows[0][0].ToString();

            DataTable DTprid = m.GetData($"SELECT project_projectid from employee WHERE empid={eid}");
            projectid = int.Parse(DTprid.Rows[0][0].ToString());

            DataTable DTteamid = m.GetData($"SELECT team_teamid from employee WHERE empid={eid}");
            teamid = int.Parse(DTteamid.Rows[0][0].ToString());

            DataTable DTdeptid = m.GetData($"SELECT department_deptid from employee WHERE empid={employeeid}");
            deptid = int.Parse(DTdeptid.Rows[0][0].ToString());

            DataTable DTtaskid = m.GetData($"SELECT task_taskid from team where teamid={teamid}");
            taskid = int.Parse(DTtaskid.Rows[0][0].ToString());

            DataTable DTtskname = m.GetData($"SELECT taskname from task where taskid={taskid}");
            tskname = DTtskname.Rows[0][0].ToString();

            DataTable DTtskdesc = m.GetData($"SELECT taskdesc from task where taskid={taskid}");
            tskdesc = DTtskdesc.Rows[0][0].ToString();

            DataTable DTstartdate = m.GetData($"SELECT startdate from task where taskid={taskid}");
            startdate = Convert.ToDateTime(DTstartdate.Rows[0][0].ToString());

            DataTable DTestdtime = m.GetData($"SELECT estdtime from task where taskid={taskid}");
            estdtime = Convert.ToDateTime(DTestdtime.Rows[0][0].ToString());

            teammembers = m.GetData($"SELECT name FROM employee WHERE team_teamid={teamid} AND authlevel=1");

            availmembers = m.GetData($"SELECT name FROM employee WHERE team_teamid IS NULL AND department_deptid={deptid}");

           
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Model.connstr))
            {
                conn.Open();
                string update = $"UPDATE task SET taskdesc='{rtd_desc.Text}' WHERE taskid={taskid}";
                SqlCommand command = new SqlCommand(update, conn);
                command.ExecuteNonQuery();
            }
        }

        private void TLform_Load(object sender, EventArgs e)
        {
            lbl_title.Text = $"Project:'{projectname}'\nTeam:#{teamid}\nTask:#{taskid} {tskname}";
            dtp_startdate.Value = startdate;
            dtp_estdtime.Value = estdtime;
            rtd_desc.Text = tskdesc;

            List<string> str = new List<string>();
            foreach (DataRow dr in teammembers.Rows)
            {str.Add($"{dr["name"]}");}

            lb_teammembers.DataSource = str;

            List<string> str1 = new List<string>();
            foreach (DataRow dr in availmembers.Rows)
            {str1.Add($"{dr["name"]}"); }

            cmb_teamadd.DataSource = str1;

            DateTime today = DateTime.Today;
            if (today >= startdate)
            {
                pn1.BackColor = Color.Cyan;
            }
            if (today <= estdtime && today >= startdate)
            {
                pn2.BackColor = Color.LimeGreen;
            }
            else if (today > estdtime)
            {
                pn2.BackColor = Color.OrangeRed;
            }
        }

        private void btn_addmember_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DTemptoaddid = m.GetData($"SELECT empid FROM employee WHERE name='{cmb_teamadd.Text}'");
                int emptoaddid = int.Parse(DTemptoaddid.Rows[0][0].ToString());

                using (SqlConnection conn = new SqlConnection(Model.connstr))
                {
                    conn.Open();
                    string update = $"UPDATE employee SET team_teamid={teamid}, project_projectid={projectid} WHERE empid={emptoaddid}";
                    SqlCommand command = new SqlCommand(update, conn);
                    command.ExecuteNonQuery();
                }
                teammembers = m.GetData($"SELECT name FROM employee WHERE team_teamid={teamid} AND authlevel=1");
                availmembers = m.GetData($"SELECT name FROM employee WHERE team_teamid IS NULL AND department_deptid={deptid}");
                List<string> str = new List<string>();
                foreach (DataRow dr in teammembers.Rows)
                { str.Add($"{dr["name"]}"); }

                lb_teammembers.DataSource = str;

                List<string> str1 = new List<string>();
                foreach (DataRow dr in availmembers.Rows)
                { str1.Add($"{dr["name"]}"); }

                cmb_teamadd.DataSource = str1;
            }
            catch (Exception) {
                MessageBox.Show("There are no Employees available to add!");
            }
        }

        private void btn_removemember_Click(object sender, EventArgs e)
        {
            DataTable DTemptoremoveid = m.GetData($"SELECT empid FROM employee WHERE name='{lb_teammembers.SelectedValue.ToString()}'");
            int emptoremoveid = int.Parse(DTemptoremoveid.Rows[0][0].ToString());

            using (SqlConnection conn = new SqlConnection(Model.connstr))
            {
                conn.Open();
                string update = $"UPDATE employee SET team_teamid=null, project_projectid=null WHERE empid={emptoremoveid}";
                SqlCommand command = new SqlCommand(update, conn);
                command.ExecuteNonQuery();
            }
            teammembers = m.GetData($"SELECT name FROM employee WHERE team_teamid={teamid} AND authlevel=1");
            availmembers = m.GetData($"SELECT name FROM employee WHERE team_teamid IS NULL AND department_deptid={deptid}");
            List<string> str = new List<string>();
            foreach (DataRow dr in teammembers.Rows)
            { str.Add($"{dr["name"]}"); }

            lb_teammembers.DataSource = str;

            List<string> str1 = new List<string>();
            foreach (DataRow dr in availmembers.Rows)
            { str1.Add($"{dr["name"]}"); }

            cmb_teamadd.DataSource = str1;
        }

        private void TLform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LL_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new login()).Show();
        }
    }
}
