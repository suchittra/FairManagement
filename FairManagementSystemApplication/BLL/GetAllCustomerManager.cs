using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.BLL
{
    class GetAllCustomerManager
    {
        GetAllCustomerGetway allCustomerGetway = new GetAllCustomerGetway();

        public List<Customer> GetAllCustomer(int aZone)
        {
            return allCustomerGetway.GetAllCustomer(aZone);
        }
    }
}
