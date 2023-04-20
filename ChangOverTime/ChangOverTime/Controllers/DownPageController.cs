using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class DownPageController : ApiController
    {
        // GET: B15_daily_status
        [HttpPost]
        [Route("DownPageSandKeyData")]
        public IHttpActionResult DownPageSandKeyData()
        {
            var dataList = new List<object> {
              new  {name= "100T"},
              new  {name= "110T"},
              new  {name= "200T"},
              new  {name= "160T"},
              new  {name= "100T-V"},
              new  {name= "800T"},
              new  {name= "850T"},
              new  {name= "180T"},
              new  {name= "190T"},
              new  {name= "220T"},
              new  {name= "250T"},
              new  {name= "300T"},
              new  {name= "120T"},
              new  {name= "410T"},
              new  {name= "150T"},
              new  {name= "280T"},
              new  {name= "Out Of Cycle"},
              new  {name= "Unknown Cycle"},
              new  {name= "Change Over"},
              /*new  {name= "Setup"},
              new  {name= "No Operator"},
              new  {name= "Tooling Down"},
              new  {name= "Material Shortage"},
              new  {name= "Equipment Down"},*/
              new  {name= "Quality"},
              new  {name= "B1-CNC"},
              new  {name= "B2-Stamping"},
              new  {name= "B3-Molding"},
            };

            return Json(dataList);
        }

        [HttpPost]
        [Route("DownPageSandKeyLinks")]
        public IHttpActionResult DownPageSandKeyLinks()
        {
            var dataList = new List<object> {
              new  {source="100T", target="Out Of Cycle", value = 100},
              new  {source="110T", target="Out Of Cycle", value = 100},
              new  {source="200T", target="Out Of Cycle", value = 100},
              new  {source="160T", target="Out Of Cycle", value = 100},
              new  {source="100T-V", target="Out Of Cycle", value = 100},
              new  {source="800T", target="Out Of Cycle", value = 100},
              new  {source="850T", target="Out Of Cycle", value = 100},


              new  {source="180T", target="Out Of Cycle", value = 100},
              new  {source="190T", target="Out Of Cycle", value = 100},
              new  {source="220T", target="Out Of Cycle", value = 100},
              new  {source="250T", target="Unknown Cycle", value = 100},
              new  {source="300T", target="Change Over", value = 100},
              new  {source="120T", target="Quality", value = 100},
              new  {source="410T", target="Quality", value = 100},
              new  {source="150T", target="Out Of Cycle", value = 100},
              new  {source="280T", target="Out Of Cycle", value = 100},
              new  {source="ChangeOver", target="B1-CNC", value = 100},
              new  {source="ChangeOver", target="B2-Stamping", value = 100},
              new  {source="ChangeOver", target="B3-Molding", value = 100},
              new  {source="Out Of Cycle", target="B1-CNC", value = 100},
              new  {source="Out Of Cycle", target="B2-Stamping", value = 100},
              new  {source="Out Of Cycle", target="B3-Molding", value = 100},
              new  {source="Quality", target="B1-CNC", value = 100},
              new  {source="Quality", target="B2-Stamping", value = 100},
              new  {source="Quality", target="B3-Molding", value = 100},

              new  {source="Unknown Cycle", target="B1-CNC", value = 100},
              new  {source="Unknown Cycle", target="B2-Stamping", value = 100},
              new  {source="Unknown Cycle", target="B3-Molding", value = 100},
            };

            return Json(dataList);
        }
    }
}