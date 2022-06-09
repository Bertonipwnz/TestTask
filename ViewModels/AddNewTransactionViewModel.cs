using TestTaskUWP.Models;
using TestTaskUWP.Data;
using TestTaskUWP.Views;
using System;

namespace TestTaskUWP.ViewModels
{
    /// <summary>
    /// ViewModel для добавления операции
    /// </summary>
    public class AddNewTransactionViewModel : BaseViewModel<Transaction>
    {
        public Transaction transaction;
        private readonly Repository repository;
        //Переменные для валидации данных
        private bool isFieldsRight_ = false;
        private bool isAmountTransactionInput_ = false;
        private bool isCategoryTransactionInput_ = false;
        private bool isTypeTransactionInput_ = false;

        public AddNewTransactionViewModel()
        {
            repository = new Repository();
            transaction = new Transaction();
        }

        //true - кнопка для записи доступна, false - недоступна
        public bool IsFieldsRight
        {
            get { return isFieldsRight_; }
            set
            { SetProperty(isFieldsRight_, value, () => isFieldsRight_ = value); }
        }

        //мето для проверки, три поля введены верно?
        private void CheckInputRight()
        {
            if (isAmountTransactionInput_ && isCategoryTransactionInput_ && isTypeTransactionInput_)
            {
                IsFieldsRight = true;
            }
            else IsFieldsRight = false;
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
            set
            {
                //Если введено число больше 0, то валидация поля пройдена с учётом Convertor привязанного к полю
                if (value > 0)
                {
                    SetProperty(This.AmountTransaction, value, () => This.AmountTransaction = value);
                    isAmountTransactionInput_ = true;
                }
                else
                {
                    isAmountTransactionInput_ = false;
                }
                CheckInputRight();
            }
        }

        public DateTime Date_and_Time_Transaction
        {
            get { return This.DateAndTimeTransaction; }
            set { SetProperty(This.DateAndTimeTransaction, value, () => This.DateAndTimeTransaction = value); }

        }

        public string Type_Transaction
        {
            get { return This.TypeTransaction; }
            set
            {
                //Если в поле выбрано значение из предложенных валидация пройдена
                if (!string.IsNullOrEmpty(Convert.ToString(value)))
                {
                    SetProperty(This.TypeTransaction, value, () => This.TypeTransaction = value);
                    isTypeTransactionInput_ = true;
                }
                else
                {
                    isTypeTransactionInput_ = false;
                }
                CheckInputRight();
            }
        }

        public string Category_Transaction
        {
            get { return This.CategoryTransaction; }
            set
            {
                //Если в поле выбрано значение из предложенных валидация пройдена
                if (!string.IsNullOrEmpty(Convert.ToString(value)))
                {
                    SetProperty(This.CategoryTransaction, value, () => This.CategoryTransaction = value);
                    isCategoryTransactionInput_ = true;
                }
                else
                {
                    isCategoryTransactionInput_ = false;
                }
                CheckInputRight();
            }
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
            NewTransactionView ntf = new NewTransactionView();
            if (isFieldsRight_)
            {
                repository.SaveTransaction(This);
                ntf.SuccessAddTransactionAsync();
            }
            else
            {
                ntf.UnsuccessfulAddTransactionAsync();
            };
        }
    }
}
