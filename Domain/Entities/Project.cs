using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
     public class Project
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public Guid? OwnerId { get; set; }
        public User Owner { get; set; }
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
