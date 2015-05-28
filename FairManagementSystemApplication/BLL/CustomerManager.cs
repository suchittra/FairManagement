using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.BLL
{
    class CustomerManager
    {
        CustomerGetway aCustomerGetway = new CustomerGetway();
        public bool Insert( Customer aCustomer)
        {
            return aCustomerGetway.Insert(aCustomer) > 0;
        }

        public List<Customer> GetAllCustomers()
        {
            return aCustomerGetway.GetAllCustomers();
        }
    }
}
