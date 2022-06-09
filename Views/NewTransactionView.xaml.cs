using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TestTaskUWP.ViewModels;
using System.Collections.ObjectModel;
using System;
using System.Threading.Tasks;

namespace TestTaskUWP.Views
{
    public sealed partial class NewTransactionView : Page
    {
        //коллекции содержащие данные категорий для зачислений и расходов
        ObservableCollection<string> income = new ObservableCollection<string>();
        ObservableCollection<string> expenses = new ObservableCollection<string>();
        public AddNewTransactionViewModel Transaction { get; set; }

        public NewTransactionView()
        {
            this.InitializeComponent();
            Transaction = new AddNewTransactionViewModel();
            income.Add("Зарплата");
            income.Add("Стипендия");
            income.Add("Нал. вычет");
            expenses.Add("Еда");
            expenses.Add("Транспорт");
            expenses.Add("ЖКХ");
        }

        /// <summary>
        /// Обнуление всех полей
        /// </summary>
        public void ClearFields(object sender, RoutedEventArgs e)
        {
            comboBoxForTypeOperation.ItemsSource = null;
            comboBoxForCategoryOperation.IsEnabled = false;
            comboBoxForCategoryOperation.ItemsSource = null;
            textBoxForAmountOperation.Text = "";
            textBoxForCommentOperation.Text = "";
        }

        public async Task UnsuccessfulAddTransactionAsync()
        {
            ContentDialog checkTextBox = new ContentDialog()
            {
                Title = "Уведомление",
                Content = "Ошибка проверьте внесённые данные",
                PrimaryButtonText = "ОК"
            };
            await checkTextBox.ShowAsync();
        }

        public async Task SuccessAddTransactionAsync()
        {
            ContentDialog checkTextBox = new ContentDialog()
            {
                Title = "Уведомление",
                Content = "Операция прошла успешно",
                PrimaryButtonText = "ОК"
            };
            await checkTextBox.ShowAsync();
            Frame fr = new Frame();
            Window.Current.Content = fr;
            fr.Navigate(typeof(MainPage));
            Window.Current.Activate();
        }


        /// <summary>
        /// Проверяем выбран доход или расход, относительно этого меняем элементы
        /// combobox категории
        /// </summary>
        private void CheckTypeTransaction(object sender, SelectionChangedEventArgs e)
        {
            string choiceItem = comboBoxForTypeOperation.SelectedItem as string;
            if (choiceItem.Equals("Зачисление"))
            {
                comboBoxForCategoryOperation.ItemsSource = income;
            }
            else
            {
                comboBoxForCategoryOperation.ItemsSource = expenses;
            }
            comboBoxForCategoryOperation.IsEnabled = true;
        }
    }
}
