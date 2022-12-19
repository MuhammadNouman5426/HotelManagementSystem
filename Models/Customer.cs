using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotalManagementSystem.Models
{
    public class Customer
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
    [Display(Name = "Total Bill")]
    public string TotalBill { get; set; }

    [Required]
    [Display(Name = "Payment Type")]
    public string PaymentType { get; set; }
    
    }
}
