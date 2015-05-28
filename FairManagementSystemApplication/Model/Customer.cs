using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementSystemApplication.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int contact { get; set; }

        public int totalAmount { get; set; }


    }
}