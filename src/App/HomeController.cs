using System.Web.Http;

namespace App
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string GetRunningMessage()
        {
            return "Self hosted api is running";
        }
    }
}