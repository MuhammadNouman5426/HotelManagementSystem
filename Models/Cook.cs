using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotalManagementSystem.Models
{
    public class Cook
    { 
    [Key]
    public int ID { get; set; }

    [Required]
    [Display(Name = "Full Name")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Contact Number")]
    public string Number { get; set; }

    [Required]
    [Display(Name = "Salary")]
    public string Salary { get; set; }

    [Required]
    [Display(Name = "Joining Date")]
    public DateTime JoiningDate { get; set; }
}
}
