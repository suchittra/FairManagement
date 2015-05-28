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
    public partial class ZoneWiseVisitorNumberUI : Form
    {
        public ZoneWiseVisitorNumberUI()
        {
            InitializeComponent();
        }
        private  ZoneManager aZoneManager = new ZoneManager();
        private  List<Zone> alistZones = new List<Zone>(); 
        private Zone aZone = new Zone();
        private void ZoneWiseVisitorNumberUI_Load(object sender, EventArgs e)
        {
            LoadZone();
        }
        private void LoadZone()
        {
            alistZones.Clear();
            alistZones = aZoneManager.GetAllZone();
            LoadListViewByZone(alistZones);

        }

        private void LoadListViewByZone(List<Zone> aZones )
        {
            int total = 0;
            listViewCustonerByZone.Items.Clear();
            foreach (var zone in aZones)
            {
                ListViewItem item = new ListViewItem(zone.ZoneName.ToString());
                item.SubItems.Add(aZone.totalNumber.ToString());
                total = total + aZone.totalNumber;
                item.Tag = zone;
                listViewCustonerByZone.Items.Add(item);

            }
            textBoxTotalAll.Text = Convert.ToString(total);
        }

      
    }
}
