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
    public class ProjectController : ApiController
    {
        ProjectRepository repo = new ProjectRepository();
        ProjectTrackContext db = new ProjectTrackContext();

        // GET: api/Project
        public IEnumerable<Project> Get()
        {
            return repo.GetAllProjects();
        }

        // GET: api/Project/5
        public Project Get(int id)
        {
            return repo.SearchProjectById(id);
        }

        // POST: api/Project
        public void Post(Project project)
        {
            repo.CreateNewProject(project);
        }

        // PUT: api/Project/5
        public void Put(int id, Project value)
        {
            repo.EditProject(id, value);
        }

        // DELETE: api/Project/5
        public void Delete(int id)
        {
            repo.DeleteProject(id);
        }
    }
}
