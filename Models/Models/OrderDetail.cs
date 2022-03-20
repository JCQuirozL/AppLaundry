using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaundry.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Ingresa la cantidad")]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cantidad")]
        public decimal Quantity { get; set; }


        [Required(ErrorMessage = "El total no puede ser 0")]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Total")]
        public decimal Total { get; set; }

        [Required]
        [Display(Name = "Número de orden")]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Required(ErrorMessage = "El tipo de prenda es requerido")]
        [Display(Name = "Tipo de prenda")]
        public int ClothingTypeId { get; set; }

        [ForeignKey("ClothingTypeId")]
        public ClothingType ClothingType { get; set; }
    }
}
