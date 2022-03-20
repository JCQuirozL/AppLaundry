using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaundry.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Fecha de creación")]
        public DateTime CreateDate { get; set; }


        [Required]
        [Display(Name = "Fecha de pago")]
        public DateTime PayDate { get; set; }

        [Display(Name ="Observaciones")]
        [StringLength(maximumLength:200,ErrorMessage ="No puedes exceder de 200 caracteres")]
        public string Annotations { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        [Display(Name ="Total")]
        public decimal Total { get; set; }

        [Required]
        public string Estatus { get; set; }

        [Required]
        [Display(Name ="Cliente")]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }



    }
}
