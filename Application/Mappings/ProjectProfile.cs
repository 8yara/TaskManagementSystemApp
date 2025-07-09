using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Mappings
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {

            CreateMap<Project, ProjectDto>()
          .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Owner != null ? src.Owner.Name : null))
          .ForMember(dest => dest.OwnerId, opt => opt.MapFrom(src => src.OwnerId)) 
          .ForMember(dest => dest.TaskTitles, opt => opt.MapFrom(src => src.Tasks.Select(t => t.Title)));

            CreateMap<ProjectDto, Project>()
                .ForMember(dest => dest.Owner, opt => opt.Ignore()) 
                .ForMember(dest => dest.Tasks, opt => opt.Ignore());
        }
    }
}
