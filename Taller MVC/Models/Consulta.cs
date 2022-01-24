using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_MVC.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Display(Name ="Anotación")]
        [Required(ErrorMessage ="Debe agregar las notas de la consulta")]
        public string Anotaciones { get; set; }

        [Required(ErrorMessage ="Debe escribir una fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/DD/YYYY}")]
        public DateTime FechaConsulta { get; set; }

        [ForeignKey("FK_ClienteDeConsulta")]
        public int ClienteId { get; set; }

        //public Cliente Cliente { get; set; }


    }
}
