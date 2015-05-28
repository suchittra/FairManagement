using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementSystemApplication.DAL;
using FairManagementSystemApplication.Model;

namespace FairManagementSystemApplication.BLL
{
    class ZoneManager
    {
        ZoneGetway aZoneGetway = new ZoneGetway();

        public bool Insert(Zone aZone)
        {
            return aZoneGetway.Insert(aZone) > 0;
        }

        public List<Zone> GetAllZone()
        {
            return aZoneGetway.GetAllZone();
        }



    }
}
