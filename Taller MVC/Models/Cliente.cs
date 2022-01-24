using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Taller_MVC.Models
{
    public class Cliente
    {
        
        [Key]
        public int Id { get; set; }//Identity(1,1)
        
        [Required(ErrorMessage="Es obligatorio agregar una cédula")]
        [Display(Name = "Cédula")]
        [StringLength(10,ErrorMessage ="La cédula debe ser de 10 carácteres")]
        [MinLength(10,ErrorMessage ="Mínimo 10 carácteres")]

        public string Cedula { get; set; }

        [Required(ErrorMessage = "Es obligatorio escribir un Nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage ="Debe escribir al menos el Primer Apellido")]
        [Display(Name ="Primer Apellido")]
        public string Ape1 { get; set; }

        [StringLength(50)]
        public string Ape2 { get; set; }

        public ICollection<Consulta> Consultas { get; set; }

    }
}
