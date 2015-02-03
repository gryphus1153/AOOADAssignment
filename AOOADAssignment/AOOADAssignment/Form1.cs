using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace AOOADAssignment
{
    public partial class Form1 : Form
    {
        static ArrayList userList = new ArrayList();
        static ArrayList EventList = new ArrayList();
        public Form1()
        {
            Address addr = new Address("Block 123", "Street1234", "uNo", "#01-900");
            Name name = new Name("stupid", "irritating", "dumbass");
            CreditCard cc = new CreditCard("ccNo", "09/25");
            ArrayList tickList = new ArrayList();
            ArrayList payList = new ArrayList();
            User cust1 = new Customer("uID", "pass", name, "email@email.com", addr, "999666999", cc, tickList, payList);
            userList.Add(cust1);

            DateTime time = Convert.ToDateTime("3/2/2015 12:00");
            DateTime endTime = Convert.ToDateTime("3/2/2015 18:00");
            Genre eg = new Genre("Fantasy");
            ArrayList performancesList = new ArrayList();
            ArrayList sManagers = new ArrayList();
            EventManager el = new EventManager();
            Event event1 = new Event("Disney Fat Princesses", time, endTime, eg, performancesList, 100, "Open", el, sManagers, true);
            EventList.Add(event1);

            DateTime time1 = Convert.ToDateTime("4/4/2015 12:00");
            DateTime endTime1 = Convert.ToDateTime("4/4/2015 18:00");
            Genre eg1 = new Genre("Dance");
            ArrayList performancesList1 = new ArrayList();
            ArrayList sManagers1 = new ArrayList();
            EventManager el1 = new EventManager();
            Event event2 = new Event("Dance dance?!", time1, endTime1, eg1, performancesList1, 100, "Open", el1, sManagers1, true);
            EventList.Add(event2);

            InitializeComponent();
        }

        private void startDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void EventNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool exist = false;

            foreach (User i in userList)
            {
                if (i.UserID.Equals(loginIDTextBox.Text))
                {
                    string pass = i.Password;
                    if (pass.Equals(passwordTextBox.Text))
                    {
                        tabControl1.Enabled = true;
                        tabControl1.Visible = true;
                        exist = true;
                        break;
                    }
                }
                tabControl1.Enabled = false;
                tabControl1.Visible = false;
                exist = false;
            }
            if (exist == true)
            {
                //TextBox t = new TextBox();
                //t.Text = "Logged in successfully";
                label3.Text = "Logged in successfully!";
            }
            else
            {
                label3.Text = "Log in unsuccessfully";
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            browseListView.View = View.Details;
            /*browseListView.Columns.Add("Event Name", -2, HorizontalAlignment.Center);
            browseListView.Columns.Add("Start Date", -2, HorizontalAlignment.Center);
            browseListView.Columns.Add("End Date", -2, HorizontalAlignment.Center);*/

           // browseListView.Columns.Add("Event Name");
           // browseListView.Columns.Add("Start Date");
           // browseListView.Columns.Add("End Date");

           // browseListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
           // browseListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ListViewExtender extender = new ListViewExtender(browseListView);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(3);
            //buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;
            ListViewButtonColumn buttonAction2 = new ListViewButtonColumn(4);
            buttonAction2.FixedWidth = true;
            extender.AddColumn(buttonAction);
            extender.AddColumn(buttonAction2);
            foreach (Event evt in EventList)
            {
                if (evt.Status.Equals("Open"))
                {
                    //browseEventDisplay.Text += evt.EventName + "\t" + evt.StartDate + "\t" + evt.EndDate;
                    ListViewItem item = new ListViewItem(new[] { evt.EventName.ToString(), evt.StartDate.ToString(), evt.EndDate.ToString(), "Buy" , "Follow"});
                    browseListView.Items.Add(item);
                }
            }
        }


    }
}
