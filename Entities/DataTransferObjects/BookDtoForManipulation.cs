using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public abstract record BookDtoForManipulation
    {
        [Required( ErrorMessage ="Book title is a required field")]
        [MinLength(2, ErrorMessage = "Book title must be at least 2 characters long")]
        [MaxLength(50, ErrorMessage = "Book title must be at most 50 characters long")]
        public string Title { get; set; }

        [Required]
        [Range(10, 1000)]
        public decimal Price { get; set; }
    }
}
