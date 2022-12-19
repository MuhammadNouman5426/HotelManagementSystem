using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotalManagementSystem.Models
{
    public class Dish
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Dish Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Dish Price")]
        public string Price { get; set; }

        [Required]
        [Display(Name = "Dish Description")]
        public string Description { get; set; }

        public int Fk_Cook { get; set; }
        [ForeignKey("Fk_Cook")]
        public Cook Cook { get; set; }

    }
}
