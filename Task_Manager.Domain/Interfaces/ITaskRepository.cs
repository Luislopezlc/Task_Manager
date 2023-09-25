using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Domain.Dtos;
using Task_Manager.Domain.Models;

namespace Task_Manager.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<Tasks> GetTaskById(int Id);
        Task<List<TasksDto>> GetAllTasks();
    }
}
