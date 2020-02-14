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
    public partial class projectform : Form
    {
        Model m = new Model();
        int prid;
        int edit = 0;

        //Add Project form constructor
        public projectform()
        {
            InitializeComponent();
            cmb_clientname.DataSource = m.GetData("SELECT clientname FROM client");
            edit = 0;
        }

        //Edit Project form constructor
        public projectform(int pid,string pn, string pd, DateTime sd, DateTime est, string clname)
        {
            InitializeComponent();
            this.Text = "Edit Project Form";
            btn_add.Text = "Edit";
            prid = pid;
            txt_projectname.Text = pn;
            rtb_projectdescription.Text = pd;
            dtp_startdate.Value = sd;
            dtp_estdtime.Value = est;
            cmb_clientname.DataSource = m.GetData("SELECT clientname FROM client");
            cmb_clientname.SelectedIndex = cmb_clientname.FindString(clname);
            edit = 1;
           
        }

        Project p;

        private void btn_add_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            int ep = 0;

            if (txt_projectname.Text == "")
            {
                ep = 1;
                ep1.SetError(txt_projectname, "Title can not be empty!");
            }
            if (dtp_estdtime.Value < dtp_startdate.Value)
            {
                ep = 1;
                ep1.SetError(dtp_estdtime, "Estimated end date must be after start date!");
            }

            if (ep==0)
            {
                if (edit == 0)
                {
                    p = new Project(txt_projectname.Text, rtb_projectdescription.Text, dtp_startdate.Value, dtp_estdtime.Value, cmb_clientname.Text);
                    try
                    {
                        p.AddProjecttoDb();
                        MessageBox.Show("Project Added");
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
                        m.UpdateProject(prid, txt_projectname.Text, rtb_projectdescription.Text, dtp_startdate.Value, dtp_estdtime.Value, m.Getclientid(cmb_clientname.Text));
                    }

                }
            }
        }

        private void LL_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
