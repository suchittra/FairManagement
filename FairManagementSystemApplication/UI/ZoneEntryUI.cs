using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.BLL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.UI
{
    public partial class ZoneEntryUI : Form
    {
        public ZoneEntryUI()
        {
            InitializeComponent();
        }
        ZoneManager aZoneManager = new ZoneManager();
        Zone aZone = new Zone();
        List<Zone> aListZones = new List<Zone>(); 
        private void buttonSaveZone_Click(object sender, EventArgs e)
        {
            
            aZone.ZoneName = textBoxZoneName.Text;

            if (aZoneManager.Insert(aZone))
            {
                MessageBox.Show("Zone inserted");
            }
            //dataGridViewZone.DataSource = aZoneManager.GetAllZoneInGridView(aZone);
            //LoadZone(List<Zone> aZone);
            LoadZone();
        }

        private void LoadZone()
        {
            aListZones.Clear();
            aListZones = aZoneManager.GetAllZone();
            LoadListViewByZone(aListZones);

        }
        private void LoadListViewByZone(List<Zone> aZones)
        {
            // int total = 0;
            listViewZone.Items.Clear();
            foreach (var zone in aZones)
            {
                ListViewItem item = new ListViewItem(zone.ZoneName.ToString());
                //item.SubItems.Add(a.totalNumber.ToString());
                //total = total + aZone.totalNumber;
                item.Tag = zone;
                listViewZone.Items.Add(item);

            }
           // textBoxTotalAll.Text = Convert.ToString(total);
        }

    


 
      
    }
}
