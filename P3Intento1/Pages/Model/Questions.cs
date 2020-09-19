using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P3Intento1.Pages.Model
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Content { get; set; }
        [Required]
        public string QuestionType { get; set; }

        public ICollection<Answers> Answers { get; set; }

    }
}
