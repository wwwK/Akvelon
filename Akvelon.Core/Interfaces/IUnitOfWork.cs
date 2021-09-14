using Akvelon.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

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
