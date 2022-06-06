using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskUWP.Models
{
    /// <summary>
    /// Создание атрибутов таблицы "Операции"
    /// </summary>
    [Table("Transaction")]
    public class Transaction
    {
        //id операции - auto increment, ключевое поле
        [Key]
        public int IdTransaction { get; set; }


        //Сумма операции - обязательное поле, максимальная длина символов 10, число
        [Required]
        [MaxLength(10)]
        public int AmountTransaction { get; set; }
        
        
        //Дата и время операции - обязательное поле, заполняется текущей датой и временем на момент операции
        [Required]
        public DateTime DateAndTimeTransaction { get; set; }
        
        
        //Тип операции - обязательное поле, текстовое
        [Required]
        public string TypeTransaction { get; set; }
        
        
        //Категория операции - обязательное поле, текстовое
        [Required]
        public string CategoryTransaction { get; set; }
        
        
        //Комментарий - необязательное, максимальная длина - 30, текстовое
        [MaxLength(30)]
        public string CommentTransaction { get; set; }
        
        
        //Баланс - баланс на момент совершения операции
        public int AmountMoney { get; set; }
    }
}
