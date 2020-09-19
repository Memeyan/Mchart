using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P3Intento1.Pages.Model
{
    public class Escuelas
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Direccion { get; set; }

        public ICollection<Students> Students { get; set; }

    }
}
