using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Enums;

namespace Application.DTOs
{
    public class TaskItemDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }

        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }

        public Guid AssignedUserId { get; set; }
        public string AssignedUserName { get; set; }
    }


}
