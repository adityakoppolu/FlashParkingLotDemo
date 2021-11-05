using Microsoft.Extensions.Configuration;
using ParkingLotApi.Interface;
using ParkingLotApi.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApi.Repository
{
    public class LocationRepository : ILocationRepo
    {
        private readonly IConfiguration _configuration;
        private readonly string DBConnection;

        public LocationRepository(IConfiguration config)
        {
            _configuration = config;
            DBConnection = config.GetConnectionString("DBConnection");
        }

        public List<LocationInfo> GetAllLocations()
        {
            List<LocationInfo> lstemployee = new List<LocationInfo>();
            using (SqlConnection con = new SqlConnection(DBConnection))
            {                
                using (SqlCommand cmd = new SqlCommand("spGetAllLocations", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            LocationInfo loc = new LocationInfo();
                            loc.LocId = Convert.ToInt32(rdr["LocId"]);
                            loc.LocationName = rdr["LocName"].ToString();
                            loc.TotalLotsCount = Convert.ToInt32(rdr["TotalLots"]);
                            loc.OccupiedLotsCount = Convert.ToInt32(rdr["OccupiedLotsCount"]);
                            lstemployee.Add(loc);
                        }
                    }
                }
                
                con.Close();
            }
            return lstemployee;
        }

        public bool UpdateEntry(int locId)
        {
            bool isSucess;
            using (SqlConnection con = new SqlConnection(DBConnection))
            {
                SqlCommand cmd = new SqlCommand("spUpdateLotEntry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LocId", locId);
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                isSucess = count > 0 ? true : false;
            }

            return isSucess;
        }

        public bool ExitEntry(int locId)
        {
            bool isSucess;
            using (SqlConnection con = new SqlConnection(DBConnection))
            {
                SqlCommand cmd = new SqlCommand("spExitLotEntry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LocId", locId);
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                isSucess = count > 0 ? true : false;
            }

            return isSucess;
        }       

        public LocationInfo GetLocationInfo(int locId)
        {
            throw new NotImplementedException();
        }
    }
}
