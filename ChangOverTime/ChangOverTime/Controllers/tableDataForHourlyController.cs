using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace tableDataForHourly.Controllers
{
    public class tableDataForHourlyController : ApiController
    {
        // GET: ChangeOver
        [HttpPost]
        [Route("tableDataHourly")]
        public IHttpActionResult ChangOver()
        {
            var dataList = new List<object>
            {
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
                new {Machine = "B99 CNC", partNumber = "0000-xxxx-0000", ZAM = "999", OAM = "999", TAM = "999", ThAM = "999", FouAM = "999", FiAM = "999", SixAM = "999", SevAM = "999",EAM = "999", NAM = "999", TenAM = "999", EleAM = "999", TwPM = "999", OPM = "999",TPM = "999",ThPM = "999",FouPM = "999",FivPM = "999",SixPM = "999",SevPM = "999",EPM = "999", NPM = "999", TenPM = "999", ElePM = "999"},
            };
            //make the return data Json type
            return Json(dataList);
        }
    }
}