using System;
using System.Collections.Generic;
using System.Linq;
using TestTaskUWP.Models;

namespace TestTaskUWP.Data
{
    /// <summary>
    /// Реализация операций базы данных
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Метод для сохранения данных записи в БД
        /// </summary>
        /// <param name="model">Модель таблицы</param>
        public void SaveTransaction(Transaction model)
        {
            using (var db = new TransactionContext())
            {
                //Устанавливаем для входящей записи текущее время и дату
                model.DateAndTimeTransaction = DateTime.Now;
                //Проверка доход или расход, в зависимости от этого отнимаем или прибавляем к сумме
                if (db.Transactions.Count() > 0)
                {
                    if (model.TypeTransaction == "Доход")
                    {
                        model.AmountMoney = db.Transactions.LastOrDefault().AmountMoney + model.AmountTransaction;
                    }
                    else
                        model.AmountMoney = db.Transactions.LastOrDefault().AmountMoney - model.AmountTransaction;
                }
                else model.AmountMoney += model.AmountTransaction;
                if (model.IdTransaction > 0)
                {
                    //Добавление данных в базу
                    db.Attach(model);
                    db.Update(model);
                }
                else
                {
                    db.Add(model);
                }
                //Сохранение базы    
                db.SaveChanges();
            }
        }

        //Загрузка первой записи
        public Transaction LoadTransaction()
        {
            using (var db = new TransactionContext())
            {
                return (from t in db.Transactions select t).FirstOrDefault();
            }
        }

        //Загрузка сохранённого баланса
        public Transaction LoadAmount()
        {
            using (var db = new TransactionContext())
            {
                if (db.Transactions.Count() > 0)
                {
                    return (from t in db.Transactions select t).Last();
                }
                else return null;
                
            }
        }
    }
}
