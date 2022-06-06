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
        //Сохранение записи
        public void SaveTransaction(Transaction model)
        {
            using (var db = new TransactionContext())
            {
                //Устанавливаем для входящей записи текущее время и дату
                model.date_and_Time_Transaction = DateTime.Now;
                //Проверка доход или расход, в зависимости от этого отнимаем или прибавляем к сумме
                if (model.type_Transaction == "Доход")
                {
                    model.amount_Money = db.Transactions.Last().amount_Money + model.amount_Transaction;
                }
                else
                {
                    model.amount_Money = db.Transactions.Last().amount_Money - model.amount_Transaction;
                }

                //Добавление данных в базу
                if (model.id_Transaction > 0)
                {
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
                return (from t in db.Transactions select t).Last();
            }
        }

    }
}
