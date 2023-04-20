using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class MCRRController : ApiController
    {
        // GET: B15_daily_status
        [HttpPost]
        [Route("B15_CNC_daily_status")]
        public IHttpActionResult B15_CNC_daily_status()
        {
            var dataList = new List<object> {
              new  {value = 1000, name = "Processing"},
              new  {value = 200, name = "ChangeOver"},
              new  {value = 500, name = "idle"},
              new  {value = 700, name = "Set Up"},
              new  {value = 1500, name = "Trail Run"},
            };

            return Json(dataList);
        }

        [HttpPost]
        [Route("status_form")]
        public IHttpActionResult All_week_running()
        {
            var dataList = new List<object> {
              new  {status = "Idle", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Processing/Running", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Down/Equipment Down", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Down/Material Shortage", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Down/No Plan", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Down/Quality", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Down/Tooling Down", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Setup(Set up + Adjustment + FAI)", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "Overtime(Machine Abnormal, not running/Cycle time > 3x CT)", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "ChangeOver(Change Task, Waiting time)", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "UnknownCycle(Machine running without task)", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
              new  {status = "TrialRun", Thu = 999, Fri = 999, Sat = 999, Sun = 999, Mon = 999, Tue = 999, Wen = 999},
            };

            return Json(dataList);
        }
    }
}