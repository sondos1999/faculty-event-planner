using System;
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
using System.Collections;

namespace FacultyEventPlanner
{
    public partial class createEvent : Form
    {
        OracleDataReader depDR;
        OracleDataReader userDR;
        ArrayList dates, startTimes, endTimes;
        public createEvent()
        {
            InitializeComponent();
        }

        private void createEvent_Load(object sender, EventArgs e)
        {
            #region location combo box
            OracleCommand loc = new OracleCommand();
            loc.Connection = OracleHelper.getConnection();
            loc.CommandText = "select l_name from location";
            loc.CommandType = CommandType.Text;
            OracleDataReader locDR = loc.ExecuteReader();
            while (locDR.Read())
            {
                locCB.Items.Add(locDR[0]);
            }
            #endregion

            #region depCB
            OracleCommand dep = new OracleCommand();
            dep.Connection = OracleHelper.getConnection();
            dep.CommandText = "select * from department";
            dep.CommandType = CommandType.Text;
            depDR = dep.ExecuteReader();
            while (depDR.Read())
            {
                depCB.Items.Add(depDR[1]);
            }
            #endregion

            #region userCB
            OracleCommand user = new OracleCommand();
            user.Connection = OracleHelper.getConnection();
            user.CommandText = "select first_name, last_name, user_name  from users";
            user.CommandType = CommandType.Text;
            userDR = user.ExecuteReader();
            while (userDR.Read())
            {
                hostCLB.Items.Add(userDR[0]+" "+userDR[1]);
            }
            #endregion

        }

        private void capTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                //event title is unique

                int x = int.Parse(capTxt.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter number in capacity...", "Warning");
            }

        }

        private void locCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand loc = new OracleCommand();
            loc.Connection = OracleHelper.getConnection();
            loc.CommandText = @"select date_, start_time, end_time
                            from locations_schedule
                            where status = 'Available'
                            and l_name =:loc";
            loc.Parameters.Add("loc", locCB.SelectedItem.ToString());
            loc.CommandType = CommandType.Text;
            OracleDataReader locDR = loc.ExecuteReader();
            
            dates = new ArrayList();
            startTimes = new ArrayList();
            endTimes = new ArrayList();
            timeCB.Items.Clear();
            timeCB.Text = "";
            while (locDR.Read())
            {
                timeCB.Items.Add(locDR[0]+": "+ locDR[1]+" - "+ locDR[2]);
                dates.Add(locDR[0]);
                startTimes.Add(locDR[1]);
                endTimes.Add(locDR[2]);
            }
        }
    }
}
