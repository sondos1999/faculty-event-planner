using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FacultyEventPlanner
{
    public partial class UserHome : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string cmdstr; 
        string constr = "Data Source=orcl; User Id=hr;Password=hr;";
        int count = 0;
        

        public UserHome()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            
            cmdstr = @"select title, capacity, description, l_name, ls_date, ls_start_time,
                d_title, user_name from EVENT, department, host
                where request_status = 'Rejected'
                AND title = e_title
                AND event.d_id =  department.d_id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds, "event");
            eventsDGV.DataSource = ds.Tables["event"];
            cmdstr = "select * from department";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.Fill(ds, "dep");
            depComboBox.Items.Add("All");
            foreach (DataRow row in ds.Tables["dep"].Rows)
            {
                depComboBox.Items.Add(row["D_TITLE"].ToString());
            }
            

        }

        private void depComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (depComboBox.SelectedIndex != 0)
            {
                DataRow r = ds.Tables["dep"].Rows[depComboBox.SelectedIndex - 1];
                string d = r["D_ID"].ToString();
                if (ds.Tables.Contains(d))
                {
                    eventsDGV.DataSource = ds.Tables[d];
                    return;
                }

                cmdstr = @"select title, capacity, description, l_name, ls_date, ls_start_time,
                d_title, user_name from EVENT, department, host
                where request_status = 'Rejected'
                AND title = e_title
                AND event.d_id =  department.d_id";
                cmdstr += " and event.d_id = " + d;
                StreamWriter s = new StreamWriter(new FileStream("dep.txt", FileMode.Append));
                s.WriteLine(cmdstr);
                s.Close();
                adapter = new OracleDataAdapter(cmdstr, constr);
                adapter.Fill(ds, d);
                eventsDGV.DataSource = ds.Tables[d];
            }
            else
            {
                eventsDGV.DataSource = ds.Tables["event"];
            }
            
        }

        private void createEventBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            createEvent c = new createEvent();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }
    }
}
