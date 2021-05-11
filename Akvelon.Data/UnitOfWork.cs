using Akvelon.Core.Interfaces;
using Akvelon.Core.Interfaces.Repositories;
using Akvelon.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        public DbContext _context;

        public DbContext DbContext
        {
            get { return _context; }
        }

        public IProjectRepository ProjectRepository { get; }

        public IProjectTaskRepository ProjectTaskRepository { get; }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void SetContext(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public UnitOfWork(DbContext context)
        {
           this._context = context;
           ProjectRepository = new  ProjectRepository(_context);
           ProjectTaskRepository = new ProjectTaskRepository(_context);
        }

    }
}
