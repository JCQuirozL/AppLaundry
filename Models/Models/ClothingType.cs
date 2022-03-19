using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ClothingType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tipo de prenda es requerido")]
        [Display(Name = "Tipo de prenda")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name="Precio")]
        public decimal Price { get; set; }

        
        [Required(ErrorMessage = "La categoría es requerida")]
        [Display(Name = "Categoría")]
        public int ServiceTypeId { get; set; }

        [ForeignKey("ServiceTypeId")]
        public ServiceType ServiceType { get; set; }

        
    }
}
