using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestTaskUWP.Models
{
    //Модель таблицы "Операции"
    [Table("Transaction")]
    public class Transaction
    {
        //id операции - auto increment, ключевое поле
        [Key]
        public int id_Transaction { get; set; }
        //Сумма операции - обязательное поле, максимальная длина символов 10, число
        [Required]
        [MaxLength(10)]
        public int amount_Transaction { get; set; }
        //Дата и время операции - обязательное поле, заполняется текущей датой и временем на момент операции
        [Required]
        public DateTime date_and_Time_Transaction { get; set; }
        //Тип операции - обязательное поле, текстовое
        [Required]
        public string type_Transaction { get; set; }
        //Категория операции - обязательное поле, текстовое
        [Required]
        public string category_Transaction { get; set; }
        //Комментарий - необязательное, максимальная длина - 30, текстовое
        [MaxLength(30)]
        public string comment_Transaction { get; set; }
        //Баланс - баланс на момент совершения операции
        [Required]
        public int amount_Money { get; set; }
    }

}
