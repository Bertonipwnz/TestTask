using System;
using System.Collections.Generic;
using TestTaskUWP.Models;

namespace TestTaskUWP.ViewModels
{

    public class TransactionVM: NotificationBase<Transaction>
    {

        private Transaction transaction;
        private readonly Repository repository;
        public TransactionVM()
        {
            transaction = new Transaction();
            repository = new Repository();
        }


        public int ID_Transaction
        {
            get { return This.id_Transaction; }
            set { SetProperty(This.id_Transaction, value, () => This.id_Transaction = value); }
        }

        public int Amount_Transaction
        {
            get { return This.amount_Transaction; }
            set { SetProperty(This.amount_Transaction, value, () => This.amount_Transaction = value); }
        }

        public DateTime Date_and_Time_Transaction
        {
            get { return This.date_and_Time_Transaction; }
            set { SetProperty(This.date_and_Time_Transaction, DateTime.Now, () => This.date_and_Time_Transaction = DateTime.Now); }

        }

        public string Type_Transaction
        {
            get { return This.type_Transaction; }
            set { SetProperty(This.type_Transaction, value, () => This.type_Transaction = value); }

        }

        public string Category_Transaction
        {
            get { return This.category_Transaction; }
            set { SetProperty(This.category_Transaction, value, () => This.category_Transaction = value); }

        }

        public string Comment_Transaction
        {
            get { return This.comment_Transaction; }
            set { SetProperty(This.comment_Transaction, value, () => This.comment_Transaction = value); }

        }

        public void Save()
        {
            repository.SaveTransaction(This);
        }

        public void Load()
        {
            transaction = repository.LoadTransaction();
            ID_Transaction = transaction.id_Transaction;
            Amount_Transaction = transaction.amount_Transaction;
            Date_and_Time_Transaction = transaction.date_and_Time_Transaction;
            Type_Transaction = transaction.type_Transaction;
            Category_Transaction = transaction.category_Transaction;
            Comment_Transaction = transaction.comment_Transaction;

        }
          public List<Transaction> SelectAllTransaction()
          {
              return repository.GetAllTransaction();
          }
       
      

    }
}
