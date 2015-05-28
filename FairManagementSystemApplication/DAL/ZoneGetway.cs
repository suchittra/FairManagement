using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FairManagementSystemApplication.Model;
using FairManagementSystemApplication.UI;

namespace FairManagementSystemApplication.DAL
{
    internal class ZoneGetway
    {
        //ZoneEntryUI aEntryUi = new ZoneEntryUI();
        private string connectionString = ConfigurationManager.ConnectionStrings["FairManager"].ConnectionString;

        public int Insert(Zone aZone)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO zoneTaable VALUES('" + aZone.ZoneName + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

        public List<Zone> GetAllZone()
        {
            SqlConnection aSqlConnection = new SqlConnection(connectionString);

            string query = "SELECT * FROM zoneTaable";
            SqlCommand aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aDataReader = aSqlCommand.ExecuteReader();
            List<Zone> aZones = new List<Zone>();

            while (aDataReader.Read())
            {
                Zone alistZone = new Zone();
                alistZone.ZId = int.Parse(aDataReader["ZId"].ToString());
                alistZone.ZoneName = aDataReader["ZoneName"].ToString();

                aZones.Add(alistZone);
            }
            aDataReader.Close();
            aSqlConnection.Close();

            return aZones;
        }


           }
         }
        

        



    

