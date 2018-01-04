using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BBS.Domain;
using BBS.UI.BbsService;
using BBS.Util;

namespace BBS.UI.Controllers
{
    public class UsersController : BaseController
    {
        // GET: api/Users
        public IHttpActionResult GetUsers()
        {
            return Ok(_client.GetUsers());
        }

        // GET: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int id)
        {
            User user = _client.FindUser(id);
            if (user == null)
            {
                // log
                return NotFound();
            }

            return Ok(user);
        }

        // Upsert
        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser([FromBody]User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Update
                if (_client.FindUser(user.Id) != null)
                {
                    _client.UpdateUser(user);
                    return Ok(user);
                }

                _client.CreateUser(user);
            }
            catch (Exception ex)
            {
                // log
                return BadRequest();
            }

            return Ok(user);
        }

        // DELETE: api/Users/5
        //[ResponseType(typeof(User))]
        [HttpPost]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = _client.FindUser(id);
            if (user == null)
            {
                return NotFound();
            }

            try
            {
                _client.DeleteUser(id);
            }
            catch (Exception)
            {
                // log
                return BadRequest();
            }

            return Ok(user.Id);
        }

        private bool UserExists(int id)
        {
            return _client.FindUser(id) != null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ((IDisposable)_client).Dispose(); // ?? 
            }

            base.Dispose(disposing);
        }

    }
}