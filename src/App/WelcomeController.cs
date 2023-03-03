using System.Web.Http;

namespace App
{
    public class WelcomeController : ApiController
    {
        [HttpGet]
        public string GetRunningMessage()
        {
            return "Self hosted api is running";
        }
    }
}