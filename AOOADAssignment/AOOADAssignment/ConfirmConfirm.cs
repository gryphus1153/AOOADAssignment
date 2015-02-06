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
    public partial class ConfirmConfirm : Form
    {
        public ConfirmConfirm(Event evt)
        {
            InitializeComponent();
            evt1 = evt;
        }

        Event evt1;

        private void ConfirmConfirm_Load(object sender, EventArgs e)
        {
            eventNameLabel.Text = evt1.EventName;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            evt1.IsConfirmed = true;
            eventNameLabel.Text = eventNameLabel.Text + " event is now confirmed";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
