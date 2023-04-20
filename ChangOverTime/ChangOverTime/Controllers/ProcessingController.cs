using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class ProcessingController : ApiController
    {
        // GET: Processing
        [HttpPost]
        [Route("Processing")]
        public IHttpActionResult Processing()
        {
            var dataList = new List<object> {
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
                new {Category = "B7-CNC", MAC = "D#01", PO = "#0000", Project = "Brand E", Part = "####-0000-####", Mold = "N/A", StdCycle = "102.9", AvgCycle = "110.1", LastCycle = "95", Good = "60", Scrap = "0", ToGo = "999", percentage = "1%", ESTDT = "2023/03/22"},
            };

            return Json(dataList);
        }
    }
}