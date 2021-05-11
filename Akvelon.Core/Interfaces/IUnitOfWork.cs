using Akvelon.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository ProjectRepository { get; }

        IProjectTaskRepository  ProjectTaskRepository { get; }

        void Save();

        void SetContext(DbContext context);

        DbContext DbContext { get; }
    }
}
