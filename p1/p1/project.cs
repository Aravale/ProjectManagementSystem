using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Project
    {
        public string projectname;
        public string projectdesc;
        public DateTime startdate;
        public DateTime estdtime;
        public int client_clientid;
        Model m = new Model();
        public Project(string pn,string pd,DateTime sd,DateTime est,string clname)
        {
            projectname = pn;
            projectdesc = pd;
            startdate = sd;
            estdtime = est;
            client_clientid = m.Getclientid(clname);
        }

        public void AddProjecttoDb()
        {
            

            using (SqlConnection conn = new SqlConnection(Model.connstr))
            {
                conn.Open();
                string insert = "INSERT INTO project(projectname, projectdesc, startdate, estdtime, client_clientid) VALUES (@projectname, @projectdesc, @startdate, @estdtime, @client_clientid)";
                SqlCommand command = new SqlCommand(insert, conn);
                command.Parameters.AddWithValue(@"projectname", projectname);
                command.Parameters.AddWithValue(@"projectdesc", projectdesc);
                command.Parameters.AddWithValue(@"startdate", startdate);
                command.Parameters.AddWithValue(@"estdtime", estdtime);
                command.Parameters.AddWithValue(@"client_clientid", client_clientid);
                command.ExecuteNonQuery();
            }
        }
    }
}
