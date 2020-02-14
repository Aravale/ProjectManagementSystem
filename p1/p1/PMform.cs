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
    public partial class PMform : Form
    {
        Model m=new Model();
        string allpr=$"SELECT p.projectid,p.projectname AS Title,p.projectdesc AS Description,p.startdate AS 'Start Date'," +
                $"p.estdtime AS 'Estimated Time',c.clientname AS Client FROM project p INNER JOIN client c ON p.client_clientid=c.clientid";

        public PMform()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm = new login();
            frm.Show();
        }

        private void PMform_Load(object sender, EventArgs e)
        {
            dgv_projects.DataSource = m.GetData(allpr);
            dgv_projects.Columns[0].Visible = false;     
        }

        private void PMform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_addproject_Click(object sender, EventArgs e)
        {
            projectform frm = new projectform();
            frm.Show();
        }

        private void btn_deleteproject_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_projects.CurrentCell.OwningRow;
            string value = row.Cells["projectid"].Value.ToString();
            string projtitle = row.Cells["Title"].Value.ToString(); 

            DialogResult result = MessageBox.Show("Are you sure you want to Delete " + projtitle + "? Clicking Yes will also Delete all active tasks!", "Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string deletestr = @"Delete from project where projectid = '" + value + "'";

            if (result == DialogResult.Yes)
            {
                string gettasks = $"SELECT taskid,team_teamid FROM task WHERE project_projectid={value}";
                DataTable tasktable = new DataTable();
                tasktable = m.GetData(gettasks);
                foreach (DataRow r in tasktable.Rows) {
                    m.DeleteTask(int.Parse(r[0].ToString()), int.Parse(r[1].ToString()));
                }                
                m.DeleteProjectfromDb(deletestr);
                dgv_projects.DataSource = m.GetData(allpr);
                dgv_projects.Columns[0].Visible = false;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_projects.DataSource = m.GetData(allpr);
            dgv_projects.Columns[0].Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchstr = txt_search.Text.ToLower();
            switch (cmb_searchby.Text)
            {
                case "Project Title":
                    string srch= $"SELECT p.projectid,p.projectname AS Title,p.projectdesc AS Description,p.startdate AS 'Start Date'," +
                $"p.estdtime AS 'Estimated Time',c.clientname AS Client FROM project p INNER JOIN client c ON p.client_clientid=c.clientid " +
                $"WHERE p.projectname LIKE '%{searchstr}%'";
                    dgv_projects.DataSource = m.GetData(srch);
                    dgv_projects.Columns[0].Visible = false;
                    break;
                case "Client":
                    string srch2 = $"SELECT p.projectid,p.projectname AS Title,p.projectdesc AS Description,p.startdate AS 'Start Date'," +
                    $"p.estdtime AS 'Estimated Time',c.clientname AS Client FROM project p INNER JOIN client c ON p.client_clientid=c.clientid " +
                    $"WHERE c.clientname LIKE '%{searchstr}%'";
                    dgv_projects.DataSource = m.GetData(srch2);
                    dgv_projects.Columns[0].Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btn_editproject_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_projects.CurrentCell.OwningRow;
            int id = int.Parse(row.Cells["projectid"].Value.ToString());
            string pn = row.Cells["Title"].Value.ToString();
            string pd = row.Cells["Description"].Value.ToString();
            DateTime sd = Convert.ToDateTime(row.Cells["Start Date"].Value.ToString());
            DateTime et = Convert.ToDateTime(row.Cells["Estimated Time"].Value.ToString());
            string cn = row.Cells["Client"].Value.ToString();
            projectform editform = new projectform(id, pn, pd, sd, et, cn);
            editform.Show();
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgv_projects.CurrentCell.OwningRow;
                PMtaskform tf = new PMtaskform(int.Parse(row.Cells["projectid"].Value.ToString()));
                this.Hide();
                tf.Show();
            }
            catch (Exception) {
                MessageBox.Show("No Project is selected!");
            }
        }

        private void LL_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new login()).Show();
        }

        private void PMform_Click(object sender, EventArgs e)
        {
            dgv_projects.DataSource = m.GetData(allpr);
            dgv_projects.Columns[0].Visible = false;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_projects.DataSource = m.GetData(allpr);
            dgv_projects.Columns[0].Visible = false;
        }
    }
}
