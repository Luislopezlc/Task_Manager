using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Domain.Dtos;
using Task_Manager.Domain.Interfaces;
using Task_Manager.Domain.Models;

namespace Task_Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService taskService;
        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Tasks>> GetTaskById([FromRoute]int Id)
        {
            var response = await taskService.GetTaskById(Id);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<TasksDto>> GetAllTasks()
        {
            var response = await taskService.GetAllTasks();
            return Ok(response);
        }
    }
}
