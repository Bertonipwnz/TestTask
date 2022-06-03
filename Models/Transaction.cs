using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestTaskUWP.Models
{
    [Table("Transaction")]
    public class Transaction
    {
            [Key]
            public int ID_Transaction { get; set; }
           
            public int Amount_Transaction { get; set; }

             public DateTime Date_and_Time_Transaction { get; set; }

             public string Type_Transaction { get; set; }

             public string Category_Transaction { get; set; }

             public string Comment_Transaction { get; set; }
        
    }
}
