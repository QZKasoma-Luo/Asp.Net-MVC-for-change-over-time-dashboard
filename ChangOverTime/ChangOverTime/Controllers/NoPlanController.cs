using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class NoPlanController : ApiController
    {
        // GET: NoPlan
        [HttpGet]
        [Route("NoPlan")]
        public IHttpActionResult NoPlanTable ()
        {
            var dataList = new List<object>
            {
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                new {Category = "B1-CNC", Ton = 20, NoPlanMACQty = 35, MachineNumber = "A#001"},
                
            };
            return Json(dataList);
        }
    }
}