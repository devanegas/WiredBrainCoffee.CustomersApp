using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SuperBasicCoffee
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonAddCustomerClick(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Customer Edit");
            await messageDialog.ShowAsync();

        }

        private void ButtonMoveClick(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(customerListGrid);

            int newColumn = column == 0 ? 2 : 0;

            Grid.SetColumn(customerListGrid, newColumn);
            arrowToMove.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;

        }

        private void ButtonRemoveCustomerClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
