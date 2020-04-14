using System;
using System.Collections;
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
    public partial class MyEvents : Form
    {
        enum RequestStatus
        {
            ACCEPTED, REJECTED, PENDING
        };
        struct Event
        {
            public string title, description, location, start_time, end_time, department, date;
            public int capacity;
            public RequestStatus rs;
        };

        ArrayList dates, startTimes, endTimes, events, dids;
        List<Panel> listPanel;
        int panelIndx, evTimeIndx=0, evLocIndx, evDepIndx;

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
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

            if (locCB.SelectedIndex < 0 || depCB.SelectedIndex <0)
            {
                MessageBox.Show("Please do not leave empty fields..", "Warning");
                return;
            }

            try
            {
                int x = int.Parse(capTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter number in capacity...", "Warning");
            }


            //insert event
            OracleCommand insEvent = new OracleCommand();
            insEvent.Connection = OracleHelper.getConnection();
            insEvent.CommandText = "Update_Event";
            insEvent.CommandType = CommandType.StoredProcedure;
            insEvent.Parameters.Add("t", titleTxt.Text);
            insEvent.Parameters.Add("cap", capTxt.Text);
            insEvent.Parameters.Add("des", descriptionTxt.Text);
            insEvent.Parameters.Add("ln", locCB.SelectedItem.ToString());
            if (timeCB.SelectedIndex >= 0)
            {
                int tIndx = timeCB.SelectedIndex;
                insEvent.Parameters.Add("st", startTimes[tIndx].ToString());
                insEvent.Parameters.Add("ld", dates[tIndx].ToString().ToUpper());
            }
            else
            {
                Event ev = (Event)events[eventsCLB.SelectedIndex];
                insEvent.Parameters.Add("st", ev.start_time);
                insEvent.Parameters.Add("ld", ev.date);
            }
            insEvent.Parameters.Add("did", dids[depCB.SelectedIndex]);
            insEvent.ExecuteNonQuery();

            MessageBox.Show("Event successfully updated!", "Success");
            titleTxt.Clear();
            descriptionTxt.Clear();
            capTxt.Clear();
            listPanel[0].BringToFront();
            events.Clear();
            eventsCLB.Items.Clear();

            OracleCommand getEvents = new OracleCommand();
            getEvents.Connection = OracleHelper.getConnection();
            getEvents.CommandType = CommandType.StoredProcedure;
            getEvents.CommandText = "GetEvents";
            getEvents.Parameters.Add("ref", OracleDbType.RefCursor, ParameterDirection.Output);
            getEvents.Parameters.Add("hst", OracleHelper.LoggedIn.user_name);
            OracleDataReader eventsDR = getEvents.ExecuteReader();

            while (eventsDR.Read())
            {
                Event ev = new Event();
                ev.title = eventsDR[0].ToString();
                ev.capacity = int.Parse(eventsDR[2].ToString());
                ev.description = eventsDR[3].ToString();
                ev.location = eventsDR[4].ToString();
                ev.start_time = eventsDR[5].ToString();
                ev.date = eventsDR[6].ToString();
                ev.department = eventsDR[7].ToString();
                ev.end_time = eventsDR[8].ToString();
                if (eventsDR[1].ToString().CompareTo("Rejected") == 0)
                    ev.rs = RequestStatus.REJECTED;
                else if (eventsDR[1].ToString().CompareTo("accepted") == 0)
                    ev.rs = RequestStatus.ACCEPTED;
                else if (eventsDR[1].ToString().CompareTo("pending") == 0)
                    ev.rs = RequestStatus.PENDING;
                eventsCLB.Items.Add(ev.title + " " + ev.rs.ToString());
                events.Add(ev);

            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            descriptionTxt.Clear();
            capTxt.Clear();
            listPanel[0].BringToFront();
            events.Clear();
            eventsCLB.Items.Clear();

            OracleCommand getEvents = new OracleCommand();
            getEvents.Connection = OracleHelper.getConnection();
            getEvents.CommandType = CommandType.StoredProcedure;
            getEvents.CommandText = "GetEvents";
            getEvents.Parameters.Add("ref", OracleDbType.RefCursor, ParameterDirection.Output);
            getEvents.Parameters.Add("hst", OracleHelper.LoggedIn.user_name); 
            OracleDataReader eventsDR = getEvents.ExecuteReader();

            while (eventsDR.Read())
            {
                Event ev = new Event();
                ev.title = eventsDR[0].ToString();
                ev.capacity = int.Parse(eventsDR[2].ToString());
                ev.description = eventsDR[3].ToString();
                ev.location = eventsDR[4].ToString();
                ev.start_time = eventsDR[5].ToString();
                ev.date = eventsDR[6].ToString();
                ev.department = eventsDR[7].ToString();
                ev.end_time = eventsDR[8].ToString();
                if (eventsDR[1].ToString().CompareTo("Rejected") == 0)
                    ev.rs = RequestStatus.REJECTED;
                else if (eventsDR[1].ToString().CompareTo("accepted") == 0)
                    ev.rs = RequestStatus.ACCEPTED;
                else if (eventsDR[1].ToString().CompareTo("pending") == 0)
                    ev.rs = RequestStatus.PENDING;
                eventsCLB.Items.Add(ev.title + " " + ev.rs.ToString());
                events.Add(ev);

            }
        }

        public MyEvents()
        {
            InitializeComponent();
            events = new ArrayList();
            listPanel = new List<Panel>();
            panelIndx = 0;
        }

        private void MyEvents_Load(object sender, EventArgs e)
        {
            listPanel.Add(eventsPanel);
            listPanel.Add(editPanel);
            listPanel[panelIndx].BringToFront();

            OracleCommand getEvents = new OracleCommand();
            getEvents.Connection = OracleHelper.getConnection();
            getEvents.CommandType = CommandType.StoredProcedure;
            getEvents.CommandText = "GetEvents";
            getEvents.Parameters.Add("ref", OracleDbType.RefCursor, ParameterDirection.Output);
            getEvents.Parameters.Add("hst", OracleHelper.LoggedIn.user_name);
            OracleDataReader eventsDR = getEvents.ExecuteReader();
            
            while (eventsDR.Read())
            {
                Event ev = new Event();
                ev.title = eventsDR[0].ToString();
                ev.capacity = int.Parse( eventsDR[2].ToString());
                ev.description = eventsDR[3].ToString();
                ev.location = eventsDR[4].ToString();
                ev.start_time = eventsDR[5].ToString();
                ev.date = eventsDR[6].ToString();
                ev.department = eventsDR[7].ToString();
                ev.end_time = eventsDR[8].ToString();
                if (eventsDR[1].ToString().CompareTo("Rejected") == 0)
                    ev.rs = RequestStatus.REJECTED;
                else if (eventsDR[1].ToString().CompareTo("accepted") == 0)
                    ev.rs = RequestStatus.ACCEPTED;
                else if (eventsDR[1].ToString().CompareTo("pending") == 0)
                    ev.rs = RequestStatus.PENDING;
                eventsCLB.Items.Add(ev.title+" "+ev.rs.ToString());
                events.Add(ev);
             
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
                timeCB.Items.Add(locDR[0] + ": " + locDR[1] + " - " + locDR[2]);
                dates.Add(locDR[0]);
                startTimes.Add(locDR[1]);
                endTimes.Add(locDR[2]);
                
            }
            locDR.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (eventsCLB.CheckedItems.Count <=0)
            {
                MessageBox.Show("You must make a selection...", "Warning");
                return;
            }
            for (int i=0; i<eventsCLB.CheckedIndices.Count; i++)
            {
                OracleCommand del = new OracleCommand();
                del.Connection = OracleHelper.getConnection();
                del.CommandType = CommandType.StoredProcedure;
                del.CommandText = "DeleteEvent";
                Event ev = (Event)events[eventsCLB.CheckedIndices[i]];
                del.Parameters.Add("t", ev.title);
                del.ExecuteNonQuery();
                events.RemoveAt(eventsCLB.CheckedIndices[i]);
            }
            eventsCLB.Items.Clear();
            foreach(Event ev in events)
            {
                eventsCLB.Items.Add(ev.title + " " + ev.rs.ToString());
            }

        }

        private void timeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (eventsCLB.CheckedItems.Count > 1)
            {
                MessageBox.Show("You cannot edit more than 1 event at a time!", "Warning");
                return;
            }

            listPanel[1].BringToFront();

            Event ev = (Event)events[eventsCLB.SelectedIndex];
            
            #region location combo box
            OracleCommand loc = new OracleCommand();
            loc.Connection = OracleHelper.getConnection();
            loc.CommandText = "select l_name from location";
            loc.CommandType = CommandType.Text;
            OracleDataReader locDR = loc.ExecuteReader();
            evLocIndx = 0;
            while (locDR.Read())
            {
                locCB.Items.Add(locDR[0].ToString());
                if (ev.location.CompareTo(locDR[0].ToString()) == 0)
                    evLocIndx=locCB.Items.Count-1;
            }
            locDR.Close();
            #endregion

            #region depCB
            dids = new ArrayList();
            OracleCommand dep = new OracleCommand();
            dep.Connection = OracleHelper.getConnection();
            dep.CommandText = "select * from department";
            dep.CommandType = CommandType.Text;
            OracleDataReader depDR = dep.ExecuteReader();
            evDepIndx = 0;
            while (depDR.Read())
            {
                depCB.Items.Add(depDR[1]);
                dids.Add(depDR[0]);
                if (ev.department.CompareTo(depDR[1].ToString()) == 0)
                    evDepIndx= depCB.Items.Count-1;
            }
            depDR.Close();
            #endregion

            
            titleTxt.Text = ev.title.ToString();
            descriptionTxt.Text = ev.description.ToString();
            capTxt.Text = ev.capacity.ToString();
            locCB.SelectedIndex = evLocIndx;
            timeCB.Text = ev.date.ToString() + ": " + ev.start_time + " - " + ev.end_time;
            depCB.SelectedIndex = evDepIndx;
        }
    }
}
