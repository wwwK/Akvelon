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
    public class ProjectTaskRepository : Repository<ProjectTask>, IProjectTaskRepository
    {
        public ProjectTaskRepository(DbContext context) : base(context)
        {
            Context = context;
        }
    }
}
