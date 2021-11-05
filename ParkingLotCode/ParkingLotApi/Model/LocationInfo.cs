using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApi.Model
{
    public class LocationInfo
    {
        public int LocId { get; set; }
        public string LocationName { get; set; }
        public int TotalLotsCount { get; set; }
        public int OccupiedLotsCount { get; set; }
        public int AvailableLotsCount { get => TotalLotsCount - OccupiedLotsCount; } 
        public List<ParkingLotInfo> OccupiedLots { get; set; }

        //public List<ParkingLotInfo> AvailableLots { get; set; }
    }
}
