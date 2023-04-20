using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class OEEOverAllController : ApiController 
        /*remember change Controller to ApiController
         * after created the Controller
         */
    {
        // GET: OEEOverAll
        [HttpGet]
        [Route("OEEOverAll")]//Set the route as /api/OEEOverALL
        public double ChartData()
        {
            Random rand = new Random(); // Build Random number 1-100
            return rand.Next(1, 100);
        }
    }
}