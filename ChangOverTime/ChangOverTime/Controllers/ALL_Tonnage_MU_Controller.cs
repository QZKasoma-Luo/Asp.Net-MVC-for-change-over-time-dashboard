using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class ALL_Tonnage_MU_Controller : ApiController
    {
        // GET: ALL_Tonnage_MU_
        [HttpPost]
        [Route("ALL_Tonnage_MU")]
        public IHttpActionResult ALL_Tonnage_MU()
        {
            var dataList = new List<object> {
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
              new  {title = "30.74%", Ton = "100-120T", department = "B15-Molding"},
            };

            return Json(dataList);
        }
    }
}