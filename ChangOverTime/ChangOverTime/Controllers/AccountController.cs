using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChangOverTime.Controllers
{
    /// <summary>
    /// Login Api
    /// </summary>
    public class AccountController : ApiController
    {
        /// <summary>
        /// Looking for Account ID
        /// </summary>
        /// <param name="loginData"></param>
        /// <returns>UserTest</returns>

        [HttpPost]
        [Route("UserInfo")]
        /* [FromBody] is an attribute in ASP.NET Web API that is used to deserialize  data from the message body of a request into a method's parameter.
         * Specifically, the FromBody attributebinds the data in the message body of
         * an HTTP request to a specified method parameter.
         * Please remeber this!!!! I spend 2 days on how to pass parameters from
         * front-end to the API!
         */
        public Boolean AccountInfo([FromBody]UserInfo loginData)
        {

            //Sample Account
            UserInfo user_libary = new UserInfo()
            {
                name = "Admin",
                pwd = "1234567"
            };
            Boolean passFlag = false;            

            if(loginData.name == user_libary.name && loginData.pwd == user_libary.pwd)
            {
                passFlag = true;
                return passFlag;
            }
            else
            {
                passFlag = false;
            }

            return passFlag;

            /*
             * In the above code, I use the [FromBody] attribute to bind the JSON object in the
             * request body to the method parameter loginData of type Product. This way, when handling
             * an HTTP POST request, Web API extracts the Product object from the message body and
             * passes it to the AccountInfo method.
             * 
             * It's important to note that when using the [FromBody] attribute for data binding, the
             * data in the message body must be compatible with the type of the method parameter,
             * otherwise deserialization cannot occur. Additionally, when using the FromBody attribute
             * for data binding, I need to use the HTTP POST or PUT methods to submit data because
             * these methods allow data to be carried in the message body. If I use the GET method
             * to retrieve data, I cannot use the [FromBody] attribute to bind data and need to use
             * the [FromUri] attribute.
             */
        }
        /// <summary>
        /// UserTest
        /// </summary>
        public class UserInfo
        {
            /// <summary>
            /// id
            /// </summary>
            public string pwd { set; get; }
            /// <summary>
            /// name
            /// </summary>
            public string name { set; get; }
        }
    }
}