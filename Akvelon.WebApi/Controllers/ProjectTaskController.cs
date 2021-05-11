using Akvelon.Core.Entities;
using Akvelon.Core.Interfaces;
using Akvelon.Core.Interfaces.Repositories;
using Akvelon.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;



namespace Akvelon.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTaskController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AkvelonDbContext _dbContext;


        public ProjectTaskController(AkvelonDbContext context)
        {
            _dbContext = context;
            _unitOfWork = new UnitOfWork(_dbContext);
        }

        // GET: api/<ProjectTask>
        [HttpGet]
        public IEnumerable<ProjectTask> Get()
        {

                return _unitOfWork.ProjectTaskRepository.GetAll(x => x.Id != 0);
        }

        // GET api/<ProjectTask>/5
        [HttpGet("{id}")]
        public ProjectTask Get(int id)
        {
                return _unitOfWork.ProjectTaskRepository.Get(id);
        }

        // POST api/<ProjectTask>
        [HttpPost]
        public void Post(JObject value)
        {
                var projectTaskModel = value.ToObject<ProjectTask>();
                _unitOfWork.ProjectTaskRepository.Add(projectTaskModel);
                _unitOfWork.Save();
        }

        // PUT api/<ProjectTask>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] JObject value)
        {
                var projectTaskModel = value.ToObject<ProjectTask>();
                _unitOfWork.ProjectTaskRepository.Update(projectTaskModel);
                _unitOfWork.Save();
                _unitOfWork.Dispose();
        }

        // DELETE api/<ProjectTask>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
                _unitOfWork.ProjectTaskRepository.Remove(id);
                _unitOfWork.Save();
                _unitOfWork.Dispose();
        }
    }
}
