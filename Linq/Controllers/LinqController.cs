using Linq.Business;
using Linq.Common.Entities;
using System.Web.Http;

namespace Linq.Controllers
{
    public class LinqController : ApiController
    {
        public string GetStatus(string input)
        {
            if (string.IsNullOrEmpty(input)) return "Ok, sin input";
            else return "Ok";
        }

        /// <summary>
        /// Insert data into table
        /// </summary>
        /// <param name="input"></param>
        /// <response code="0">Response ok.</response>
        /// <response code="1">Error.</response>
        /// <returns></returns>
        [HttpPost]
        public Result CreateData(string input)
        {
            Result output = Result.Error;
            LinqBS business = new LinqBS();
            var result = business.CreateData(input);
            if (result == Result.Success) output = Result.Success;
            return output;
        }
    }
}
