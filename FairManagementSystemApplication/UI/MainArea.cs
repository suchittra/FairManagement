using FairManagementSystemApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairManagementSystemApplication
{
    public partial class MainAreaUI : Form
    {
        public MainAreaUI()
        {
            InitializeComponent();
        }
        
        private void vsitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI aVisitor = new VisitorEntryUI();
           aVisitor.Show();
        }

        private void zoneTyepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneEntryUI aZoneEntry = new ZoneEntryUI();
         //  ZoneEntryUI aEntryZone = new ZoneEntryUI
           aZoneEntry.Show();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorInformation aVisitorInformation = new ZoneSpecificVisitorInformation();
            aVisitorInformation.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorNumberUI visitorsNumber = new ZoneWiseVisitorNumberUI();
            visitorsNumber.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
