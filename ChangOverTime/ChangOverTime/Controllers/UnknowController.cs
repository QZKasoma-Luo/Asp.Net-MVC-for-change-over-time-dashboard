using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class UnknowController : ApiController
    {
        // GET: Unknow
        [HttpGet]
        [Route("Unknow")]
        public IHttpActionResult Unknow()
        {
            var dataList = new List<object> {
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
                new {Category = "B5-CNC", Ton = "100T", MAC = "B#01"},
            };

            return Json(dataList);
        }
    }
}