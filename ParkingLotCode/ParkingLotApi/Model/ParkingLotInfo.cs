using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApi.Model
{
    public class ParkingLotInfo
    {
        public int ParkingId { get; set; }
        public int LocId { get; set; }
        public int ParkingLotCode { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public float PerHourBilling { get; set; }
        public float ParkingLotBilling { get; set; }
    }
}
