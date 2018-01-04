using System;
using System.Web.Http;
using BBS.UI.BbsService;
using BBS.Util;

namespace BBS.UI.Controllers
{
    public class BaseController : ApiController
    {
        protected readonly BbsServiceClient _client;

        public BaseController()
        {
            _client = new BbsServiceClient();

            if (_client.ClientCredentials == null)
                throw new ArgumentNullException(nameof(_client), "Client credentials are null :/");

            _client.ClientCredentials.UserName.UserName = Constants.UserCredential.Username;
            _client.ClientCredentials.UserName.Password = Constants.UserCredential.Password;
        }
    }
}