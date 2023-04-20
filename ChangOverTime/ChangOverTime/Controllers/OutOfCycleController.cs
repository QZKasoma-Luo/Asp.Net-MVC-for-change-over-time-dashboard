using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class OutOfCycleController : ApiController
    {
        // GET: OutOfCycle
        [HttpGet]
        [Route("OutOfCycle")]
        public IHttpActionResult OutOfCycle()
        {
            var dataList = new List<object>
            {
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
                new {Category = "B3-CNC", MachineNo = "A11#", Project = "Brand B", PartNo = "BA0000-01/01", Description = "Main Cover, CNC", StdCycle = 130.7, AvgCycle = 0, LastCycle = "0Day(s)00:00:00", Gap = 687.2},
            };
            //make the return data Json type
            return Json(dataList);
        }
    }
}