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
    public partial class ConfirmClose : Form
    {
        public ConfirmClose(Event evt)
        {
            InitializeComponent();
            selectedEvnt = evt;
        }

        Event selectedEvnt;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //sets evnt status, check if ticket bought is >= min tickets if true the execute the bottom code
            //else don't set status, but display a message that ticjet bought is less than min tickets.
            selectedEvnt.Status = "Open";
            eventNLabel.Text = eventNLabel.Text + " is now set to viewable for customers";
        }
    }
}
