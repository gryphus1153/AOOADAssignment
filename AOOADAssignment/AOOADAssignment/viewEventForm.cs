using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOADAssignment
{
    public partial class viewEventForm : Form
    {
        public viewEventForm()
        {
            InitializeComponent();
        }
        public string eventName;
        private void viewEventForm_Load(object sender, EventArgs e)
        {
            viewEventTxtBox.Text = eventName;
        }
    }
}
