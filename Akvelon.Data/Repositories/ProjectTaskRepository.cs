using Akvelon.Core.Models;
using Akvelon.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

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
