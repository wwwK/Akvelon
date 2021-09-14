using Akvelon.Core.Models;
using Akvelon.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

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
