using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities
{

   public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        public Guid AssignedUserId { get; set; }
        public User AssignedUser { get; set; }
    }
}
