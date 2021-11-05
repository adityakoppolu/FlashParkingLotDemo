using ParkingLotApi.Controllers;
using ParkingLotApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApi.Interface
{
    public interface ILocationRepo
    {
        public List<LocationInfo> GetAllLocations();

        public LocationInfo GetLocationInfo(int locId);

        public bool UpdateEntry(int locId);

        public bool ExitEntry(int locId);
    }
}
