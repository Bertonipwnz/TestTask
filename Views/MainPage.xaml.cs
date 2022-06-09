using Windows.UI.Xaml.Controls;

namespace TestTaskUWP.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            // Содержимое выбранного элемента
            switch (item.Name)
            {
                case "ViewAllTransaction":
                    ContentFrame.Navigate(typeof(HistoryTransaction));
                    break;
                case "ViewScore":
                    ContentFrame.Navigate(typeof(Score));
                    break;
                case "NewOperation":
                    ContentFrame.Navigate(typeof(NewTransactionView));
                    break;
            }
        }
    }
}
