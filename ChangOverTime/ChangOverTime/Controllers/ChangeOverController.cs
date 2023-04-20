using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // using Web.Http instead of Web.MVC

namespace ChangOverTime.Controllers
{
    public class ChangeOverController : ApiController
    {
        // GET: ChangeOver
        [HttpGet]
        [Route("ChangeOver")]
        public IHttpActionResult ChangOver()
        {
            var dataList = new List<object>
            {
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
                new {Category = "B4-CNC", MachineNo = "B11#", NextWo = "Test", NextProject = "Brand C", NextPartNo = "0002", Mold = "AXXXX", MaterialPartNo = "XXXX-0000-111", MaterialDescription = "Plastic", BOMUsage = "99%"},
            };
            //make the return data Json type
            return Json(dataList);
        }
    }
}