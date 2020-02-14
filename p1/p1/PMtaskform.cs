using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class PMtaskform : Form
    {
        int projectid;
        string gettasks;
        public PMtaskform(int prid)
        {
            projectid = prid; 
            InitializeComponent();
            label1.Text = "Viewing tasks for "+m.GetProjectName(projectid);
            gettasks = $"SELECT t.taskid,t.taskname AS Task,t.taskdesc AS Description,t.startdate AS 'Start Date'," +
                    $"t.estdtime AS 'Estimated Time',t.team_teamid AS 'Team ID',e.name AS 'Team Lead' FROM task t INNER JOIN employee e on t.team_teamid=e.team_teamid WHERE t.project_projectid={projectid} " +
                    $"AND e.authlevel=2";
        }
        Model m = new Model();
        private void PMtaskform_Load(object sender, EventArgs e)
        {
            dgv_tasks.DataSource = m.GetData(gettasks);
            dgv_tasks.Columns[0].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            taskform tskf = new taskform(projectid);
            tskf.Show();
        }

        private void LL_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            this.Hide();
            (new PMform()).Show();
            
        }

        private void PMtaskform_Shown(object sender, EventArgs e)
        {
            dgv_tasks.DataSource = m.GetData(gettasks);
            dgv_tasks.Columns[0].Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_tasks.CurrentCell.OwningRow;
                int pid = projectid;
                int taskid = int.Parse(row.Cells["taskid"].Value.ToString());
                string taskname = row.Cells["TASK"].Value.ToString();
                string taskdesc = row.Cells["Description"].Value.ToString();
                DateTime estdtime = Convert.ToDateTime(row.Cells["Estimated Time"].Value.ToString());
                DateTime stdate = Convert.ToDateTime(row.Cells["Start Date"].Value.ToString());
                int teamid = int.Parse(row.Cells["Team"].Value.ToString());
                taskform editform = new taskform(pid, taskid, taskname, taskdesc, estdtime, stdate, teamid);
                editform.Show();
            }
            catch (Exception) {
                MessageBox.Show("No Task is selected!");
            }
        }

        private void PMtaskform_Click(object sender, EventArgs e)
        {
            dgv_tasks.DataSource = m.GetData(gettasks);
            dgv_tasks.Columns[0].Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_tasks.CurrentCell.OwningRow;
                int taskid = int.Parse(row.Cells["taskid"].Value.ToString());
                int teamid = int.Parse(row.Cells["Team"].Value.ToString());
                m.DeleteTask(taskid, teamid);
                dgv_tasks.DataSource = m.GetData(gettasks);
                dgv_tasks.Columns[0].Visible = false;
            }
            catch (Exception) {
                MessageBox.Show("No Task is selected!");
            }
        }

        private void PMtaskform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_tasks.DataSource = m.GetData(gettasks);
            dgv_tasks.Columns[0].Visible = false;
        }
    }
}
