using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaundry.Models
{
    public class Customer
    {
        [Key]
        public int Id{ get; set; }
        
        [Required(ErrorMessage ="Apellido es requerido")]
        [Display(Name ="Apellidos")]
        [StringLength(50)]
        public string LastName{ get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [Display(Name = "Nombre")]
        [StringLength(50)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Dirección es requerido")]
        [Display(Name = "Dirección")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Teléfono es requerido")]
        [Display(Name = "Teléfono")]
        [StringLength(10)]
        [Phone]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Escribe algún email")]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
