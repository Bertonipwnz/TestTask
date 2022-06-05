using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TestTaskUWP.ViewModels;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestTaskUWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class NewOperation : Page
    {
        public TransactionVM Transaction { get; set; }
        public NewOperation()
        {
            this.InitializeComponent();
            Transaction = new TransactionVM();
        }

        /// <summary>
        /// Обнуление всех полей
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            comboBoxForTypeOperation.SelectedItem = null;
            comboBoxForCategoryOperation.SelectedItem = null;
            textBoxForAmountOperation.Text = "";
            textBoxForCommentOperation.Text = "";
        }

        /// <summary>
        /// Кнопка добавления записи
        /// </summary>
        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Проверка ввода
            try
            {   //Если в поле введено не число или не выбран элемент в комбобокс, то вызываем исключение
                Convert.ToInt32(textBoxForAmountOperation.Text);
                if (string.IsNullOrEmpty(Convert.ToString(comboBoxForTypeOperation.SelectedItem)))
                    throw new FormatException();
                if (string.IsNullOrEmpty(Convert.ToString(comboBoxForCategoryOperation.SelectedItem)))
                    throw new FormatException();


                //Создаём уведомление если операция прошла успешно
                ContentDialog checkTextBox = new ContentDialog()
                {
                    Title = "Уведомление",
                    Content = "Операция на сумму " + textBoxForAmountOperation.Text + " успешно добавлена",
                    PrimaryButtonText = "ОК"
                };
                await checkTextBox.ShowAsync();
                //Сохраняем данные
                Transaction.Save();
                //Обновляем окно
                Frame fr = new Frame();
                Window.Current.Content = fr;
                fr.Navigate(typeof(MainPage));
                Window.Current.Activate();

            }
            catch (FormatException)
            {
                ContentDialog checkTextBox = new ContentDialog()
                {
                    Title = "Ошибка ввода",
                    Content = "При ввода данных, обнаружена ошибка. Проверьте поля.",
                    PrimaryButtonText = "ОК"

                };
                await checkTextBox.ShowAsync();
            }
            
        }
    }
}
