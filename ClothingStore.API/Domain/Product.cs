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
        
        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [MaxLength(50)]
        public string Size { get; set; }

        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(400)]
        public string UrlImage { get; set; }
        public string Stock { get; set; }
        public DateTime RegisterDate  { get; set; }
        
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
