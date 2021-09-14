using Akvelon.Core.Models;
using Akvelon.Core.Interfaces;
using Akvelon.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Akvelon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AkvelonDbContext _dbContext;

        public ProjectController(AkvelonDbContext context)
        {
            _dbContext = context;
            _unitOfWork = new UnitOfWork(_dbContext);
        }

        // GET: api/<Project>
        [HttpGet]
        public IEnumerable<Project> Get()
        {
              return _unitOfWork.ProjectRepository.GetAll(x => x.Id != 0);
        }

        // GET api/<Project>/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
              return _unitOfWork.ProjectRepository.Get(id);
        }

        // POST api/<Project>
        [HttpPost]
        public void Post(JObject value)
        {
            var projectTaskModel = value.ToObject<Project>();
            _unitOfWork.ProjectRepository.Add(projectTaskModel);
            _unitOfWork.Save();
        }

        // PUT api/<Project>
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] JObject value)
        {
                var projectTaskModel = value.ToObject<Project>();
                _unitOfWork.ProjectRepository.Update(projectTaskModel);
                _unitOfWork.Save();
                _unitOfWork.Dispose();
        }

        // DELETE api/<Project>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
                _unitOfWork.ProjectRepository.Remove(id);
                _unitOfWork.Save();
                _unitOfWork.Dispose();
        }
    }
}
