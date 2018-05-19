using FirstWebApi.Common;
using FirstWebApi.Models;
using FirstWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FirstWebApi.Controllers
{
    public class TaskController : ApiController
    {
        ProjectTrackContext db = new ProjectTrackContext();
        TaskRepository repo = new TaskRepository();

        // GET: api/Task
        public IEnumerable<ProjectTask> Get()
        {
            return repo.GetAllTasks();
        }

        // GET: api/Task/5
        public ProjectTask Get(int id)
        {
            return repo.SearchTasktById(id);
        }

        // POST: api/Task
        public void Post(ProjectTask value)
        {
            repo.CreteNewTask(value);
        }

        // PUT: api/Task/5
        public void Put(int id, ProjectTask value)
        {
            repo.EditTask(id, value);
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
            repo.DeleteTask(id);
        }
    }
}
