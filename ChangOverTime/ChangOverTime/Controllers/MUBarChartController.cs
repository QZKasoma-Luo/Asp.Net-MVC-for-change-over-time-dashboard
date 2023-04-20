using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class MUBarChartController : ApiController
    {
        // GET: MUBarChart
        [HttpPost]
        [Route("MUBarCharts_Y")]
        public IHttpActionResult MUBarCharts_Y()
        {
            int[] dataList_Y = {220,182,191,234,290,220,182,191,234,290,111,999}; // Unlinke C using [] to define array, Use curly braces and initialize the array with array in C#
            return Json(dataList_Y);
        }

        [HttpPost]
        [Route("MUBarCharts_X")]
        public IHttpActionResult MUBarCharts_X()
        {
            string[] dataList_X = { "Jan 1", "Feb 1", "Mar 1", "Ap 1", "May 1", "Jun 1", "Jly 1", "Aug 1", "Sep 1", "Oct 1", "Nov 1", "Dec 1" };
            return Json(dataList_X);
        }

        [HttpPost]
        [Route("MuBarDownTitle")]
        public IHttpActionResult MuBarDownTitle()
        {
            var data = "Adjust Mchine";
            return Json(data);
        }
    }
}