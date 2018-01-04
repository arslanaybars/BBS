using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BBS.UI.Controllers
{
    public class RolesController : BaseController
    {
        public RolesController()
        {
        }

        // GET: api/Roles
        public IHttpActionResult GetRoles()
        {
            return Ok(_client.GetRoles());
        }
    }
}
