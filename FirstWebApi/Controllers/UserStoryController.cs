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
    public class UserStoryController : ApiController
    {
        ProjectTrackContext db = new ProjectTrackContext();
        UserStoryRepository repo = new UserStoryRepository();

        // GET: api/UserStory
        public IEnumerable<UserStory> Get()
        {
            return repo.GetAllUserStories();
        }

        // GET: api/UserStory/5
        public UserStory Get(int id)
        {
            return repo.SearchUserStoryById(id);
        }

        // POST: api/UserStory
        public void Post(UserStory value)
        {
            repo.CreteNewUserStory(value);
        }

        // PUT: api/UserStory/5
        public void Put(int id, UserStory value)
        {
            repo.EditUserStory(id, value);
        }

        // DELETE: api/UserStory/5
        public void Delete(int id)
        {
            repo.DeleteUserStory(id);
        }
    }
}
