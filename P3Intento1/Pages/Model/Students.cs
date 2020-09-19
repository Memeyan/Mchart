using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace P3Intento1.Pages.Model
{
    public class Students
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido{ get; set; } 
        [Required]
        public string CURP { get; set; }
        
        [Required]
        public string Genero { get; set; }
        
        [Required]
        public string Nacionalidad { get; set; }



        [Required]
        [DisplayFormat(DataFormatString ="(yyyy-MM-dd)")]
        public DateTime? FechaDeNacimiento { get; set; }



        [Required]
        [ForeignKey("TblUsers")]
        public int TblUsersId { get; set; }

        [Required]
        [ForeignKey("Escuelas")]

        public int EscuelaId { get; set; }


        public TblUsers TblUsers { get; set; }
        public Escuelas Escuelas { get; set; }

        public ICollection<Answers> Answers { get; set; }


    }
}
