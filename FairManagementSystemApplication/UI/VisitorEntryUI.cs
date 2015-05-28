using FairManagementSystemApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairManagementSystemApplication.BLL;
using FairManagementSystemApplication.DAL;

namespace FairManagementSystemApplication.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
        }
        CustomerManager aManager = new CustomerManager();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
            aCustomer.name = textBoxName.Text;
            aCustomer.email = textBoxEmail.Text;
            aCustomer.contact = int.Parse(textBoxComtactNumber.Text);

           
            if (aManager.Insert(aCustomer))
            {
                MessageBox.Show("Customer is inserted");
            }
        }



    }
}
