using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace ChangOverTime.Controllers
{
    public class Top5ReasonDownController : ApiController
    {
        // GET: Top5ReasonDown
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Top5ReasonDown")]
        
        public IHttpActionResult Top5ReasonData()
        {
            //Sample datalist to be returned 
            var dataList = new List<object>
            {
                new {Reason = "Reason 1", QTY = 20, percentage = "4.81%"},
                new {Reason = "Reason 2", QTY = 25, percentage = "6.03%"},
                new {Reason = "Reason 3", QTY = 10, percentage = "3.40%"},
                new {Reason = "Reason 4", QTY = 11, percentage = "7.40%"},
                new {Reason = "Reason 5", QTY = 22, percentage = "5.40%"},
                new {Reason = "Reason 6", QTY = 13, percentage = "3.40%"},
                new {Reason = "Reason 7", QTY = 14, percentage = "1.40%"},
                new {Reason = "Reason 8", QTY = 8, percentage = "2.40%"},
            };

            //Sort the data by its QTY
            //use the dynamic let the terminal confirm the type "QTY" and access them
            dataList.Sort((a, b) => ((dynamic)a).QTY - ((dynamic)b).QTY);

            //only return the top 5 data since we only display top 5
            var topFive = dataList.Take(5).ToList();

            //make the return data to Json type
            return Json(topFive);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Top5ToolsDown")]
        public IHttpActionResult Top5ToolsData()
        {
            var dataList = new List<object>
            {
                new {MAC = "MAC#1", Tool = 20, DownTime = "2"},
                new {MAC = "MAC#2", Tool = 34, DownTime = "4"},
                new {MAC = "MAC#3", Tool = 9, DownTime = "4"},
                new {MAC = "MAC#4", Tool = 4, DownTime = "3"},
                new {MAC = "MAC#5", Tool = 12, DownTime = "7"},
                new {MAC = "MAC#6", Tool = 14, DownTime = "1"},
                new {MAC = "MAC#7", Tool = 99, DownTime = "0.5"},
                new {MAC = "MAC#8", Tool = 98, DownTime = "11"},
            };

            //Sort the data by its QTY
            //use the dynamic let the terminal confirm the type "QTY" and access them
            dataList.Sort((a, b) => ((dynamic)a).Tool - ((dynamic)b).Tool);

            //only return the top 5 data since we only display top 5
            var topFive = dataList.Take(5).ToList();

            //make the return data to Json type
            return Json(topFive);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Top5MachineDown")]
        public IHttpActionResult Top5MachineDownData()
        {
            var dataList = new List<object>
            {
                new {MAC = "MAC#1", Reason = "Tooling Down", DownTime = 2},
                new {MAC = "MAC#2", Reason = "Tooling Down", DownTime = 9},
                new {MAC = "MAC#3", Reason = "Equipment Down", DownTime = 10},
                new {MAC = "MAC#4", Reason = "Equipment Down", DownTime = 90},
                new {MAC = "MAC#5", Reason = "Tooling Down", DownTime = 99},
                new {MAC = "MAC#6", Reason = "Tooling Down", DownTime = 31},
                new {MAC = "MAC#7", Reason = "Tooling Down", DownTime = 78},
                new {MAC = "MAC#8", Reason = "Tooling Down", DownTime = 4},
            };

            //Sort the data by its QTY
            //use the dynamic let the terminal confirm the type "QTY" and access them
            dataList.Sort((a, b) => ((dynamic)a).DownTime - ((dynamic)b).DownTime);

            //only return the top 5 data since we only display top 5
            var topFive = dataList.Take(5).ToList();

            //make the return data to Json type
            return Json(topFive);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Top5ScrapReason")]
        public IHttpActionResult Top5ScrapReason()
        {
            var dataList = new List<object>
            {
                new {percentage = 0.00342, QTY = 641, Reason = "Adjust Machine"},
                new {percentage = 0.00036, QTY = 567, Reason = "Short Shot"},
                new {percentage = 0.00032, QTY = 67, Reason = "Black Mark"},
                new {percentage = 0.00031, QTY = 58, Reason = "Silver Mark"},
                new {percentage = 0.00026, QTY = 60, Reason = "Excessive material"},
                new {percentage = 0.00001, QTY = 48, Reason = "Power Shortage"},
                new {percentage = 0.000, QTY = 58, Reason = "Knife change"},
                new {percentage = 0.0007, QTY = 90, Reason = "Some other Reason"},
            };

            //Sort the data by its QTY
            //use the dynamic let the terminal confirm the type "QTY" and access them
            dataList.Sort((a, b) => ((dynamic)a).QTY - ((dynamic)b).QTY);

            //only return the top 5 data since we only display top 5
            var topFive = dataList.Take(5).ToList();

            //make the return data to Json type
            return Json(topFive);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Top5LowYield")]
        public IHttpActionResult Top5LowYield()
        {
            var dataList = new List<object>
            {
                new {MAC = "MAC1", yield = 0.00342, QTY = 641, Reason = "Adjust Machine"},
                new {MAC = "MAC2", yield = 0.00036, QTY = 567, Reason = "Short Shot"},
                new {MAC = "MAC3", yield = 0.00032, QTY = 67, Reason = "Black Mark"},
                new {MAC = "MAC4", yield = 0.00031, QTY = 58, Reason = "Silver Mark"},
                new {MAC = "MAC5", yield = 0.00026, QTY = 60, Reason = "Excessive material"},
                new {MAC = "MAC6", yield = 0.00001, QTY = 48, Reason = "Power Shortage"},
                new {MAC = "MAC7", yield = 0.000, QTY = 58, Reason = "Knife change"},
                new {MAC = "MAC8", yield = 0.0007, QTY = 90, Reason = "Some other Reason"},
            };

            //Sort the data by its QTY
            //use the dynamic let the terminal confirm the type "QTY" and access them
            dataList.Sort((a, b) => ((dynamic)a).QTY - ((dynamic)b).QTY);

            //only return the top 5 data since we only display top 5
            var topFive = dataList.Take(5).ToList();

            //make the return data to Json type
            return Json(topFive);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Top5LowPerformance")]
        public IHttpActionResult Top5LowPerformance()
        {
            var dataList = new List<object>
            {
                new {MAC = "MAC1", Percentage = "0.00342%", StdCycle = 160, AvgCycle = "250"},
                new {MAC = "MAC2", Percentage = "0.00342%", StdCycle = 160, AvgCycle = "500"},
                new {MAC = "MAC3", Percentage = "0.00342%", StdCycle = 160, AvgCycle = "493"},
                new {MAC = "MAC4", Percentage = "0.00342%", StdCycle = 0, AvgCycle = "497"},
                new {MAC = "MAC5", Percentage = "0.00342%", StdCycle = 22, AvgCycle = "501"},
                new {MAC = "MAC6", Percentage = "0.00342%", StdCycle = 30, AvgCycle = "71"},
                new {MAC = "MAC7", Percentage = "0.00342%", StdCycle = 90, AvgCycle = "0"},
            };

            //Sort the data by its QTY
            //use the dynamic let the terminal confirm the type "QTY" and access them
            dataList.Sort((a, b) => ((dynamic)a).StdCycle - ((dynamic)b).StdCycle);

            //only return the top 5 data since we only display top 5
            var topFive = dataList.Take(5).ToList();

            //make the return data to Json type
            return Json(topFive);
        }
    }
}