using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvelon.Core.Entities
{
   public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ProjectStatus Status { get; set; }

        public int Priority { get; set; }

        public virtual ICollection<ProjectTask> Tasks { get; set; }

        public Project()
        {
            Tasks = new List<ProjectTask>();
        }
    }

    public enum ProjectStatus
    {
        NotStarted = 0,
        Active,
        Completed
    }
}
