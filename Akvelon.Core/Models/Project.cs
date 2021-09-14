using System;
using System.Collections.Generic;

namespace Akvelon.Core.Models
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
