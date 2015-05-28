using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.DAL
{
    class GetAllCustomerGetway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FairManager"].ConnectionString;

        public List<Customer> GetAllCustomer(int ZId)
        {
            SqlConnection aSqlConnection = new SqlConnection(connectionString);

            string query = "SELECT MappingTable.CId,CustomerTable.name,CustomerTable.email,CustomerTable.contactNumber FROM MappingTable,CustomerTable WHERE MappingTable.ZId='" + ZId + "' AND MappingTable.CId=CustomerTable.CId";
            SqlCommand aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            List<Customer> customers= new List<Customer>();

            while (aDataReader.Read())
            {

                Customer aCustomer = new Customer();
                aCustomer.Id = int.Parse(aDataReader["CId"].ToString());

                aCustomer.name = aDataReader["name"].ToString();
                aCustomer.email = aDataReader["email"].ToString();
                aCustomer.contact = int.Parse(aDataReader["contactNumber"].ToString());


               customers.Add(aCustomer);
            }

            aDataReader.Close();
            aSqlConnection.Close();
            return customers;
        }
    }
}
