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
        ArrayList dates, startTimes, endTimes, dids;
        Dictionary<string, string> usernames;
        public createEvent()
        {
            InitializeComponent();
        }

        private void createEvent_Load(object sender, EventArgs e)
        {
            dids = new ArrayList();
            usernames = new Dictionary<string, string>();
            #region location combo box
            OracleCommand loc = new OracleCommand();
            loc.Connection = OracleHelper.getConnection();
            loc.CommandText = "select l_name from location";
            loc.CommandType = CommandType.Text;
            OracleDataReader locDR = loc.ExecuteReader();
            while (locDR.Read())
            {
                locCB.Items.Add(locDR[0].ToString());
            }
            locDR.Close();
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
                dids.Add(depDR[0]);
            }
            depDR.Close();
            #endregion

            #region userCB
            OracleCommand user = new OracleCommand();
            user.Connection = OracleHelper.getConnection();
            user.CommandText = "select first_name, last_name, user_name  from users";
            user.CommandType = CommandType.Text;
            userDR = user.ExecuteReader();
            while (userDR.Read())
            {
                if (userDR[2].ToString().CompareTo(OracleHelper.LoggedIn.user_name) == 0)
                    continue;
                hostCLB.Items.Add(userDR[0]+" "+userDR[1]);
                usernames[userDR[0] + " " + userDR[1]] = userDR[2].ToString();
            }
            userDR.Close();
            #endregion

        }

        private void capTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void createEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            OracleHelper.closeConnection();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //event title is not empty
            if(titleTxt.Text.Length==0)
            {
                MessageBox.Show("Title is empty! Please enter a title...", "Warning");
                return;
            }
            //event title is unique
            OracleCommand title = new OracleCommand();
            title.Connection = OracleHelper.getConnection();
            title.CommandText = "IsTitleUnique";
            title.CommandType = CommandType.StoredProcedure;
            title.Parameters.Add("title", titleTxt.Text);
            int ret;
            title.Parameters.Add("ret", OracleDbType.Int32, ParameterDirection.Output);
            title.ExecuteNonQuery();

            //description is not empty
            if (descriptionTxt.Text.Length == 0)
            {
                MessageBox.Show("Description is empty! Please enter a description...", "Warning");
                return;
            }

            //capacity is not empty
            if (capTxt.Text.Length == 0)
            {
                MessageBox.Show("Capacity is empty! Please enter a capacity...", "Warning");
                return;
            }

            if (locCB.SelectedIndex < 0 || timeCB.SelectedIndex < 0 || depCB.SelectedIndex < 0)
            {
                MessageBox.Show("Please do not leave empty fields..", "Warning");
                return;
            }

            try
            {
                ret = int.Parse(title.Parameters["ret"].Value.ToString());
                if (ret == 0)
                {
                    MessageBox.Show("Title is not unique!", "Warning");
                    return;
                }
                int x = int.Parse(capTxt.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter number in capacity...", "Warning");
            }


            //insert event
            OracleCommand insEvent = new OracleCommand();
            insEvent.Connection = OracleHelper.getConnection();
            insEvent.CommandText = "Insert_Event";
            insEvent.CommandType = CommandType.StoredProcedure;
            insEvent.Parameters.Add("t", titleTxt.Text);
            insEvent.Parameters.Add("cap", capTxt.Text);
            insEvent.Parameters.Add("des", descriptionTxt.Text);
            insEvent.Parameters.Add("ln", locCB.SelectedItem.ToString());
            int tIndx = timeCB.SelectedIndex;
            insEvent.Parameters.Add("st", startTimes[tIndx].ToString());
            insEvent.Parameters.Add("et", endTimes[tIndx].ToString());
            insEvent.Parameters.Add("ld", dates[tIndx].ToString().ToUpper());
            insEvent.Parameters.Add("did", dids[depCB.SelectedIndex]);
            insEvent.Parameters.Add("hst", OracleHelper.LoggedIn.user_name);
            insEvent.ExecuteNonQuery();

            //insert hosts
            if (hostCLB.CheckedItems.Count > 0)
            {
                for(int i =0; i< hostCLB.CheckedItems.Count; i++)
                {
                    OracleCommand addHost = new OracleCommand();
                    addHost.Connection = OracleHelper.getConnection();
                    addHost.CommandText = "Add_Host";
                    addHost.CommandType = CommandType.StoredProcedure;
                    addHost.Parameters.Add("t", titleTxt.Text);
                    addHost.Parameters.Add("hst", usernames[hostCLB.CheckedItems[i].ToString()]);
                    addHost.ExecuteNonQuery();
                }
                
            }

            MessageBox.Show("Event successfully created!", "Success");
            titleTxt.Clear();
            descriptionTxt.Clear();
            capTxt.Clear();
            hostCLB.ClearSelected();


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
            locDR.Close();
        }
    }
}
