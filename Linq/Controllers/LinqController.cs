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
    }
}
