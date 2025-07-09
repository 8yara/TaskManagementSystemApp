using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        public ICollection<Project> OwnedProjects { get; set; } = new List<Project>();
    }
}
