using ParkingLotApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApi.Interface
{
    public interface ILocation
    {
        public List<LocationInfo> GetAllLocations();

        public LocationInfo GetLocationInfo();

        public bool UpdateEntry(int locId);

        public bool ExitEntry(int locId);
    }
}
