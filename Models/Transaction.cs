using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestTaskUWP.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int id_Transaction { get; set; }

        public int amount_Transaction { get; set; }

        public DateTime date_and_Time_Transaction { get; set; }

        public string type_Transaction { get; set; }

        public string category_Transaction { get; set; }

        public string comment_Transaction { get; set; }


    }



}
