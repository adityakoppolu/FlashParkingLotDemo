using ParkingLotApi.Interface;
using ParkingLotApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApi.BAL
{
    public class LocationBAL : ILocation
    {
        private readonly ILocationRepo _locationRepo;

        public LocationBAL(ILocationRepo locationRepo)
        {
            _locationRepo = locationRepo;
        }


        public List<LocationInfo> GetAllLocations()
        {
            return _locationRepo.GetAllLocations();
        }
        public bool UpdateEntry(int locId)
        {
            return _locationRepo.UpdateEntry(locId);
        }

        public bool ExitEntry(int locId)
        {
            return _locationRepo.ExitEntry(locId);
        }

        public LocationInfo GetLocationInfo()
        {
            throw new NotImplementedException();
        }
    }
}
