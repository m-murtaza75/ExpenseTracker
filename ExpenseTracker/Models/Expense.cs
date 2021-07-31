using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Expense Name")]
        public string ExpenseName { get; set; }        
        
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }
    }
}
