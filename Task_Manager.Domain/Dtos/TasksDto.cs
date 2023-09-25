using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Domain.Dtos
{
    public class TasksDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TraineeName { get; set; }
        public string StatusDescription { get; set; }
        public string Date { get; set; }
    }
}
