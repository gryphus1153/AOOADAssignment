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
    public partial class AddPerformance : Form
    {
        
        public AddPerformance()
        {
            InitializeComponent();
        }

        public Performance getPerformance()
        {
            Performance p;
            ArrayList perfomersList = new ArrayList();
            foreach (string i in PerformersListBox.CheckedItems)
	        {
                perfomersList.Add(i);
	        }
            p = new Performance(Convert.ToString(StartdateTimePicker1), Convert.ToString(EnddateTimePicker), perfomersList);
            return p;

        }
    }
}
