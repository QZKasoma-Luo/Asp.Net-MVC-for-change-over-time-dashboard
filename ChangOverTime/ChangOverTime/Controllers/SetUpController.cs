using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class SetUpController : ApiController
    {
        // GET: SetUp
        [HttpPost]
        [Route("setUp")]
        public IHttpActionResult SetUp()
        {
            var dataList = new List<object> {
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
                new {Category = "B6-Molding", MachineNo = "C#01", WorkOrder = "0000", Project = "Brand D", PartNo = "####-0000-####", Description = "Release Trigger", Mold = "AAAA", MaterialPartNo = "MPN-0001", MaterialDescription = "MPD-0002", BOMUsage = "50%"},
            };

            return Json(dataList);
        }
    }
}