using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestTaskUWP.Models;
using TestTaskUWP.Data;
namespace TestTaskUWP.ViewModels
{
    /// <summary>
    /// Модель представления операций
    /// </summary>
    public class TransactionVM : BaseViewModel<Transaction>
    {
        private Transaction _transaction;
        private readonly Repository repository;
        public ObservableCollection<Transaction> Transactions { get; set; }
        public List<Transaction> TransactionsList { get; set; }

        public TransactionVM()
        {
            _transaction = new Transaction();
            repository = new Repository();
            //Запись всех данных таблицы в лист и коллекцию
            using (TransactionContext db = new TransactionContext())
            {
                Transactions = new ObservableCollection<Transaction>(db.Transactions.ToList());
                TransactionsList = new List<Transaction>(db.Transactions.ToList());
            }
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
            set { SetProperty(This.date_and_Time_Transaction, value, () => This.date_and_Time_Transaction = value); }

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
        public int Amount_Money
        {
            get { return This.amount_Money; }
            set { SetProperty(This.amount_Money, value, () => This.amount_Money = value); }
        }

        //Сохранение данных
        public void Save()
        {
            repository.SaveTransaction(This);
        }

        //Загрузка записи
        public void Load()
        {
            _transaction = repository.LoadTransaction();
            ID_Transaction = _transaction.id_Transaction;
            Amount_Transaction = _transaction.amount_Transaction;
            Date_and_Time_Transaction = _transaction.date_and_Time_Transaction;
            Date_and_Time_Transaction = Convert.ToDateTime(Date_and_Time_Transaction.ToString("G"));
            Type_Transaction = _transaction.type_Transaction;
            Category_Transaction = _transaction.category_Transaction;
            Comment_Transaction = _transaction.comment_Transaction;
            Amount_Money = _transaction.amount_Money;
        }

        //Загрузка текущего бюджета
        public void LoadAmount()
        {
            _transaction = repository.LoadAmount();
            Amount_Money = _transaction.amount_Money;
        }
    }
}
