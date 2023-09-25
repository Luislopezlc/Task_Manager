using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Domain.Dtos;
using Task_Manager.Domain.Interfaces;
using Task_Manager.Domain.Models;

namespace Task_Manager.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public async Task<List<TasksDto>> GetAllTasks()
        {
            var response = await taskRepository.GetAllTasks();
            return response;
        }

        public async Task<Tasks> GetTaskById(int Id)
        {
            var response = await taskRepository.GetTaskById(Id);
            return response;
        }
    }
}
