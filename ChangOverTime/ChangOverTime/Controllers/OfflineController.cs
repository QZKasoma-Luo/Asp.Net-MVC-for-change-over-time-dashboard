using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class OfflineController : ApiController
    {
        // GET: Offline
        [HttpPost]
        [Route("Offline")]
        public IHttpActionResult Offline()
        {
            var dataList = new List<object> {
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
                new {Category = "B7-Stampling", MAC = "E#99", StartAt = "2023/03/22", PLC = "N/A", IP = "255.255.255.255"},
            };

            return Json(dataList);
        }
    }
}