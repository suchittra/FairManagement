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
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.UI
{
    public partial class ZoneSpecificVisitorInformation : Form
    {
        public ZoneSpecificVisitorInformation()
        {
            InitializeComponent();
        }
        ZoneManager aZoneManager = new ZoneManager();
        List<Customer> aCustomers = new List<Customer>();
        List<Zone> aZones= new List<Zone>(); 
        GetAllCustomerManager allCustomerManager = new GetAllCustomerManager();
        private void ZoneSpecificVisitorInformation_Load(object sender, EventArgs e)
        {
            LoadAllZoneInComboBox();
        }

        private void LoadAllZoneInComboBox()
        {
            List<Zone> zones = aZoneManager.GetAllZone();
            
            comboBoxZoneName.DisplayMember = "ZoneName";
            comboBoxZoneName.ValueMember = "ZId";
            comboBoxZoneName.DataSource = null;
            comboBoxZoneName.DataSource = zones;
        }
        Zone aZone = new Zone();
        private void buttonShow_Click(object sender, EventArgs e)
        {

            aZone.ZId = int.Parse(comboBoxZoneName.SelectedValue.ToString()); ;
            LoadCustomer(aZone.ZId);
        }
        
        private void LoadCustomer(int zones)
        {
            aCustomers.Clear();
            aCustomers = allCustomerManager.GetAllCustomer(zones);
            LoadListVieByCustomer(aCustomers);

        }

        Customer aCustomer = new Customer();
        private void LoadListVieByCustomer(List<Customer> aCustomers)
        {
            // show students to list view 

            listViewZoneSpecificCustomer.Items.Clear();
            int count = 0;
            foreach (var customer in aCustomers)
            {
                count++;
                ListViewItem item = new ListViewItem(customer.name.ToString());
                item.SubItems.Add(customer.email.ToString());
                item.SubItems.Add(customer.contact.ToString());
                aCustomer.totalAmount = count;

                item.Tag = customer;
                listViewZoneSpecificCustomer.Items.Add(item);

            }
            textBoxTotal.Text = Convert.ToString(aCustomer.totalAmount);
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            int i = 1;
            int j = 1;
            foreach (ListViewItem comp in listViewZoneSpecificCustomer.Items)
            {
                ws.Cells[i, j] = comp.Text.ToString();
                MessageBox.Show(comp.Text.ToString());
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }


                }
            }

        }

