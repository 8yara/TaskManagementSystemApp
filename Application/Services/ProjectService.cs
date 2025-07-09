using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUserRepository _userRepository;

        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository projectRepository,IUserRepository userRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<ProjectDto>> GetAllAsync()
        {
            var projects = await _projectRepository.GetAllAsync();
            return _mapper.Map<List<ProjectDto>>(projects);
        }

        public async Task<ProjectDto> GetByIdAsync(Guid id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            return project == null ? null : _mapper.Map<ProjectDto>(project);
        }

        public async Task<ProjectDto> CreateAsync(ProjectDto dto)
        {
           

            var ownerExists = await _userRepository.ExistsAsync((Guid)dto.OwnerId);
            if (!ownerExists)
                throw new ArgumentException("Owner user not found with the given ID.");

            var project = _mapper.Map<Project>(dto);

            await _projectRepository.AddAsync(project);

            return _mapper.Map<ProjectDto>(project);
        }

        public async Task<bool> UpdateAsync(Guid id, ProjectDto dto)
        {
            var existing = await _projectRepository.GetByIdAsync(id);
            if (existing == null)
                return false;

            // Map fields from DTO to the existing entity
            existing.Name = dto.Name;
            existing.Description = dto.Description;
            if (dto.OwnerId.HasValue)
            {
                existing.OwnerId = dto.OwnerId;
            }

            await _projectRepository.UpdateAsync(existing);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var existing = await _projectRepository.GetByIdAsync(id);
            if (existing == null)
                return false;

            await _projectRepository.DeleteAsync(existing);
            return true;
        }
    }
}
