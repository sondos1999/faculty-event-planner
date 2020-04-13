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

        ArrayList events;
        List<Panel> listPanel;
        int panelIndx;
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
            getEvents.Parameters.Add("hst", "HT_2000"); // TODO use logged in
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            for(int i=0; i<eventsCLB.CheckedIndices.Count; i++)
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
    }
}
