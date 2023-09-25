using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Manager.Domain;
using Task_Manager.Domain.Dtos;
using Task_Manager.Domain.Interfaces;
using Task_Manager.Domain.Models;

namespace Task_Manager.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IProviderDbContext providerDbContext;
        private readonly AppDbContext appContext;
        public TaskRepository(IProviderDbContext providerDbContext)
        {
            this.providerDbContext = providerDbContext;
            this.appContext = this.providerDbContext.GetDbContext();
        }

        public async Task<List<TasksDto>> GetAllTasks()
        {
            var response = new List<TasksDto>();

            response = await (from t in this.appContext.Tasks
                              join tr in this.appContext.Trainees on t.TraineesId equals tr.Id
                              join s in this.appContext.Status on t.StatusId equals s.Id
                              select new TasksDto
                              {
                                  Name = t.Name,
                                  Id = t.Id,
                                  TraineeName = tr.Name,
                                  StatusDescription = s.Name,
                                  Date = t.Date.ToShortDateString(),
                              }
                              ).ToListAsync();
            return response;
        }

        public async Task<Tasks> GetTaskById(int Id)
        {
            var response = await this.appContext.Tasks
                            .Where(t => t.Id == Id)
                            .Include(t => t.Status)
                            .Include (t => t.Trainees)
                            .FirstOrDefaultAsync();
            return response;

        }
    }
}
