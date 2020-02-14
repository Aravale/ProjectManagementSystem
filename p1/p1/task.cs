using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class task
    {
        public string taskname;
        public string taskdesc;
        public DateTime startdate;
        public DateTime estdtime;
        public int project_projectid;
        Model m = new Model();
        public task(string tn, string td, DateTime sd, DateTime est, int pid)
        {
            taskname = tn;
            taskdesc = td;
            startdate = sd;
            estdtime = est;
            project_projectid = pid;
        }

        public void AddTasktoDb()
        {
            

            using (SqlConnection conn = new SqlConnection(Model.connstr))
            {
                conn.Open();
                string insert = "INSERT INTO task(taskname, taskdesc, startdate, estdtime, project_projectid) VALUES (@taskname, @taskdesc, @startdate, @estdtime, @project_projectid)";
                SqlCommand command = new SqlCommand(insert, conn);
                command.Parameters.AddWithValue(@"taskname", taskname);
                command.Parameters.AddWithValue(@"taskdesc", taskdesc);
                command.Parameters.AddWithValue(@"startdate", startdate);
                command.Parameters.AddWithValue(@"estdtime", estdtime);
                command.Parameters.AddWithValue(@"project_projectid", project_projectid);
                command.ExecuteNonQuery();
            }
        }
    }
}
