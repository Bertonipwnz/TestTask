using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TestTaskUWP.Models;
using Windows.UI.Xaml.Navigation;
// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

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
                    ContentFrame.Navigate(typeof(NewOperation));
                    break;

            }
        }
    }
}
