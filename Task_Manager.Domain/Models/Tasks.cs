using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Domain.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string  Name { get; set; }
        public DateTime Date { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public Status Status { get; set; }
        public int TraineesId { get; set; }
        [ForeignKey("TraineesId")]
        public Trainees Trainees { get; set; }
    }
}
