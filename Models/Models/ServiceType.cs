using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ServiceType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Categoría es requerida")]
        [Display(Name = "Categoría")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
