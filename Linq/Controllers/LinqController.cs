using Linq.Business;
using Linq.Common.Entities;
using Linq.Common.MethodParameters;
using System.Web.Http;
using System.Web.Http.Description;

namespace Linq.Controllers
{
    /// <summary>
    /// Linq project controller
    /// </summary>
    [RoutePrefix("api")]

    public class LinqController : ApiController
    {
        /// <summary>
        /// Gets controller status
        /// </summary>
        /// <response code="Ok, sin input">Success, but no input</response>
        /// <response code="Ok">Success, with input</response>
        /// <returns>Retorna Ok si el servicio está arriba</returns>
        [HttpGet]
        [Route("GetStatus")]
        [ResponseType(typeof(string))]
        public string GetStatus(string input)
        {
            if (string.IsNullOrEmpty(input)) return "Ok, no input";
            else return "Ok";
        }

        /// <summary>
        /// Insert data into table
        /// </summary>
        /// <param name="input"></param>
        /// <response code="0">Success</response>
        /// <response code="1">Error</response>
        [HttpPost]
        [Route("CreateData")]
        [ResponseType(typeof(Result))]
        public Result CreateData(CreateDataIn input)
        {
            Result output = Result.Error;
            LinqBS business = new LinqBS();
            var result = business.CreateData(input);
            if (result == Result.Success) output = Result.Success;
            return output;
        }
    }
}
