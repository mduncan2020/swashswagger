using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SwashApi.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SwashApi.Controllers
{
    /// <summary>
    /// Supports all user-centric operations
    /// </summary>
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        /// <summary>
        /// Lists all the registered users in the system
        /// </summary>
        /// <returns></returns>
        /// <example>GET: api/users</example>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new User[] 
            {
                new User() { Id = Guid.NewGuid(), Email = "user.1@swash.com", Name = "First user", IsVerified = false },
                new User() { Id = Guid.NewGuid(), Email = "user.2@swash.com", Name = "Second user", IsVerified = false }
            };
        }

        /// <summary>
        /// Gets the user with the supplied id
        /// </summary>
        /// <param name="id">Unique identifier of the user</param>
        /// <returns>The matching user record</returns>
        /// <example>GET api/users/79A0C53F-8131-4E7C-8BA8-AD4D8659FED7</example>
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return new User() { Id = id, Email = "user.1@swash.com", Name = "First user", IsVerified = false };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userData"></param>
        /// <example>POST api/users</example>
        [HttpPost]
        public void Post([FromBody]User userData)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userData"></param>
        /// <example>PUT api/users/79A0C53F-8131-4E7C-8BA8-AD4D8659FED7</example>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]User userData)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <example>DELETE api/users/5</example>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
