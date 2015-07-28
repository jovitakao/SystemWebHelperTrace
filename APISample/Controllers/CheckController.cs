using HelperSample;
using System.Web.Http;

namespace APISample.Controllers
{
    public class CheckController : ApiController
    {
        public string Get()
        {
            return Signature.Get("Bruce");
        }
    }
}
