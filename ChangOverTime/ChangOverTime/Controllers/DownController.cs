using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class DownController : ApiController
    {
        // GET: Down
        [HttpGet]
        [Route("Down")]
        public IHttpActionResult Down()
        {
            var dataList = new List<object>
            {
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
                new {Category = "B2-Molding", MachineNo = "B2-A03", DownReason = "Quality", Project = "Brand A", PartNo = "BA0000-01/01", Description = "Hull", Mold = "BAM000", DownStartAt = "2023/01/01 00:00", DownTime = "0Day(s)00:00:00", Comment = "Waiting on the PO"},
            };
            //make the return data Json type
            return Json(dataList);
        }
    }
}