using FirstWebApi.Common;
using FirstWebApi.Models;
using FirstWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApi.Controllers
{
    public class ManagerCommentController : ApiController
    {
        ProjectTrackContext db = new ProjectTrackContext();
        ManagerCommentRepository repo = new ManagerCommentRepository();

        // GET: api/ManagerComment
        public IEnumerable<ManagerComment> Get()
        {
            return repo.GetAllManagerComments();
        }

        // GET: api/ManagerComment/5
        public ManagerComment Get(int id)
        {
            return repo.SearchManagerCommentById(id);
        }

        [Route("api/ManagerComment/GetByTaskId/{id}")]
        public IEnumerable<ManagerComment> GetByTaskId(int id) 
        {
            return repo.SearchManagerCommentByTaskId(id);
        }

        // POST: api/ManagerComment
        public void Post(ManagerComment value)
        {
            repo.CreateNewManagerComment(value);
        }

        // PUT: api/ManagerComment/5
        public void Put(int id, ManagerComment value)
        {
            repo.EditManagerComment(id, value);
        }

        // DELETE: api/ManagerComment/5
        public void Delete(int id)
        {
            repo.DeleteManagerCommentBy(id);
        }
    }
}
