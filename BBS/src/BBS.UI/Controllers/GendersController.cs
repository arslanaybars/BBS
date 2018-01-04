
using System.Web.Http;

namespace BBS.UI.Controllers
{
    public class GendersController : BaseController
    {
        // GET: api/Gender
        public IHttpActionResult GetGenders()
        {
            return Ok(_client.GetGenders());
        }
    }
}
