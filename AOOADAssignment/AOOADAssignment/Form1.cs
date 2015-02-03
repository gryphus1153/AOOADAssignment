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
            
        public Form1()
        {
            Address addr = new Address("Block 123", "Street1234", "uNo", "#01-900");
            Name name = new Name("stupid", "irritating", "dumbass");
            CreditCard cc = new CreditCard("ccNo", "09/25");
            ArrayList tickList = new ArrayList();
            ArrayList payList = new ArrayList();
            User cust1 = new Customer("uID", "pass", name, "email@email.com", addr, "999666999", cc, tickList, payList);
            userList.Add(cust1);


            InitializeComponent();
        }

        private void EventIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool exist = false;
            
           foreach(User i in userList)
           {
               if(i.UserID.Equals(loginIDTextBox.Text))
               {
                   string pass = i.Password;
                   if(pass.Equals(passwordTextBox.Text))
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
            if(exist==true)
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
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            DateTime time = Convert.ToDateTime("3/2/2015 12:00");
            DateTime endTime = Convert.ToDateTime("3/2/2015 18:00");
            Genre eg = new Genre("Fantasy");
            ArrayList performancesList = new ArrayList();
            ArrayList sManagers = new ArrayList();
            EventManager el = new EventManager();
            Event event1 = new Event("Disney Fat Princesses", time, endTime, eg, performancesList, 100, "Open", el, sManagers, true);
            browseEventDisplay.Text += event1.EventName + "\t" + event1.StartDate + "\t" + event1.EndDate;

        }
    }
}