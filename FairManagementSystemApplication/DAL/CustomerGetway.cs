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
    class CustomerGetway
    {

        string connectionString = ConfigurationManager.ConnectionStrings["FairManager"].ConnectionString;
        public int Insert(Customer aCustomer)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO CustomerTable VALUES('" + aCustomer.name + "','" + aCustomer.email + "', '" +
                           aCustomer.contact + "')";
            
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public List<Customer> GetAllCustomers()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM CustomerTable ";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Customer> aCustomers = new List<Customer>();

            while (reader.Read())
            {
                Customer aaCustomer = new Customer();
                aaCustomer.name = reader["name"].ToString();
                aaCustomer.email = reader["email"].ToString();
                aaCustomer.contact = int.Parse(reader["contactNumber"].ToString());

                aCustomers.Add(aaCustomer);
            }
            reader.Close();
            connection.Close();

            return aCustomers;
        }
    }
}
