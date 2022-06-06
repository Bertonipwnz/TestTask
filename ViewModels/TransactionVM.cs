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
        private Transaction transaction;
        private readonly Repository repository;
        public ObservableCollection<Transaction> Transactions { get; set; }
        public List<Transaction> TransactionsList { get; set; }


        public TransactionVM()
        {
            transaction = new Transaction();
            repository = new Repository();
            //Запись всех данных таблицы в лист и коллекцию
            using (TransactionContext db = new TransactionContext())
            {
                Transactions = new ObservableCollection<Transaction>(db.Transactions.ToList());
                TransactionsList = new List<Transaction>(db.Transactions.ToList());
            }
        }
        #region Определение_Свойств
        public int ID_Transaction
        {
            get { return This.IdTransaction; }
            set { SetProperty(This.IdTransaction, value, () => This.IdTransaction = value); }
        }

        public int Amount_Transaction
        {
            get { return This.AmountTransaction; }
            set { SetProperty(This.AmountTransaction, value, () => This.AmountTransaction = value); }
        }

        public DateTime Date_and_Time_Transaction
        {
            get { return This.DateAndTimeTransaction; }
            set { SetProperty(This.DateAndTimeTransaction, value, () => This.DateAndTimeTransaction = value); }

        }

        public string Type_Transaction
        {
            get { return This.TypeTransaction; }
            set { SetProperty(This.TypeTransaction, value, () => This.TypeTransaction = value); }

        }

        public string Category_Transaction
        {
            get { return This.CategoryTransaction; }
            set { SetProperty(This.CategoryTransaction, value, () => This.CategoryTransaction = value); }

        }

        public string Comment_Transaction
        {
            get { return This.CommentTransaction; }
            set { SetProperty(This.CommentTransaction, value, () => This.CommentTransaction = value); }

        }
        public int Amount_Money
        {
            get { return This.AmountMoney; }
            set { SetProperty(This.AmountMoney, value, () => This.AmountMoney = value); }
        }
        #endregion Определение_свойств


        //Сохранение данных
        /// <summary>
        /// Метод сохранения записи в бд
        /// </summary>
        public void Save()
        {
            repository.SaveTransaction(This);
        }


        /// <summary>
        /// Метод загрузки записи
        /// </summary>
        public void Load()
        {
            transaction = repository.LoadTransaction();
            Amount_Money = transaction.AmountMoney;
            ID_Transaction = transaction.IdTransaction;
            Date_and_Time_Transaction = transaction.DateAndTimeTransaction;
            Date_and_Time_Transaction = Convert.ToDateTime(Date_and_Time_Transaction.ToString("G"));
            Type_Transaction = transaction.TypeTransaction;
            Category_Transaction = transaction.CategoryTransaction;
            Comment_Transaction = transaction.CommentTransaction;
        }


        /// <summary>
        /// Метод для загрузки бюджета
        /// </summary>
        public void LoadAmount()
        {
            transaction = repository.LoadAmount();
            if (transaction == null)
            {
                Amount_Money = 0;
            }
            else
            { 
                Amount_Money = transaction.AmountMoney; 
            }
        }
    }
}
