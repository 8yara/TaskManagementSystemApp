using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Application.DTOs
{
   public class ProjectDto
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string OwnerName { get; set; }
        public Guid? OwnerId { get; set; }
        public List<string> TaskTitles { get; set; }
    }
}
