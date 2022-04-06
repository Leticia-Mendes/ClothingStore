using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingStore.API.Domain
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name must be between 3 and 60 characters", MinimumLength = 3)]
        public string Name { get; set; }
        
        [MaxLength(300)]
        public string UrlImage { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}
