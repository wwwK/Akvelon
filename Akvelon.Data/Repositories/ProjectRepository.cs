using Akvelon.Core.Entities;
using Akvelon.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon.Data.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext context) : base(context)
        {
            Context = context;
        }
    }
}
