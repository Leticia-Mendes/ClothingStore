using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingStore.API.Domain
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name must be between 3 and 60 characters", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Size is required")]
        [MaxLength(20)]
        public string Size { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [MaxLength(30)]
        public string Color { get; set; }

        [StringLength(600, ErrorMessage = "Description must be a maximum of 600 characters")]
        public string Description { get; set; }

        [StringLength(200)]
        public string UrlImage { get; set; }
        
        public int Stock { get; set; }
       
        public DateTime RegisterDate  { get; set; }
        
        public Category Category { get; set; }
       
        public int CategoryId { get; set; }

    }
}
