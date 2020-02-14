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
    public partial class taskform : Form
    {
        int edit;
        int projectid;
        int taskid;
        int teamid;
        int currentlead;

        int teamleadid;
        public taskform(int pid)
        {
            projectid = pid;
            edit = 0;
            InitializeComponent();
        }

        public taskform(int pid, int taskid, string taskname, string taskdesc, DateTime estdtime, DateTime stdate, int teamid)
        {
            edit = 1;
            InitializeComponent();
            projectid = pid;
            btn_add.Text = "Edit";
            this.Text = "Edit Task";
            txt_taskname.Text = taskname;
            rtb_taskdescription.Text = taskdesc;
            dtp_estdtime.Value = estdtime;
            dtp_startdate.Value = stdate;
            this.taskid = taskid;
            teamleadid = m.GetTeamLeadID(teamid);
            this.teamid = teamid;
        }

        task t;
        Model m = new Model();

        private void btn_add_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            int ep = 0;

            DateTime projectenddate = Convert.ToDateTime(m.GetData($"Select estdtime from project where projectid={projectid}").Rows[0][0]);

            if (txt_taskname.Text == "")
            {
                ep = 1;
                ep1.SetError(txt_taskname, "Title can not be empty!");
            }
            if (dtp_estdtime.Value < dtp_startdate.Value)
            {
                ep = 1;
                ep1.SetError(dtp_estdtime, "Estimated end date must be after start date!");
            }
            if (projectenddate >= dtp_estdtime.Value)
            {
                ep = 1;
                ep1.SetError(dtp_startdate, "Estimated end date must be before or upto project end estimate!");
            }
                if (ep==0)
            {               
                    
                        if (edit == 0)
                        {
                            t = new task(txt_taskname.Text, rtb_taskdescription.Text, dtp_startdate.Value, dtp_estdtime.Value, projectid);
                            try
                            {
                                if (cmb_teamlead.SelectedIndex != -1)
                                {
                                    t.AddTasktoDb();
                                    //GETTING EMPLOYEE NAME FOR EMPLOYEE ID THROUGHT GET DATA>>
                                    string[] emp = cmb_teamlead.Text.Split('|');
                                    m.SetTeamLead(projectid, m.GetTaskIdLast(), int.Parse(emp[0]), 0);
                                    MessageBox.Show("Task Added");
                                    cmb_teamlead.DataSource = m.GetEmployeeswithDepartment();
                                }
                                else
                                {
                                    MessageBox.Show("No Employee available to be Team Lead!");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Do you really want to edit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                m.UpdateTask(taskid, txt_taskname.Text, rtb_taskdescription.Text, dtp_estdtime.Value, dtp_startdate.Value);

                                string[] emp = cmb_teamlead.Text.Split('|');
                                if (currentlead != int.Parse(emp[0].ToString()))
                                {
                                    m.SetTeamLead(projectid, taskid, int.Parse(emp[0]), 1);
                                    m.updateOldTeamMembers(teamid);
                                }
                                MessageBox.Show("Task Editted Successfully");
                            }

                        }   

            }
        }

        private void taskform_Load(object sender, EventArgs e)
        {

            if (edit == 1)
            {
                List<string> empstr = new List<string>();
                empstr = m.GetEmployeeswithDepartment();
                DataTable table = new DataTable();
                string sql = $"Select e.empid AS EmployeeID, e.name AS Name,d.deptname AS Department from employee e INNER JOIN department d ON e.department_deptid=d.deptid WHERE e.empid = '{teamleadid}'";
                SqlDataAdapter dad1 = new SqlDataAdapter(sql, Model.connstr);
                dad1.Fill(table);
                string selectedval = "";
                foreach (DataRow dr in table.Rows)
                {
                    selectedval = $"{dr["EmployeeID"]} | {dr["Name"]} | {dr["Department"]}";
                    currentlead = int.Parse(dr["EmployeeID"].ToString());
                    empstr.Add($"{dr["EmployeeID"]} | {dr["Name"]} | {dr["Department"]}");
                    cmb_teamlead.DataSource = empstr;
                    cmb_teamlead.SelectedIndex = cmb_teamlead.FindStringExact(selectedval);
                }
            }
            else
            {
                cmb_teamlead.DataSource = m.GetEmployeeswithDepartment();
            }
        }

        private void LL_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
