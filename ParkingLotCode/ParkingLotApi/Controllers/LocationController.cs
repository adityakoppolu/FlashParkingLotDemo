using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApi.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkingLotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocation _locationBAL;

        public LocationController(ILocation locationBal)
        {
            _locationBAL = locationBal;
        }
        
        [HttpGet]
        [Route("GetAllLocations")]
        public IActionResult GetLocations()
        {
            return Ok(_locationBAL.GetAllLocations());
        }



        [Route("UpdateEntry")]
        [HttpPut("{id}")]
        public IActionResult UpdateEntry(int id)
        {
            return Ok(_locationBAL.UpdateEntry(id));
        }

        [Route("ExitEntry")]
        [HttpPut("{id}")]
        public IActionResult ExitEntry(int id)
        {
            return Ok(_locationBAL.ExitEntry(id));
        }
    }
}
