using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool IsDone { get; set; }
    }
}
