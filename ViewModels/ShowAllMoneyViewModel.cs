using TestTaskUWP.Models;
using TestTaskUWP.Data;

namespace TestTaskUWP.ViewModels
{
    /// <summary>
    /// ViewModel для отображения общего баланса
    /// </summary>
    public class ShowAllMoneyViewModel : BaseViewModel<Transaction>
    {
        private Transaction transaction;
        private readonly Repository repository;

        public ShowAllMoneyViewModel()
        {
            transaction = new Transaction();
            repository = new Repository();
        }

        public int Amount_Money
        {
            get { return This.AmountMoney; }
            set { SetProperty(This.AmountMoney, value, () => This.AmountMoney = value); }
        }

        /// <summary>
        /// Метод для загрузки бюджета
        /// </summary>
        public void LoadAmount()
        {
            transaction = repository.LoadAmount();
            //Если записей в базе нет, то ставим по умолчанию значение 0
            if (transaction == null)
            {
                Amount_Money = 0;
            }
            //Иначе высчитываем сумму относительно дохода/расхода
            else
            {
                Amount_Money = transaction.AmountMoney;
            }
        }
    }
}
