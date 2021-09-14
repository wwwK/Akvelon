namespace Akvelon.Core.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }

        public TaskStatus Status { get; set; }

        public string Description;

        public int Priority { get; set; }

        public virtual Project Project { get; set; }

    }

    public enum TaskStatus
    {
        ToDo = 0,
        InProgress,
        Done,
    }
}
