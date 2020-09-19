using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P3Intento1.Pages.Model
{
    public class Answers
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Respuesta { get; set; }


        [Required]
        [ForeignKey("Questions")]
        public int QuestionsId { get; set; }


        [Required]
        [ForeignKey("Students")]
        public int StudentsId{ get; set; }


        public Students Students { get; set; }

        public Questions Questions { get; set; }
    }
}
