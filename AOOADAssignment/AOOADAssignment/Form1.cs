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
        static bool isCustomer = false;//if customer then true
        public Form1()
        {
            Address addr = new Address("Block 123", "Street1234", "uNo", "#01-900");
            Name name = new Name("firstName", "middleName", "lastName");
            CreditCard cc = new CreditCard("1234-5678-9019", "09/25");
            ArrayList tickList = new ArrayList();
            //need ticket class
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
                        if (i.GetType() == typeof(Customer))
                        {
                            isCustomer = true;
                        }
                        exist = true;
                        break;
                    }
                }
                

            }
            if (exist == true)
            {
                label3.Text = "Logged in successfully!";
            }
            else
            {
                label3.Text = "Log in unsuccessfully";
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            browseListView.Items.Clear();
            browseEventAdd(EventList);   
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            if(isCustomer == true)
            {

            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if(isCustomer == false)
            {

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (browseListView.SelectedItems.Count > 0)
            {
                ListViewItem item = browseListView.SelectedItems[0];
                viewEventForm vEF = new viewEventForm();
                vEF.eventName = item.SubItems[0].Text;
                vEF.Visible = true;
                vEF.Show();
            }
        }
        void btnFilterStartDate_Click(object sender, EventArgs e)
        {
            browseListView.Items.Clear();
            ArrayList tempList = new ArrayList();
            tempList.AddRange(EventList);
            for (int i = 0; i < tempList.Count; ++i)
            {
                for (int j = 1; j < tempList.Count; ++j)
                {
                    Event event1 = (Event)tempList[i];
                    Event event2 = (Event)tempList[j];
                    DateTime e1 = event1.StartDate;
                    DateTime e2 = event2.StartDate;
                    if (e1 > e2)
                    {
                        Event tempLargerEvent = event1;
                        tempList[i] = event2;
                        tempList[j] = tempLargerEvent;
                    }
                }
            }
            browseEventAdd(tempList);
        }

        private void btnFilterEndDate_Click(object sender, EventArgs e)
        {
            browseListView.Items.Clear();
            ArrayList tempList = new ArrayList();
            tempList.AddRange(EventList);
            for (int i = 0; i < tempList.Count; ++i)
            {
                for (int j = 1; j < tempList.Count; ++j)
                {
                    Event event1 = (Event)tempList[i];
                    Event event2 = (Event)tempList[j];
                    DateTime e1 = event1.EndDate;
                    DateTime e2 = event2.EndDate;
                    if (e1 > e2)
                    {
                        Event tempLargerEvent = event1;
                        tempList[i] = event2;
                        tempList[j] = tempLargerEvent;
                    }
                }
            }
            browseEventAdd(tempList);
        }

        private void btnEventFliter_Click(object sender, EventArgs e)
        {
            browseListView.Items.Clear();
            ArrayList tempList = new ArrayList();
            tempList.AddRange(EventList);
            for(int i= 0; i < tempList.Count; ++i)
            {
                for(int j=1; j<tempList.Count; ++j)
                {
                    Event event1 = (Event)tempList[i];
                    Event event2 = (Event)tempList[j];
                    string e1 = event1.EventName;
                    string e2 = event2.EventName;
                    if(String.Compare(e1,e2) > 0)
                    {
                        Event tempLargerEvent = event1;
                        tempList[i] = event2;
                        tempList[j] = tempLargerEvent;
                    }
                }
            }
            browseEventAdd(tempList);

            
        }

        private void browseEventAdd(ArrayList tempList)
        {
            if (isCustomer == true)
            {
                browseListView.View = View.Details;
                foreach (Event evt in tempList)
                {
                    if (evt.Status.Equals("Open"))
                    {
                        ListViewItem item = new ListViewItem(new[] { evt.EventName.ToString(), evt.StartDate.ToString(), evt.EndDate.ToString() });
                        browseListView.Items.Add(item);
                    }
                }

            }
        }

    }
}
