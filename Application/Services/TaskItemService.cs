using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TaskItemService
    {
        private readonly ITaskItemRepository _repository;
        private readonly IMapper _mapper;

        public TaskItemService(ITaskItemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TaskItemDto>> GetAllAsync()
        {
            var tasks = await _repository.GetAllAsync();
            return _mapper.Map<List<TaskItemDto>>(tasks);
        }

        public async Task<TaskItemDto> GetByIdAsync(Guid id)
        {
            var task = await _repository.GetByIdAsync(id);
            return task == null ? null : _mapper.Map<TaskItemDto>(task);
        }

        public async Task<TaskItemDto> CreateAsync(TaskItemDto dto)
        {
            var task = _mapper.Map<TaskItem>(dto);
            task.Id = Guid.NewGuid();

            await _repository.AddAsync(task);
            return _mapper.Map<TaskItemDto>(task);
        }

        public async Task<bool> UpdateAsync(Guid id, TaskItemDto dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return false;

            existing.Title = dto.Title;
            existing.Status = dto.Status;
            existing.DueDate = dto.DueDate;
            existing.ProjectId = dto.ProjectId;
            existing.AssignedUserId = dto.AssignedUserId;

            await _repository.UpdateAsync(existing);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var task = await _repository.GetByIdAsync(id);
            if (task == null) return false;

            await _repository.DeleteAsync(task);
            return true;
        }
    }
}
